using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.Util;
using System.Data;
using MySql.Data.MySqlClient;

namespace OTC
{
    public class SettlementReports
    {

        public SettlementReports(OTCDataSet ds)
        {
            dataset = ds;
        }

        public void GenerateBusinessReport(DateTime settle_day)
        {
            FileStream fs = new FileStream("MDAS_业务日报(金融)_中粮期货(auto).xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            NPOI.SS.UserModel.ISheet sheet;
            NPOI.SS.UserModel.IRow row;
            NPOI.SS.UserModel.ICell cell;

            //工作簿1
            sheet = (HSSFSheet)workbook.CreateSheet("sheet_index");
            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "宋体";

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            style1.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
            style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.SetFont(font1);

            //行1
            row = sheet.CreateRow(0);
            cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue("时间值");

            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("采集表流水号");

            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue("样表流水号");

            cell = row.CreateCell(3);
            cell.CellStyle = style1;
            cell.SetCellValue("经营单位代码");

            //行2
            row = sheet.CreateRow(1);
            cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue(settle_day.ToShortDateString());

            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("4271");

            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue("22865");

            cell = row.CreateCell(3);
            cell.CellStyle = style1;
            cell.SetCellValue("100054");
            //工作簿2
            sheet = (HSSFSheet)workbook.CreateSheet("S_22865_SCFXQH1.5_0_业务日报_中粮期货_");

            row = sheet.CreateRow(0);
            cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue("采集表名称");
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("经营单位");
            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue("时间值");

            row = sheet.CreateRow(1);
            cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue("业务日报（中粮期货）");

            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("中粮期货");

            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue(settle_day.ToShortDateString());

            var font2 = workbook.CreateFont();
            font2.IsBold = true;
            font2.FontName = "宋体";

            var style2 = workbook.CreateCellStyle();
            style2.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style2.SetFont(font2);

            row = sheet.CreateRow(2);
            cell = row.CreateCell(0);
            cell.CellStyle = style2;
            cell.SetCellValue("业务部门");

            cell = row.CreateCell(1);
            cell.CellStyle = style2;
            cell.SetCellValue("业务类型");

            cell = row.CreateCell(2);
            cell.CellStyle = style2;
            cell.SetCellValue("产品类型/产品名称");

            cell = row.CreateCell(3);
            cell.CellStyle = style2;
            cell.SetCellValue("管理规模/认购份额（元）");

            cell = row.CreateCell(4);
            cell.CellStyle = style2;
            cell.SetCellValue("责任总盈亏（元）");

            cell = row.CreateCell(5);
            cell.CellStyle = style2;
            cell.SetCellValue("开始日期(YYYYMMDD)");

            cell = row.CreateCell(6);
            cell.CellStyle = style2;
            cell.SetCellValue("结束日期(YYYYMMDD)");

            cell = row.CreateCell(7);
            cell.CellStyle = style2;
            cell.SetCellValue("当年责任总盈亏（元）");

            cell = row.CreateCell(8);
            cell.CellStyle = style2;
            cell.SetCellValue("报告期责任盈亏（元）");

            //第四行
            var style3 = workbook.CreateCellStyle();
            var font3 = workbook.CreateFont();
            font3.FontName = "宋体";
            style3.SetFont(font3);
            style3.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            row = sheet.CreateRow(3);


            var gross_pnl =
                from r in dataset.display_ds.Tables["business_state_view"].AsEnumerable()
                where r.Field<DateTime>("结算日") == settle_day
                select new
                {
                    future_accum_pnl = r.Field<decimal>("累计期货盈亏"),
                    future_pnl = r.Field<decimal>("结算日期货盈亏"),
                    option_accum_pnl = r.Field<decimal>("累计期权盈亏"),
                    option_pnl = r.Field<decimal>("结算日期权盈亏")
                };
            var yearly_pnl =
                from r in dataset.display_ds.Tables["business_state_view"].AsEnumerable()
                where r.Field<DateTime>("结算日") < settle_day && r.Field<DateTime>("结算日") >= new DateTime(settle_day.Year, 1, 1)
                select new {
                    future_pnl = r.Field<decimal>("结算日期货盈亏"),
                    option_pnl =  r.Field<decimal>("结算日期权盈亏")
                };
            var future_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期货",
                "164871.00",
                gross_pnl.Select(r=>r.future_accum_pnl).First().ToString(),
                "---",
                "---",
                yearly_pnl.Select(r=>r.future_pnl).Sum().ToString(),
                gross_pnl.Select(r=>r.future_pnl).First().ToString()
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(future_line_data_array[i]);
                cell.CellStyle = style3;
                sheet.AutoSizeColumn(i);
            }

            //第五行    
            row = sheet.CreateRow(4);
            var buy_option_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期权销售",
                "0.00",
                gross_pnl.Select(r=>r.option_accum_pnl).First().ToString(),
                "---",
                "---",
                yearly_pnl.Select(r=>r.option_pnl).Sum().ToString(),
                gross_pnl.Select(r=>r.option_pnl).First().ToString()
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(buy_option_line_data_array[i]);
                cell.CellStyle = style3;
                sheet.AutoSizeColumn(i);
            }

            row = sheet.CreateRow(5);
            var sell_option_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期权购买",
                "0.00",
                "0.00",
                "---",
                "---",
                "0.00",
                "0.00"
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(sell_option_line_data_array[i]);
                cell.CellStyle = style3;
                sheet.AutoSizeColumn(i);
            }

            for (int i = 6; i < 17; ++i)
            {
                row = sheet.CreateRow(i);
                for (int j = 0; j < 9; ++j)
                {
                    cell = row.CreateCell(j);
                    cell.CellStyle = style3;
                }
            }


            workbook.Write(fs);
            fs.Close();
        }

        public void GenerateOptionReport(DateTime settle_day)
        {
            FileStream fs = new FileStream("MDAS_期权日报表(金融)_中粮期货(auto).xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Sheet1");

            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "宋体";

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            style1.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
            style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.SetFont(font1);

            var row = sheet.CreateRow(0);
            var cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue("采集表名称");
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("经营单位");
            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue("时间值");

            row = sheet.CreateRow(1);
            cell = row.CreateCell(0);
            cell.CellStyle = style1;
            cell.SetCellValue("业务日报（中粮期货）");

            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("中粮期货");

            cell = row.CreateCell(2);
            cell.CellStyle = style1;
            cell.SetCellValue(settle_day.ToShortDateString());

            var font2 = workbook.CreateFont();
            font2.IsBold = true;
            font2.FontName = "宋体";

            var style2 = workbook.CreateCellStyle();
            style2.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style2.SetFont(font2);

            var header_array = new string[]
            {
                "产品",
                "标的",
                "品种",
                "期权类型",
                "月份",
                "执行价格",
                "当日多仓(手)",
                "当日空仓(手)",
                "当日净持仓(手)",
                "当日总盈亏（元）",
                "当日总delta",
                "当日总gamma",
                "当日总theta",
                "当日总vega",
                "当日总rho",
                "平仓价（元/吨）",
                "当日结算价（元/吨）",
                "波动率",
                "期权期初价值（元）",
                "当日期权市值（元）",
                "当日手续费（元）",
                "当日净盈亏（元）"
            };
            row = sheet.CreateRow(2);
            for (int i = 0; i < header_array.Length; ++i)
            {
                cell = row.CreateCell(i);
                cell.CellStyle = style2;
                cell.SetCellValue(header_array[i]);
            }

            var style3 = workbook.CreateCellStyle();
            var font3 = workbook.CreateFont();
            font3.FontName = "宋体";
            style3.SetFont(font3);
            style3.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style3.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

            var option_table = dataset.display_ds.Tables["option_position_settle_info"];
            int n = 3;
            int n_col = option_table.Columns.Count;
            foreach (var data_row in option_table.AsEnumerable())
            {
                row = sheet.CreateRow(n);
                if ((DateTime)data_row.ItemArray[n_col-1] == settle_day)
                {
                    for (int j = 0; j < data_row.ItemArray.Count() - 1; ++j)
                    {
                        cell = row.CreateCell(j);
                        cell.CellStyle = style3;
                        cell.SetCellValue(data_row.ItemArray[j].ToString());
                    }
                    n++;
                }
            }
            var future_table = dataset.display_ds.Tables["future_position_settle_info"];
            foreach (var data_row in future_table.AsEnumerable())
            {
                row = sheet.CreateRow(n);
                if ((DateTime)data_row.ItemArray[n_col - 1] == settle_day)
                {
                    for (int j = 0; j < data_row.ItemArray.Count() - 1; ++j)
                    {
                        cell = row.CreateCell(j);
                        cell.CellStyle = style3;
                        cell.SetCellValue(data_row.ItemArray[j].ToString());
                    }
                    n++;
                }
            }

            workbook.Write(fs);
            fs.Close();
        }

        public void GenerateDetailedReport(DateTime settle_day)
        {
            FileStream fs = new FileStream(String.Format("产品运行数据日报（报风委会表单）-{0}.xls", settle_day.ToString("yyyyMMdd")), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Sheet1");

            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "宋体";

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            style1.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
            style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style1.SetFont(font1);

            sheet.AddMergedRegion(new CellRangeAddress(1, 1, 1, 6));

            workbook.Write(fs);
            fs.Close();
        }

        OTCDataSet dataset;
    }
}


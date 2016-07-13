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
            string dirPath = Properties.Settings.Default.SettleFileDir + '\\' + settle_day.ToString("yyyy.MM.dd")+'\\';
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            FileStream fs = new FileStream(dirPath+"MDAS_业务日报(金融)_中粮期货.xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            NPOI.SS.UserModel.ISheet sheet;
            NPOI.SS.UserModel.IRow row;
            NPOI.SS.UserModel.ICell cell;

            //工作簿1
            sheet = (HSSFSheet)workbook.CreateSheet("sheet_index");
            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "宋体";
            for (int i = 0; i < 22; ++i)
            {
                sheet.SetColumnWidth(i, 4296);
            }

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style1.WrapText = true;
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
            //调整表格大小
            sheet.SetColumnWidth(0, 6000);
            sheet.SetColumnWidth(1, 4296);
            sheet.SetColumnWidth(2, 7000);
            sheet.SetColumnWidth(3, 7000);
            sheet.SetColumnWidth(4, 4296);
            sheet.SetColumnWidth(5, 7000);
            sheet.SetColumnWidth(6, 7000);
            sheet.SetColumnWidth(7, 6000);
            sheet.SetColumnWidth(8, 6000);
            sheet.SetColumnWidth(9, 6000);

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
            style2.WrapText = true;
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
            style3.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style3.WrapText = true;
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
                where r.Field<DateTime>("结算日") <= settle_day && r.Field<DateTime>("结算日") >= new DateTime(settle_day.Year, 1, 1)
                select new {
                    future_pnl = r.Field<decimal>("结算日期货盈亏"),
                    option_pnl =  r.Field<decimal>("结算日期权盈亏")
                };
            string[] future_line_data_array = new string[] { };
            try
            {
                future_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期货",
                dataset.display_ds.Tables["business_overview"].Rows[0]["granted_balance"].ToString(),
                gross_pnl.Select(r=>r.future_accum_pnl).First().ToString(),
                "",
                "",
                yearly_pnl.Select(r=>r.future_pnl).Sum().ToString(),
                gross_pnl.Select(r=>r.future_pnl).First().ToString()
                };
            }
            catch (InvalidOperationException e)
            {
                return;
            }

            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(future_line_data_array[i]);
                cell.CellStyle = style3;
            }

            //第五行    
            row = sheet.CreateRow(4);
            var buy_option_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期权销售",
                "0.00",
                gross_pnl.Select(r=>r.option_accum_pnl).First().ToString(),
                "",
                "",
                yearly_pnl.Select(r=>r.option_pnl).Sum().ToString(),
                gross_pnl.Select(r=>r.option_pnl).First().ToString()
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(buy_option_line_data_array[i]);
                cell.CellStyle = style3;
            }

            row = sheet.CreateRow(5);
            var sell_option_line_data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期权购买",
                "0.00",
                "0.00",
                "",
                "",
                "0.00",
                "0.00"
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(sell_option_line_data_array[i]);
                cell.CellStyle = style3;
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
            string dirPath = Properties.Settings.Default.SettleFileDir + '\\' + settle_day.ToString("yyyy.MM.dd")+'\\';
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            FileStream fs = new FileStream(dirPath+"MDAS_期权日报表(金融)_中粮期货.xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
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
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style1.WrapText = true;
            style1.SetFont(font1);

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
                "当日净盈亏（元）",
                "已支付权利金（元）"
};

            for (int i = 0; i < header_array.Count(); ++i)
            {
                if (i == 2)
                {
                    sheet.SetColumnWidth(i, 12000);
                }
                else if (i == 16)
                {
                    sheet.SetColumnWidth(i, 9000);
                }
                else
                {
                    sheet.SetColumnWidth(i, 5000);
                }
            }

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
            style2.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style2.WrapText = true;
            style2.SetFont(font2);


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
            style3.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style3.WrapText = true;

            var option_table = dataset.display_ds.Tables["option_settle_view"];
            int n = 3;
            int n_col = option_table.Columns.Count;
            foreach (var data_row in option_table.AsEnumerable())
            {
                row = sheet.CreateRow(n);
                if ((DateTime)data_row.ItemArray[n_col-1] == settle_day)
                {
                    for (int j = 0; j < header_array.Count() ; ++j)
                    {
                        cell = row.CreateCell(j);
                        cell.CellStyle = style3;
                        cell.SetCellValue(data_row.ItemArray[j].ToString());
                    }
                    n++;
                }
            }
            var future_table = dataset.display_ds.Tables["future_settle_view"];
            n_col = future_table.Columns.Count;
            foreach (var data_row in future_table.AsEnumerable())
            {
                row = sheet.CreateRow(n);
                if ((DateTime)data_row.ItemArray[n_col - 1] == settle_day)
                {
                    for (int j = 0; j < header_array.Count()-1; ++j)
                    {
                        cell = row.CreateCell(j);
                        cell.CellStyle = style3;
                        cell.SetCellValue(data_row.ItemArray[j].ToString());
                    }
                    cell = row.CreateCell(header_array.Count() - 1);
                    cell.CellStyle = style3;
                    n++;
                }
            }

            workbook.Write(fs);
            fs.Close();
        }

        public void GenerateDetailedReport(DateTime settle_day)
        {
            string dirPath = Properties.Settings.Default.SettleFileDir + "\\" + settle_day.ToString("yyyy.MM.dd")+'\\';
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            FileStream fs = new FileStream(dirPath+String.Format("产品运行数据日报（报风委会表单）-{0}.xls", settle_day.ToString("yyyyMMdd")), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Sheet1");

            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "楷体";
            font1.FontHeightInPoints = 11;

            int left_border = 1;

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Medium;
            style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Medium;
            style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Medium;
            style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Medium;
            style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            style1.SetFont(font1);
            style1.WrapText = true;

            int nrow = 1;

            //表一：总账户信息
            //表一第一行
            var region = new CellRangeAddress(1, 1, left_border, 6);
            var row = sheet.CreateRow(nrow++);
            var cell = row.CreateCell(1);
            sheet.AddMergedRegion(region);
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);
            cell.SetCellValue("总账户");
            cell.CellStyle = style1;

            //表一第二行
            region = new CellRangeAddress(2, 2, left_border, 2);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            sheet.AddMergedRegion(region);
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);
            cell.SetCellValue("额度（元）");
            cell.CellStyle = style1;

            region = new CellRangeAddress(2, 2, left_border + 2, 4);
            cell = row.CreateCell(3);
            sheet.AddMergedRegion(region);
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);
            cell.SetCellValue("权益（元）");
            cell.CellStyle = style1;

            region = new CellRangeAddress(2, 2, left_border + 4, 6);
            cell = row.CreateCell(5);
            sheet.AddMergedRegion(region);
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);
            cell.SetCellValue("风险水平");
            cell.CellStyle = style1;

            //读取数据库表
            var granted_table = this.dataset.display_ds.Tables["business_overview"];
            var pnl_table = this.dataset.display_ds.Tables["business_state_view"];

            var last_year_settle_rec = (from s in pnl_table.AsEnumerable()
                                        where s.Field<DateTime>("结算日").Year < settle_day.Year orderby s.Field<DateTime>("结算日") descending
                                        select new
                                        {
                                            settle_day = s.Field<DateTime>("结算日"),
                                            accum_gross_pnl = s.Field<decimal>("累计总盈亏")
                                        }).First();

            //表一第三行
            string[] row_data = new string[]
            {
                "总授权额度",
                granted_table.Rows[0].Field<decimal>(0).ToString(),
                "年初总账户权益",
                (last_year_settle_rec.accum_gross_pnl+ granted_table.Rows[0].Field<decimal>(0)).ToString(),
                "总delta",
                "0"
            };
            int ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach(var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }

            //表一第四行
            var last_settle_rec = (from s in pnl_table.AsEnumerable()
                                        where s.Field<DateTime>("结算日") < settle_day
                                        orderby s.Field<DateTime>("结算日") descending
                                        select new
                                        {
                                            settle_day = s.Field<DateTime>("结算日"),
                                            accum_gross_pnl = s.Field<decimal>("累计总盈亏")
                                        }).First();

            row_data = new string[]
            {
                "已使用额度",
                granted_table.Rows[0].Field<decimal>(1).ToString(),
                "期初总账户权益",
                (last_settle_rec.accum_gross_pnl + granted_table.Rows[0].Field<decimal>(0)).ToString(),
                "",
                ""
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }

            //表一第五行
            var cur_settle_rec = (from s in pnl_table.AsEnumerable()
                                  where s.Field<DateTime>("结算日") == settle_day
                                  orderby s.Field<DateTime>("结算日") descending
                                  select new
                                  {
                                      settle_day = s.Field<DateTime>("结算日"),
                                      gross_pnl = s.Field<decimal>("结算日总盈亏"),
                                       accum_gross_pnl = s.Field<decimal>("累计总盈亏")
                                   }).First();
            
            row_data = new string[]
           {
                "授权亏损度",
                granted_table.Rows[0].Field<decimal>(2).ToString(),
                "当前总账户权益",
                (cur_settle_rec.accum_gross_pnl + granted_table.Rows[0].Field<decimal>(0)).ToString(),
                "",
                ""
           };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }

            //表一第六行
            row_data = new string[]
            {
                "",
                "",
                "当日盈亏数",
                cur_settle_rec.gross_pnl.ToString(),
                "",
                ""
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }

            //表一第七行
            row_data = new string[]
            {
                "",
                "",
                "本年亏损度",
                (cur_settle_rec.accum_gross_pnl - last_year_settle_rec.accum_gross_pnl<0?cur_settle_rec.accum_gross_pnl - last_year_settle_rec.accum_gross_pnl:0).ToString(),
                "",
                ""
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }

            //调整表格大小
            sheet.SetColumnWidth(1, 9000);
            sheet.SetColumnWidth(2, 4296);
            sheet.SetColumnWidth(3, 4296);
            sheet.SetColumnWidth(4, 4296);
            sheet.SetColumnWidth(5, 4296);
            sheet.SetColumnWidth(6, 4296);
            sheet.SetColumnWidth(7, 4296);
            sheet.SetColumnWidth(8, 4296);
            sheet.SetColumnWidth(9, 4296);
            sheet.SetColumnWidth(10, 4296);
            sheet.SetColumnWidth(11, 4296);

            //表二：期权信息
            nrow++;
            region = new CellRangeAddress(nrow, nrow, 1, 11);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期权账户");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            row_data = new string[] {
            "",
            "当日权利仓开仓量（手）",
            "当日权利仓平仓量（手）",
            "当日义务仓开仓量（手）",
            "当日义务仓平仓量（手）",
            "权利仓持仓量（手）",
            "义务仓持仓量（手）",
            "当日期权持仓损益（元）",
            "当日期权平仓损益（元）",
            "当日期权总损益（元）",
            "本年期权累计损益（元）"
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            var option_table = this.dataset.display_ds.Tables["option_detailed_settle_view"];
            int row_count = 0;
            foreach(var r in option_table.AsEnumerable())
            {
                if (r.Field<DateTime>("settle_date") == settle_day)
                {
                    row = sheet.CreateRow(nrow++);
                    ncol = left_border;
                    for (int i = 0; i < r.ItemArray.Count() - 2; ++i)
                    {
                        cell = row.CreateCell(ncol);
                        cell.CellStyle = style1;
                        cell.SetCellValue(r.ItemArray[i].ToString());
                        ncol++;
                    }
                    cell = row.CreateCell(ncol);
                    cell.CellStyle = style1;
                    if (row_count == 0)
                    {
                        cell.SetCellValue(r.ItemArray[r.ItemArray.Count() - 2].ToString());
                        ncol++;
                    }
                    row_count++;
                }

            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < option_table.Columns.Count - 1; ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表二：期货信息
            nrow++;
            region = new CellRangeAddress(nrow, nrow, 1, 10);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期货账户");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            row_data = new string[] {
            "",
            "当日多开仓量（手）",
            "当日多平仓量（手）",
            "当日空开仓量（手）",
            "当日空平仓量（手）",
            "净多持仓量（手）",
            "净空持仓量（手）",
            "保证金占用（元）",
            "当日对冲损益（元）",
            "本年对冲累计损益（元）"

            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            var future_table = this.dataset.display_ds.Tables["future_detailed_settle_view"];
            row_count=0;
            foreach (var r in future_table.AsEnumerable())
            {
                if (r.Field<DateTime>("settle_date") == settle_day)
                {
                    row = sheet.CreateRow(nrow++);
                    ncol = left_border;
                    for (int i = 0; i < r.ItemArray.Count() - 2; ++i)
                    {
                        cell = row.CreateCell(ncol);
                        cell.CellStyle = style1;
                        cell.SetCellValue(r.ItemArray[i].ToString());
                        ncol++;
                    }
                    cell = row.CreateCell(ncol);
                    cell.CellStyle = style1;
                    if (row_count == 0)
                    {
                        cell.SetCellValue(r.ItemArray[r.ItemArray.Count() - 2].ToString());
                        ncol++;
                    }
                    row_count++;
                }
            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < future_table.Columns.Count - 1; ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表三：期权持仓及对冲损益明细
            nrow++;
            region = new CellRangeAddress(nrow, nrow, 1, 6);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期权持仓及对冲损益明细");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            row_data = new string[] {
            "品种",
            "前日收盘理论价值（元/手）",
            "当日收盘理论价值（元/手）",
            "持仓数量（手）",
            "持仓方向",
            "期权价值的理论盈亏（元）"
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            var option_pnl_table = this.dataset.display_ds.Tables["option_pnl_settle_view"];
            foreach (var r in option_pnl_table.AsEnumerable())
            {
                if (r.Field<DateTime>("settle_date") == settle_day)
                {
                    row = sheet.CreateRow(nrow++);
                    ncol = left_border;
                    for (int i = 0; i < r.ItemArray.Count() - 1; ++i)
                    {
                        cell = row.CreateCell(ncol);
                        cell.CellStyle = style1;
                        cell.SetCellValue(r.ItemArray[i].ToString());
                        ncol++;
                    }
                }
            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < option_pnl_table.Columns.Count - 1; ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表四：期权行权明细
            nrow++;
            region = new CellRangeAddress(nrow, nrow, 1, 6);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期权行权明细");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            row_data = new string[] {
            "行权合约",
            "执行价格",
            "行权结算价",
            "行权数量（手）",
            "行权方向",
            "行权收支总额"
            };
            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            //var exercise_table = this.dataset.display_ds.Tables["option_pnl_settle_view"];
            /*foreach (var r in option_pnl_table.AsEnumerable())
            {
                if (r.Field<DateTime>("settle_date") == settle_day)
                {
                    row = sheet.CreateRow(nrow++);
                    ncol = left_border;
                    for (int i = 0; i < r.ItemArray.Count() - 1; ++i)
                    {
                        cell = row.CreateCell(ncol);
                        cell.CellStyle = style1;
                        cell.SetCellValue(r.ItemArray[i].ToString());
                        ncol++;
                    }
                }
            }*/
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < row_data.Count(); ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表五：期权持仓及对冲损益明细（复盘）            
            row_data = new string[] {
            "品种",
            "前日理论对冲持仓（手）",
            "当日对冲操作",
            "当日收盘理论对冲持仓",
            "理论对冲交易盈亏（元）"
            };
            nrow++;
            region = new CellRangeAddress(nrow, nrow, left_border, left_border + row_data.Count() - 1);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期权持仓及对冲损益明细（复盘）");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < row_data.Count(); ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表六：期权持仓及对冲损益明细（复盘）
            row_data = new string[] {
            "品种",
            "理论头寸净盈亏（元）",
            "理论头寸累计净盈亏（元）",
            "初始对冲保证金额度（元）",
            "当前对冲保证金额度（元）",
            "存续状态",
            "是否释放对冲保证金"
            };
            nrow++;
            region = new CellRangeAddress(nrow, nrow, left_border, left_border+row_data.Count()-1);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("期权持仓及对冲损益明细（复盘）");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < row_data.Count(); ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            //表七：客户风险状况				
            row_data = new string[] {
            "客户名称",
            "客户编号",
            "客户权益（元）",
            "应缴保证金（元）",
            "风险率"
            };
            nrow++;
            region = new CellRangeAddress(nrow, nrow, left_border, left_border + row_data.Count() - 1);
            sheet.AddMergedRegion(region);
            row = sheet.CreateRow(nrow++);
            cell = row.CreateCell(1);
            cell.CellStyle = style1;
            cell.SetCellValue("客户风险状况");
            RegionUtil.SetBorderTop(2, region, sheet, workbook);
            RegionUtil.SetBorderBottom(2, region, sheet, workbook);
            RegionUtil.SetBorderLeft(2, region, sheet, workbook);
            RegionUtil.SetBorderRight(2, region, sheet, workbook);

            ncol = left_border;
            row = sheet.CreateRow(nrow++);
            foreach (var data in row_data)
            {
                cell = row.CreateCell(ncol++);
                cell.CellStyle = style1;
                cell.SetCellValue(data);
            }
            row = sheet.CreateRow(nrow++);
            ncol = left_border;
            for (int i = 0; i < row_data.Count(); ++i)
            {
                cell = row.CreateCell(ncol);
                cell.CellStyle = style1;
                ncol++;
            }

            workbook.Write(fs);
            fs.Close();
        }

        OTCDataSet dataset;
    }
}


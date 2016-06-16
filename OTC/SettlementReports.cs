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
        public SettlementReports()
        {
            dataset = new DataSet();
            MySqlConnectionStringBuilder conn_builder = new MySqlConnectionStringBuilder();
            conn_builder.Server = "localhost";
            conn_builder.Port = 3306;
            conn_builder.Database = "otc_test";
            conn_builder.UserID = "root";
            conn_builder.Password = "80027111t";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_builder.GetConnectionString(true));
            conn.Open();
            MySqlCommand select_command = new MySqlCommand("select * from business_state_view", conn);
            var adapter = new MySqlDataAdapter(select_command);
            //adapter.FillSchema(dataset, SchemaType.Source, "business_state_view");
            adapter.Fill(dataset, "business_state_view");

        }
        public SettlementReports(OTCDataSet ds)
        {
            dataset = ds;
        }

        public void GenerateBusinessReport(DateTime settle_day)
        {
            FileStream fs = new FileStream("MDAS_业务日报(金融)_中粮期货(auto).xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Sheet1");

            HSSFFont font1 = (HSSFFont)workbook.CreateFont();
            font1.FontName = "宋体";
            font1.FontHeightInPoints = 11;

            HSSFCellStyle style1 = (HSSFCellStyle)workbook.CreateCellStyle();
            style1.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            style1.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
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
            font2.FontHeightInPoints = 11;

            var style2 = workbook.CreateCellStyle();
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

            var style3 = workbook.CreateCellStyle();
            var font3 = workbook.CreateFont();
            font3.FontHeightInPoints = 11;
            style3.SetFont(font3);
            row = sheet.CreateRow(3);
            row.RowStyle = style3;


            var future_gross_pnl =
                from r in dataset.Tables["business_state_view"].AsEnumerable()
                where r.Field<DateTime>("settle_day") == settle_day
                select r.Field<decimal>("future_pnl");

            var data_array = new string[] {
                "金融事业部",
                "场外期权交易",
                "期货",
                "164871.00",
                future_gross_pnl.First<decimal>().ToString(),
                "---",
                "---",
                "-104810.65",
                "0.00"
            };
            for (int i = 0; i < 9; ++i)
            {
                cell = row.CreateCell(i);
                cell.SetCellValue(data_array[i]);
            }
            

            workbook.Write(fs);
            fs.Close();
        }

        DataSet dataset;
    }
}


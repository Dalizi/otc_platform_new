using Microsoft.VisualStudio.TestTools.UnitTesting;
using OTC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTC.Tests
{
    [TestClass()]
    public class SettlementReportsTests
    {
        [TestMethod()]
        public void GenerateBusinessReportTest()
        {
            string sql_conn_str = "server = 10.2.7.210; user id = tanzehuan; password = 80027111t; database = otc_test; characterset = utf8; port = 3306";
            string redis_conn_str = "10.2.7.210:6379, password=Finders6";
            OTCDataSet dataset = new OTCDataSet(sql_conn_str, redis_conn_str);
            SettlementReports sr = new SettlementReports(dataset);
            sr.GenerateBusinessReport(new DateTime(2016, 5, 23));
            sr.GenerateOptionReport(new DateTime(2016, 5, 23));
            sr.GenerateDetailedReport(new DateTime(2016, 5, 23));
        }
    }
}
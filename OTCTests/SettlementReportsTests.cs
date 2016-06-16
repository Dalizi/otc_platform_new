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
            SettlementReports sr = new SettlementReports();
            sr.GenerateBusinessReport(new DateTime(2016,6,15));
        }
    }
}
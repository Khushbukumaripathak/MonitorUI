using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringWebApp.Models
{
    public class MockNotificationRule : INotificationRule
    {
        private List<NotificationRule> _testNameList = GetList();
        public static string dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\netcoreapp2.2", "");
        //reading data from csv and converting it into list
        public static List<NotificationRule> GetList()
        {
            List<NotificationRule> result = new List<NotificationRule>();
            string testcaseName;
            int loopCount, cycleTime;
            using (TextReader fileReader = File.OpenText(dir + "\\TestData\\TestCaseNames.csv"))
            {
                fileReader.ReadLine();
                var csv = new CsvReader(fileReader, CultureInfo.InvariantCulture);
                while (csv.Read())
                {
                    csv.TryGetField<string>(0, out testcaseName);
                    csv.TryGetField<int>(1, out cycleTime);
                    csv.TryGetField<int>(2, out loopCount);
                    result.Add(new NotificationRule {
                        testName = testcaseName,
                        cycleTime = cycleTime,
                        loopCount = loopCount
                    });                   
                }
            }
            return result;
        }

        public List<NotificationRule> GetTestName()
        {
            return _testNameList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonitoringWebApp.Models;
using Newtonsoft.Json;

namespace MonitoringWebApp.Controllers
{
    public class HomeController : Controller
    {
        public static string dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\netcoreapp2.2", "");
        public static string filePath = dir + "\\TestData\\TestCaseList.csv";
        
        //Constructor injection
        private readonly INotificationRule _notificationRule;

        public HomeController(INotificationRule notificationRule)
        {
            _notificationRule = notificationRule;
        }
        
        public ViewResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomePage(string startButton, string stopButton)
        {
            HttpContext.Session.SetString("message", "");
            if (!string.IsNullOrEmpty(startButton))
            {
                SCM_TF.Monitoring.MonitoringExecutable.Main();
                HttpContext.Session.SetString("message", "Execution Done");
            }
            else if (!string.IsNullOrEmpty(stopButton))
            {
                //foreach (var process in Process.GetProcessesByName("dotnet"))
                //{
                //    process.Kill();
                //}
                var process = Process.GetProcessesByName("dotnet");                

                process[process.Count()-1].Kill();

                HttpContext.Session.SetString("message", "Execution Stopped");
            }

            return View();
        }

        public IActionResult Details()
        {
            List<NotificationRule> data = _notificationRule.GetTestName();
            List<string> testCaseList = new List<string>();
            foreach (var item in data)
                testCaseList.Add(item.testName);
            ViewBag.testName = testCaseList;
            return View(data);
        }

        [HttpPost]
        public IActionResult Details(List<string> testName)
        {
            //ViewBag.Data = testName;
            HttpContext.Session.SetString("testName", string.Join(",", testName));
            List<string> value = HttpContext.Session.GetString("testName").Split(',').ToList();

            return RedirectToAction("DetailsView");
        }

        public IActionResult DetailsView()
        {
            List<string> value = HttpContext.Session.GetString("testName").Split(',').ToList();
            return View(value);
        }

        [HttpPost]
        public IActionResult DetailsView(List<int> cycleTime, List<int> loopCount, string save)
        {
            List<string> value = HttpContext.Session.GetString("testName").Split(',').ToList();
            if (!string.IsNullOrEmpty(save))
            {
                ViewBag.cycleTime = cycleTime;
                ViewBag.loopCount = loopCount;
                ViewBag.testName = value;
                List<NotificationRule> notify = new List<NotificationRule>(); ;
                for (int i = 0; i < cycleTime.Count; i++)
                {
                    notify.Add(
                     new NotificationRule
                     {
                         testName = value[i],
                         loopCount = loopCount[i],
                         cycleTime = cycleTime[i]
                     });

                }
                var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";" };
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(notify);
                }
                ViewBag.Message = "Data saved successfully! You can close the browser.";
            }
            return View(value);
        }

        public IActionResult Download()
        {
            return View();
        }
    }
}
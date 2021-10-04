using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringWebApp.Models
{
    public class NotificationRule
    {
        [Key]
        public string testName { get; set; }
        public int loopCount { get; set; }
        public int cycleTime { get; set; }
    }
}

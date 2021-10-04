using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringWebApp.Models
{
    public interface INotificationRule
    {
        List<NotificationRule> GetTestName();
    }
}

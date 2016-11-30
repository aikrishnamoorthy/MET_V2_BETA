using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MET.WEB.UI.Models.Common
{
    public class WorkItemModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string  Type { get; set; }

        public int TotalHours { get; set; }

        public int Severity { get; set; }
    }
}
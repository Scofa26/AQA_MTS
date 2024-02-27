using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfObjects.Models
{
    internal class Project
    {
        public string ProjectName { get; set; }
        public string Announcement { get; set; }
        public bool? IsShowAnnouncement { get; set; }
        public int ProjectType { get; set; }
        public bool IsTestCaseApprovals { get; set; }
        public string NewField { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.Models
{
    public class ReportingSkills
    {
        public int ID { get; set; }
        public DateTime? ReportingDate { get; set; }
        public int SkillID { get; set; }
        public int Count { get; set; }
    }
}
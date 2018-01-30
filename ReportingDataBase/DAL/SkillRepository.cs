using ReportingDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportingDataBase.DAL
{
    public class SkillRepository : GenericRepository<DatabaseContext, Skill>
    {
        public SkillRepository()
        {
            context = new DatabaseContext();
        }
    }
}
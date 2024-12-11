using DAL.EF;
using DAL.Enums;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class TaskPriorityRepository : BaseRepository<TaskPriority>, ITaskPriorityRepository
    {
        public TaskPriorityRepository(ManagementSystemContext context) : base(context)
        {
        }

    }
}

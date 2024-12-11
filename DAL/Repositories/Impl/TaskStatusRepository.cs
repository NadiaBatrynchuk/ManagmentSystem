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
    public class TaskStatusRepository : BaseRepository<Enums.TaskStatus>, ITaskStatusRepository
    {
        public TaskStatusRepository(ManagementSystemContext context) : base(context)
        {
        }

    }
}

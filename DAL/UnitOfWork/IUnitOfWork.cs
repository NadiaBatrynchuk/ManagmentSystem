using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        ITaskRepository Tasks { get; }
        ITaskPriorityRepository TaskPriorities { get; }
        ITaskCategoryRepository TaskCategories { get; }
        IUserTaskRepository UserTasks { get; }

        void Save();
    }
}

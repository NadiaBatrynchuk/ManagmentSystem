using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class TaskRepository : BaseRepository<Entities.Task>, ITaskRepository
    {
        public TaskRepository(ManagementSystemContext context) : base(context)
        {
        }

        public IEnumerable<Entities.Task> GetTasksByUserId(int userId)
        {
            return _set
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Where(t => t.UserId == userId)
                .ToList();
        }

        public IEnumerable<Entities.Task> GetTasksByStatus(int statusId)
        {
            return _set
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.User)
                .Where(t => t.StatusId == statusId)
                .ToList();
        }

        public IEnumerable<Entities.Task> GetTasksWithinDateRange(DateTime startDate, DateTime endDate)
        {
            return _set
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.User)
                .Where(t => t.CreatedAt >= startDate && t.Deadline <= endDate)
                .OrderBy(t => t.CreatedAt)
                .ToList();
        }

        public IEnumerable<Entities.Task> SearchTasks(string keyword)
        {
            return _set
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.User)
                .Where(t => t.TaskName.Contains(keyword) || t.Description.Contains(keyword))
                .ToList();
        }

    }
}

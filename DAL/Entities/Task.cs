using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } 
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }

        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public TaskCategory Category { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskCategory Status { get; set; }
        public User User { get; set; }
    }
}

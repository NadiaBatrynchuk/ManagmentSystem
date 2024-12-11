using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserTask
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime AssignedAt { get; set; }
    }
}

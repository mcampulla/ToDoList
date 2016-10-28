using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{

    public class TaskItem
    {
        [PrimaryKey]
        public int TaskId { get; set; }
        [Indexed]
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}

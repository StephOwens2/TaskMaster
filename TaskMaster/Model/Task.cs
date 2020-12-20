using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Model
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }

        //foreign key to Statuses - TableId name format is convention: 
        public int StatusId { get; set; }

        //navigation property - reference to status class itself
        public Status Status { get; set; }

    }
}

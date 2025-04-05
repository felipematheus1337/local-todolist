using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{

    enum TaskStatus
    {
        PENDING, FINISHED
    }
    class Tarefa
    {
        public int id { get; set; }
        public string description { get; set; }
        public DateTime creationDate { get; set; }

        public TaskStatus status;


    }
}

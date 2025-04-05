using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace todolist
{

 
    class User
    {
        public int id { get; set; }

        public string name { get; set; }

        public List<Tarefa> tasks { get; set; } = new List<Tarefa>();




    }
}

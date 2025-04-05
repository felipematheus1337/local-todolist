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


        public User() { }

        public User(string nome, int id) {
            this.name = nome;
            this.id = id;
        }




    }
}

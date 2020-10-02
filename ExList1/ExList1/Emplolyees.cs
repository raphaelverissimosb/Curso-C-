using System;
using System.Collections.Generic;
using System.Text;

namespace ExList1
{
    class Emplolyees
    {

        private string name { get; set;}
        private double salary { get; set;}
        private int id { get; set;}

        public Emplolyees(string name,double salary, int id) {
            this.name = name;
            this.salary = salary;
            this.id = id;
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ExercicioFixacaoEnum.Entities
{
    class Client
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }
        public Client(string name, string email, DateTime date) {
            this.Name = name;
            this.Email = email;
            this.BirthDate = date;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") -" + Email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RentedRoom
{
    class Rooms
    {
        public string Name {get;set;}
        public string Email {get;set;}


        public String getName() {
            return Name;
        }
        public void setName(string name) {
            this.Name = name;
        }


    }
}

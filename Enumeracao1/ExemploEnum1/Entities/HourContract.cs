using System;


namespace ExemploEnum1.Entities
{
    class HourContract
    {

        public DateTime Date{ get; set; }

        public double ValuePerHour { get; set; }

        public int Hour { get; set; }

        public HourContract() { 
        }

        public HourContract(DateTime date, double valuePerHour, int hour) {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hour = hour;
        }

        public double TotalValue() {
            return ValuePerHour * Hour;
        }


    }
}

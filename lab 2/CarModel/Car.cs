using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car
    {
        public string Mark { get; set; } = string.Empty;
        public double Power { get; set; }
        public int CountOfSeats { get; set; }

        public virtual double Qaullity ()
        {
            return 0.1 * Power * CountOfSeats;
        }

        public override string ToString()
        {
            return $"Марка автомобиля: {Mark}; Мощность двигателя: {Power}; Число мест: {CountOfSeats}; Качество: {Qaullity()} ";
        }

        public Car(string mark, double power, int countOfSeats)
        {
            Mark = mark;
            Power = power;
            CountOfSeats = countOfSeats;
        }

        public Car()
        {
            Mark = "";
            Power = 0;
            CountOfSeats = 0;
        }
    }
}

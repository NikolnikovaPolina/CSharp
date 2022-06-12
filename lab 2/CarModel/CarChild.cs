using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel
{
    public class CarChild : Car
    {
        public int YearOfManufacture { get; set; }

        public override double Qaullity()
        {
            return base.Qaullity() - 1.5 * (DateTime.Now.Year - YearOfManufacture);
        }

        public override string ToString()
        {
            return base.ToString() + $" Год производства: {YearOfManufacture}г;";
        }

        public CarChild(string mark, double power, int countOfSeats, int year) : base(mark, power, countOfSeats)
        {
            YearOfManufacture = year;
        }

        public CarChild() : base()
        {
            YearOfManufacture = 2000;
        }
    }
}

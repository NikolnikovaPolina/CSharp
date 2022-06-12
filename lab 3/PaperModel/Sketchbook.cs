using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperModel
{
    public class Sketchbook : Copybook
    {
        public Sketchbook()
        {
            Price = 0;
            Weight = 0;
            Color = "Зеленый";
            CountOfSheet = 0;
            Id = 0;
        }

        public double Price { get; set; }

        public double Weight { get; set; }

        public double Quallity()
        {
            return Weight * CountOfSheet * Price * 0.05;
        }

        public override void DeleteSheet(int count)
        {
            base.DeleteSheet(count);
            Weight = CountOfSheet * 0.2;
            Price = CountOfSheet * 2.2;
        }

        public void AddSheet(int count)
        {
            CountOfSheet += count;
            Weight += count * 0.2;
            Price += count * 2.2;
        }

        public override string ToString()
        {
            return base.ToString() + $"Цена: {Price}руб; Вес: {Weight}гр;";
        }
    }
}

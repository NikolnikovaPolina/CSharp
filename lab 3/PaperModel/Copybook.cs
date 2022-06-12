using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperModel
{
    public abstract class Copybook : IPaper
    {
        public string Color { get; set; } = string.Empty;   
        public int CountOfSheet { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return $"Цвет тетради: {Color}; Количество листов: {CountOfSheet}; Id: {Id}; ";
        }

        public virtual void DeleteSheet(int count)
        {
            if (CountOfSheet - count < 0)
                CountOfSheet = 0;
            else
                CountOfSheet -= count;
        }

        public void Paint(string color)
        {
            Color = color;
        }
    }
}

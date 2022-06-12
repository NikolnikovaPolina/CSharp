using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperModel
{
    public class Notepad : Copybook
    {
        public string Name { get; set; } = string.Empty;
        public double Size { get; set; }

        public string Description()
        {
            return $"Блокнот: {Name}, размер страниц: {Size}.";
        }

        public double Quallity()
        {
            return Size * CountOfSheet;
        }
    }
}

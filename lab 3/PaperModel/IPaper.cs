using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperModel
{
    public interface IPaper
    {
        public int CountOfSheet { get; set; }
        public void Paint(string color);
        public void DeleteSheet(int count);
    }
}

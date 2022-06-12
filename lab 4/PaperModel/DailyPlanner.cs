using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperModel
{
    internal class DailyPlanner : Copybook
    {
        public double Price { get; set; }
        public string Owner { get; set; } = string.Empty;

        public override void DeleteSheet(int count)
        {
            CountOfSheet -= count * 7;
            if (CountOfSheet < 0)
                CountOfSheet = 0;
        }

        public string GetInfo()
        {
            return $"Ежедневник: владелец - {Owner}, количество страниц - {CountOfSheet}.";
        }

    }
}

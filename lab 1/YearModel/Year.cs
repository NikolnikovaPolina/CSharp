using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearModel
{
    public class Year
    {
        public Day day { get; set; }
        public Month month { get; set; }
        public int year { get; set; }

        public Year()
        { }

        public Year(int year)
        {
            this.year = year;
            month = new Month("Январь");
            day = new Day(1);
        }

        private int CodeYear()
        {
            int codeYear;

            if (year / 100 == 20 || year / 100 == 16 || year / 100 == 12 || year / 100 == 8 || year / 100 == 4 || year / 100 == 0)
            {
                codeYear = 6;
            }
            else if (year / 100 == 21 || year / 100 == 17 || year / 100 == 13 || year / 100 == 9 || year / 100 == 5 || year / 100 == 1)
            {
                codeYear = 4;
            }
            else if (year / 100 == 22 || year / 100 == 18 || year / 100 == 14 || year / 100 == 10 || year / 100 == 6 || year / 100 == 2)
            {
                codeYear = 2;
            }
            else
            {
                codeYear = 0;
            }

            return codeYear;
        }

        private int CodeMonth()
        {
            int codeMonth;
          
            if ((year % 4 == 0 && month.month == "Январь") || month.month == "Апрель" || month.month == "Июль")
            {
                codeMonth = 0;
            }
            else if ((year % 4 != 0 && month.month == "Январь") || month.month == "Октябрь")
            {
                codeMonth = 1;
            }
            else if (month.month == "Май")
            {
                codeMonth = 2;
            }
            else if ((year % 4 == 0 && month.month == "Февраль") || month.month == "Август")
            {
                codeMonth = 3;
            }
            else if ((year % 4 != 0 && month.month == "Февраль") || month.month == "Март" || month.month == "Ноябрь")
            {
                codeMonth = 4;
            }
            else if (month.month == "Июнь")
            {
                codeMonth = 5;
            }
            else
            {
                codeMonth = 6;
            }

            return codeMonth;
        }

        private string DayOfTheWeek(int codeDay)
        {
            string dayOfTheWeek;

            if (codeDay == 0)
            {
                dayOfTheWeek = "Суббота";
            }
            else if (codeDay == 1)
            {
                dayOfTheWeek = "Воскресенье";
            }
            else if (codeDay == 2)
            {
                dayOfTheWeek = "Понедельник";
            }
            else if (codeDay == 3)
            {
                dayOfTheWeek = "Вторник";
            }
            else if (codeDay == 4)
            {
                dayOfTheWeek = "Среда";
            }
            else if (codeDay == 5)
            {
                dayOfTheWeek = "Четверг";
            }
            else
            {
                dayOfTheWeek = "Пятница";
            }

            return dayOfTheWeek;
        }

        public string CalculateDay()
        {
            int codeYear = CodeYear();
            int codeMonth = CodeMonth();
            int codeDay = (day.day + codeMonth + codeYear) % 7;
            
            return DayOfTheWeek(codeDay);
        }

        private int SearchForTheMonth(Month month)
        {
            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int i = 0;
           
            while (months[i] != month.month)
            {
                i++;
            }
           
            return i;
        }

        private int CompareStrings(Month month1, Month month2)
        {
            int str1 = SearchForTheMonth(month1);
            int str2 = SearchForTheMonth(month2);

            return str1 - str2;
        }

        private int Dday(int dday, ref int dmonth)
        {
            dmonth--;
            SearchForTheMonth(month);
            
            if (month.month == "Февраль" || month.month == "Апрель" || month.month == "Июнь" || month.month == "Август" ||
               month.month == "Сентябрь" || month.month == "Ноябрь" || month.month == "Январь")
            {
                dday += 31;
            }
            else if (this.year % 4 == 0 && month.month == "Март")
            {
                dday += 29;
            }
            else if (this.year % 4 != 0 && month.month == "Март")
            {
                dday += 28;
            }
            else
            {
                dday += 30;
            }

            return dday;
        }

        private int CompareYears(Year year, ref int dmonth, ref int dday)
        {
            int dyear = this.year - year.year;
            dmonth = CompareStrings(month, year.month);
            
            if (dmonth == 0)
            {
                dday = day.day - year.day.day;
                
                if (dday < 0)
                {
                    dyear--;
                    dmonth += 12;
                    dday = Dday(dday, ref dmonth);
                }
            }
            else if (dmonth > 0)
            {
                dday = day.day - year.day.day;
              
                if (dday < 0)
                {
                    dday = Dday(dday, ref dmonth);
                }
            }
            else
            {
                dyear--;
                dmonth += 12;
                dday = day.day - year.day.day;
                
                if (dday < 0)
                {
                    dday = Dday(dday, ref dmonth);
                }
            }

            return dyear;
        }
        public string CalculateInterval(Year year)
        {
            int dyear;
            int dmonth = 0;
            int dday = 0;

            if (this.year == year.year)
            {
                dyear = 0;
                dmonth = CompareStrings(month, year.month);
                
                if (dmonth == 0)
                {
                    dday = day.day - year.day.day;
                    
                    if (dday < 0)
                    {
                        dday *= (-1);
                    }
                }
                else if (dmonth > 0)
                {
                    dday = day.day - year.day.day;
                    
                    if (dday < 0)
                    {
                        dday = Dday(dday, ref dmonth);
                    }
                }
                else
                {
                    dmonth = -dmonth;
                    dday = year.day.day - day.day;
                    
                    if (dday < 0)
                    {
                        dday = year.Dday(dday, ref dmonth);
                    }
                }
            }
            else if (this.year > year.year)
            {
                dyear = CompareYears(year, ref dmonth, ref dday);
            }
            else
            {
                dyear = year.CompareYears(year, ref dmonth, ref dday);
            }
            
            dmonth += dyear * 12;
            string interval = "Количество месяцев: " + dmonth + "\nКоличество дней: " + dday;
            return interval;
        }
    }
}
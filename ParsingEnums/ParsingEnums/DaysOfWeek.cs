using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public class DaysOfWeek
    {
        public DayOfWeekType DayOfWeek { get; set; }
    }
    public enum DayOfWeekType
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Word
    {
        String[] weekDays = new String[7] { "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday", "Sunday" };

        String day;

        private static String RandomDay(String[] Days)
        {
            var rnd = new Random();
            String day = Days[rnd.Next(Days.Length)];
            return day;
        }

        private static String ChosenWord(String[] Days)
        {
            String day = RandomDay(Days);
            String hideDay = day;
            foreach (char l in hideDay)
            {
                hideDay = hideDay.Replace(l, '*');
            }
            return hideDay;

        }
    }
}

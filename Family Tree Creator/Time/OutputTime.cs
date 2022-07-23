using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree_Creator.Time
{
    internal class OutputTime : OutputTextOfTime
    {
        public OutputTime(string time):base(time)
        {
            DateConversion(time);
        }
        public override void DateConversion( string time)
        {
            string[] words = time.Split(new char[] { '.' });
            int z = 0;
            foreach (string s in words)
            {
                if (z == 0)
                {
                    this.myHours = int.Parse(s);
                }
                if (z == 1)
                {
                    this.myMinutes = int.Parse(s);
                }
                if (z == 2)
                {
                    this.mySeconds = int.Parse(s);
                }
                z++;
            }
        }
    }
}

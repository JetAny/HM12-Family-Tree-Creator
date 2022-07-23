
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree_Creator.Time
{
    internal class OutputDey : OutputTextOfTime
    {
        public OutputDey(string day):base(day) 
        {
            DateConversion(day);
        }
        public override void DateConversion(string day)
        {
            string[] words = day.Split(new char[] { '.' });
            int z = 0;
            foreach (string s in words)
            {
                if (z == 0)
                {
                    this.myYear = int.Parse(s);
                }
                if (z == 1)
                {
                    this.myMonth = int.Parse(s);
                }
                if (z == 2)
                {
                    this.myDay = int.Parse(s);
                }
                z++;
            }
        }
    }
}

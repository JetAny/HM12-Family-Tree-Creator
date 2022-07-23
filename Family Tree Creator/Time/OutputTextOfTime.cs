namespace Family_Tree_Creator
{
    public class OutputTextOfTime

    {
        public int myYear { get; set; }
        public int myMonth { get; set; }
        public int myDay { get; set; }
        public int myWeek { get; set; }
        public long myHours { get; set; }
        public long myMinutes { get; set; }
        public long mySeconds { get; set; }

        public OutputTextOfTime(string date) 
        {
            DateConversion(date);
        }        
        public virtual void DateConversion(string date)
        {
            string[] words = date.Split(new char[] { '.' });
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
                if (z == 3)
                {
                    this.myHours = int.Parse(s);
                }
                if (z == 4)
                {
                    this.myMinutes = int.Parse(s);
                }
                if (z == 5)
                {
                    this.mySeconds = int.Parse(s);
                }
                z++;
            }
        }
        public static void PrintDateTime( OutputTextOfTime day ) 
        {
            Console.WriteLine();
            Console.WriteLine(day);
            Console.WriteLine(new string('^', 20));
        }
        public override string ToString()
        {
            return 
                $"Год: {myYear}\n " +
                $"Месяц:{myMonth}\n" +
                $"Число:{myDay}\n" +
                $"Время: {myHours}:{myMinutes}:{mySeconds}";
        }
    }
}

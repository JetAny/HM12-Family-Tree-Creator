namespace FamilyTreeClassLib
{
    public class Servis
    {


        public static void Print(Family1 family)
        {
            Console.WriteLine(family);
            foreach (Person person in family.persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine(new string('-', 70));
        }
        public static void PrintTree(Family1 family1, Family1 family2, Family1 family3)

        {
            Console.WriteLine(new string('=', 100));
            Console.WriteLine("{0,31}{1,-40}", (new string(' ', 31)), (new string('_', 40)));
            Console.WriteLine("{0,30}{1,1}{2,40}{3,1}", (new string(' ', 30)), "|", family1, "|");
            Console.WriteLine("{0,30}|{1,-40}|", (new string(' ', 30)), (new string('_', 40)));
            foreach (Person person in family1.persons)
            {
                Console.WriteLine("{0,30}|{1,-40}|", (new string(' ', 10)), (person.firstName + " " + person.lastName));
            }
            Console.WriteLine("{0,30}|{1,-40}|", (new string(' ', 30)), (new string('_', 40)));
            Console.WriteLine("{0,35}{1,1}{2,30}", new string(' ', 35), "|", "|");
            Console.WriteLine("{0,35}{1,1}{2,30}", new string(' ', 35), "|", "|");
            Console.WriteLine("{0,35}{1,1}{2,30}", new string(' ', 35), "|", "|");
            Console.WriteLine("{0,35}{1,1}{2,30}", new string(' ', 35), "|", "|");
            Console.WriteLine("{0,6}{1,-35}{2,22}{3,-35}", new string(' ', 6), new string('_', 35), new string(' ', 22), new string('_', 35));
            Console.WriteLine("{0,5}|{1,-35}|{2,20}|{3,-35}|", new string(' ', 5), family2, new string(' ', 20), family3);
            Console.WriteLine("{0,5}|{1,-35}|{2,20}|{3,-35}|", new string(' ', 5), new string('_', 35), new string(' ', 20), new string('_', 35));

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine
                        ("{0,5}|{1,-35}|{2,20}|{3,-35}|",
                        new string(' ', 5), family2.persons[i].firstName + " " + family2.persons[i].lastName,
                        new string(' ', 20), family3.persons[i].firstName + " " + family3.persons[i].lastName);
                }
                catch (Exception)
                {
                    if (family2.persons[i] == null)
                    {
                        Console.WriteLine
                        ("{0,5}|{1,-35}|{2,20}|{3,-35}|",
                        new string(' ', 5), "  " + " " + " ",
                        new string(' ', 20), family3.persons[i].firstName + " " + family3.persons[i].lastName);
                    }

                    else
                    {
                        if (family3.persons[i] == null)
                        {
                            Console.WriteLine
                        ("{0,5}|{1,-35}|{2,20}|{3,-35}|",
                        new string(' ', 5), family2.persons[i].firstName + " " + family2.persons[i].lastName,
                        new string(' ', 20), " " + " " + " ");
                        }
                    }
                    break;
                }
            }
            Console.WriteLine("{0,5}|{1,-35}|{2,20}|{3,-35}|", new string(' ', 5), new string('_', 35), new string(' ', 20), new string('_', 35));
        }
        public static void TransformDate(Person person)     // 2022.10.08 (гггг,мм,дд)
        {            
            int yearBirth = person.dateOfBirth.Year;
            person.howManyYears = (person.dateOfDeath.AddYears(-yearBirth)).Year;
        }       
    }
}

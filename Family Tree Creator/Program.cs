using Family_Tree_Creator;
using Family_Tree_Creator.Time;
using FamilyTreeClassLib;


class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Петров", "Николай", 55, "1960,10,28", "2015,9,24", "male");
        Person person2 = new Person("Кузина", "Светлана", 50, "1965,10,28", "2010,9,24", "female");
        Person person3 = new Person("Сухов", "Николай", 55, "1970,10,28", "2012,9,24", "male");
        Person person4 = new Person("Васин", "Александр", 85, "1930,10,28", "2000,9,24", "male");
        Person person5 = new Person("Телева", "Татьяна", 75, "1940,10,28", "1998,9,24", "female");
        Person person6 = new Person("Колышкина", "Ольга", 55, "1960,10,28", "2005,9,24", "female");
        Person person7 = new Person("Сухова", "Наталья", 55, "1950,10,28", "2018,9,24", "female");
        Person person8 = new Person("Сухов", "Кирил", 55, "1968,10,28", "2150,9,24", "male");
        Person person9 = new Person("Васин", "Николай", 55, "1940,10,28", "2200,9,24", "male");

        Family1 family1 = new Family1("Петровы");
        Family1 family2 = new Family2("Васины");
        Family1 family3 = new Family3("Суховы");


        family1.AddPerson(person1, "Per");
        family1.AddPerson(person2, "Per");
        family1.AddPerson(person5, "Ch");
        family1.AddPerson(person3, "Ch");

        family2.AddPerson(person4, "Per");
        family2.AddPerson(person5, "Per");
        family2.AddPerson(person9, "Ch");

        family3.AddPerson(person3, "Per");
        family3.AddPerson(person6, "Per");
        family3.AddPerson(person7, "Ch");
        family3.AddPerson(person8, "Ch");

        Servis.Print(family1);
        Servis.Print(family2);
        Servis.Print(family3);
        Servis.PrintTree(family1, family2, family3);

        OutputTextOfTime day1 = new OutputDey ("2020.10.25");
        OutputTextOfTime time2 = new OutputTime("10.15.58");
        OutputTextOfTime day = new OutputTextOfTime("2020.10.25.10.15.58");

        OutputTextOfTime.PrintDateTime(day1);
        OutputTextOfTime.PrintDateTime(time2);
        OutputTextOfTime.PrintDateTime (day);
    }
}
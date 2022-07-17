namespace FamilyTreeClassLib
{
    public class Person
    {
        public string family { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public DateOnly dateOfDeath { get; set; }
        public string familyAffil { get; set; }


        public Person(string family, string name, int age, string dateOfBirth, string dateOfDeath, string familyAffil)
        {
            this.family = family;
            this.name = name;
            this.age = age;
            this.dateOfBirth = DateOnly.Parse(dateOfBirth);
            this.dateOfDeath = DateOnly.Parse(dateOfDeath);
            this.familyAffil = familyAffil;

        }


    }
}
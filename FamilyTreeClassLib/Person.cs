namespace FamilyTreeClassLib
{
    public class Person
    {        public string maidenName { get; set; }

        public string lastName { get; set; } 
        public string firstName { get; set; }
        public int age { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public DateOnly dateOfDeath { get; set; }
        public string gender { get; set; }
        public string familyMember { get; set; }
        public int howManyYears { get; set; }

        public Person(string lastName, string firstName, int age, string dateOfBirth, string dateOfDeath, string gender)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.dateOfBirth = DateOnly.Parse(dateOfBirth);
            this.dateOfDeath = DateOnly.Parse(dateOfDeath);
            this.gender = gender;           
        }

        public Person(string lastName, string firstName, int age, DateOnly dateOfBirth, DateOnly dateOfDeath, string gender)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            this.dateOfDeath = dateOfDeath;
            this.gender = gender;
        }
        public override string ToString()
        {       
            return  ($"Family:" +
                $"Person:                {firstName} {lastName}\n" +
                $"Age: {age}  Gender: {gender}\n" +
                $"Date jf birth: {dateOfBirth}  Date of death: {dateOfDeath}   Family Member {familyMember} How many years: {howManyYears}");             
        }
    }
}
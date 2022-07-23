namespace FamilyTreeClassLib
{
    public class Family1
    {
        public Person[] persons { get; set; } = new Person[4];
        public string family { get; set; }

        public Family1(string family)
        {
            this.family = family;
        }
        public override string ToString()
        {
            return $"Family:  {family}";
        }

        public void AddPerson(Person person, string familyMember1)
        {
            Person pers = new Person(person.lastName, person.firstName, person.age, person.dateOfBirth, person.dateOfDeath, person.gender);

            for (int i = 0; i < persons.Length; i++)
            {

                if (persons[i] == null)
                {

                    persons[i] = pers;
                    Servis.TransformDate(persons[i]);
                    persons[i].familyMember = familyMember1;
                    persons[i].howManyYears = pers.howManyYears;
                    if (persons[i].familyMember != "Ch")
                    {
                        if (persons[i].gender == "female")
                        {
                            persons[i].lastName = $"{persons[0].lastName}а (Девичья: {person.lastName})";
                        }
                    }
                    else
                    {
                        if (persons[i].gender == "female")
                        {
                            persons[i].lastName = $"{persons[0].lastName}а";
                        }
                        else { persons[i].lastName = persons[0].lastName; }
                        break;
                    }
                    break;
                }
            }
        }
    }
}
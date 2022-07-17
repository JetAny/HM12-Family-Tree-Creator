using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeClassLib
{
    internal class Family1
    {
        string family { get; set; }
        Person person { get; set; }
        
        public Family1(string family,Person person)
        {
            this.family = family;
            this.person = person;
        }
    }
}

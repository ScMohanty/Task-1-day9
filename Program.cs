using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Company
    {
        private string name;
        private string sector;
        private string location;
        private int age;

        public Company(string name, string sector, string location, int age)
        {
            Name = name;
            Sector = sector;
            Location = location;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Location { get => location; set => location = value; }
        public int Age { get => age; set => age = value; }


        public override string ToString()
        {
            return string.Format("Name {0}/nSector {1}/nLocation  {2}/nAge  {3}", Name, Sector, Location);
        }
        public override bool Equals(object obj)
        {
            Company c = (Company)obj;
            return this.Name.Equals(c.Name) && this.Location.Equals(c.Location);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
   
}
    



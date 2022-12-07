
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressVerwaltungLib
{
    public class Gruppe
    {
        public List<Person> people = new List<Person>();
        public string? Gruppenname;
        public int Gruppennummer;
        
        public void PersonAdd(Person person) 
        { 
            people.Add(person); 
        }
        public void Persondelet(int persondloeschen)
        {
            people.RemoveAt(persondloeschen);
        }
    }
}
    








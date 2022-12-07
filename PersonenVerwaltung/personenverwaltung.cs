namespace AdressVerwaltungLib
{
    public class Personenverwaltung
    {
        public List<Person> adressverwaltung = new List<Person>();
        public bool isSaved = true;
        public void addPerson(Person person)
        {
            int nummer = 0;
            if (person.Personalnumber == 0)
            {
                if (adressverwaltung.Count == 0)
                {
                    nummer = 1;
                }
                else
                {
                    nummer = adressverwaltung[adressverwaltung.Count - 1].Personalnumber + 1;
                }
                person.Personalnumber = nummer;
            }
            adressverwaltung.Add(person);
            isSaved = false;
        }
        public void EditPerson(Person personen, string Vorname, string Nachname, DateTime birthday)
        {
            int index = -1;
            foreach (Person person in adressverwaltung)
            {
                index = index + 1;
                if (person.Personalnumber.Equals(personen.Personalnumber))
                {
                    break;
                }
            }
            adressverwaltung[index].Firstname = Vorname;
            adressverwaltung[index].Lastname = Nachname;
            adressverwaltung[index].birthday = birthday;

            isSaved = false;
        }
        public void deletePerson(int PersönlicheNummerPersonZuLöschen)
        {
            Person PersonezuLöschen = new Person();
            foreach (Person personen in adressverwaltung)
            {
                if (PersönlicheNummerPersonZuLöschen == personen.Personalnumber)
                {
                    PersonezuLöschen = personen;
                }
            }
            adressverwaltung.Remove(PersonezuLöschen);
            isSaved = false;
        }
        public Person GetPerson(int PTC)
        {
            Person person1 = new Person();
                foreach (Person person in adressverwaltung)
                {
                    int PNTC = Convert.ToInt32(person.Personalnumber);
                    if (PNTC == PTC)
                    {
                        person1 = person;
                    }
                }
            return person1;
        }
    }
}

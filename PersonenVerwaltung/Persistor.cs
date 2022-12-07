using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdressVerwaltungLib
{
    public class Persistor
    {   
        public void saveXml(Adressvvrwaltung_Verwaltungen personenverwaltung, string Path)
        {
            personenverwaltung.meineVerwaltung.isSaved = true;
            using (FileStream fs = new FileStream(Path, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(typeof(Adressvvrwaltung_Verwaltungen));
                x.Serialize(fs, personenverwaltung);
            }
           }
        public Adressvvrwaltung_Verwaltungen LoadXml(string Path)
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung_Verwaltungen = new Adressvvrwaltung_Verwaltungen();
            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                XmlSerializer x = new XmlSerializer(typeof(Adressvvrwaltung_Verwaltungen));
                adressvvrwaltung_Verwaltungen = x.Deserialize(fs) as Adressvvrwaltung_Verwaltungen;               
            }
            return adressvvrwaltung_Verwaltungen;


        }
        //public void saveXmlGruppen(gruppenVerwaltung gruppenverwaltung, string Path)
        //{
        //    using (FileStream fs = new FileStream(Path, FileMode.Create))
        //    {
        //        XmlSerializer x = new XmlSerializer(typeof(gruppenVerwaltung));
        //        x.Serialize(fs, gruppenverwaltung);
        //    }
        //}
        //public gruppenVerwaltung LoadXmlGruppen(string Path)
        //{
        //    gruppenVerwaltung gruppenverwaltung = new gruppenVerwaltung();
        //    using (FileStream fs = new FileStream(Path, FileMode.Open))
        //    {
        //        XmlSerializer x = new XmlSerializer(typeof(gruppenVerwaltung));
        //        gruppenverwaltung = x.Deserialize(fs) as gruppenVerwaltung;
        //    }
        //    return gruppenverwaltung;

        //}
        //public void save(Personenverwaltung personenverwaltung, string Path)
        //{
            //Path1 = Path;
            //if (File.Exists(Path))
            //{
            //    File.Delete(Path);
            //}
            //foreach (Person person in personenverwaltung.adressverwaltung)
            //{
            //    Line = person.Personalnumber + ";" + person.Firstname + ";" + person.Lastname + ";" + person.birthday + ";" + person.Telenumber + "\n";
            //    System.IO.File.AppendAllText(Path, Line);
            //}
            //personenverwaltung.isSaved = true;
        //}
        //public Personenverwaltung Load(string Path)
        //{
        //Personenverwaltung personenverwaltung = new Personenverwaltung();
        //foreach (string line in System.IO.File.ReadLines(Path))
        //{
        //    string[] collection = line.Split(';');

        //    Person person = new Person();
        //    person.Personalnumber = Convert.ToInt32(collection[0]);
        //    person.Firstname = collection[1];
        //    person.Lastname = collection[2];
        //    person.birthday = Convert.ToDateTime(collection[3]);
        //    try
        //    {
        //        person.Telenumber = collection[4];
        //        personenverwaltung.addPerson(person);
        //    }
        //    catch
        //    {
        //        person.Telenumber = "Keine Vorhanden";
        //    }
        //    personenverwaltung.addPerson(person);
        //}
        //    return personenverwaltung;
        //}


    }
}

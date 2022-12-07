//Entwickle eine AdressVerwaltung. Es sollen User mit Vorname, Nachmane und Telefonnummer verwaltet werden können
using AdressVerwaltungLib;
using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace AdressVerwaltung
{
    public static class Adressverwaltung
    { 
        public static void Main()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung_Verwaltungen = new Adressvvrwaltung_Verwaltungen();
            int ESC = 1;
            do 
            {
                UserInterface.BaisikLook();
                string? toChekck = null;
                try
                {
                    toChekck = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Ungültige Ausgabe");
                    break;
                }
                Console.Clear();
                int ZUZ = Convert.ToInt32(toChekck);
                {
                    switch (ZUZ)
                    {
                        case 1:
                            {
                                int aPh = 0;
                                UserInterface.disgineAddPerseonBasic();
                                try
                                {
                                    aPh = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Unglültige Eingabe");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                                Console.WriteLine();
                                for (int i = 0; i < aPh; i++)
                                {
                                    int number = i + 1;
                                    UserInterface.disigneAddPerson();
                                    string firstname = Console.ReadLine();
                                    UserInterface.disgineAddPersonTwo();
                                    string lastname = Console.ReadLine();
                                    UserInterface.disgineAddPersonFor();
                                    string birthday = Console.ReadLine();
                                    string telenumber = Console.ReadLine();
                                    Console.WriteLine();
                                    UserInterface.disgineAddPersonThree();
                                    Person person = new Person();
                                    try
                                    {
                                        person.birthday = Convert.ToDateTime(birthday);
                                        person.Lastname = lastname;
                                        person.Firstname = firstname;
                                        person.Telenumber = telenumber;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ungültige Eingabe");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }
                                    adressvvrwaltung_Verwaltungen.meineVerwaltung.addPerson(person);
                                }
                                break;
                            }
                        case 2:
                            {
                                UserInterface.returnPerson(adressvvrwaltung_Verwaltungen.meineVerwaltung);
                                UserInterface.disgineAddPersonThree();
                                break;
                            }
                        case 3:
                            {
                                UserInterface.disgineModifyOne();
                                int personenzahl = 1;
                                foreach (Person person in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
                                {
                                    Console.WriteLine(personenzahl + ". " + person.Firstname + " " + person.Lastname);
                                    Console.WriteLine();
                                    personenzahl++;
                                }
                                UserInterface.disigneModifyBasic();
                                string? GPAS = Console.ReadLine();
                                int WishedPerson = Convert.ToInt32(GPAS);
                                foreach (Person persons in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
                                {
                                    if (WishedPerson == persons.Personalnumber)
                                    {
                                        UserInterface.disgineAddPerseonBasic();
                                        string firstname = Console.ReadLine();
                                        UserInterface.disgineAddPersonTwo();
                                        string lastname = Console.ReadLine();
                                        Console.WriteLine();
                                        UserInterface.disgineAddPersonThree();
                                        Person person = new Person();
                                        adressvvrwaltung_Verwaltungen.meineVerwaltung.EditPerson(persons, firstname , lastname, DateTime.Now);
                                    }
                                }
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                UserInterface.disgineModifyOne();
                                foreach (Person person in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
                                {
                                    Console.WriteLine(person.Personalnumber + ". " + person.Firstname + " " + person.Lastname);
                                    Console.WriteLine();
                                }
                                UserInterface.disigneModifyBasic();
                                string GPAS = null;
                                try
                                {
                                    GPAS = Console.ReadLine();
                                }
                                catch
                                {
                                    Console.WriteLine("Ungültige Eingabe");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                                int WishedPerson = Convert.ToInt32(GPAS);
                                adressvvrwaltung_Verwaltungen.meineVerwaltung.deletePerson(WishedPerson);
                                break;
                            }
                        case 5:
                            {
                                int CLO = 1;
                                do
                                {
                                    UserInterface.basicLockGroup();
                                    string ChoisToCheck = null;
                                    try
                                    {
                                        ChoisToCheck = Console.ReadLine();
                                    }
                                    catch 
                                    {
                                        Console.WriteLine("Ungültige Ausgabe");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                    }
                                    Console.Clear();
                                    int ZÜ = Convert.ToInt32(ChoisToCheck);
                                    switch (ZÜ)
                                    {
                                        case 1:
                                            {
                                                AddGroup(adressvvrwaltung_Verwaltungen.meineGruppen);
                                                break;
                                            }
                                        case 2:
                                            {
                                                UserInterface.disgineGroupBasicOne();
                                                int Gruppenzahl = 1;
                                                foreach (Gruppe gruppenacala in adressvvrwaltung_Verwaltungen.meineGruppen.gruppenverwaltung)
                                                {
                                                    Console.WriteLine(Gruppenzahl + " " + gruppenacala.Gruppenname);
                                                    Console.WriteLine();
                                                    Gruppenzahl++;
                                                }
                                                UserInterface.disigneGroupPersonBasic();
                                                string GPAS = null;
                                                try
                                                {
                                                    GPAS = Console.ReadLine();
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Ungültige Eingabe");
                                                    Thread.Sleep(2000);
                                                    Console.Clear();
                                                }
                                                int GewünschteGruppe = Convert.ToInt32(GPAS);

                                                Gruppe gruppe = adressvvrwaltung_Verwaltungen.meineGruppen.gruppenverwaltung[GewünschteGruppe - 1];  
                                                        int personenzahl = 1;
                                                        foreach (Person person in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
                                                        {
                                                            Console.WriteLine(personenzahl + ". " + person.Firstname + " " + person.Lastname);
                                                            Console.WriteLine();
                                                            personenzahl++;
                                                       }
                                                        UserInterface.disgineGroupBasicOne();
                                                        string GPZG = null;
                                                        try
                                                            {
                                                                GPZG = Console.ReadLine();
                                                            }
                                                        catch
                                                            {
                                                                Console.WriteLine("Ungültige Eingabe");
                                                                Thread.Sleep(2000);
                                                                Console.Clear();
                                                            }
                                                gruppe.PersonAdd(adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung.Find(person => person.Personalnumber.ToString() == GPZG));
                                                        Console.Clear();
                                                break;
                                            }
                                        case 3:
                                            {
                                                int WG = 0;
                                                UserInterface.prepareGroup(adressvvrwaltung_Verwaltungen.meineGruppen);
                                                Console.WriteLine("Welche Gruppe wollen sie Bearbeiten");
                                                try
                                                {
                                                    WG = Convert.ToInt32(Console.ReadLine());
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Ungültige Eingabe");
                                                    Thread.Sleep(2000);
                                                    Console.Clear();
                                                }
                                                foreach (Gruppe gruppe in adressvvrwaltung_Verwaltungen.meineGruppen.gruppenverwaltung)
                                                {
                                                    if (WG == gruppe.Gruppennummer)
                                                    {
                                                        Console.WriteLine("Was möchten sie Bearbeiten?");
                                                        Console.WriteLine();
                                                        Console.WriteLine("1. Name ändern");
                                                        Console.WriteLine("2. Personen entfärnen");
                                                        Console.WriteLine();
                                                        string WishedFunktionToPrepare = Console.ReadLine();
                                                        int WFTP = Convert.ToInt32(WishedFunktionToPrepare);
                                                        Console.WriteLine();
                                                        switch (WFTP)
                                                        {
                                                            case 1:
                                                                {
                                                                    UserInterface.disgineAddPerseonBasic();
                                                                    string gruppenname = Console.ReadLine();
                                                                    UserInterface.disgineAddPersonTwo();
                                                                    Gruppe gruppe1 = new Gruppe();
                                                                    adressvvrwaltung_Verwaltungen.meineGruppen.EditGroup(gruppe, gruppenname);
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    int personenzahl = 1;
                                                                    foreach (Person person in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
                                                                    {
                                                                        Console.WriteLine(personenzahl + ". " + person.Firstname + " " + person.Lastname);
                                                                        Console.WriteLine();
                                                                        personenzahl++;
                                                                    }
                                                                    Console.WriteLine("Welchge Person wollen sie entförnen");
                                                                    int personToDelet = Convert.ToInt32(Console.ReadLine()) - 1;
                                                                    gruppe.Persondelet(personToDelet);
                                                                    break;
                                                                }
                                                        }

                                                    }
                                                }
                                                break;
                                            }
                                        case 4:
                                            {
                                                UserInterface.disgineModifyOne();
                                                foreach (Gruppe gruppe in adressvvrwaltung_Verwaltungen.meineGruppen.gruppenverwaltung)
                                                {
                                                    Console.WriteLine(gruppe.Gruppennummer + ". " + gruppe.Gruppenname);
                                                    Console.WriteLine();
                                                }
                                                UserInterface.disigneModifyBasic();
                                                int GewünschteGruppe = 0;
                                                try
                                                {
                                                    string GGAS = Console.ReadLine();
                                                    GewünschteGruppe = Convert.ToInt32(GGAS);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("Ungültige Ausgabe");
                                                    Thread.Sleep(2000);
                                                    Console.Clear();
                                                }
                                                adressvvrwaltung_Verwaltungen.meineVerwaltung.deletePerson(GewünschteGruppe);
                                                break;
                                            }
                                        case 5:
                                            {
                                                UserInterface.returnGroup(adressvvrwaltung_Verwaltungen.meineGruppen);
                                                UserInterface.disgineAddPersonThree();
                                                break;
                                            }

                                        case 6:
                                            {
                                                CLO = 0;
                                                break;
                                            }
                                    }

                                }
                                while (CLO == 1);
                                break;
                            }

                        case 6:
                            {
                                Persistor persistor = new Persistor();
                                persistor.saveXml(adressvvrwaltung_Verwaltungen, "C:\\Users\\i40011221\\Documents\\Adressverwaltung\\Adressen.xml");
                                break;
                            }
                        case 7:
                            {
                                Persistor persistor = new Persistor();
                                adressvvrwaltung_Verwaltungen = persistor.LoadXml("C:\\Users\\i40011221\\Documents\\Adressverwaltung\\Adressen.xml");
                                break;
                            }
                        case 8:
                            {
                                ESC = 0;

                                Persistor persistor = new Persistor();
                                if (adressvvrwaltung_Verwaltungen.meineVerwaltung.isSaved != true)
                                {
                                    Console.WriteLine("Wollen sie das Program noch Speichern?");
                                    string jaOderNein = "";
                                    Console.WriteLine("Wollen sie das Program Speichern?");
                                    try
                                    {
                                        jaOderNein = Console.ReadLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ungültige Eingabe");
                                    }
                                    if (jaOderNein == "Ja" || jaOderNein == "ja");
                                    {
                                        persistor.saveXml(adressvvrwaltung_Verwaltungen, "C:\\Users\\i40011221\\Documents\\Adressverwaltung\\Adressen.xml");
                                    }
                                }
                            
                                break;
                            }
                    }
                }
            }
            while (ESC == 1);
        }

        private static void AddGroup(gruppenVerwaltung meineGruppen)
        {
            UserInterface.disgineAddGroupBasic();
            int aPh = 0;
            try
            {
                aPh = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe");
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine();
            for (int i = 0; i < aPh; i++)
            {
                int nummer = i + 1;
                UserInterface.disigneAddGroupBasicOne();
                string GruppenName = "";
                try
                {
                    GruppenName = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Ungültige eingabe");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                Console.WriteLine();
                UserInterface.disgineAddPersonThree();
                Gruppe gruppe = new Gruppe();
                gruppe.Gruppenname = GruppenName;

                meineGruppen.AddGroup(gruppe);
            }
        }
    }
}
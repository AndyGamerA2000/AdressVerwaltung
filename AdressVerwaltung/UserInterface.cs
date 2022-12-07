
using AdressVerwaltung;
using AdressVerwaltungLib;

public class UserInterface
{
    public static void disigneAddPerson()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine();                                                               
        Console.WriteLine("Bitte geben sie den Vorname Ein");
        Console.WriteLine();
    }
    public static void disgineAddPersonTwo()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Bitte geben sie den Nachname Ein");
        Console.WriteLine();
    }
    public static void disgineAddPersonFor()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Bitte geben sie das Alter Ein");
        Console.WriteLine();
    }
    public static void disgineAddPersonThree()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Eingabe mit Enter bestätigen");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.ReadKey();
        Console.Clear();
    }
    public static void BaisikLook()
    {
        Console.WriteLine();
        Console.WriteLine("Adressverwaltung");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("1: Benutzer Hinzufügen");
        Console.WriteLine("2: Benutzer Ausgaben");
        Console.WriteLine("3: Benutzer Bearbeiten");
        Console.WriteLine("4: Benutzer Löschen");
        Console.WriteLine("5: Gruppen Erstellen");
        Console.WriteLine("6: Adressverwaltung Speichern");
        Console.WriteLine("7: Adressverwaltung Laden");
        Console.WriteLine("8: Program beenden");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
    }
    public static void disgineAddPerseonBasic()
    {
        Console.WriteLine("Benutzer Hinzufügen");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Wie veiel Personen wollen sie Hinzufügen");
        Console.WriteLine();
    }
    public static void disgineModifyOne()
    {
        Console.WriteLine("Benutzer Bearbeiten");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Welcher Benutzer möchten sie Bearbeiten");
        Console.WriteLine();

    }
    public static void disgineModifyTwo()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();

    }
    public static void disigneModifyBasic()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Bitte Benutzer Auswählen");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
    }
    public static void returnPerson(Personenverwaltung personenverwaltung)
    {
        foreach (Person person in personenverwaltung.adressverwaltung)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine(person.Personalnumber + ". ");
            Console.Write(person.Firstname + " ");
            Console.WriteLine(person.Lastname + " ");
            Console.WriteLine(person.Telenumber);
            Console.WriteLine(person.GetAge());
            Console.WriteLine();
        }
    }
    public static void disgineGroupBasicTwo()
    {
        Console.WriteLine("Gruppe erstellen ");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Welcher Benutzer möchten sie zur Gruppe Hinzufügen");
        Console.WriteLine();

    }
    public static void disgineGroupBasicOne()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();

    }
    public static void disgineGroupOne()
    {
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Bitte Benutzer Auswählen");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
    }
    public static void basicLockGroup()
    {
        Console.WriteLine();
        Console.WriteLine("Gruppenverwaltung");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("1: Gruppe Erstellen");
        Console.WriteLine("2: Benutzer Hinzufügen");
        Console.WriteLine("3: Gruppen Bearbeiten");
        Console.WriteLine("4: Gruppen Löschen");
        Console.WriteLine("5: Gruppen Ausgeben");
        Console.WriteLine("6: Zurück");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
    }
    public static void disgineAddGroupBasic()
    {
        Console.WriteLine("Gruppen Erstellen");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Wie veiel Gruppen wollen sie Erstellen");
        Console.WriteLine();
    }
    public static void disigneAddGroupBasicOne()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Bitte geben sie den Gruppenname Ein");
        Console.WriteLine();
    }
    public static void returnGroup(gruppenVerwaltung gruppenverwaltung)
    {
        foreach (Gruppe gruppe in gruppenverwaltung.gruppenverwaltung)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.Write(gruppe.Gruppenname + " ");
            Console.WriteLine();
            foreach (Person gruppenmidglied in gruppe.people)
            {
                Console.WriteLine(gruppenmidglied.Firstname + " " + gruppenmidglied.Lastname);
            }
        }
    }
    public static void disigneGroupPersonBasic()
    {
        Console.WriteLine("Gruppe erstellen ");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Zu welcher Gruppe wollen sie Benutzer Hinzufügen");
        Console.WriteLine();

    }
    public static void prepareGroup(gruppenVerwaltung gruppenverwaltung) 
    {
        int numberToCount = 1;
        foreach (Gruppe gruppe in gruppenverwaltung.gruppenverwaltung)
        {
            Console.WriteLine(numberToCount + ". " + gruppe.Gruppenname);
            numberToCount++;
        }
    }
}
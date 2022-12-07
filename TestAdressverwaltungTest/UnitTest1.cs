using AdressVerwaltungLib;
namespace TestAdressverwaltungTest

{
    
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestNewAddressVerwaltung_Count0()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Assert.AreEqual(0, adressvvrwaltung.meineVerwaltung.adressverwaltung.Count);
        }

        [TestMethod]
        public void TestAddressVerwaltungAddPerson_Count1()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person1 = new Person();
            person1.Firstname = "dummy";
            person1.Personalnumber = 420;
            adressvvrwaltung.meineVerwaltung.addPerson(person1);
            Assert.AreEqual(1, adressvvrwaltung.meineVerwaltung.adressverwaltung.Count);
        }

        [TestMethod]
        public void TestGetPerson_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person1 = new Person();
            person1.Firstname = "dummy";
            person1.Personalnumber = 420;
            adressvvrwaltung.meineVerwaltung.addPerson(person1);
            Person person2 = adressvvrwaltung.meineVerwaltung.GetPerson(420);
            Assert.AreEqual(person2, person1);
        }
        [TestMethod]
        public void TestDeletePerson_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person1 = new Person();
            person1.Firstname = "dummy";
            person1.Personalnumber = 420;
            adressvvrwaltung.meineVerwaltung.addPerson(person1);
            Person personadressvvrwaltung2 = adressvvrwaltung.meineVerwaltung.GetPerson(420);
            adressvvrwaltung.meineVerwaltung.deletePerson(420);
            int z = adressvvrwaltung.meineVerwaltung.adressverwaltung.Count();
            Assert.AreEqual(0, z);
        }
        [TestMethod]
        public void TestEditPerson_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person1 = new Person();
            person1.Firstname = "dummy";
            person1.Personalnumber = 1;
            Person persondummy = new Person();
            persondummy.Firstname = "dummy";
            persondummy.Personalnumber = 1;
            adressvvrwaltung.meineVerwaltung.addPerson(person1);
            Person person2 = adressvvrwaltung.meineVerwaltung.GetPerson(1);
            adressvvrwaltung.meineVerwaltung.EditPerson(person2, "Dummy2.0", "", new DateTime( 2022, 2, 2));
            Assert.AreNotEqual(person2, persondummy);
        }
        [TestMethod]
        public void TestGetAge_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person = new Person();
            person.birthday = new DateTime(2009, 02, 02);
            string BD = person.GetAge();
            string birthday = BD.ToString();
            Assert.AreEqual("13", birthday);
        }
        [TestMethod]
        public void TestGetAge2_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person = new Person();
            person.birthday = new DateTime(2009, 12, 07);
            string BD = person.GetAge();
            string birthday = BD.ToString();
            Assert.AreEqual("13", birthday);

        }
        [TestMethod]
        public void TestGetAge3_Dummy()
        {
            Adressvvrwaltung_Verwaltungen adressvvrwaltung = new Adressvvrwaltung_Verwaltungen();
            Person person = new Person();
            person.birthday = new DateTime(2009, 12, 08);
            string BD = person.GetAge();
            string birthday = BD.ToString();
            Assert.AreEqual("12", birthday);
        }


    }
}
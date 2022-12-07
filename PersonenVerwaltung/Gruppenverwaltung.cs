using AdressVerwaltungLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressVerwaltungLib
{
    public class gruppenVerwaltung
    {
        public List<Gruppe> gruppenverwaltung = new List<Gruppe>();
        public void AddGroup(Gruppe gruppe)
        {
            int nummer = 0;
            if (gruppenverwaltung.Count == 0)
            {
                nummer = 1;
            }
            else
            {
                nummer = gruppenverwaltung[gruppenverwaltung.Count - 1].Gruppennummer + 1;
            }
            gruppe.Gruppennummer = nummer;
            gruppenverwaltung.Add(gruppe);
        }
        public void GroupToDelete(int gewünschtegruppe)
        {
            Gruppe gruppeZuLöschen = new Gruppe();
            foreach (Gruppe gruppen in gruppenverwaltung)
            {
                if (gewünschtegruppe == gruppen.Gruppennummer)
                {
                    gruppeZuLöschen = gruppen;
                }
            }
            gruppenverwaltung.Remove(gruppeZuLöschen);
            Console.Clear();
        }
        public void EditGroup(Gruppe gruppen, string gruppenname)
        {
            gruppenverwaltung[gruppen.Gruppennummer - 1].Gruppenname = gruppenname;

        }
    }
}

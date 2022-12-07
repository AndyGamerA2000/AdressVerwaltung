using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressVerwaltungLib
{
    public class Person
    {
        public string Firstname;
        public string Lastname;
        public string Telenumber;
        public int Personalnumber;
        public DateTime birthday;
        public Person()
        {
            Firstname = "";
            Lastname = "";
            birthday = DateTime.Now;

        }
        public Person(string firstname, string lastname, int personalNumber = 1)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            birthday = DateTime.Now;

        }
        public Person(string firstname, int personalNumber)
        {
            this.Firstname = firstname;
            this.Lastname = "";
            this.Personalnumber = personalNumber;
            birthday = DateTime.Now;

        }
        public string GetAge()
        { 
            
            DateTime now = DateTime.Now;
            TimeSpan Age = now.Subtract(birthday);
            string AY = "";
            if (birthday.Month <= now.Month)
            {
                int Ageyears = Age.Days / 365;
                AY = Convert.ToString(Ageyears);
            }
            else
            {
                if (birthday.Month == now.Month)
                {
                    if (birthday.Day < now.Day)
                    {
                        int Ageyears = Age.Days / 365;
                        AY = Convert.ToString(Ageyears);
                    }
                    else
                    {
                        int Ageyears = Age.Days / 365;
                        Ageyears = Ageyears - 1;
                        AY = Convert.ToString(Ageyears);
                    }

                }

            }
            return AY;
        }
        
         
    }
}

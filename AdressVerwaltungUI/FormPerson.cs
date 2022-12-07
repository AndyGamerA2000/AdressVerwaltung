using AdressVerwaltungLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressVerwaltungUI
{
    public partial class FormPerson : System.Windows.Forms.Form
    {
        public Person person = new Person();
        public FormPerson()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtFirstNameAddFP.Text = person.Firstname;
            txtTelenumberAddFP.Text = person.Telenumber;
            btnNameAdd.Text = person.Lastname;
            txtAddBirthdayDateFP.Text = Convert.ToString(person.birthday);
        }

        private void btnNameAdd_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnokayFP_Click(object sender, EventArgs e)
        {
            if (txtFirstNameAddFP.Text != "FirstName" && btnNameAdd.Text != "Name" && txtTelenumberAddFP.Text != "Telenumber")
            {
                person.Firstname = txtFirstNameAddFP.Text;
                person.Lastname = btnNameAdd.Text;
                person.Telenumber = txtTelenumberAddFP.Text;
                person.birthday = Convert.ToDateTime(txtAddBirthdayDateFP.Text);
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Sie haben keine Neue Person erstellt, geben sie gültige daten ein \n Wollen sie eine Neue Person erstellen?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            } 
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }
    }
}

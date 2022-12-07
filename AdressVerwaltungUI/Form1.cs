using AdressVerwaltungLib;

namespace AdressVerwaltungUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        Adressvvrwaltung_Verwaltungen adressvvrwaltung_Verwaltungen = new Adressvvrwaltung_Verwaltungen();
        public Form()
        {
            InitializeComponent();
        }
        int WishedPerson = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form = new Form(); 
            AdressVerwaltungReturn.Items.Clear();
            getAdressverwaltung();
            ReLoad_AdressVerwaltungReturn();
            AdressVerwaltungReturn.FullRowSelect = true;
            form.Text = "Adressverwaltung";
            btnEdit.Enabled = false;
            btudelete.Enabled = false;
            toolStripStatusLabel1.Text = "isSaved";
        }
        private void AdressVerwaltungReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdressVerwaltungReturn.SelectedItems.Count >= 1)
            {
                ListViewItem selectedItem = AdressVerwaltungReturn.SelectedItems[0];
                string WP = selectedItem.Text;
                WishedPerson = Convert.ToInt16(WP);
                string PersonToCheck = selectedItem.Text;
                int PTC = Convert.ToInt32(PersonToCheck);
                Person person = adressvvrwaltung_Verwaltungen.meineVerwaltung.GetPerson(PTC);
                btnEdit.Enabled = true;
                btudelete.Enabled = true;
            }
        }

        public void Savebtn_Click(object sender, EventArgs e)
        {
            save();
            toolStripProgressBar1.Maximum = 100000;
            toolStripProgressBar1.Step = 1;
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                toolStripProgressBar1.PerformStep();
            }
            toolStripStatusLabel1.Text = "isSaved";
            this.Refresh();
        }

        public void Namebtn_TextChanged(object sender, EventArgs e)
        {

        }

        public void FirstNamebtn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btuOK_Click(object sender, EventArgs e)
        {
        }
        private void ReLoad_AdressVerwaltungReturn()
        {
            AdressVerwaltungReturn.Items.Clear();
            foreach (Person person in adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = Convert.ToString(person.Personalnumber);
                Item.SubItems.Add(person.Lastname);
                Item.SubItems.Add(person.Firstname);
                Item.SubItems.Add(person.GetAge());
                AdressVerwaltungReturn.Items.Add(Item);
            }
            AdressVerwaltungReturn.Refresh();
        }

        private void btudelete_Click(object sender, EventArgs e)
        {
            if (AdressVerwaltungReturn.SelectedItems.Count >= 1)
            {
                ListViewItem selectedItem = AdressVerwaltungReturn.SelectedItems[0];
                string WP = selectedItem.Text;
                WishedPerson = Convert.ToInt16(WP);
                string PersonToCheck = selectedItem.Text;
                int PTC = Convert.ToInt32(PersonToCheck);
                Person person = adressvvrwaltung_Verwaltungen.meineVerwaltung.GetPerson(PTC);
                adressvvrwaltung_Verwaltungen.meineVerwaltung.deletePerson(person.Personalnumber);
                ReLoad_AdressVerwaltungReturn();
                toolStripProgressBar1.Value = (0);
                toolStripStatusLabel1.Text = "isNotSaved";
            }
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            FormPerson formPerson = new FormPerson();
            formPerson.Text = "AddPerson";
            formPerson.person = person;
            formPerson.ShowDialog();
 
            if (formPerson.DialogResult == DialogResult.OK)
            {
                adressvvrwaltung_Verwaltungen.meineVerwaltung.addPerson(person);
                ReLoad_AdressVerwaltungReturn();
            }
            else
            {
                if (DialogResult == DialogResult.Cancel)
                {
                    formPerson.Close();
                }
            }
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Text = "isNotSaved";
        }
        private void dateTimePickerAddPerson_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePickerShowAge_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AdressVerwaltungReturn_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (adressvvrwaltung_Verwaltungen.meineVerwaltung.isSaved == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sie haben nicht gespeichert!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    save();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AdressVerwaltungReturn.SelectedItems.Count >= 1)
            {
                ListViewItem selectedItem = AdressVerwaltungReturn.SelectedItems[0];
                string PersonToCheck = selectedItem.Text;
                int PTC = Convert.ToInt32(PersonToCheck);
                Person person = adressvvrwaltung_Verwaltungen.meineVerwaltung.GetPerson(PTC);
                FormPerson formPerson = new FormPerson();
                formPerson.Text = "EditPerson";
                formPerson.person = person;
                formPerson.ShowDialog();
                if (DialogResult == DialogResult.OK)
                {
                    adressvvrwaltung_Verwaltungen.meineVerwaltung.EditPerson(person, person.Firstname, person.Lastname, person.birthday);
                    ReLoad_AdressVerwaltungReturn();
                }
                else
                {
                    formPerson.Close();
                }
            }
            toolStripProgressBar1.Value = (0);
            toolStripStatusLabel1.Text = "isNotSaved";
        }

        private void pbForSavebtn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Caluculate(int i)
        { 
            double pow = Math.Pow(i, i);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adressvvrwaltung_Verwaltungen.meineVerwaltung.isSaved == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sie haben nicht gespeichert!", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    save();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            toolStripProgressBar1.Maximum = 100000;
            toolStripProgressBar1.Step = 1;
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                toolStripProgressBar1.PerformStep();
            }
            toolStripStatusLabel1.Text = "isSaved";
            this.Refresh();
        }
        

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML|*.xml";
            saveFileDialog.Title = "Save Adressverwaltung";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string path = saveFileDialog.FileName;
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                fs.Close();
                Persistor persistor = new Persistor();
                persistor.saveXml(adressvvrwaltung_Verwaltungen,path);

            }
            else
            {

            }
        }
        string PathToSave = "C:\\Users\\i40011221\\Documents\\Adressverwaltung\\SaveAdressverwaltug\\Adressen.xml";
        public void ControlePath()
        {
            if (!File.Exists(PathToSave))
            {
                Directory.CreateDirectory("C:\\Users\\[User1]\\Documents\\SaveAdressverwaltung");
                PathToSave = "C:\\Users\\[User1]\\Documents\\SaveAdressverwaltung\\Adressen.xml";
            }
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adressvvrwaltung_Verwaltungen.meineVerwaltung.adressverwaltung.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load a Adressverwaltung";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            PathToSave = path;
            Persistor persistor = new Persistor();
            persistor.LoadXml(path);
            ReLoad_AdressVerwaltungReturn();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                if (adressvvrwaltung_Verwaltungen.meineVerwaltung.isSaved == true)
                {

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Sie haben nicht gespeichert! \n wollen sie noch Speichern?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        save();
                    }
                    else
                    {   

                    }     
                }   
            }   
        }   
        public void save()
        {
            Persistor persistor = new Persistor();
            string path = "..\\net6.0-windows\\log.txt";
            System.IO.File.WriteAllText(path, "");
            System.IO.File.WriteAllText(path, PathToSave);
            persistor.saveXml(adressvvrwaltung_Verwaltungen, PathToSave);
            adressvvrwaltung_Verwaltungen.meineVerwaltung.isSaved = true;
        }
        public void getAdressverwaltung()
        {
             string path = "..\\net6.0-windows\\log.txt";
            string PathToLoad = System.IO.File.ReadAllText(path);
            Persistor persistor = new Persistor();
            adressvvrwaltung_Verwaltungen = persistor.LoadXml(PathToLoad);
            ReLoad_AdressVerwaltungReturn();
        }
    }
}

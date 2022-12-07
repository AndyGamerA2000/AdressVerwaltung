namespace AdressVerwaltungUI
{
    partial class FormPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNameAdd = new System.Windows.Forms.TextBox();
            this.txtTelenumberAddFP = new System.Windows.Forms.TextBox();
            this.txtFirstNameAddFP = new System.Windows.Forms.TextBox();
            this.btnokayFP = new System.Windows.Forms.Button();
            this.txtAddBirthdayDateFP = new System.Windows.Forms.DateTimePicker();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNameAdd
            // 
            this.btnNameAdd.Location = new System.Drawing.Point(45, 21);
            this.btnNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnNameAdd.Name = "btnNameAdd";
            this.btnNameAdd.Size = new System.Drawing.Size(106, 23);
            this.btnNameAdd.TabIndex = 0;
            this.btnNameAdd.TextChanged += new System.EventHandler(this.btnNameAdd_TextChanged);
            // 
            // txtTelenumberAddFP
            // 
            this.txtTelenumberAddFP.Location = new System.Drawing.Point(45, 94);
            this.txtTelenumberAddFP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelenumberAddFP.Name = "txtTelenumberAddFP";
            this.txtTelenumberAddFP.Size = new System.Drawing.Size(106, 23);
            this.txtTelenumberAddFP.TabIndex = 2;
            // 
            // txtFirstNameAddFP
            // 
            this.txtFirstNameAddFP.Location = new System.Drawing.Point(45, 57);
            this.txtFirstNameAddFP.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstNameAddFP.Name = "txtFirstNameAddFP";
            this.txtFirstNameAddFP.Size = new System.Drawing.Size(106, 23);
            this.txtFirstNameAddFP.TabIndex = 3;
            // 
            // btnokayFP
            // 
            this.btnokayFP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnokayFP.Location = new System.Drawing.Point(459, 219);
            this.btnokayFP.Name = "btnokayFP";
            this.btnokayFP.Size = new System.Drawing.Size(89, 39);
            this.btnokayFP.TabIndex = 4;
            this.btnokayFP.Text = "Okay";
            this.btnokayFP.UseVisualStyleBackColor = true;
            this.btnokayFP.Click += new System.EventHandler(this.btnokayFP_Click);
            // 
            // txtAddBirthdayDateFP
            // 
            this.txtAddBirthdayDateFP.Location = new System.Drawing.Point(208, 21);
            this.txtAddBirthdayDateFP.Name = "txtAddBirthdayDateFP";
            this.txtAddBirthdayDateFP.Size = new System.Drawing.Size(200, 23);
            this.txtAddBirthdayDateFP.TabIndex = 5;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(459, 168);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(89, 45);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtAddBirthdayDateFP);
            this.Controls.Add(this.btnokayFP);
            this.Controls.Add(this.txtFirstNameAddFP);
            this.Controls.Add(this.txtTelenumberAddFP);
            this.Controls.Add(this.btnNameAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPerson";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox btnNameAdd;
        private TextBox txtTelenumberAddFP;
        private TextBox txtFirstNameAddFP;
        private Button btnokayFP;
        private DateTimePicker txtAddBirthdayDateFP;
        private Button btnCancle;
    }
}
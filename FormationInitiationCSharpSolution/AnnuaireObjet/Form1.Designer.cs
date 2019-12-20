namespace AnnuaireObjet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.checkBoxTelPrefered = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelPoste = new System.Windows.Forms.Label();
            this.textBoxPoste = new System.Windows.Forms.TextBox();
            this.labelSociete = new System.Windows.Forms.Label();
            this.textBoxSociete = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxFiltre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNaissance = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(158, 66);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(186, 22);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(73, 69);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(73, 110);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(57, 17);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "Prénom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(158, 107);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(186, 22);
            this.textBoxPrenom.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(73, 153);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(158, 150);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(186, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(73, 194);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(76, 17);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Téléphone";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(158, 191);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(186, 22);
            this.textBoxPhone.TabIndex = 6;
            // 
            // checkBoxTelPrefered
            // 
            this.checkBoxTelPrefered.AutoSize = true;
            this.checkBoxTelPrefered.Checked = true;
            this.checkBoxTelPrefered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTelPrefered.Location = new System.Drawing.Point(158, 239);
            this.checkBoxTelPrefered.Name = "checkBoxTelPrefered";
            this.checkBoxTelPrefered.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTelPrefered.TabIndex = 8;
            this.checkBoxTelPrefered.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Favoriser le téléphone";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(158, 478);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 41);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Ami",
            "ContactPro",
            "Famille"});
            this.comboBoxType.Location = new System.Drawing.Point(158, 277);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(186, 24);
            this.comboBoxType.TabIndex = 11;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // labelPoste
            // 
            this.labelPoste.AutoSize = true;
            this.labelPoste.Location = new System.Drawing.Point(73, 452);
            this.labelPoste.Name = "labelPoste";
            this.labelPoste.Size = new System.Drawing.Size(44, 17);
            this.labelPoste.TabIndex = 15;
            this.labelPoste.Text = "Poste";
            this.labelPoste.Visible = false;
            // 
            // textBoxPoste
            // 
            this.textBoxPoste.Location = new System.Drawing.Point(158, 449);
            this.textBoxPoste.Name = "textBoxPoste";
            this.textBoxPoste.Size = new System.Drawing.Size(186, 22);
            this.textBoxPoste.TabIndex = 14;
            this.textBoxPoste.Visible = false;
            // 
            // labelSociete
            // 
            this.labelSociete.AutoSize = true;
            this.labelSociete.Location = new System.Drawing.Point(73, 411);
            this.labelSociete.Name = "labelSociete";
            this.labelSociete.Size = new System.Drawing.Size(55, 17);
            this.labelSociete.TabIndex = 13;
            this.labelSociete.Text = "Société";
            this.labelSociete.Visible = false;
            // 
            // textBoxSociete
            // 
            this.textBoxSociete.Location = new System.Drawing.Point(158, 408);
            this.textBoxSociete.Name = "textBoxSociete";
            this.textBoxSociete.Size = new System.Drawing.Size(186, 22);
            this.textBoxSociete.TabIndex = 12;
            this.textBoxSociete.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(533, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 361);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenom";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telephone";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            // 
            // comboBoxFiltre
            // 
            this.comboBoxFiltre.FormattingEnabled = true;
            this.comboBoxFiltre.Items.AddRange(new object[] {
            " Tous",
            "Ami",
            "ContactPro",
            "Famille"});
            this.comboBoxFiltre.Location = new System.Drawing.Point(533, 69);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(186, 24);
            this.comboBoxFiltre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type";
            // 
            // dateTimePickerNaissance
            // 
            this.dateTimePickerNaissance.Location = new System.Drawing.Point(158, 322);
            this.dateTimePickerNaissance.Name = "dateTimePickerNaissance";
            this.dateTimePickerNaissance.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNaissance.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date de Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ville";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(158, 365);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(186, 22);
            this.textBoxVille.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerNaissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFiltre);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelPoste);
            this.Controls.Add(this.textBoxPoste);
            this.Controls.Add(this.labelSociete);
            this.Controls.Add(this.textBoxSociete);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxTelPrefered);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxTelPrefered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelPoste;
        private System.Windows.Forms.TextBox textBoxPoste;
        private System.Windows.Forms.Label labelSociete;
        private System.Windows.Forms.TextBox textBoxSociete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBoxFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaissance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVille;
    }
}


namespace AnyasPhoneBook
{
    partial class FromContactsMenu
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
            this.ListBoxContacts = new System.Windows.Forms.ListBox();
            this.LabelContactList = new System.Windows.Forms.Label();
            this.ButtonAddContact = new System.Windows.Forms.Button();
            this.LabelInformationForAddContact = new System.Windows.Forms.Label();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonUpdateListBox = new System.Windows.Forms.Button();
            this.ButtonSearchContacts = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonRemoveContact = new System.Windows.Forms.Button();
            this.ButtonSortList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxContacts
            // 
            this.ListBoxContacts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListBoxContacts.FormattingEnabled = true;
            this.ListBoxContacts.ItemHeight = 23;
            this.ListBoxContacts.Location = new System.Drawing.Point(6, 46);
            this.ListBoxContacts.Name = "ListBoxContacts";
            this.ListBoxContacts.Size = new System.Drawing.Size(361, 303);
            this.ListBoxContacts.TabIndex = 0;
            // 
            // LabelContactList
            // 
            this.LabelContactList.AutoSize = true;
            this.LabelContactList.Location = new System.Drawing.Point(2, 14);
            this.LabelContactList.Name = "LabelContactList";
            this.LabelContactList.Size = new System.Drawing.Size(138, 23);
            this.LabelContactList.TabIndex = 1;
            this.LabelContactList.Text = "Мои контакты:";
            // 
            // ButtonAddContact
            // 
            this.ButtonAddContact.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAddContact.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.ButtonAddContact.Location = new System.Drawing.Point(174, 140);
            this.ButtonAddContact.Name = "ButtonAddContact";
            this.ButtonAddContact.Size = new System.Drawing.Size(274, 34);
            this.ButtonAddContact.TabIndex = 20;
            this.ButtonAddContact.Text = "Добавить";
            this.ButtonAddContact.UseVisualStyleBackColor = false;
            this.ButtonAddContact.Click += new System.EventHandler(this.ButtonAddContact_Click);
            // 
            // LabelInformationForAddContact
            // 
            this.LabelInformationForAddContact.AutoSize = true;
            this.LabelInformationForAddContact.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.LabelInformationForAddContact.Location = new System.Drawing.Point(9, 7);
            this.LabelInformationForAddContact.Name = "LabelInformationForAddContact";
            this.LabelInformationForAddContact.Size = new System.Drawing.Size(439, 23);
            this.LabelInformationForAddContact.TabIndex = 19;
            this.LabelInformationForAddContact.Text = "Заполните поля, чтобы добавить новый контакт.";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxPhone.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextBoxPhone.Location = new System.Drawing.Point(174, 104);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(274, 30);
            this.TextBoxPhone.TabIndex = 18;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.TextBoxName.Location = new System.Drawing.Point(64, 53);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(384, 30);
            this.TextBoxName.TabIndex = 17;
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.LabelPhone.Location = new System.Drawing.Point(9, 107);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(159, 23);
            this.LabelPhone.TabIndex = 16;
            this.LabelPhone.Text = "Номер телефона:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.LabelName.Location = new System.Drawing.Point(9, 53);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 23);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ButtonAddContact);
            this.panel1.Controls.Add(this.LabelInformationForAddContact);
            this.panel1.Controls.Add(this.TextBoxPhone);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.LabelPhone);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Location = new System.Drawing.Point(374, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 192);
            this.panel1.TabIndex = 21;
            // 
            // ButtonUpdateListBox
            // 
            this.ButtonUpdateListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonUpdateListBox.Font = new System.Drawing.Font("Wingdings 3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonUpdateListBox.Location = new System.Drawing.Point(328, 6);
            this.ButtonUpdateListBox.Name = "ButtonUpdateListBox";
            this.ButtonUpdateListBox.Size = new System.Drawing.Size(39, 36);
            this.ButtonUpdateListBox.TabIndex = 22;
            this.ButtonUpdateListBox.Text = "@";
            this.ButtonUpdateListBox.UseVisualStyleBackColor = false;
            this.ButtonUpdateListBox.Click += new System.EventHandler(this.ButtonUpdateListBox_Click);
            // 
            // ButtonSearchContacts
            // 
            this.ButtonSearchContacts.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSearchContacts.Location = new System.Drawing.Point(673, 44);
            this.ButtonSearchContacts.Name = "ButtonSearchContacts";
            this.ButtonSearchContacts.Size = new System.Drawing.Size(75, 32);
            this.ButtonSearchContacts.TabIndex = 23;
            this.ButtonSearchContacts.Text = "Поиск";
            this.ButtonSearchContacts.UseVisualStyleBackColor = false;
            this.ButtonSearchContacts.Click += new System.EventHandler(this.ButtonSearchContacts_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(482, 46);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(185, 30);
            this.TextBoxSearch.TabIndex = 24;
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(800, 6);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(30, 29);
            this.ButtonCloseForm.TabIndex = 25;
            this.ButtonCloseForm.Text = "X";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSave.Location = new System.Drawing.Point(482, 119);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(266, 32);
            this.ButtonSave.TabIndex = 26;
            this.ButtonSave.Text = "Сохранить изменения";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click_1);
            // 
            // ButtonRemoveContact
            // 
            this.ButtonRemoveContact.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonRemoveContact.Location = new System.Drawing.Point(482, 82);
            this.ButtonRemoveContact.Name = "ButtonRemoveContact";
            this.ButtonRemoveContact.Size = new System.Drawing.Size(266, 32);
            this.ButtonRemoveContact.TabIndex = 27;
            this.ButtonRemoveContact.Text = "Удалить контакт";
            this.ButtonRemoveContact.UseVisualStyleBackColor = false;
            this.ButtonRemoveContact.Click += new System.EventHandler(this.ButtonRemoveContact_Click);
            // 
            // ButtonSortList
            // 
            this.ButtonSortList.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSortList.Location = new System.Drawing.Point(169, 8);
            this.ButtonSortList.Name = "ButtonSortList";
            this.ButtonSortList.Size = new System.Drawing.Size(153, 35);
            this.ButtonSortList.TabIndex = 28;
            this.ButtonSortList.Text = "Отсортировать";
            this.ButtonSortList.UseVisualStyleBackColor = false;
            this.ButtonSortList.Click += new System.EventHandler(this.ButtonSortList_Click);
            // 
            // FromContactsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 356);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonSortList);
            this.Controls.Add(this.ButtonRemoveContact);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonSearchContacts);
            this.Controls.Add(this.ButtonUpdateListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelContactList);
            this.Controls.Add(this.ListBoxContacts);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FromContactsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контакты";
            this.Load += new System.EventHandler(this.FromContactsMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxContacts;
        private System.Windows.Forms.Label LabelContactList;
        private System.Windows.Forms.Button ButtonAddContact;
        private System.Windows.Forms.Label LabelInformationForAddContact;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonUpdateListBox;
        private System.Windows.Forms.Button ButtonSearchContacts;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonRemoveContact;
        private System.Windows.Forms.Button ButtonSortList;
    }
}


﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnyasPhoneBook
{
    public partial class FromContactsMenu : Form
    {
        private static PhoneBook phonebook;
        public FromContactsMenu()
        {
            InitializeComponent();
            phonebook = new PhoneBook();
        }
        private void FromContactsMenu_Load(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phonebook, "contacts.txt");
            RefreshList();
        }

        static string CheckName(string TextName)
        {
            string message = "";

            if (TextName == "")
            {
                message = "Поле для ввода имени не может быть пустым.";
            }
            else
            {
                foreach (char symbol in TextName)
                {
                    if (!char.IsLetter(symbol) && symbol != ' ')
                    {
                        message = "Поле имя может содержать только буквы.";
                        break;
                    }

                }
            }

            return message;
        }

        static string CheckPhone(string TextPhone)
        {
            string message = "";

            if (TextPhone == "")
            {
                message = "Поле для ввода номера телефона не может быть пустым.";
            }
            else
            {
                if (message == "")
                {
                    foreach (char symbol in TextPhone)
                    {
                        if (!char.IsDigit(symbol) && symbol != '+')
                        {
                            message = "Поле для ввода номера телефона может содержать только цифры и знак +.";
                            break;
                        }

                    }
                }

                if (message == "")
                {
                    if (TextPhone[0] == '+')
                    {
                        if (TextPhone.Length < 12 || TextPhone.Length > 12)
                        {
                            message = "Некорректное количество символов в номере телефона для сохранения.";
                        }
                    }
                    else
                    {
                        if (TextPhone.Length < 11 || TextPhone.Length > 11)
                        {
                            message = "Некорректное количество символов в номере телефона для сохранения.";
                        }
                    }
                }
            }

            return message;
        }

        static void AddContact(string TextName, string TextPhone)
        {
            Contact contact = new Contact(TextName, TextPhone);
            phonebook.AddContact(contact);
        }

        private void ButtonAddContact_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string phone = TextBoxPhone.Text;
            string message;

            message = CheckName(name);

            if (message == "")
            {
                message = CheckPhone(phone);

                if (message == "")
                {
                    Contact VerifableContact = new Contact(name, phone);
                    bool NotFound = phonebook.CheckContainsContact(VerifableContact);
                    if (NotFound == true)
                    {
                        AddContact(name, phone);
                        MessageBox.Show("Контакт добавлен.");
                    }
                    else
                    {
                        MessageBox.Show("Контакт с таким номером телефона уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonRemoveContact_Click(object sender, EventArgs e)
        {
            string name;
            string phone;
            string[] components = ListBoxContacts.SelectedItem.ToString().Split(',');

            name = components[0];
            phone = components[1];

            if (ListBoxContacts.SelectedIndex != -1)
            {
                phonebook.RemoveContact(phonebook, name, phone);
            }

            RefreshList();
        }

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(ListBoxContacts, "contacts.txt");
        }

        private void ButtonSearchContacts_Click(object sender, EventArgs e)
        {
            string SearchComponent = TextBoxSearch.Text;
            if (SearchComponent != "")
            {
                List<Contact> searchResults = phonebook.SearchContact(phonebook, SearchComponent);
                ListBoxContacts.Items.Clear();
                foreach (Contact contact in searchResults)
                {
                    ListBoxContacts.Items.Add(contact.ContactToString());
                }
            }
        }

        public void RefreshList()
        {
            ListBoxContacts.Items.Clear();
            foreach (Contact contact in phonebook.GetContacts())
            {
                ListBoxContacts.Items.Add(contact.ContactToString());
            }
        }

        private void ButtonUpdateListBox_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ButtonSortList_Click(object sender, EventArgs e)
        {
            ListBoxContacts.Sorted = true;
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
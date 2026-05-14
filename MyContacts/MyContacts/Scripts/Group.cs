using System;
using System.Collections.Generic;

namespace MyContacts.Scripts
{
    public class Group
    {
        //Variables
        private string name;
        private List<Contact> contactsList;

        //Properties
        public string Name { get => name; private set => name = value; }
        public List<Contact> Contacts { get => contactsList; private set => contactsList = value; }

        //Constructor
        public Group()
        {
            this.Name = "Undefined";
            this.Contacts = new List<Contact>();
        }

        public Group(string groupName)
        {
            this.Name = groupName;
            this.Contacts = new List<Contact>();
        }

            public Group(string groupName, List<Contact> contacts)
            {
                this.Name = groupName;
                this.Contacts = contacts;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

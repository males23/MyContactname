using System;
using System.Drawing;

namespace MyContacts.Scripts
{
    public class Contact
    {
       //Variables
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string address;
        private string city;
        private Image photo;

        //Properties
        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public string Email { get => email; private set => email = value; }
        public string Phone { get => phone; private set => phone = value; }
        public string Address { get => address; private set => address = value; }
        public string City { get => city; private set => city = value; }
        public Image Photo { get => photo; private set => photo = value; }

        //Constructor

        public Contact()
        {
           
        }
        public Contact(string firstName, string lastName, string email, string phone, string address, string city, Image photo)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            City = city;
            Photo = photo;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
}

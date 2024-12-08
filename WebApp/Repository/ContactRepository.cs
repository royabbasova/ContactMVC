using System;
using WebApp.Models;

namespace WebApp.Repository
{
	public class ContactRepository
	{
		private List<Contact> contacts =
						new List<Contact>()
						{
							new Contact() { ID = 1, Name = "Esma", Surname = "Uddin", ImagePath = "~/images/1.jpeg"},
							new Contact() { ID = 2, Name = "Mirvari", Surname = "Muradova", ImagePath = "~/images/2.jpeg"},
                            new Contact() { ID = 3, Name = "Zehra", Surname = "Malikzada", ImagePath = "~/images/3.jpeg"},
                            new Contact() { ID = 4, Name = "Roya", Surname = "Abbasova", ImagePath = "~/images/4.jpeg"},
                        };


		public List<Contact> GetContacts()
		{
			return this.contacts;
		}

		public Contact? GetByID(int ID)
		{
			return this.contacts.FirstOrDefault(c => c.ID == ID);
		}
	}
}


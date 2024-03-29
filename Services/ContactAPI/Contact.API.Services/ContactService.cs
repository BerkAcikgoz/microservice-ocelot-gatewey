﻿using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO
            {
                Id = 1994,
                FirstName = "Berk",
                LastName = "Açıkgöz"
            };
        }
    }
}

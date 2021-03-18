using System;
using domain.abstracts;

namespace domain.models
{
    public class AccountModel : AEntity
    {
        public string Email {get; set;}
        public string FirstName {get; set;}
        public string LastName {get;set;}
        public DateTime DateJoined {get;set;}
        
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class AnimalRescueAccount
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get;set;}
        public string EmailAddress {get; set;}
        public string? PhoneNumber {get;set;}
        public DateTime? DateOfBirth {get;set;}
        public string? Address1 {get;set;}
        public string? Address2 {get;set;}
        public string? City {get;set;}
        public string? State {get;set;}
        public string? ZipCode {get;set;}
        public string? Country {get;set;}
        public virtual IEnumerable<AnimalRescueAccountRole> AnimalRescueAccountRoles {get; set;}
        public virtual IEnumerable<AnimalRescueAccountLocation> AnimalRescueAccountLocations {get; set;}
        public virtual AnimalRescueAccountVolunteerApplication AnimalRescueAccountVolunteerApplication { get; set; } 
        public virtual AnimalRescueAccountFosterApplication AnimalRescueAccountFosterApplication { get; set; }  
        public virtual IEnumerable<AnimalRescueAccountAdoptionApplication> AnimalRescueAccountAdoptionApplications { get; set; }   
    }
}
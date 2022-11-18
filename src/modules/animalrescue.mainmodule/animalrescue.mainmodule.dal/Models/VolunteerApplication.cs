using animalrescue.mainmodule.helpers.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace animalrescue.mainmodule.dal.models
{
    public class VolunteerApplication: IHasAddress
    {
        public int Id {get; set;}
        public int AnimalRescueAccountId {get; set;}
        public string Username { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName {get;set;}
        public string EmailAddress {get; set;} = string.Empty;
        public string? PhoneNumber {get;set;} 
        public DateTime? DateOfBirth {get;set;}
        public string? Address1 {get;set;}
        public string? Address2 {get;set;}
        public string? City {get;set;}
        public string? State {get;set;}
        public string? ZipCode {get;set;}
        public string? Country {get;set;}
        public bool? HaveDogTraining {get;set;}
        public string? DogTrainingDetails {get;set;}
        public bool? HaveBottleFeeding {get;set;}
        public string? BottleFeedingDetails {get;set;}
        public bool? HaveGrantWriting {get;set;}
        public string? GrantWritingDetails {get;set;}
        public bool? OwnDog {get;set;}
        public bool? OwnCat {get;set;}
        public bool? ConvictedFelonyOfAnimals {get;set;}
        public string? ConvictedFelonyOfAnimalsDetails {get;set;}
        public virtual AnimalRescueAccount AnimalRescueAccount {get; set;} = null!;
        public virtual IEnumerable<VolunteerApplicationInterest> VolunteerApplicationInterests {get;set;} = null!;
        public virtual IEnumerable<VolunteerApplicationPurpose> VolunteerApplicationPurposes {get;set;} = null!;
        public virtual IEnumerable<VolunteerApplicationPet> VolunteerApplicationPets {get;set;} = null!;
        public virtual IEnumerable<VolunteerApplicationAgreement> VolunteerApplicationAgreements {get;set;} = null!;
    }
}
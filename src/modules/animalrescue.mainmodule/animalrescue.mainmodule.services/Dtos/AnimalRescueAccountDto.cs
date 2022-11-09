using System;
using System.Collections.Generic;
using PropertyChanged;

namespace animalrescue.mainmodule.services.dtos
{
    public class AnimalRescueAccountDto : BaseDto
    {
        [DoNotNotify]
        public int Id { get; set; }
        [DoNotNotify]
        public string Username { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [DoNotNotify]
        public string EmailAddress { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
namespace animalrescue.mainmodule.web.viewmodels.location
{
    public class LocationDetailsVm
    {
        public int Id {get; set;}
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
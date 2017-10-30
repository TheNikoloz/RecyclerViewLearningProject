using System;

namespace RecyclerViewX
{
    public enum Genders
    {
        Male,
        Female
    }

    public class Person
    {
        public int ImageResourceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BD { get; set; }
        public Genders Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLearning.Domain
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorBiography Biography { get; set; }
    }
    public class AuthorBiography
    {
        public int AuthorBiographyId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public int AuthorRef { get; set; }
        public Author Author { get; set; }
    }

    // One-to-One Relationship which do not need mapping
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public StudentAddress Address { get; set; }
    //}

    //public class StudentAddress
    //{
    //    public int StudentAddressId { get; set; }
    //    public string Address { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string Country { get; set; }
    //    public int StudentId { get; set; }
    //    public Student Student { get; set; }
    //}
}

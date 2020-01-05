using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLearning.Domain
{
    //Shodow Property
    //public class AuthorTest
    //{
    //    public int AuthorId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public ICollection<Book> Books { get; set; }
    //}
    //public class Book
    //{
    //    public int BookId { get; set; }
    //    public string Title { get; set; }
    //}
    //**************************************************************
    //Inverse Navigation Property
    //public class Author
    //{
    //    public int AuthorId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public ICollection<Book> Books { get; set; }
    //}
    //public class Book
    //{
    //    public int BookId { get; set; }
    //    public string Title { get; set; }
    //    public Author Author { get; set; }
    //}
    //**************************************************************
    //Fully Defined Relationship
    //public class Author
    //{
    //    public int AuthorId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public ICollection<Book> Books { get; set; }
    //}
    //public class Book
    //{
    //    public int BookId { get; set; }
    //    public string Title { get; set; }
    //    public int AuthorId { get; set; }
    //    public Author Author { get; set; }
    //}
    //**************************************************************
    //public class Property
    //{
    //    public int PropertyId { get; set; }
    //    public string Address { get; set; }
    //    public List<Tenant> Tenants { get; set; }
    //}
    //public class Tenant
    //{
    //    public int TenantId { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public int? PropertyId { get; set; }   // Optional Relationship Tenant can exist with out Property 
    //    public Property Property { get; set; }
    //}
    //***************************************************************
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
    }
}


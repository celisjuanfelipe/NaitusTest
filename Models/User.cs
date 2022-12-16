using System;
using System.Collections.Generic;

namespace NaitusTest.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Rut { get; set; } = null!;
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Pass { get; set; }
    }
}

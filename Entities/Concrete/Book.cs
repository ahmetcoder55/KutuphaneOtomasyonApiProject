using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Author { get; set; } = "no-name";
        public int Page { get; set; } = 10;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}

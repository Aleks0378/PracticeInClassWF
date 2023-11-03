using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02._10.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Product() { }
        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}";
        }
    }
}

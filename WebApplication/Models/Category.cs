using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Material> Materials { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class MaterialsListViewModel
    {
        public IEnumerable<Material> Materials { get; set; }
        public string CurrentCategory { get; set; }
    }
}

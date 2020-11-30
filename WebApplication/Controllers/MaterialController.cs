using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MaterialController(IMaterialRepository materialRepository, ICategoryRepository categoryRepository)
        {
            _materialRepository = materialRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Material> materials;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                materials = _materialRepository.AllMaterials.OrderBy(p => p.MaterialId);
                currentCategory = "All Materials";
            }
            else
            {
                materials = _materialRepository.AllMaterials.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.MaterialId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new MaterialsListViewModel
            {
                Materials = materials,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            Material material = _materialRepository.GetMaterialById(id);
            if (material == null) return NotFound();
            
            return View(material);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly AppDbContext _appDbContext;

        public MaterialRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Material> AllMaterials 
        {
            get 
            {
                return _appDbContext.Materials.Include(c => c.Category);
            }
        }

        public IEnumerable<Material> MaterialsOfTheWeek
        { 
            get
            {
                return _appDbContext.Materials.Include(c => c.Category).Where(p => p.IsMaterialOfTheWeek);
            }
        }

        public Material GetMaterialById(int materialId)
        {
            return _appDbContext.Materials.FirstOrDefault(m => m.MaterialId == materialId);
        }
    }
}

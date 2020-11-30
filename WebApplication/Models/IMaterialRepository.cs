using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public interface IMaterialRepository
    {
        IEnumerable<Material> AllMaterials { get; }
        IEnumerable<Material> MaterialsOfTheWeek { get; }
        Material GetMaterialById(int materialId);

    }
}

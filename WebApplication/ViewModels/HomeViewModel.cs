﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Material> MaterialsOfTheWeek { get; set; }

    }
}

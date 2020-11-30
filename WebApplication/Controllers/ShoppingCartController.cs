using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMaterialRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMaterialRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectedMaterial = _pieRepository.AllMaterials.FirstOrDefault(p => p.MaterialId == pieId);

            if (selectedMaterial != null)
            {
                _shoppingCart.AddToCart(selectedMaterial, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            var selectedMaterial = _pieRepository.AllMaterials.FirstOrDefault(p => p.MaterialId == pieId);

            if (selectedMaterial != null)
            {
                _shoppingCart.RemoveFromCart(selectedMaterial);
            }
            return RedirectToAction("Index");
        }
    }
}

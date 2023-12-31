﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{

    public HomeController()
    {

    }

    [HttpGet]
    public IActionResult Index(string searchString, string category)
    {
        var product = Repository.Product;
        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearcString = searchString;
            product = product.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }

        if(!String.IsNullOrEmpty(category) && category != "0"){
            product = product.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }

     //   ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");

        var model = new ProductViewModel{
            Products = product,
            Categories =Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product model, IFormFile imageFile)
    {
        var allowedExtensions = new[] {".jpg",".jpeg",".png"};
        var extension = Path.GetExtension(imageFile.FileName); // ahmet.jpg
        var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);

        if(imageFile != null){
            if(!allowedExtensions.Contains(extension)){
                ModelState.AddModelError("", "Geçerli bir resim seçiniz");
            }
        }

        if(ModelState.IsValid){
            if(imageFile != null){
            using(var stream = new FileStream(path,FileMode.Create)){
                await imageFile.CopyToAsync(stream);
            }
            }
        model.Image = randomFileName;
        model.ProductId = Repository.Product.Count +1;
        Repository.CreateProduct(model);
        return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int? id){
        if(id == null){
            return NotFound();
        }

        var entity = Repository.Product.FirstOrDefault(p => p.ProductId == id);
        if(entity == null){
            return NotFound();
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(entity);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(int id, Product model, IFormFile? imageFile){
        if(id != model.ProductId){
            return NotFound();
        }
        if(ModelState.IsValid){           
            if(imageFile != null){
            var extension = Path.GetExtension(imageFile.FileName); // ahmet.jpg
            var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);
            using(var stream = new FileStream(path,FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);                
            }
                model.Image = randomFileName;
            }
            Repository.EditProduct(model);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(model);
    }

    public IActionResult Delete(int? id){
        if(id == null){
            return NotFound();
        }
        var entity = Repository.Product.FirstOrDefault(p => p.ProductId == id);
        if(id == null){
            return NotFound();
        }

        return View("DeleteConfirm",entity);
    }

    [HttpPost]
    public IActionResult Delete(int id, int ProductId){
        
        if(id != ProductId){
            return NotFound();
        }
        var entity = Repository.Product.FirstOrDefault(p => p.ProductId == ProductId);
        if(entity == null){
            return NotFound();
        }
        Repository.DeleteProduct(entity);
        return RedirectToAction("Index");
    }


}

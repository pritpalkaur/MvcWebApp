using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MVCWeb.Models;
using MVC.Business.Interface;
using MVC.Exceptions.Service;
using MVC.Domain;

namespace MVCWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductBusiness _productBusiness;
        private readonly ILoggingService _ILoggingService;
        private readonly IMapper _mapper; // Inject IMapper

        public ProductsController(IProductBusiness IProductBusiness, ILoggingService ILoggingService, IMapper mapper)
        {
            _productBusiness = IProductBusiness;
            _ILoggingService = ILoggingService;
            _mapper = mapper; // Assign IMapper to a field
        }

        public async Task<IActionResult> ProductsIndex()
        {
            var products = await _productBusiness.GetProductsAsync();

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            // Map List<Products> to List<ProductViewModel>
            var productViewModels = _mapper.Map<List<ProductViewModel>>(products);

            return View(productViewModels); // Pass the ViewModel list to the view
        }
        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Products>(model);
                await _productBusiness.AddProductAsync(product);
                return RedirectToAction(nameof(ProductsIndex));
            }
            return View(model);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            //var product = await _productBusiness.GetProductByIdAsync(id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //var model = _mapper.Map<ProductViewModel>(product);
            return View();//model
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel model)
        {
            //if (id != model.Id)
            //{
            //    return BadRequest();
            //}

            //if (ModelState.IsValid)
            //{
            //    var product = _mapper.Map<Product>(model);
            //    await _productBusiness.UpdateProductAsync(product);
            //    return RedirectToAction(nameof(ProductsIndex));
            //}
            return View(model);
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //await _productBusiness.DeleteProductAsync(id);
           return RedirectToAction();//nameof(ProductsIndex)
        }
    }
}



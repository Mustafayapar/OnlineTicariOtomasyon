using Microsoft.AspNetCore.Mvc;
using OnlineTicariOtomasyon.Models.Entity;
using System.Linq;

namespace OnlineTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    foreach (var entry in ModelState)
                    {
                        foreach (var error in entry.Value.Errors)
                        {
                            Console.WriteLine($"Alan: {entry.Key}, Hata: {error.ErrorMessage}");
                        }
                    }
                    Console.WriteLine($"veri: {category.CategoryName}");
                    Console.WriteLine($"veri: {category.CategoryId}");
                    Console.WriteLine($"veri: {category.Products}");



                    Console.WriteLine("Model hatalı!");
                    return View(category);
                }

                _context.Categories.Add(category);
                _context.SaveChanges();
                Console.WriteLine($"Kategori eklendi: {category.CategoryName}");

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return View(category);
            }
        }

        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);

            Console.WriteLine($"Silinecek kategori ID: {category.CategoryName}");

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                Console.WriteLine($"Kategori silindi: {category.CategoryName}");
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı!");
            }
            return RedirectToAction("Index");
        }

        // UPDATE (GET)
        public IActionResult GetCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                return View("GetCategory", category);
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı!");
                return RedirectToAction("Index");
            }
        }

        // UPDATE (POST)
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            var existing = _context.Categories.Find(category.CategoryId);
            if (existing != null)
            {
                existing.CategoryName = category.CategoryName;
                _context.SaveChanges();
                Console.WriteLine($"Kategori güncellendi: {category.CategoryName}");
                System.Diagnostics.Debug.WriteLine("🐞 Debug çıktı testi çalıştı.");
            }
            return RedirectToAction("Index");
        }

    }
}

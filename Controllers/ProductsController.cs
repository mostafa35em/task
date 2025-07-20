using Microsoft.AspNetCore.Mvc;       // ضروري لـ Controller, IActionResult, HttpPost
using task_in_setion.Data;            // لتعريف AppDbContext (تأكد من المسار الصحيح حسب مشروعك)
using task_in_setion.Migrations;
using task_in_setion.Models;          // لتعريف موديل Empollyes (تأكد من المسار الصحيح)
public class ProductsController : Controller


{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    public IActionResult Edit(int id)
    {
        var pro = _context.Products.FirstOrDefault(e => e.id == id);
        if (pro == null) return NotFound();
        return View(pro);
    }

    [HttpPost]
    public IActionResult Edit(task_in_setion.Models.Products
 e)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Update(e);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(e);
    }

    public IActionResult Delete(int id)
    {
        var pro = _context.Products.Find(id);
        if (pro == null) return NotFound();

        _context.Products.Remove(pro);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult cards()
    {
        var products = _context.Products.ToList();
        return View(products);
    }
}

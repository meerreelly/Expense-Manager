using Expense_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expense_Manager.Controllers;

public class CategoryController : Controller
{
    private readonly DataBaseContext _context;
    
    public CategoryController(DataBaseContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        return View(await _context.Categories.ToListAsync());
    }
    
    public IActionResult Create() => View();
    
    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Api.Data;
using TaskManagement.Api.DTOs;
using TaskManagement.Api.Models;

namespace TaskManagement.Api.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await _context.Categories.ToListAsync();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound("Kategori bulunamadi.");
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryDto dto)
    {
        var category = new Category
        {
            Name = dto.Name
        };

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CategoryDto dto)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound("Kategori bulunamadi.");
        }

        category.Name = dto.Name;
        await _context.SaveChangesAsync();

        return Ok(category);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound("Kategori bulunamadi.");
        }

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Kategori silindi." });
    }
}
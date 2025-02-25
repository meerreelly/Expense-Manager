using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models;

public class Category
{
    public Guid CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Expense>? Expenses { get; set; }
}
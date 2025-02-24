using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Manager.Models;

public class Expense
{
    public Guid ExpenseId { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    
    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
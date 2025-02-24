namespace Expense_Manager.Models;

public class Category
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public List<Expense> Expenses { get; set; }
}
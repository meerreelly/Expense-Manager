using Microsoft.EntityFrameworkCore;

namespace Expense_Manager.Models;

public class DataBaseContext:DbContext
{
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Category> Categories => Set<Category>();
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

}
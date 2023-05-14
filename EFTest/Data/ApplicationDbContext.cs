using EFTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTest.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public DbSet<Employee> Employees { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>().HasData(
				new Employee { Id = 1, Name = "Zenon Martyniuk", Email = "oczyzielone@zenek.pl", Address = "Adamcka 12" },
				new Employee { Id = 2, Name = "Adam Nowak", Email = "mene@zenek.pl", Address = "Adamcka 14" });
		}
	}
}

using System.ComponentModel;

namespace WebApplicationMVC.Models
{
    public class Person
    {
        public int PersonId { get; set; }
		[DisplayName("Name:")]
		public string PersonName { get; set; } = default!;
		[DisplayName("Age:")]
		public int PersonAge { get; set; }
    }
}

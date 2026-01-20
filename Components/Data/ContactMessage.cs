using System.ComponentModel.DataAnnotations;

namespace dev_portfolio.Components.Data
{
    public class ContactMessage
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}

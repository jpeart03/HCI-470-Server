using System.ComponentModel.DataAnnotations;

namespace RecycleBlazorServer.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please use a valid email address")]
        public string Email { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Your message must be atleast 3 characters long")]
        public string Message { get; set; }
    }
}

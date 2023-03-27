using APIdotnet.Data;
using System.ComponentModel.DataAnnotations;

namespace APIdotnet.Models
{
    public class Newsletter
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [UniqueEmail]
        public string? Email { get; set; }
        [Required]
        public Boolean? Conditions { get; set; }
    }


    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object value, ValidationContext? validationContext)
        {
            var dbContext = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));
            var email = (string)value;

            var exists = dbContext.Newsletters.Any(u => u.Email == email);
            if (exists)
            {
                return new ValidationResult("Merci mais, vous êtes déjà inscrit dans le Newsletter !");
            }

            return ValidationResult.Success;
        }
    }
}

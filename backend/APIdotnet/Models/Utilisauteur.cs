using Microsoft.AspNetCore.Identity;

namespace APIdotnet.Models
{
    public class Utilisateur : IdentityUser<int>
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
    }
}
 
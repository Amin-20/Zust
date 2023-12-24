using Microsoft.AspNetCore.Identity;

namespace AspProjectZust.WebUI.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        public virtual User User { get; set; }
       
    }
}
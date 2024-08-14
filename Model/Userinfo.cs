using System.ComponentModel.DataAnnotations;

namespace Coreweb_api_token.Model
{
    public class Userinfo
    {
        [Key]
        public int UserId { get; set; }
        public string DisplayName { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public DateTime? CreatedDate { get; set; }
    }
}

using Coreweb_api_token.Model;
using Microsoft.EntityFrameworkCore;

namespace Coreweb_api.Models
{
    public class StudDataContext: DbContext
    {
        public StudDataContext(DbContextOptions<StudDataContext> options) : base(options) { }
        
       
        public DbSet<Student> Students
        {
            get;
            set;
        }
        public DbSet<Userinfo> userinfos
        {
            get;
            set;
        }
    }
   
}

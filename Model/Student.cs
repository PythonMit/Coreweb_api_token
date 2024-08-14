using System.ComponentModel.DataAnnotations;

namespace Coreweb_api_token.Model
{
    public class Student
    {
       
            [Key]
            public int Stuid { get; set; }
            public string Sfname { get; set; } = String.Empty;
            public string slname { get; set; } = String.Empty;

            public int Sage { get; set; }

       
    }
}

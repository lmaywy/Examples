using System.ComponentModel.DataAnnotations;

namespace Examples.EntityFramework.CodeFirstDemoForNewDB
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}

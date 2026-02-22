using System.ComponentModel.DataAnnotations;

namespace pronto_back.Domain.Entities
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string IsActive { get; set; }
        


    }
}

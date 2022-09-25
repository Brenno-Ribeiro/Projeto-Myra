using System.ComponentModel.DataAnnotations;

namespace StationAPI.Models
{
    public class Auth
    {
        [Key]
        public int Id { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
    }
}

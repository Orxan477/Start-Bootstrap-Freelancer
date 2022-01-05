using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBootstrap_Project.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Information { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}

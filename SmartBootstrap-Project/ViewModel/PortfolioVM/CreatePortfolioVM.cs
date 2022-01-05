using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SmartBootstrap_Project.ViewModel.PortfolioVM
{
    public class CreatePortfolioVM
    {
        public int Id { get; set; }
        [Required][MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        [Required][MaxLength(255)]
        public string Information { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using MultiShop.Models;

namespace WebApplication1.Areas.Admin.Models;

public class Sliders : BaseEntity
{
    [MaxLength(32), Required]
    public string Title { get; set; } 
    [MaxLength(64)]
    public string Subtitle { get; set; }
    [Required]
    public string ImageUrl { get; set; }

}

using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class ProductRequestDTO
    {
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public float? Price { get; set; }

        public sbyte Active { get; set; }
    }
}

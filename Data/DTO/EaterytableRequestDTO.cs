using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class EaterytableRequestDTO
    {
        public int? Id { get; set; }
        [Required]
        public int? Number { get; set; }
        [Required]
        public int? Capacity { get; set; }
        public sbyte Active { get; set; }
    }
}

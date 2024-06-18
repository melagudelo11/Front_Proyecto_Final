using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class EaterytableRqCreateDTO
    {
        [Required]
        public int? Number { get; set; }
        [Required]
        public int? Capacity { get; set; }
        public sbyte Active { get; set; } = 1;
    }
}

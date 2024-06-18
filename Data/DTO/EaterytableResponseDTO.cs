using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class EaterytableResponseDTO
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public int? Capacity { get; set; }
        public sbyte Active { get; set; }
    }
}

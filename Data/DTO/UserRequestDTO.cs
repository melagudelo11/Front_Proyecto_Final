using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class UserRequestDTO
    {
        public int Id { get; set; }
        [Required]
        public string? RoleCode { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Identification { get; set; }
        [Required]
        public DateTime? Birthday { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Email { get; set; }

        public sbyte Active { get; set; }
    }
}

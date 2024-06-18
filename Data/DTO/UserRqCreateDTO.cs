using System.ComponentModel.DataAnnotations;

namespace VirtualWaiter.Application.Data.DTO
{
    public class UserRqCreateDTO
    {
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
        public sbyte Active { get; set; } = 1;
    }
}

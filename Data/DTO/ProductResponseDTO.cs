namespace VirtualWaiter.Application.Data.DTO
{
    public class ProductResponseDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public float? Price { get; set; }

        public sbyte Active { get; set; }
    }
}

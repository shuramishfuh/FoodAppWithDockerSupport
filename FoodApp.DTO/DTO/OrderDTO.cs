

using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class OrderDTO : IOrderDTO
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int PaymentId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}

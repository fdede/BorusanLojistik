using Borusan.Core.Models;

namespace Borusan.Core.DTOs
{
    public class ResponseOrderWithStatusDto
    {
        public string CustomerOrderNo { get; set; }
        public OrderStatusDto OrderStatusDto { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

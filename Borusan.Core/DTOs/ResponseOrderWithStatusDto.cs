using Borusan.Core.Models;

namespace Borusan.Core.DTOs
{
    public class ResponseOrderWithStatusDto
    {
        public string CustomerOrderNo { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int Amount { get; set; }
        public AmountTypeDto AmountTypeDto { get; set; }
        public decimal Weight { get; set; }
        public WeightUnitDto WeightUnitDto { get; set; }
        public MaterialDto MaterialDto { get; set; }
        public string Note { get; set; }
        public OrderStatusDto OrderStatusDto { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

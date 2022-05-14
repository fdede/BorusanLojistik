﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Core.DTOs
{
    public class OrderDto : BaseDto
    {
        public string CustomerOrderNo { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int Amount { get; set; }
        public long AmountTypeId { get; set; }
        public decimal Weight { get; set; }
        public long WeightUnitId { get; set; }
        public long MaterialId { get; set; }
        public string Note { get; set; }
        public long OrderStatusId { get; set; }
    }
}

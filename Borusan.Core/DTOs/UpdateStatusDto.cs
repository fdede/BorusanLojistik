using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Core.DTOs
{
    public class UpdateStatusDto
    {
        public string CustomerOrderNo { get; set; }
        public long OrderStatusId { get; set; }
    }
}

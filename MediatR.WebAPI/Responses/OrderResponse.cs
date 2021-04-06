using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Responses
{
    public class OrderResponse
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
    }
}

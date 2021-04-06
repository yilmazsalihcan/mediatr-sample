using MediatR.WebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public int OrderId { get; set; }
        public GetOrderByIdQuery(int orderId)
        {
            OrderId = orderId;
        }
    }
}

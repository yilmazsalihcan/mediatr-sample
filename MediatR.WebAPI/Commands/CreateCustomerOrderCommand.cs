using MediatR.WebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }

    }
}

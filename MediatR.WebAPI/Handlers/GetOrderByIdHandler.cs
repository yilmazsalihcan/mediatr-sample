using MediatR.WebAPI.Queries;
using MediatR.WebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderResponse>
    {
        private List<OrderResponse> _orderResponses;
        public GetOrderByIdHandler()
        {
            _orderResponses = new List<OrderResponse>
            {
                new OrderResponse{OrderId = 1,OrderName = "Pc"},
                new OrderResponse{OrderId = 2,OrderName = "Mouse"}
            };
        }
        public async Task<OrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var getOrderById = _orderResponses.FirstOrDefault(x => x.OrderId == request.OrderId);
            return await Task.FromResult(getOrderById);
        }
    }
}

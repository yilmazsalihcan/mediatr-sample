using MediatR.WebAPI.Queries;
using MediatR.WebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderResponse>>
    {
        public GetAllOrdersHandler()
        {

        }
        public async Task<List<OrderResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            List<OrderResponse> orderResponses = new List<OrderResponse> {

                new OrderResponse
                {
                    OrderId = 1,
                    OrderName = "Pc"
                }

            };
            return await Task.FromResult(orderResponses);

        }
    }
}

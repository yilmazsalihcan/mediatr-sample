using MediatR.WebAPI.Commands;
using MediatR.WebAPI.Responses;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Handlers
{
    public class CreateCustomerOrderHandler : IRequestHandler<CreateCustomerOrderCommand, OrderResponse>
    {
        private readonly ILogger<CreateCustomerOrderHandler> _logger;
        public CreateCustomerOrderHandler(ILogger<CreateCustomerOrderHandler> logger)
        {
            _logger = logger;
        }

        public async Task<OrderResponse> Handle(CreateCustomerOrderCommand request, CancellationToken cancellationToken)
        {
            var orderResponse = new OrderResponse
            {
                OrderId = request.OrderId,
                OrderName = request.OrderName
            };
            _logger.LogInformation("Created order for customer", request);
            return await Task.FromResult(orderResponse);
        }
    }
}

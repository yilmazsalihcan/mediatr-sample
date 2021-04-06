using MediatR.WebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.WebAPI.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderResponse>>
    {

    }
}

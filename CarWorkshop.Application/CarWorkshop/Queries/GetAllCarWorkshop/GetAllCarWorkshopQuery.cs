﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetAllCarWorkshop
{
    public class GetAllCarWorkshopQuery : IRequest<IEnumerable<CarWorkshopDto>>
    {
    }
}

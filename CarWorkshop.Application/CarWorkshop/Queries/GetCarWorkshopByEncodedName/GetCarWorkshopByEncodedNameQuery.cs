﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetCarWorkshopByEncodedName
{
    public class GetCarWorkshopByEncodedNameQuery : IRequest<CarWorkshopDto> 
    {
        public string Encodedname { get; set; }
        public GetCarWorkshopByEncodedNameQuery(string encodedName)
        {
             Encodedname = encodedName;
        }
    }
}

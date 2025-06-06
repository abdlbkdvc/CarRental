﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Features.Mediator.Results.CarResults
{
    public class GetCarByIdQueryResult
    {
        public int CarID { get; set; }
        public string PhotoUrl { get; set; }
        public string CarName { get; set; }
        public DateTime CarReleaseDate { get; set; }
        public string Transmission { get; set; }
        public string Km { get; set; }
        public decimal Price { get; set; }
    }
}

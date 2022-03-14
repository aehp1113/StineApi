using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.DTOS
{
    public class RequestInventoryDTO
    {
        public List<Inventory> Inventory { get; set; }
        public List<Requests> Requests { get; set; }
    }
}

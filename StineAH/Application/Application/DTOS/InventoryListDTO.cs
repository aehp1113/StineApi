using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Application.DTOS
{
    public class InventoryListDTO
    {
        public List<Inventory> Inventory { get; set; }
    }
}

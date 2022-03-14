using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOS;
using Domain.Entities;

namespace Application.Services
{
    public interface IRequestInventoryService
    {
        Task<InventoryListDTO> GetInventory();
        Task<List<RequestInventoryListDTO>> GetRequestInventory();
    }
}

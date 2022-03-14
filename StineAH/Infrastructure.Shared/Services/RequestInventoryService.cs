using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOS;
using Application.Services;
using Infrastructure.Shared.Helpers;
using Newtonsoft.Json;

namespace Infrastructure.Shared.Services
{
    public class RequestInventoryService : IRequestInventoryService
    {
        public Task<InventoryListDTO> GetInventory()
        {
            var json = GetInfoHelper.GetInfo();
            var inventory = JsonConvert.DeserializeObject<InventoryListDTO>(json);
            return Task.FromResult(inventory);
        }

        public Task<List<RequestInventoryListDTO>> GetRequestInventory()
        {
            
            var json = GetInfoHelper.GetInfo();
            var requestInventory = JsonConvert.DeserializeObject<RequestInventoryDTO>(json);
            var request = requestInventory.Requests.Join(requestInventory.Inventory,
                                                           r => r.InventoryId,
                                                           i => i.Id,
                                                           (r,i) => new { Request = r , Inventory = i}

                                                         )
                                                         .Select( req => new RequestInventoryListDTO
                                                                             {
                                                                                IdRequest = req.Request.Id,
                                                                                RequestedKernelsRequest = req.Request.RequestedKernels,
                                                                                NameInventory = req.Inventory.Name,
                                                                                KernelsInventory = req.Inventory.Kernels,
                                                                                InventoryFlag = req.Inventory.Kernels < req.Request.RequestedKernels ? true : false
                                                                             }
                                                                    
                                                                ).ToList();

            return Task.FromResult(request);
        }
    }
}

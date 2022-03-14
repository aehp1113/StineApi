using System;
namespace Application.DTOS
{
    public class RequestInventoryListDTO
    {
        public string NameInventory { get; set; }
        public int KernelsInventory { get; set; }
        public int IdRequest { get; set; }
        public int RequestedKernelsRequest { get; set; }
        public bool InventoryFlag { get; set; }
    }
}

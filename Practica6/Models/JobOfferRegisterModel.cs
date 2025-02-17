using Microsoft.Identity.Client;

namespace Practica6.Models
{
    public class JobOfferRegisterModel
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
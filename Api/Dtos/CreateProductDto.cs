using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos
{
    public class CreateProductDto
    {
        
        public string Name {get;set;}
        public string Description {get;set;}
        public decimal Price {get;set;}
        public int StockQuantity {get;set;}
        public string Category {get;set;}

    }
}
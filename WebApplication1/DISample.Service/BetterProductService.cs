using DISample.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Service
{
    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {ID = 1, Name = "San Pham 1 " },
                new ProductViewModel {ID = 2, Name = "San Pham 2 " },
                new ProductViewModel {ID = 3, Name = "San Pham 3 " },
                new ProductViewModel {ID = 4, Name = "San Pham 4 " },
                new ProductViewModel {ID = 5, Name = "San Pham 5 " },
            };
        }
    }
}

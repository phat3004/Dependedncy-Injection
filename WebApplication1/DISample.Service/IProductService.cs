﻿using DISample.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Service
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();

    }
}

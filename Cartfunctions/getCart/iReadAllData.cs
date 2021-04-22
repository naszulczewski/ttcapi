using System;
using System.Collections.Generic;
using API.Cartfunctions;

namespace API.Cartfunctions.getCart
{
    public interface iReadAllData
    {
        public List<cart> GetAllItems();
    }
}

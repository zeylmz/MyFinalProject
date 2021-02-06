using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal = Data Access Library
    public interface IProductDal : IEntitiyRepository<Product>
    {        
    }
}
//Code Refactoring -- Kod iyileştirme
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AStore.Data;

namespace AStore.Core.Abstract
{
    public interface IAstoreRepository
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<Categories> Categories { get; }
    }
}

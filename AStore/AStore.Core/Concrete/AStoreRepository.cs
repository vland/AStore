using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AStore.Core.Abstract;
using AStore.Data;

namespace AStore.Core.Concrete
{
    public class AStoreRepository : IAstoreRepository
    {
        private AStoreEntities _db = new AStoreEntities();

        public IEnumerable<Product> Products {
            get { return _db.Products; }
        } 
    }
}

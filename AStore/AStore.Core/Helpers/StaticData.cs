using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AStore.Core.Concrete;
using AStore.Data;

namespace AStore.Core.Helpers
{
    public static class StaticData
    {
        public const string SessionCartKey = "Cart";

        private static List<Categories> _categories;
        public static List<Categories> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var repository = new AStoreRepository();
                    _categories = repository.Categories.ToList();
                }
                return _categories;
            }
        } 
    }
}

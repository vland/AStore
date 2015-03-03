using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AStore.Core.Concrete;

namespace AStore.Core.Helpers
{
    public static class StaticData
    {
        private static List<string> _categories; 
        public static List<string> Categories {
            get
            {
                if (_categories == null)
                {
                    var repository = new AStoreRepository();
                    _categories = repository.Categories.Select(x => x.Name).ToList();
                }
                return _categories;
            }
        } 
    }
}

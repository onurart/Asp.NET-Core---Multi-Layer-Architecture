using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Model
{
  public  class Category
    {
        public Category()
        {
            Product = new Collection<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

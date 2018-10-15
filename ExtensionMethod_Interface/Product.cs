using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtensionMethod_Interface{
    public class Product{
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price{ get; set; }

    }

    public class Order : IEnumerable<Product>
    {
        public IEnumerator<Product> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
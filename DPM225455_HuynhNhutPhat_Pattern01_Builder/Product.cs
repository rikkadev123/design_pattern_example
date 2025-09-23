using System;
using System.Collections.Generic;

namespace DPM225455_HuynhNhutPhat_Pattern01_Builder
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    class Product
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}

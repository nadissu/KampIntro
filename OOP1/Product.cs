using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        //referans anahtarları kod okunurluğu için P.k  nin altına yazılır
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnıtPrice { get; set; }
        public int UnitsInStock { get; set; }   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLayer
{
    public class Products : IProducts
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public bool Status { get; set; }
        public string Manufacturer { get; set; }
        public string FrenchDesc { get; set; }
        public string EnglishDesc { get; set; }
        public string ImageFileName { get; set; }
        public string DocumentFileName { get; set; }
        public int InventoryQuantity { get; set; }
        public double Price { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool PromotionFlag { get; set; }
        public bool Taxable { get; set; }
    }
}

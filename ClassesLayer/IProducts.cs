using System;

namespace ClassesLayer
{
    public interface IProducts
    {
        string DocumentFileName { get; set; }
        string EnglishDesc { get; set; }
        string FrenchDesc { get; set; }
        Guid Id { get; set; }
        string ImageFileName { get; set; }
        int InventoryQuantity { get; set; }
        DateTime LastUpdateDate { get; set; }
        string Manufacturer { get; set; }
        double Price { get; set; }
        string ProductCode { get; set; }
        bool PromotionFlag { get; set; }
        bool Status { get; set; }
        bool Taxable { get; set; }
    }
}
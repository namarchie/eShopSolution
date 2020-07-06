using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageViewModel
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string ImagePath { get; set; }
        public string Caption { set; get; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { set; get; }
        public long FileSize { get; set; }
    }
}

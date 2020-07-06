using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { set; get; }

    }
}

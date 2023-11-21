using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehaksBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }//Display all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; } //install package 'Microsoft.AspNetCore.Mvc.ViewFeatures
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}

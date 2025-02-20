using System;
using System.ComponentModel.DataAnnotations;
namespace IndyBooks.ViewModels
{
    public class SearchVM
    {
        [Display(Name = "Title to Find: ")]
        public String Title { get; set; }

        //Done: Add properties and Display annotation needed for searching
        [Display(Name = "Low Price: ")]
        public decimal? LowPrice { get; set; }

        [Display(Name = "High Price: ")]
		public decimal? HighPrice { get; set; }

        [Display(Name = "Author Last Name: ")]
        public String AuthorLastName { get; set; }

        [Display(Name = "Half-Price Sale: ")]
        public Boolean HalfPriceSale { get; set; }

    }
}

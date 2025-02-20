using System;
namespace IndyBooks.ViewModels
{
	public class SearchResultsVM
	{
		public IEnumerable<IndyBooks.Models.Book> FoundBooks { get; set; }
		public Boolean HalfPriceSale { get; set; }

    }
}


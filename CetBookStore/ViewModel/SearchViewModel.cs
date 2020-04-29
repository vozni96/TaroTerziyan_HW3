using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewModel
{
    public class SearchViewModel
    {
        [Display(Name = "Aramak için buraya yazın ")]
        public string SearchText { get; set; }
        [Display(Name = "Açıklamalarda aramak için buraya tıklayın")]
        public bool SearchInDescription { get; set; }
        [Display(Name = "Kategoriler")]
        public int? CategoryId { get; set; }
        [Display(Name = "En düşük fiyatı girin ")]
        public decimal? MinPrice { get; set; }
        [Display(Name = "En yüksek fiyatı girin")]
        public decimal? MaxPrice { get; set; }

        public List<Models.Book> Results { get; set; }
    }
}

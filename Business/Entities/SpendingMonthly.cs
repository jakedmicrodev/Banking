using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class SpendingMonthly
    {
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Month")]
        public int MonthId { get; set; }

        [Display(Name = "Year")]
        public int YearId { get; set; }

        [Display(Name = "Month")]
        public List<SelectListItem> Months { get; set; }

        [Display(Name = "Year")]
        public List<SelectListItem> Years { get; set; }

        [Display(Name = "Category")]
        public List<SelectListItem> Categories { get; set; }

    }
}

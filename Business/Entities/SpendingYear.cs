using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class SpendingYear
    {
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public List<SelectListItem> Categories { get; set; }

        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }

        [Display(Name = "Sub Category")]
        public List<SelectListItem> SubCategories { get; set; }

        public int Id { get; set; }

        [Display(Name = "Year")]
        public string Name { get; set; }

        public List<SelectListItem> Years { get; set; }

    }
}

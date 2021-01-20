using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class SpendingYear
    {
        public int Id { get; set; }

        [Display(Name = "Year")]
        public string Name { get; set; }

        public List<SelectListItem> Years { get; set; }
    }
}

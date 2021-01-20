using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class SpendingSearch
    {
        [Display(Name = "Account")]
        public int AccountId { get; set; }
        public List<SelectListItem> Accounts { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public List<SelectListItem> Categories { get; set; }

        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }
        public List<SelectListItem> SubCategories { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Payee")]
        public string Payee { get; set; }

        [Display(Name = "Start Amount")]
        public Decimal StartAmount { get; set; }

        [Display(Name = "End Amount")]
        public Decimal EndAmount { get; set; }

    }
}

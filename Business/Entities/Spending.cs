using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Spending
    {

        public int Id { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }

        [Display(Name = "Sub Category")]
        public string Subcategory { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Payee")]
        public string Payee { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Account")]
        public int AccountId { get; set; }

        [Display(Name = "Account")]
        public string Account { get; set; }

        [Display(Name = "Account Name")]
        public string AccountDesc { get; set; }

        [Display(Name = "Payment Amount")]
        public decimal Amount { get; set; }

    }
}

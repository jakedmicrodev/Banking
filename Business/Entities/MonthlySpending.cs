using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class MonthlySpending
    {
        public string FieldName { get; set; }

        [Display(Name = "1")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal One { get; set; }

        [Display(Name = "2")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Two { get; set; }

        [Display(Name = "3")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Three { get; set; }

        [Display(Name = "4")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Four { get; set; }

        [Display(Name = "5")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Five { get; set; }

        [Display(Name = "6")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Six { get; set; }

        [Display(Name = "7")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Seven { get; set; }

        [Display(Name = "8")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Eight { get; set; }

        [Display(Name = "9")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Nine { get; set; }

        [Display(Name = "10")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Ten { get; set; }

        [Display(Name = "11")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Eleven { get; set; }

        [Display(Name = "12")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Twelve { get; set; }

        [Display(Name = "13")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Thirteen { get; set; }

        [Display(Name = "14")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Fourteen { get; set; }

        [Display(Name = "15")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Fifteen { get; set; }

        [Display(Name = "16")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Sixteen { get; set; }

        [Display(Name = "17")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Seventeen { get; set; }

        [Display(Name = "18")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Eighteen { get; set; }

        [Display(Name = "19")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Nineteen { get; set; }

        [Display(Name = "20")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Twenty { get; set; }

        [Display(Name = "21")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyOne { get; set; }
        
        [Display(Name = "22")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyTwo { get; set; }

        [Display(Name = "23")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyThree { get; set; }

        [Display(Name = "24")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyFour { get; set; }

        [Display(Name = "25")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyFive { get; set; }

        [Display(Name = "26")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentySix { get; set; }

        [Display(Name = "27")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentySeven { get; set; }

        [Display(Name = "28")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyEight { get; set; }

        [Display(Name = "29")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TwentyNine { get; set; }

        [Display(Name = "30")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Thirty { get; set; }

        [Display(Name = "31")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ThirtyOne { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Total { get; set; }
    }
}

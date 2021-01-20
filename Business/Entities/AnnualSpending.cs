using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class AnnualSpending
    {
        public string FieldName { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal January { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal February { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal March { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal April { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal May { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal June { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal July { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal August { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal September { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal October { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal November { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal December { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Total { get; set; }

    }
}

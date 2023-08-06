using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Dicetek.DomainModels
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "English Name is required")]
        [MaxLength(50, ErrorMessage = "Maximum 50 characters only")]
        public string firstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Email ID")]
        [Required(ErrorMessage = "Email ID is required.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email ID.")]
        public string emailId { get; set; }

        [DisplayName("Mobile No")]
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^(?:\00971|971|0|)(?:50|52|54|55|56|58)\d{7}$", ErrorMessage = "Provided mobile number is in incorrect format.")]
        //[ValidateMobile(ErrorMessage = "Provided mobile number is in incorrect format.")]
        public long mobileNo { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Credit Card No")]
        [Required(ErrorMessage = "Credit Card Number is required.")]
        [RegularExpression(@"^[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$", ErrorMessage = "Invalid Credit Card Number.")]
        public string creditCard { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Credit Card Expiry Date")]
        [Required(ErrorMessage = "Please Enter Credit Card Expiry Date.")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/?([0-9]{2})$", ErrorMessage = "Provided credit card expiry date is in incorrect format.")]
        public string ccExpiryDate { get; set; }

        [DisplayName("CCV No")]
        [Required(ErrorMessage = "CCV Number is required.")]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Invalid CCV Number.")]
        public int ccv { get; set; }


    }

    public class ValidateMobile : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var NumberRegex = "^[0-9]*$";
                var MobileNoRegex = @"^(?:\00971|971|0|)(?:50|52|54|55|56|58)\d{7}$";

                var IsDigit = Regex.IsMatch(value.ToString(), NumberRegex);
                var IsValidMobile = Regex.IsMatch(value.ToString(), MobileNoRegex);
                if (IsDigit && IsValidMobile)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}

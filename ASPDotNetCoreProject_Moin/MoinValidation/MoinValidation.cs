using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using ASPDotNetCoreProject_Moin.MoinValidation;

namespace ASPDotNetCoreProject_Moin.MoinValidation 
{
    public class MoinValidationAttribute:ValidationAttribute 
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("Md"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Must be Use Md !!!");
        }
    }
}

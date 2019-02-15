using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MembershipTypeID == 0 || customer.MembershipTypeID == 1)
                return ValidationResult.Success;

            if(customer.DateOfBirth == null)
                return new ValidationResult("Birthdate is required!");

            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;

            if (age >= 18)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Person should be 18 years old for membership!");
            }
        }
    }
    public class CannotBeZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock == 0)
            {
                return new ValidationResult("Stock cannot be zero!");
            }
            return ValidationResult.Success;
        }
    }
}
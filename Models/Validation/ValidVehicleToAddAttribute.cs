using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RowVehiclePoolMVC.Context;

namespace RowVehiclePoolMVC.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class ValidVehicleToAddAttribute : ValidationAttribute
    {
        private const string DefaultErrorMessage = "Date selected {0} must be on or greater than the start date";
        //private string _comparisonProperty;
        //public ValidVehicleToAddAttribute(string comparisonProperty)
        //{
        //    _comparisonProperty = comparisonProperty;
        //}

        public override bool IsValid(object value)
        {
            bool result = true;

            ErrorMessage = ErrorMessageString;
            var currentValue = (string)value;
            using ( var appContext = new RvpAppContext())
            {
                var vehicle = appContext.Vehicle.Where(c => c.TagNumber == currentValue).FirstOrDefault();
                if (vehicle == null || vehicle.Status.ToLower() != "i")
                {
                    result = false;
                }
            }

            return result;
        }
    }
}

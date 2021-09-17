using System;

namespace Agriturismo.Models
{
    internal class StringLengthRangeAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
        public int Minimum { get; set; }
        public int MaximumLength { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Palindrome.Web.Models
{
    public class IsPalindromeInputModel
    {
        [Range(0, int.MaxValue)]
        public int Number { get; set; }
    }
}
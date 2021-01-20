using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Enums
{
    public enum LanguageEnum
    {
        [Display(Name ="Hindi Language")]
        Hindi = 10,
        [Display(Name = "English Language")]
        English = 11,
        [Display(Name = "German Language")]
        German = 12,
        [Display(Name = "Chinese Language")]
        Chinese = 13,
        [Display(Name = "Urdu Language")]
        Urdu = 14
    }
}

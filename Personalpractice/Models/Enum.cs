using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Personalpractice.Models
{
    public class Enum
    {
        public enum SchoolTypeEnum
        {
            [Display(Name = "公立学校")]
            PUB = 3,
            [Display(Name = "私立学校")]
            PRI
        }
    }
}

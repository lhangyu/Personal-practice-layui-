using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;

namespace Personalpractice.Models
{
    public class MyUser : FrameworkUserBase
    {
        [Display(Name = "附加信息1")]
        public string Extra1 { get; set; }
        [Display(Name = "附加信息2")]
        public string Extra2 { get; set; }
    }
}

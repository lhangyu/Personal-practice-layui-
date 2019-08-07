using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Personalpractice.Models;
using static Personalpractice.Models.Enum;

namespace Personalpractice.ViewModels.SchoolVMs
{
    public partial class SchoolBatchVM : BaseBatchVM<School, School_BatchEdit>
    {
        public SchoolBatchVM()
        {
            ListVM = new SchoolListVM();
            LinkedVM = new School_BatchEdit();
        }

        protected override bool CheckIfCanDelete(Guid id, out string errorMessage)
        {
            errorMessage = null;
			return true;
        }
    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class School_BatchEdit : BaseVM
    {
        [Display(Name = "学校类型")]
        public SchoolTypeEnum? SchoolType { get; set; }

        protected override void InitVM()
        {
        }

    }

}

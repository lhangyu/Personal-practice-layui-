using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Personalpractice.Models;
using System.IO;
using System.Text;

namespace Personalpractice.ViewModels.SchoolVMs
{
    public partial class SchoolVM : BaseCRUDVM<School>
    {

        public SchoolVM()
        {
        }

        protected override void InitVM()
        {
        }

        public override void DoAdd()
        {
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }

        public void Output(Guid id)
        {
            string nowdate = DateTime.Now.ToString();
            nowdate = nowdate.Replace("/", "-");
            nowdate = nowdate.Replace(":", "-");
            string path = @"E:\lhy\"+Entity.SchoolName+ nowdate + ".txt";
            using (FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                string s1 = "学校名称：" + Entity.SchoolName;
                string s2 = "\r\n学校类型：" + Entity.SchoolType;
                string s3 = "\r\n学校编码：" + Entity.SchoolCode;
                string s4 = "\r\n备注：" + Entity.Remark;
                string write = s1 + s2 + s3 + s4;
                byte[] str = Encoding.Default.GetBytes(write);
                fsWrite.Write(str, 0, str.Length);
            }
        }
    }
}

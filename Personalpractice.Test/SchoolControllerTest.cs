using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using Personalpractice.Controllers;
using Personalpractice.ViewModels.SchoolVMs;
using Personalpractice.Models;
using Personalpractice;

namespace Personalpractice.Test
{
    [TestClass]
    public class SchoolControllerTest
    {
        private SchoolController _controller;
        private string _seed;

        public SchoolControllerTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateController<SchoolController>(_seed, "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Index();
            Assert.IsInstanceOfType(rv.Model, typeof(IBasePagedListVM<TopBasePoco, BaseSearcher>));
        }

        [TestMethod]
        public void CreateTest()
        {
            PartialViewResult rv = (PartialViewResult)_controller.Create();
            Assert.IsInstanceOfType(rv.Model, typeof(SchoolVM));

            SchoolVM vm = rv.Model as SchoolVM;
            School v = new School();
			
            v.SchoolCode = "gx3";
            v.SchoolName = "RH2ARKUT";
            vm.Entity = v;
            _controller.Create(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<School>().FirstOrDefault();
				
                Assert.AreEqual(data.SchoolCode, "gx3");
                Assert.AreEqual(data.SchoolName, "RH2ARKUT");
                Assert.AreEqual(data.CreateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.CreateTime.Value).Seconds < 10);
            }

        }

        [TestMethod]
        public void EditTest()
        {
            School v = new School();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.SchoolCode = "gx3";
                v.SchoolName = "RH2ARKUT";
                context.Set<School>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Edit(v.ID);
            Assert.IsInstanceOfType(rv.Model, typeof(SchoolVM));

            SchoolVM vm = rv.Model as SchoolVM;
            v = new School();
            v.ID = vm.Entity.ID;
       		
            v.SchoolCode = "EyN";
            v.SchoolName = "nma";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.SchoolCode", "");
            vm.FC.Add("Entity.SchoolName", "");
            _controller.Edit(vm);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<School>().FirstOrDefault();
 				
                Assert.AreEqual(data.SchoolCode, "EyN");
                Assert.AreEqual(data.SchoolName, "nma");
                Assert.AreEqual(data.UpdateBy, "user");
                Assert.IsTrue(DateTime.Now.Subtract(data.UpdateTime.Value).Seconds < 10);
            }

        }


        [TestMethod]
        public void DeleteTest()
        {
            School v = new School();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.SchoolCode = "gx3";
                v.SchoolName = "RH2ARKUT";
                context.Set<School>().Add(v);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.Delete(v.ID);
            Assert.IsInstanceOfType(rv.Model, typeof(SchoolVM));

            SchoolVM vm = rv.Model as SchoolVM;
            v = new School();
            v.ID = vm.Entity.ID;
            vm.Entity = v;
            _controller.Delete(v.ID,null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<School>().Count(), 0);
            }

        }


        [TestMethod]
        public void DetailsTest()
        {
            School v = new School();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v.SchoolCode = "gx3";
                v.SchoolName = "RH2ARKUT";
                context.Set<School>().Add(v);
                context.SaveChanges();
            }
            PartialViewResult rv = (PartialViewResult)_controller.Details(v.ID);
            Assert.IsInstanceOfType(rv.Model, typeof(IBaseCRUDVM<TopBasePoco>));
            Assert.AreEqual(v.ID, (rv.Model as IBaseCRUDVM<TopBasePoco>).Entity.ID);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            School v1 = new School();
            School v2 = new School();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.SchoolCode = "gx3";
                v1.SchoolName = "RH2ARKUT";
                v2.SchoolCode = "EyN";
                v2.SchoolName = "nma";
                context.Set<School>().Add(v1);
                context.Set<School>().Add(v2);
                context.SaveChanges();
            }

            PartialViewResult rv = (PartialViewResult)_controller.BatchDelete(new Guid[] { v1.ID, v2.ID });
            Assert.IsInstanceOfType(rv.Model, typeof(SchoolBatchVM));

            SchoolBatchVM vm = rv.Model as SchoolBatchVM;
            vm.Ids = new Guid[] { v1.ID, v2.ID };
            _controller.DoBatchDelete(vm, null);

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                Assert.AreEqual(context.Set<School>().Count(), 0);
            }
        }


    }
}

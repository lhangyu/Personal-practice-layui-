using Microsoft.EntityFrameworkCore;
using Personalpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;

namespace Personalpractice
{
    public class DataContext : FrameworkContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<MyUser> MyUsers { get; set; }
        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }

    }
}

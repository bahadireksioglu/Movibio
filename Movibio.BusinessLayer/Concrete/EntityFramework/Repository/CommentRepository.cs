﻿using Microsoft.EntityFrameworkCore;
using Movibio.BusinessLayer.Abstract;
using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.Concrete.EntityFramework.Repository
{
    public class CommentRepository : EntityFrameworkRepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context) { }
    }
}

﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFlamework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesdal
    {
    }
}

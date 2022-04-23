﻿using DevFramework.Core.Entities;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        IQueryable<T> _entities;

        public IQueryable<T> Table => this.Entities;

        protected virtual IQueryable<T> Entities { get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); } }
    }
}

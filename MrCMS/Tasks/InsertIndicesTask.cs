﻿using MrCMS.Entities;
using MrCMS.Indexing.Management;
using NHibernate;

namespace MrCMS.Tasks
{
    internal class InsertIndicesTask<T> : IndexManagementTask<T> where T : SiteEntity
    {
        public InsertIndicesTask(ISession session) : base(session)
        {
        }

        protected override void ExecuteLogic(IIndexManagerBase manager, T entity)
        {
            manager.Insert(entity);
        }
    }
}
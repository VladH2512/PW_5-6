using MySql.Data.MySqlClient;
using PW_5_6.Database;
using PW_5_6.MyEntity;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace PW_5_6.Database
{
    public abstract class EntityDAO : Entity
    {
        public abstract void Add();
        public abstract void Remove();
        public abstract void Change();
        public abstract void Find();
        protected abstract void Update<T>(string operation, T entity, int Id);
        public abstract void GetList();
       
    }

}

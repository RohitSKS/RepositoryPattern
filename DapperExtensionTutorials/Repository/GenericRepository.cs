using DapperExtensionTutorials.Dapper_Implementation;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace DapperExtensionTutorials.Repository
{
    public class GenericRepository<T> :IDisposable, DapperExtensionTutorials.IRepository.IGenericRepository<T> where T:class
    {
        //internal Table<T> DataTable;
        //public GenericRepository(DataContext DT)
        //{
        //    DataTable = DT.GetTable<T>();
        //}

        public IEnumerable<T> All()
        {
            //SampleEmployeeDataContext obj = new SampleEmployeeDataContext();
            //DataContext dt1 = new DataContext(obj.Connection.ConnectionString);
            //return dt1.GetTable<T>();
            return DapperConnection<T>.GetAll();
        }

        //public System.Threading.Tasks.Task<IEnumerable<T>> AllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetData(string qry, object parameters)
        //{
        //    throw new NotImplementedException();
        //}

        //public T Find(object pksFields)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Add(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Add(IEnumerable<T> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(object key)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Update(T entity, object pks)
        //{
        //    throw new NotImplementedException();
        //}

        //public int InstertOrUpdate(T entity, object pks)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
using DesafioAeC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace DesafioAeC.Data
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected IDbConnection DbConnection { get; private set; }


        public RepositoryBase(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;

        }

        public async Task<bool> CreateAsync(TEntity entity)
        {

            try
            {
                DbConnection.Open();

                var insert = DbConnection.Insert<TEntity>(entity);
                return await Task.FromResult(Convert.ToBoolean(insert));                

            }
            catch (Exception ex)
            {
                return false;
            }
            finally { DbConnection.Close(); }
        }
    }
}

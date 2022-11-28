using _2.OCP;
using System;
using System.Data.SqlClient;

namespace _5.DIP
{
    public class ProdutoRepositoryViolacao
    {
        private SqlConnection _connection { get; set; }

        public ProdutoRepositoryViolacao(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public Produto GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
using _2.OCP;
using System;
using System.Data;

namespace _5.DIP
{
    public class ProdutoRepository
    {
        private IDbConnection _connection { get; set; }

        public ProdutoRepository(IDbConnection connection)
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
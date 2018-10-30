using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoCRUD._01_Modelo
{
    class ProdutosModelo
    {
        #region CRUD
        public bool Insert(Produto produto)
        {
            return true;
        }
        public bool Update(Produto produto)
        {
            return true;
        }
        public List<Produto> Select()
        {
            return null;
        }
        public bool Delete(int id)
        {
            return true;
        }
        #endregion CRUD
    }
}

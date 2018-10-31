using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoCRUD._02_Controle;

namespace ProdutoCRUD._01_Modelo
{
    class ProdutosModelo
    {
        public string _Erro { get; private set; }

        #region CRUD
        public bool Insert(Produto produto)
        {
            if (!Validar(produto))
            {
                return false;
            }
            return true;
        }
        public bool Update(Produto produto)
        {
            if (!Validar(produto))
            {
                return false;
            }

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

        private bool Validar(Produto produto)
        {
            try
            {
                if (produto.CodigoBarras == "") { throw new Exception("Código inválida!"); }
                if (produto.Descricao == "") { throw new Exception("Descrição inválida!"); }
                if (produto.Custo < 0) { throw new Exception("Custo inválido!"); }
                if (produto.Venda < 0) { throw new Exception("Custo inválido!"); }

                return true;
            }
            catch (Exception ex)
            {
                _Erro = ex.ToString();
                return false;
            }

        }
    }
}

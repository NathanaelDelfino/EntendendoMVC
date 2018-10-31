using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoCRUD._01_Modelo;

namespace ProdutoCRUD._02_Controle
{
    public class Produto
    {
        private  ProdutosModelo _modelo;
        

        public int Id { get; private set; }
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Venda { get; set; }
        public decimal Quantidade { get; set; }
        public string _Erro { get; private set; }
        public int cpf { get; private set; }

        public Produto(int id, string codigoBarras, string descricao)
        {
            this.Id = id;
            this.CodigoBarras = codigoBarras;
            this.Descricao = descricao;

            _modelo = new ProdutosModelo();
        }
        public bool Salvar()
        {
            try
            {
                    if (this.Id == 0)
                    {
                        _modelo.Insert(this);
                    }
                    else
                    {
                        _modelo.Update(this);
                    }
                    return true;
            }catch(Exception ex)
            {
                _Erro = ex.ToString();
                return false;
            }
        }
        public bool Excluir()
        {
            _modelo.Delete(this.Id);
            return true;
        }
        public List<Produto> CarregaCadastro(string pesquisa)
        {
            return _modelo.Select(); 
        }

    }
}

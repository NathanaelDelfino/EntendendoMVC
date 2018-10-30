using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoCRUD._01_Modelo
{
    class Produto
    {
        private static ProdutosModelo _modelo;
        

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
        }
        public bool Salvar()
        {
            try
            {
                if (!Validar())
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
                }
                else
                {
                    return false;
                }
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
        private bool Validar()
        {
            try
            {
                if (this.CodigoBarras == "") { throw new Exception("Código inválida!"); }
                if (this.Descricao == "") { throw new Exception("Descrição inválida!"); }
                if (this.Custo < 0) { throw new Exception("Custo inválido!"); }
                if (this.Venda < 0) { throw new Exception("Custo inválido!"); }

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

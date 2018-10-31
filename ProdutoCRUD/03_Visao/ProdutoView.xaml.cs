using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProdutoCRUD._02_Controle;

namespace ProdutoCRUD._03_Visao
{
    /// <summary>
    /// Lógica interna para ProdutoView.xaml
    /// </summary>
    public partial class ProdutoView : Window
    {
        public ProdutoView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var produto = new Produto(Convert.ToInt32( CodigoBarras.Tag), CodigoBarras.Text, Descricao.Text );
                produto.Custo = Convert.ToDecimal(Custo.Text);
                produto.Venda =  Convert.ToDecimal(Venda.Text);
                produto.Quantidade = Convert.ToDecimal(Quantidade.Text);
                produto.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

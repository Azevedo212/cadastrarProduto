namespace cadastro_de_produto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadProduto a = new CadProduto();
            double valorVenda = a.Produto();
            
            a.Codigo = tx_codigo.Text;
            a.Descricao = tx_descricao.Text;
            //a.PrecoAquisicao = Convert.ToDouble(tx_preco.Text);
           // a.Lucro = Convert.ToDouble(tx_lucro.Text);
           
           MessageBox.Show(a.Codigo, a.Descricao);
        }
    }
}
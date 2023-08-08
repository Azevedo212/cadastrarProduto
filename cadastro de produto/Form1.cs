namespace cadastro_de_produto
{
    public partial class Form1 : Form
    {
        List<CadProduto> produtos = new List<CadProduto>();
        public Form1()
        {

            InitializeComponent();

        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadProduto a = new CadProduto();

            try
            {
                a.Codigo = tx_codigo.Text;
                a.Descricao = tx_descricao.Text;
                a.PrecoAquisicao = Convert.ToDouble(tx_preco.Text);
                a.Lucro = Convert.ToDouble(tx_lucro.Text);

                tx_Valor.Text = a.Produto(a.PrecoAquisicao, a.Lucro).ToString();

                produtos.Add(a);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
            }          
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado!");
            }
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_preco.Clear();
            tx_lucro.Clear();
            tx_Valor.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produtos.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;
        }
    }
}
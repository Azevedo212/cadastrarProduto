public class CadProduto
{
    public string Codigo { get; set; }

    public string Descricao { get; set; }

    public double Lucro { get; set; }

    public double PrecoAquisicao { get; set; }

    public double Valor { get; set; }

    public CadProduto()
    {

    }

    public CadProduto(string Codigo, string Descricao, double PrecoAquisicao, double Lucro)
    {
        this.Codigo = Codigo;
        this.Descricao = Descricao;
        this.PrecoAquisicao = PrecoAquisicao;
        this.Lucro = Lucro;
    }

    public double Produto(double PrecoAquisicao, double Lucro)
    {   
        this.Valor = ((Lucro / 100) * PrecoAquisicao) + PrecoAquisicao;
        return this.Valor;     
    }
}
namespace Avaliacao3935;

public class Fornecedor : Pessoa
{
    private float creditoMax;
    private float valorEmDivida;
    
    public Fornecedor(String nome, int idade, int altura, string sexo,  float credMax, float vDiv)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
        Sexo = sexo;
        this.CreditoMax = credMax;
        this.ValorEmDivida = vDiv;
    }

    public float obterSaldo()
    {
        return (CreditoMax - ValorEmDivida);
    }

    public float CreditoMax
    {
        get => creditoMax;
        set => creditoMax = value;
    }

    public float ValorEmDivida
    {
        get => valorEmDivida;
        set => valorEmDivida = value;
    }
}
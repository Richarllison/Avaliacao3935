using System.Security;

namespace Avaliacao3935;

public class Pessoa
{
    private string nome;
    private int idade;
    private int altura;
    private string sexo;

    public Pessoa()
    {
        
    }

    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Idade
    {
        get => idade;
        set => idade = value;
    }

    public int Altura
    {
        get => altura;
        set => altura = value;
    }

    public string Sexo
    {
        get => sexo;
        set => sexo = value ?? throw new ArgumentNullException(nameof(value));
    }
}
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Avaliacao3935;

public class Empregado : Pessoa
{
    private float salario;

    public Empregado()
    {
        
    }

    public virtual float obterLucros()
    {
        return this.salario;
    }

    public float Salario
    {
        get => salario;
        set => salario = value;
    }
}
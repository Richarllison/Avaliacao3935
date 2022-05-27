namespace Avaliacao3935;

public class Administrador : Empregado
{
    private float ajudasDeCusto;
    public Administrador(String nome, int idade, int altura, string sexo, float sal, float ajudaC)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
        Sexo = sexo;
        Salario = sal;
        this.ajudasDeCusto = ajudaC;
        obterLucros();
    }
    
    public override float obterLucros()
    {
        return Salario += this.ajudasDeCusto;
    }
}
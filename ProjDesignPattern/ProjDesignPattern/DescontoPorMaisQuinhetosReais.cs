using ProjDesignPattern;

public class DescontoPorMaisDeQuinhentosReais : Desconto
{
    public Desconto Proximo { get; set; }

    public double Calcula(Orcamento orcamento)
    {
        if (orcamento.Valor > 500)
        {
            return orcamento.Valor * 0.07;
        }
        else
        {
            return Proximo.Calcula(orcamento);
        }
    }
}
using ProjDesignPattern;

public interface Desconto
{
    double Calcula(Orcamento orcamento);
    Desconto Proximo { get; set; }
}
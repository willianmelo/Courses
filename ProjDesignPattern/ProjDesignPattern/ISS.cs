using ProjDesignPattern.Interface;


namespace ProjDesignPattern
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto){ }
        public ISS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculodoOutroIMposto(orcamento);
        }

       
    }
}

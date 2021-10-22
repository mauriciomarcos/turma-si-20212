using OOP.Interfaces;

namespace OOP.Classes
{
    public class Investimento : IInvestimento
    {
        public string Investir(decimal valorInvestimento) => "Investimento realizado por uma conta específica de investimentos";
    }
}
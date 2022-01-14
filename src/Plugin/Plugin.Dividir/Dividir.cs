using FR.Retirada.Uso.Devolucao.Contrato;
using System;
using System.Threading.Tasks;

namespace Plugin.Dividir
{
    public class Dividir : ICalculadora
    {
        public Task<decimal> CalcularAsync(int valor_A, int valor_b)
        {
            return Task.FromResult(Convert.ToDecimal(valor_A / valor_b));
        }
    }
}

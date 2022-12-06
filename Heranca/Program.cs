using System;

namespace Paymentes
{
    class Program
    {
        static void Main(string[]args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
           

            Console.WriteLine("Hello World");
        }
    }

    class Pagamento
    {
        //propriedades, variaveis
        public DateTime Vencimento;
        // metodos, funcoes
        public void Pagar()  { }
    }
    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto = "123";
    }
    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero  = "123";
    }

}
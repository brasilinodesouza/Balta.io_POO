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
            var pagamento = new Pagamento();
            pagamento.ToString();

            Console.WriteLine("Hello World");
        }
    }

    class Pagamento
    {
        //propriedades, variaveis
        public DateTime Vencimento;
        // metodos, funcoes
        public virtual void Pagar()  { }

        public override string ToString()
        {
            return Vencimento.ToString("dd/mm/yy");
        }

        
    }
    class PagamentoBoleto : Pagamento
    {
        public String NumeroBoleto  = "123";
        public override void Pagar()
        {
            //regra do boleto

        }
    }
    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero  = "123";

         public override void Pagar()
        {
            //regra do cartao

        }
    }

}

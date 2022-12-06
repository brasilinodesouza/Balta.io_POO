using System;

namespace Paymentes
{
    class Program
    {
        static void Main(string[]args)
        {
            var pagamento = new PagamentoCartao();
            pagamento.Pagar("131");
        }
    }


// private (só a class), protected(so os filhos), internal(mesmo namespace) e public(todos ve e acessa)
    public class Pagamento
    {
        public Pagamento ()
        {
             Console.WriteLine("Iniciar o pagamento");
        }


        public virtual void Pagar(string numero) {
            Console.WriteLine("Pagar");

        }

    }
    
    public class PagamentoCartao : Pagamento
    {
        public override void Pagar(string numero) {
            //base. chama o metodo do pai
            base.Pagar(numero);
            Console.WriteLine("Paga Cartao");
        }

    }


}

using System;

namespace Paymentes
{
    class Program
    {
        static void Main(string[]args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;

            Console.WriteLine("Hello World");
        }
    }


// private (só a class), protected(so os filhos), internal(mesmo namespace) e public(todos ve e acessa)
    class Pagamento
    {
        //propriedades, variaveis
        //DateTime Vencimento;
        // metodos, funcoes


        public DateTime Vencimento { get; set; }



        private DateTime dataPagamento;
        public DateTime DataPagamento
        {
            get {
                 System.Console.WriteLine("Lendo o valor");
                return dataPagamento; }

            set {
                System.Console.WriteLine("atribuindo o valor");
                 dataPagamento = value; }
        }
        

    }

}

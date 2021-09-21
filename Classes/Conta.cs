using System;

namespace Transferência_Brancária
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}


        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar (double ValorSaque)
        {
            if(this.Saldo - ValorSaque < (this.Credito*-1))
            {
                Console.WriteLine("Saldo insuficiente");
            
            return false;
            }
            this.Saldo -= ValorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar (double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }
        public void Transferir (double ValorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(ValorTransferencia))
            {
                contaDestino.Depositar(ValorTransferencia);
            }
            
        }
        public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
        }
    }

}
  
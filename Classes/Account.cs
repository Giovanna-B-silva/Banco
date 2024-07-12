
using System.ComponentModel;

namespace OOP
{
    public  class Account
    { 
        public Account(int numero,double limite)
        {
          this.Numero =numero;   
          this.Limite= limite;
        }
       protected double Saldo { get; set;}
       public double Limite { get; private  set;}
        public int Numero { get; set; }
        public string Nome {get;set;} =string.Empty;
        
        
        
        public void Deposito (double valor)
        {
            this.Saldo += valor;
           
        }
        
        public double ConsultarSaldoDisponivel ()
        {
            return  this.Saldo + this.Limite;
        }
        public virtual bool Saque (double valor)
        {
             double SaldoDisponivel =  this.ConsultarSaldoDisponivel();
          
            if (valor < SaldoDisponivel){
                this.Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saque indisponível");
                return false;
            }
            
        }
         public void  AddLimite(double valor)
        {
         this.Limite = valor;
            
        }



    }
}

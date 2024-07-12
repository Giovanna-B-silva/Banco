using System.Runtime.InteropServices.Marshalling;

namespace OOP
{
       class Savings__Account: Account
       {
               public Savings__Account(int numero, double limite) : base(numero, limite)
               {
                        
               }
              
      

    private double jurosPorcentagem = 0.05; 
    public override bool Saque(double valor)
    {
        bool DeuCertoSaque = base.Saque(valor);

        if (DeuCertoSaque)
        {
            double juros = valor * jurosPorcentagem; 
            this.Saldo -= juros;
        }
        return DeuCertoSaque;
    }

       }
    
}
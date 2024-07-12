using System.ComponentModel;
namespace OOP
{
          public class Current__Account :Account
          {
             public Current__Account(int numero,double limite): base(numero, limite)
             {
                
             }
               
        public override bool Saque(double valor)
        {
          bool DeuCertoSaque =  base.Saque(valor);

          if (DeuCertoSaque)
          {
            this.Saldo -= 20;//juros
          }
            return false;
           
        }
       }
    

        
}

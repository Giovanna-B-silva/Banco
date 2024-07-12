namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1234, 200); // Creating an account

            account.Deposito(1500);
            account.Deposito(2500);
            account.Deposito(4500);
            account.AddLimite(1500);

           

            Savings__Account savingsaccount = new Savings__Account(112, 150);
            savingsaccount.Deposito(100);
            savingsaccount.AddLimite(2500);

            Console.WriteLine("Sua conta é corrente ou poupança:");
            string? conta = Console.ReadLine();

            if (conta == "Corrente".ToLower())
            {
                double saldo = account.ConsultarSaldoDisponivel();

                Console.WriteLine("Digite seu nome:");
                string? nome = Console.ReadLine();
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("Número da conta: " + account.Numero);
                Console.WriteLine("Limite: " + account.Limite);

                Console.WriteLine("Deseja realizar algum saque? (Sim/Não)");
                string? valores = Console.ReadLine();
                if (valores == "Sim".ToLower())
                {
                    Console.WriteLine("Qual o valor desejado para saque?");
                    double sacar = Convert.ToDouble(Console.ReadLine());

                    if (sacar <= 1500)
                    {
                        Console.WriteLine("Seu novo saldo é: " + (saldo - sacar));
                    }
                    else if(sacar >= 1500)
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }
                    else if (valores == "Não".ToLower())
                  {
                        Console.Clear(); 
                         Main(args); 
                  }
                  else
                  {
                    Console.WriteLine("Opação não VALÍDA .      TENTE NOVAMENTE");
                  }
                  Console.WriteLine("Deseja realizar algum deposito? (Sim/Não)");
                  string? Deposito = Console.ReadLine();
                    if (Deposito == "Sim".ToLower())
                  {
                     Console.WriteLine("Qual o valor desejado para Deposito?");
                     double deposita= Convert.ToDouble(Console.ReadLine());

                     if (deposita<= saldo) 
                     {

                           Console.WriteLine("Operação realizada com suceso ");
                           Console.WriteLine("Seu novo saldo é: " + (saldo+ deposita));
                     }
                     else
                     {
                           Console.WriteLine("Saldo insuficiente");
                     }
                  }
                  else if (Deposito == "Não".ToLower())
                  {
                        Console.Clear(); 
                         Main(args); 
                  }
                  else
                  {
                    Console.WriteLine("Opação não VALÍDA .      TENTE NOVAMENTE");
                  }
                }
            }
               else if (conta == "poupanca".ToLower())
               {
                 
                  double saldopoupanca = savingsaccount.ConsultarSaldoDisponivel();

                  Console.WriteLine("Digite seu nome:");
                  string? nome = Console.ReadLine();
                  Console.WriteLine("Saldo: " + saldopoupanca);
                  Console.WriteLine("Número da conta: " + savingsaccount.Numero);
                  Console.WriteLine("Limite: " + savingsaccount.Limite);

                  Console.WriteLine("Deseja realizar algum saque? (Sim/Não)");
                  string? valores = Console.ReadLine();
                  if (valores == "Sim".ToLower())
                  {
                     Console.WriteLine("Qual o valor desejado para saque?");
                     double sacar = Convert.ToDouble(Console.ReadLine());

                     if (sacar <= saldopoupanca) 
                     {
                           Console.WriteLine("Seu novo saldo é: " + (saldopoupanca - sacar));
                     }
                     else
                     {
                           Console.WriteLine("Saldo insuficiente");
                     }
                  }
                  else if (valores == "Não".ToLower())
                  {
                        Console.Clear(); 
                         Main(args); 
                  }
                  else
                  {
                    Console.WriteLine("Opação não VALÍDA .      TENTE NOVAMENTE");
                  }
                   Console.WriteLine("Deseja realizar algum deposito? (Sim/Não)");
                  string? Deposito = Console.ReadLine();
                    if (Deposito == "Sim".ToLower())
                  {
                     Console.WriteLine("Qual o valor desejado para deposito?");
                     double deposita= Convert.ToDouble(Console.ReadLine());

                     if (deposita<= saldopoupanca) 
                     {

                           Console.WriteLine("Operação realizada com suceso ");
                           Console.WriteLine("Seu novo saldo é: " + (saldopoupanca + deposita));
                     }
                     else
                     {
                           Console.WriteLine("Saldo insuficiente");
                     }
                  }
                  else if (Deposito == "Não".ToLower())
                  {
                        Console.Clear(); 
                         Main(args); 
                  }
                  else
                  {
                    Console.WriteLine("Opação não VALÍDA .      TENTE NOVAMENTE");
                  }
               }
        }
    }
}


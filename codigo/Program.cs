using System.Collections;
Console.Clear();

Console.Write("Caixa eletrônico");

int saldo = 0;

Console.WriteLine("\nInsira o cartão");
//Thread.Sleep(4000);



Console.WriteLine("Tipo da conta 1 Corrente || 2 Poupança");
if (int.TryParse(Console.ReadLine(), out int conta))
    while(true)
{
    switch (conta)
    {
        case 1:
            Console.WriteLine("Saldo da conta: " + saldo);
            Console.WriteLine("1 Deposito || 2 Saque ");
            if (int.TryParse(Console.ReadLine(), out int tipoTransacao))
                switch (tipoTransacao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor a depositar: ");
                        if (int.TryParse(Console.ReadLine(), out int saldoDeposito))
                        {
                            saldo += saldoDeposito;
                            Console.WriteLine("Depósito realizado. Saldo Atual: " + saldo);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido para depósito.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor a sacar: ");
                        if (int.TryParse(Console.ReadLine(), out int saldoSaque))
                        {
                            if (saldoSaque > saldo)
                            {
                                bool repetir = true;
                                do
                                {
                                    Console.WriteLine("Valor indisponivel saldo da conta " + saldo);
                                    Console.WriteLine("Deseja depositar algum valor?: ");

                                }
                                while (repetir == false);
                                {
                                    Console.Write("Saque realizado.");
                                    Console.WriteLine("Saldo atual: " + (saldoSaque - saldo));
                                }

                            }

                        }
                        break;
                        case 3:
                        Console.WriteLine("Saindo do caixa, ate mais");
                        return;
                        break;
                        default:
                        Console.WriteLine("Tipo de transação inválido.");
                        break;
                }
            break;
    }
}



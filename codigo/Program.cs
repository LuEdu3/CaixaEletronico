using System.Collections;
using System.Runtime.Serialization;
bool retorno = true;
Console.Clear(); 
string nome_extrato = $"extrato{DateTime.Now}";
string temp = nome_extrato.Replace(" ", "").Replace(":", "").Replace("/", "");
using (StreamWriter escrever = new StreamWriter(temp + ".txt"))
{
    Console.Write("Caixa eletrônico");

    int saldo = 0;

    Console.WriteLine("\nInsira o cartão");
//Thread.Sleep(4000);

return1:
    Console.WriteLine("Tipo da conta 1 Corrente || 2 Poupança || 3 Para sair do caixa");
    if (int.TryParse(Console.ReadLine(), out int conta))
        while (retorno)
        {
            switch (conta)
            {
                case 1:
                    Console.WriteLine("Saldo da conta: " + saldo);
                    Console.WriteLine("1 Deposito || 2 Saque ||3 Transferência || 4 Para retornar ao MENU PRINCIPAL");
                    if (int.TryParse(Console.ReadLine(), out int tipoTransacao))
                        switch (tipoTransacao)
                        {
                            case 1:
                                Console.WriteLine("Digite o valor a depositar: ");
                                if (int.TryParse(Console.ReadLine(), out int saldoDeposito))
                                {
                                    saldo += saldoDeposito;
                                    Console.WriteLine("Depósito realizado.");
                                    
                                    Console.WriteLine("Saldo Atual: " + saldo);
                                    escrever.WriteLine("Depósito realizado.");
                                    escrever.WriteLine("Saldo Atual: " + saldo);
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
                                    if (saldo >= saldoSaque)
                                    {
                                        Console.Write("Saque realizado.");
                                        escrever.WriteLine("Saque realizado");
                                        saldo -= saldoSaque;
                                        escrever.WriteLine("Saldo atual: " + saldo);
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Valor indisponivel saldo da conta " + saldo);
                                        Console.WriteLine("Deseja depositar algum valor?: ");

                                    }

                                }
                                break;

                            case 3:
                                Console.WriteLine("Digite a Conta Corrente (formato 12345670 sem hífen):");
                                int dadosContaCorrente = int.Parse(Console.ReadLine());
                                Console.WriteLine("Agência (formato 1234): ");
                                int dadosAgencia = int.Parse(Console.ReadLine());
                                Console.WriteLine("Insira o banco para qual vai a  transferência: ");
                                string dadosBanco = Console.ReadLine();
                                return2:
                                Console.WriteLine("Confira os dados para transferência");
                                escrever.WriteLine("Confira os dados para transferência");
                                Console.WriteLine($"{dadosContaCorrente}");
                                escrever.WriteLine($"{dadosContaCorrente}");
                                Console.WriteLine($"{dadosAgencia}");
                                escrever.WriteLine($"{dadosAgencia}");
                                Console.WriteLine($"{dadosBanco}");
                                escrever.WriteLine($"{dadosBanco}");
                                Console.WriteLine("Valor para transferência: ");
                                escrever.WriteLine("Valor para transferência: ");
                                if(saldo<=0)
                                {
                                    Console.WriteLine("Saldo igual a 0 deseja depositar?");
                                    string s = Console.ReadLine();
                                    if(s =="S" || s =="s")
                                    {
                                    Console.WriteLine("Digite o valor a depositar: ");
                                    if (int.TryParse(Console.ReadLine(), out saldoDeposito))
                                    saldo += saldoDeposito;
                                    Console.WriteLine("Depósito realizado.");
                                    Console.WriteLine("Saldo Atual: " + saldo);
                                    escrever.WriteLine("Depósito realizado.");
                                    escrever.WriteLine("Saldo Atual: " + saldo);
                                    Console.Clear();
                                    goto return2;
                                    }
                                }
                                else
                                {
                                    int transferencia = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Transferência de {transferencia} realizada.");
                                    escrever.WriteLine($"Transferência de {transferencia} realizada.");
                                }
                            break;

                            case 4:
                                Console.WriteLine("Saindo.");
                                goto return1;
                                break;
                                default:
                                break;


            }
            break;
                case 3:
                    Console.WriteLine("Saindo do caixa eletrônico, retire seu cartão");
                    return;
                    break;
                    default:
                    break;
            }
        }

}
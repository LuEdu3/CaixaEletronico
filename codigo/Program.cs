using System.Collections;
using System.Runtime.Serialization;
bool retorno = true;
Console.Clear();
string nome_extrato = $"extrato{DateTime.Now}";
string temp = nome_extrato.Replace(" ", "").Replace(":", "").Replace("/", "");
using (StreamWriter escrever = new StreamWriter(temp + ".txt"))
{
    Console.WriteLine($"                 ......Caixa eletrônico...... Sessão iniciada {DateTime.Now}");
    escrever.WriteLine($"                 ......Caixa eletrônico...... Sessão iniciada {DateTime.Now}");
    int saldo = 0;
    Console.WriteLine("                 ......Insira o cartão.......");
    Thread.Sleep(4000);

return1:
    Console.WriteLine("Tipo da conta 1 Corrente || 2 Poupança || 4 Para sair do caixa");
    Console.WriteLine("-".PadLeft(76, '-'));
    if (int.TryParse(Console.ReadLine(), out int conta))
    {
        while (retorno)
        {
            switch (conta)
            {
                case 1:
                    Console.WriteLine("-".PadLeft(20, '-'));
                    escrever.WriteLine("-".PadLeft(20, '-'));
                    Console.WriteLine("Saldo da conta: " + saldo);
                    Console.WriteLine("-".PadLeft(20, '-'));
                    escrever.WriteLine("-".PadLeft(20, '-'));
                    Console.WriteLine("1 Deposito || 2 Saque ||3 Transferência || 4 Para retornar ao MENU PRINCIPAL");
                    Console.WriteLine("-".PadLeft(76, '-'));
                    if (int.TryParse(Console.ReadLine(), out int tipoTransacao))
                        switch (tipoTransacao)
                        {
                            case 1:
                                escrever.WriteLine($"Depósito {DateTime.Now}");
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
                                escrever.WriteLine("Saque");
                                Console.WriteLine("Digite o valor a sacar: ");
                                if (int.TryParse(Console.ReadLine(), out int saldoSaque))
                                {
                                    if (saldo >= saldoSaque)
                                    {
                                        Console.Write($"Saque realizado. {DateTime.Now}");
                                        escrever.WriteLine("Saque realizado");
                                        saldo -= saldoSaque;
                                        escrever.WriteLine("Saldo atual: " + saldo);
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Valor indisponivel saldo da conta " + saldo);
                                        Console.WriteLine("Digite valor a depositar: ");
                                        if (int.TryParse(Console.ReadLine(), out saldoDeposito))
                                            Console.WriteLine("Depósito realizado");
                                        saldo += saldoDeposito;
                                        escrever.WriteLine("Depósito realizado");
                                        escrever.WriteLine("Saldo atual: " + saldo);

                                        Console.Clear();
                                    }

                                }
                                break;

                            case 3:
                                escrever.WriteLine($"Transferência {DateTime.Now}");
                                Console.WriteLine("Digite a Conta Corrente (formato 12345670 sem hífen):");
                                int dadosContaCorrente = int.Parse(Console.ReadLine());
                                Console.WriteLine("Agência (formato 1234): ");
                                int dadosAgencia = int.Parse(Console.ReadLine());
                                Console.WriteLine("Insira o banco para qual vai a  transferência: ");
                                string? dadosBanco = Console.ReadLine();
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
                                if (saldo <= 0)
                                {
                                    Console.WriteLine("Saldo igual a 0 deseja depositar?");
                                    string s = Console.ReadLine();
                                    if (s == "S" || s == "s")
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
                                    int saldoTransferencia = int.Parse(Console.ReadLine());
                                    saldo -= saldoTransferencia;
                                    Console.WriteLine($"Transferência de {saldoTransferencia} realizada.");
                                    escrever.WriteLine($"Transferência de {saldoTransferencia} realizada.");
                                }
                                break;

                            case 4:
                                Console.WriteLine("Saindo.");
                                escrever.WriteLine("Saindo");
                                goto return1;
                                break;
                            default:
                                break;


                        }
                    break;
                case 4:
                    Console.WriteLine("Saindo do caixa eletrônico, retire seu cartão");
                    escrever.WriteLine($"Saindo do caixa eletrônico, retire seu cartão {DateTime.Now}");
                    return;
                    break;
                default:
                    break;


                case 2:
                    escrever.WriteLine("Poupança");
                    Console.WriteLine("1 Investimentos || 4 Para retornar ao MENU PRINCIPAL");
                    if (int.TryParse(Console.ReadLine(), out int poupanca))
                    {
                        switch (poupanca)
                        {
                            case 1:
                                Console.WriteLine("Selecione o investimento desejado");
                                Console.WriteLine("Em Andamento 🏗️🏗️");
                                break;
                        }
                    }

                    break;
            }
        }
    }
}
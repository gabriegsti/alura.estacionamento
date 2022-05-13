using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;

namespace Alura.Estacionamento
{
    class Program
    {

        // Cria uma lista de objetos do tipo veículos, para armazenar
        // os veículos (automovéis e motos) que estão no estacionamento;

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine(MostrarCabecalho());
                Console.WriteLine(MostrarMenu());
                opcao = LerOpcaoMenu();
                ProcessarOpcaoMenu(opcao);
                PressionaTecla();
                Console.Clear();// limpa a tela;
            } while (opcao != "5");
        }

        
        // Métodos de negócios.
        static void MostrarVeiculosEstacionados()
        {
            Console.Clear();
            Console.WriteLine(" Veículos Estacionados");
            
        }

        static void RegistrarSaidaVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Registro de Saída de Veículos");
        }

        static void RegistrarEntradaVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Registro de Entrada de Veículos");
            Console.Write("Tipo de veículo (1-Carro; 2-Moto) :");
            string tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    RegistrarEntradaAutomovel();
                    break;
                case "2":
                    RegistrarEntradaMotocicleta();
                    break;
                default:
                    Console.WriteLine("Tipo Inválido");
                    PressionaTecla();
                    break;
            }
        }

        static void RegistrarEntradaMotocicleta()
        {
            Console.WriteLine("Dados da Motocicleta");
           
        }

        static void RegistrarEntradaAutomovel()
        {
            Console.WriteLine("Dados do Automovél");
            
        }

        // Monta a interface da aplicação.
        static string MostrarCabecalho()
        {
            return "Controle de Estacionamento Rotativo";
        }

        static string LerOpcaoMenu()
        {
            string opcao;
            Console.Write("Opção desejada: ");
            opcao = Console.ReadLine();
            return opcao;
        }
           
        static string MostrarMenu()
        {
            string menu = "Escolha uma opção:\n" +
                            "1 - Registrar Entrada\n" +
                            "2 - Registrar Saída\n" +
                            "3 - Exibir Faturamento\n" +
                            "4 - Mostrar Veículos Estacionados\n" +                             
                            "5 - Sair do Programa \n";
            return menu;
        }

        private static void PressionaTecla()
        {
            Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();
        }

        static void ProcessarOpcaoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    RegistrarEntradaVeiculo();
                    break;
                case "2":
                    RegistrarSaidaVeiculo();
                    break;
               
                case "4":
                    MostrarVeiculosEstacionados();
                    break;
                case "5":
                    Console.WriteLine("Obrigado por utilizar o programa.");
                    break;
                default:
                    Console.WriteLine("Opção de menu inválida!");
                    break;
            }
        }

    }
    
}

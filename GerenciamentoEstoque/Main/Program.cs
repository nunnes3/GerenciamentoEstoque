using GerenciamentoEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, nSerieEquipamento = 0;
            
            //Opcao para menu principal,chamado,equipamento
            string opcao = "";
            string opcaoEquipamento, opcaoChamado = "";

            

            //Contador de repetições
            int contadoEquipamentos = 0;
            int contadorChamados = 0;


            //Contadores Id
            int idChamadosAutoIncrement = 0; 
            int idEquipamentosAutoIncrement = 0;
            
            int selecionaEquipamentos = 0;
            string tituloChamado, descricaoChamado = "";


            string nomeEquipamento, fabricanteEquipamento = "";
            double precoFabricacaoEquipamento = 0;
            DateTime dataFabricacaoEquipamento, dataAberturaChamado;


            //Arays
            Equipamento[] arrayEquipamento = new Equipamento[1000];
            Chamados[] arrayChamados = new Chamados[1000];

            //Declarando o objeto
            Equipamento equipamento = new Equipamento();
            Chamados chamados = new Chamados();

            while (opcao != "S")
            {
                opcao = MenuEquipamentoChamado();

                if (opcao == "1")
                {
                    opcaoEquipamento = menuEquipamento();

                    switch (opcaoEquipamento)
                    {
                        case "1":
                            {


                                idEquipamentosAutoIncrement++;

                                Console.WriteLine("Informe o nome do equipamento");
                                nomeEquipamento = Console.ReadLine();

                                Console.WriteLine("Informe a fabricante do equipamento");
                                fabricanteEquipamento = Console.ReadLine();

                                Console.WriteLine("Informe o numero de serie do equipamento");
                                nSerieEquipamento = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Informe a data de fabricacao do equipamento");
                                dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Informe a o preço do fabricação do equipamento");
                                precoFabricacaoEquipamento = Convert.ToDouble(Console.ReadLine());
                                Console.ReadLine();


                                arrayEquipamento[contadoEquipamentos] = new Equipamento(idEquipamentosAutoIncrement, nomeEquipamento, nSerieEquipamento, fabricanteEquipamento, dataFabricacaoEquipamento, precoFabricacaoEquipamento);

                                contadoEquipamentos++;

                                Console.WriteLine("Equipamento cadastrado com sucesso");
                                Console.ReadLine();
                                Console.Clear();

                                break;

                            }
                        case "2":
                            {

                                for (int i = 0; i < contadoEquipamentos; i++)
                                {
                                    if (arrayEquipamento[i] != null)
                                    {
                                        {
                                           

                                            Console.WriteLine(arrayEquipamento[i].listarEquipamentos());

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Nenhum equipamento cadastrado");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }

                                }


                                break;
                            }
                        case "3":
                            {
                                int idEquipamentoPesquisa = 0;
                                Console.WriteLine("Informe o id do equipamento a ser pesquisado ");
                                idEquipamentoPesquisa = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contadoEquipamentos; i++)
                                {
                                    if (arrayEquipamento[i].idEquipamento == idEquipamentoPesquisa)
                                    {


                                        Console.WriteLine("Informe o nome do equipamento");
                                        nomeEquipamento = Console.ReadLine();

                                        Console.WriteLine("Informe a fabricante do equipamento");
                                        fabricanteEquipamento = Console.ReadLine();

                                        Console.WriteLine("Informe o numero de serie do equipamento");
                                        nSerieEquipamento = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Informe a data de fabricacao do equipamento");
                                        dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());

                                        Console.WriteLine("Informe a o preço do fabricação do equipamento");
                                        precoFabricacaoEquipamento = Convert.ToDouble(Console.ReadLine());
                                        Console.ReadLine();

                                        arrayEquipamento[i] = new Equipamento(idEquipamentoPesquisa, nomeEquipamento, nSerieEquipamento, fabricanteEquipamento, dataFabricacaoEquipamento, precoFabricacaoEquipamento);

                                        Console.WriteLine("Equipamento editado com sucesso");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Id invalido, tente novamente");
                                        continue;

                                    }

                                }

                                break;
                            }

                        case "4":
                            {
                                int idEquipamentoExclui = 0;
                                Console.WriteLine("Informe o Id do respectivo equipamento para ser excluído");
                                idEquipamentoExclui = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contadoEquipamentos; i++)
                                {
                                   

                                        if (arrayEquipamento[i].idEquipamento == idEquipamentoExclui)
                                        {

                                            arrayEquipamento[i] = null;

                                            Console.WriteLine("Equipamento excluido com sucesso");
                                            Console.ReadLine();
                                            Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Id invalido tente novamente");
                                        Console.ReadLine();
                                        continue;
                                    }

                                  }
                               
                            }

                            break;       
                      }
                    }
                

                else if (opcao == "2")
                {
                    opcaoChamado = menuChamado();

                    switch (opcaoChamado)
                    {
                        case "1":
                            {
                                idChamadosAutoIncrement++;

                                Console.WriteLine("Informe o título do chamado");
                                tituloChamado = Console.ReadLine();

                                Console.WriteLine("Informe a descrição do chamado");
                                descricaoChamado = Console.ReadLine();

                                Console.WriteLine("Informe a data de abertura do chamado");
                                dataAberturaChamado = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Selecione o equipamento que deseja");

                                for (int i = 0; i < contadoEquipamentos; i++)
                                {
                                    Console.WriteLine(arrayEquipamento[i].SelecionarEquipamento());
                                }

                                Console.WriteLine("Escolha o equipamento desejado pelo seu respectivo id");
                                selecionaEquipamentos = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contadoEquipamentos; i++)
                                {
                                    if (arrayEquipamento[i].idEquipamento == selecionaEquipamentos)
                                    {
                                        equipamento = arrayEquipamento[i];
                                    }
                                }


                                arrayChamados[contadorChamados] = new Chamados(idChamadosAutoIncrement, tituloChamado, descricaoChamado, equipamento, dataAberturaChamado);

                                contadorChamados++;

                                Console.WriteLine("Chamado cadastrado com sucesso");
                                Console.ReadLine();
                                Console.Clear();

                                break;
                            }

                        case "2":
                            {

                                for (int i = 0; i < contadorChamados; i++)
                                {
                                    if (arrayChamados[i] != null)
                                    {
                                        {
                                            Console.WriteLine(arrayChamados[i].listarChamados());

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Nenhum chamado cadastrado");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }

                                }

                                break;
                            }

                        case "3":
                            {
                                int idChamadoPesquisa = 0;
                                Console.WriteLine("Informe o id do chamado que respectivamente vai ser editado");
                                idChamadoPesquisa = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contadorChamados; i++)
                                {
                                    if (arrayChamados[i].idChamado == idChamadoPesquisa)
                                    {


                                        Console.WriteLine("Informe o nome do equipamento");
                                        nomeEquipamento = Console.ReadLine();

                                        Console.WriteLine("Informe a fabricante do equipamento");
                                        fabricanteEquipamento = Console.ReadLine();

                                        Console.WriteLine("Informe o numero de serie do equipamento");
                                        nSerieEquipamento = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Informe a data de fabricacao do equipamento");
                                        dataFabricacaoEquipamento = Convert.ToDateTime(Console.ReadLine());

                                        Console.WriteLine("Informe a o preço do fabricação do equipamento");
                                        precoFabricacaoEquipamento = Convert.ToDouble(Console.ReadLine());
                                        Console.ReadLine();

                                        arrayEquipamento[i] = new Equipamento(idChamadoPesquisa, nomeEquipamento, nSerieEquipamento, fabricanteEquipamento, dataFabricacaoEquipamento, precoFabricacaoEquipamento);

                                        Console.WriteLine("Chamado editado com sucesso");
                                        Console.ReadLine();
                                        Console.Clear();

                                    }
                                    else
                                    {
                                        Console.WriteLine("Id invalido tente novamente");
                                        Console.ReadLine();
                                        continue;

                                    }

                                }



                                break;
                            }

                        case "4":
                            {
                                int idChamadoExclui = 0;
                                Console.WriteLine("Informe o Id do respectivo chamado para ser excluído");
                                idChamadoExclui = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contadorChamados; i++)
                                {

                                    if (arrayChamados[i].idChamado == idChamadoExclui)
                                    {

                                        arrayChamados[i] = null;

                                        Console.WriteLine("Chamdo excluido com sucesso");
                                        Console.ReadLine();
                                        Console.Clear();


                                    }
                                    else
                                    {
                                        Console.WriteLine("Id invalido, tente novamente");
                                        continue;
                                    }

                                }

                                break;
                            }


                    }
                }

                else if (EhOpcaoSair(opcao))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida, tente novamente");
                    Console.ReadLine();
                    continue;
                }
            }

        }

        private static string menuChamado()
        {
            string opcaoChamado;
            Console.WriteLine("1 - Para cadastrar chamados");
            Console.WriteLine("2 - Para listar chamados");
            Console.WriteLine("3 - Para editar chamados");
            Console.WriteLine("4 - Para excluir chamados");
            opcaoChamado = Console.ReadLine();
            return opcaoChamado;
        }

        private static string menuEquipamento()
        {
            string opcaoEquipamento;
            Console.WriteLine("1 - Para cadastrar equipamentos");
            Console.WriteLine("2 - Para listar equipamentos");
            Console.WriteLine("3 - Para editar equipamentos");
            Console.WriteLine("4 - Para excluir equipamentos");
            opcaoEquipamento = Console.ReadLine();
            return opcaoEquipamento;
        }

        private static string MenuEquipamentoChamado()
        {
            string opcao;
            Console.WriteLine(" Gerenciamento de Estoque");
            Console.WriteLine("1 - Para equipamentos");
            Console.WriteLine("2 - Para chamados");
            Console.WriteLine("3 - Para sair");
            opcao = Console.ReadLine();
            return opcao;
        }

        private static bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }
    }
}




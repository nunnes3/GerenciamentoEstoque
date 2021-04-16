using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Classes
{
    public class Equipamento
    {

        public int idEquipamento { get; set; }
        public string nomeEquipamento { get; set; }
        public int nSerieEquipamento { get; set; }
        public string fabricanteEquipamento { get; set; }
        public DateTime dataFabricacaoEquipamento { get; set; }
        public double precoEquipamento { get; set; }


        // COnstrutor para isntaciar o equipamento
        public Equipamento()
        {

        }

        //Construtor para receber informcaçãos do equipamento 
        public Equipamento(int id, string nome, int Nserie, string fabricante, DateTime dataFabricacao, double preco)
        {

            idEquipamento = id;
            nomeEquipamento = nome;
            nSerieEquipamento = Nserie;
            fabricanteEquipamento = fabricante;
            dataFabricacaoEquipamento = dataFabricacao;
            precoEquipamento = preco;

        }

        

        // Metodo para listar os equipamentos 
        public String listarEquipamentos()
        {
            // String para formatar data dd/MM/yyyy
            string formataData = Convert.ToString(dataFabricacaoEquipamento.ToString("dd/MM/yyyy"));


            return "------------------------------" + "\n" +

                    " ID: " + idEquipamento + "\n" +
                    " NOME: " + nomeEquipamento + "\n" +
                    " NUMERO DE SERIE: " + nSerieEquipamento + "\n" +
                    " FABRICANTE: " + fabricanteEquipamento + "\n" +
                    " DATA FABRICAÇÃO: " + formataData + "\n" +
                    " PREÇO: " + precoEquipamento + "\n" +

                    "------------------------------" + "\n";

        }

        // Metodo para retornar só o id e o nome 

        public String SelecionarEquipamento()
        {
            

            return "------------------------------" + "\n" +

                    " ID: " + idEquipamento + "\n" +
                    " NOME: " + nomeEquipamento + "\n" +
                   
                    "------------------------------" + "\n";

        }
    }
 }






















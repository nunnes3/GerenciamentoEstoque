using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Classes
{
    public class Chamados
    {

        public Equipamento equipamentoChamados = new Equipamento();

        public int idChamado { get; set; }
        
        public string tituloChamado { get; set; }

        public string descricaoChamados { get; set; }

        public DateTime dataAberturaChamados { get; set; }



        public Chamados()
        {

        }

        public Chamados(int id, string titulo, string descricao, Equipamento equipamento, DateTime dataAbertura)
        {

            idChamado = id;
            tituloChamado = titulo;
            descricaoChamados = descricao;
            equipamentoChamados = equipamento;
            dataAberturaChamados = dataAbertura;
            

        }

        public string listarChamados()
        {
            // String para formatar data dd/MM/yyyy
            string formataData = Convert.ToString(dataAberturaChamados.ToString("dd/MM/yyyy"));
            
            TimeSpan calculaDiferenca = DateTime.Now.Subtract(dataAberturaChamados);
            int dias = calculaDiferenca.Days;
            return "------------------------------" + "\n" +
                    " ID:  " + idChamado  + "\n" +
                    " TITULO DO CHAMADO: " + tituloChamado + "\n" +
                    " EQUIPAMENTO: " + equipamentoChamados.nomeEquipamento + "\n" +
                    " DATA DE ABERTURA: " + formataData + "\n" +
                    " DIAS ABERTOS: " + dias + "\n" +
                    
                    "------------------------------" + "\n";
        } 

       

    }
}

using e_Agenda.WinApp.TelasCompromisso;
using e_Agenda.WinApp.TelasContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using e_Agenda.WinApp.Entidades;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaTarefas telaTarefas;
        public TelaContatos telaContatos;
        public TelaCompromissos telaCompromissos;

        public TelaPrincipal()
        {
            InitializeComponent();
            telaTarefas = new();
            telaTarefas.telaCadastro.repositorioTarefa.Tarefas = CarregarTarefas();
            telaContatos = new();
            telaContatos.repositorioContato.Contatos = CarregarContatos();
            telaCompromissos = new(telaContatos);
            telaCompromissos.repositorioCompromisso.Compromissos = CarregarCompromissos();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            telaTarefas.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            telaContatos.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            telaCompromissos.ShowDialog();
        }

        private List<Tarefa> CarregarTarefas()
        {
            if (!File.Exists("..//..//..//TarefasJson.json"))
            {
                return telaTarefas.telaCadastro.repositorioTarefa.Tarefas = new();                
            }

            string json = File.ReadAllText("..//..//..//TarefasJson.json");
            List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(json);

            return tarefas;
        }

        private List<Contato> CarregarContatos()
        {
            if (!File.Exists("..//..//..//ContatosJson.json"))
            {
                return telaContatos.repositorioContato.Contatos = new();
            }

            string json = File.ReadAllText("..//..//..//ContatosJson.json");
            List<Contato> Contatos = JsonConvert.DeserializeObject<List<Contato>>(json);

            return Contatos;
        }

        private List<Compromisso> CarregarCompromissos()
        {
            if (!File.Exists("..//..//..//CompromissosJson.json"))
            {
                return telaCompromissos.repositorioCompromisso.Compromissos = new();
            }

            string json = File.ReadAllText("..//..//..//CompromissosJson.json");
            List<Compromisso> Compromissos = JsonConvert.DeserializeObject<List<Compromisso>>(json);

            return Compromissos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarTarefaEmArquivoXml();
            SalvarContatosEmArquivoXml();
            SalvarCompromissosEmArquivoXml();
            SalvarTarefasEmJson();
            SalvarContatosEmJson();
            SalvarCompromissosEmJson();
        }

        private void SalvarCompromissosEmJson()
        {
            var path = "..//..//..//CompromissosJson.json";
            var compromissos = telaCompromissos.repositorioCompromisso.Compromissos;
            string json = JsonConvert.SerializeObject(compromissos);
            File.WriteAllText(path, json);
        }

        private void SalvarContatosEmJson()
        {
            var path = "..//..//..//ContatosJson.json";
            var contatos = telaContatos.repositorioContato.Contatos;
            string json = JsonConvert.SerializeObject(contatos);
            File.WriteAllText(path, json);
        }

        private void SalvarTarefasEmJson()
        {
            var path = "..//..//..//TarefasJson.json";
            var tarefas = telaTarefas.telaCadastro.repositorioTarefa.Tarefas;
            string json = JsonConvert.SerializeObject(tarefas);
            File.WriteAllText(path, json);
        }

        private void SalvarCompromissosEmArquivoXml()
        {
            var compromissos = telaCompromissos.repositorioCompromisso.Compromissos;
            var tipo = compromissos.GetType();
            XmlSerializer writer = new(tipo);
            var path = $"..//..//..//Compromissos.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, compromissos);
            file.Close();
        }

        private void SalvarContatosEmArquivoXml()
        {
            var contatos = telaContatos.repositorioContato.Contatos;
            var tipo = contatos.GetType();
            XmlSerializer writer = new(tipo);
            var path = $"..//..//..//Contatos.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, contatos);
            file.Close();            
        }

        private void SalvarTarefaEmArquivoXml()
        {
            var tarefas = telaTarefas.telaCadastro.repositorioTarefa.Tarefas;
            var tipo = tarefas.GetType();
            XmlSerializer writer = new(tipo);
            var path = $"..//..//..//Tarefas.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, tarefas);
            file.Close();
        }
    }
}

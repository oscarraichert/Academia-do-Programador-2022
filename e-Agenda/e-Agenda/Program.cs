/*Tarefa : Prioridade, titulo, data de criação, data de conclusão e o percentual concluído, lista de itens(com descrição e
status de conclusão)

O percentual de cada tarefa é calculado nos percentuais dos itens de execução. Quando uma tarefa receber 100% de execução, esta deve
ser movida automaticamente para a lista de tarefas concluídas, podendo ser apagada, se for o caso.
visualizar as tarefas pendentes separadas das tarefas concluídas.

possibilidade de cadastrar novas tarefas e editar/excluir as tarefas já existentes.

Na edição das tarefas não poderá ser alterado a data de criação.

visualizar as tarefas finalizadas e as tarefas pendentes de forma separada, as tarefas deverão ser
apresentadas ordenadas por prioridade.

cadastro de contatos: armazenar o nome, e-mail, telefone, empresa e o cargo da pessoa,
possibilidade de registrar novos contatos, visualizar, editar e excluir contatos existentes;

O sistema não pode permitir o cadastro caso o e-mail ou o telefone estejam inválidos.
A aplicação deverá possibilitar a visualização da lista e contatos agrupados por cargo.

controlar Compromissos tendo uma visibilidade semanal e diária.

Para cada compromisso, armazenar: Assunto, local, data do compromisso, hora de início e término. A maioria dos
compromissos estão relacionados com algum contato de sua agenda.

possibilidade de registrar novos compromissos, editar e excluir os já existentes;
possibilidade de visualizar os compromissos que já passaram e que vão acontecer de forma
separada.

Para os compromissos futuros, deverá ser disponibilizado a possibilidade de filtrá-los por período.
É muito importante aparecer o nome do contato na visualização do compromissos. */

using System;

namespace e_Agenda
{
    internal class Program
    {
        public static TelaPrincipal TelaPrincipal = new();

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += TelaPrincipal.Fechando;

            TelaPrincipal.MenuPrincipal();
        }
    }
}
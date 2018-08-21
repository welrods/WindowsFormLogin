using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
        }

        private void text_Change(object sender, EventArgs e)
        {
            // O BOTÃO ENTRAR SÓ SERÁ ATIVADO QUANDO O TEXTO
            // DOS CAMPOS MUDAR PARA ALGO DIFERENTE DE VAZIO
            // != SIGNIFICA DIFERENTE
            // && = SIGNIFICA "E" SÓ VAI SER VERDADEIRO QUANDO
            // TODAS AS CONDIÇÕES FOREM VERDADEIRAS 

            btnEntrar.Enabled = textUser.Text != "" && textSenha.Text != "" ? true : false; 
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // COMANDO FOCUS FAZ COM QUE O FOCO DO SISTEMA, 
                // NO CASO, O CURSOR VÁ PARA O CAMPO INDICADO
                textSenha.Focus();
                // OS COMANDOS A SEGUIR SÃO RESPONSÁVEIS POR DESATIVAR O BEEP
                // DO COMPUTADOR NO MOMENTO QUE FAÇO ALGO NO SISTEMA
                e.Handled = true;
                e.SuppressKeyPress = true;


            }

        }

        private void textSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // COMANDO FOCUS FAZ COM QUE O FOCO DO SISTEMA,
                // NESSE CASO, O COMANDO EXECUTA A CHAMADO DO BOTÃO ENTRAR
                btnEntrar_Click(this, EventArgs.Empty);
                // OS COMANDOS A SEGUIR SÃO RESPONSÁVEIS POR DESATIVAR O BEEP
                // DO COMPUTADOR NO MOMENTO QUE FAÇO ALGO NO SISTEMA 
                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // NESSE EXEMPLO NÃO CRIAREMOS UM FORM DE LOGIN COM
            // TODAS AS FUNCIONALIDADES, MAS FAREMOS O BÁSICO
            // O PROCESSO É BASICAMENTE O MESMO, A ÚNICA DIFERENÇA É
            // QUE NÃO FAREMOS NENHUMA ROINA DE VERIFICAÇÃO DOS 
            // DADOS DO USUÁRIO, VAMOS MOSTRAR APENAS UMA MENSAGEM INDICANDO 
            // QUE O USUÁRIO ENTROU NO SISTEMA

            if (!btnEntrar.Enabled) return;
            MessageBox.Show("Você acaba de entrar no sistema!");
        }
    }
}

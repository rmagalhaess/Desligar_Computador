using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar
{
    public partial class frm_Desligar : Form
    {
        // ===========================================================================
        public int Opcoes()
        {
            // Variaveis:
                int Opcoes=0;

            // Programa:
                if( ( Opcoes == 0 ) && rdo_Hibernar.Checked )  { Opcoes = 1; }
                if( ( Opcoes == 0 ) && rdo_Reiniciar.Checked ) { Opcoes = 2; }
                if( ( Opcoes == 0 ) && rdo_Desligar.Checked )  { Opcoes = 3; }

            // Fim:
                return Opcoes;
        }

        // ===========================================================================
        public frm_Desligar()
        {
            InitializeComponent();
        }

        // ===========================================================================
        private void frm_Desligar_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        // ===========================================================================
        private void bto_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===========================================================================
        private void bto_Confirmar_Click(object sender, EventArgs e)
        {
            // Variáveis:
                int escolha = 0;
                Comando comando = null;
                bool escolheu = false;
                string opcao = "";

            // Programa:      
                escolha = this.Opcoes(); 

                if( escolha > 0 )
                {
                    comando = new Comando();

                    switch ( escolha )
                    {
                        case 1: opcao = "C:\\Windows\\System32\\rundll32.exe powrprof.dll,SetSuspendState 0,1,0"; break;
                        case 2: opcao = "C:\\Windows\\System32\\shutdown.exe /r /f /t 0"; break;
                        case 3: opcao = "C:\\Windows\\System32\\shutdown.exe /s /f /t 0"; break;
                    }

                    escolheu = comando.Executar(opcao);
                }
                else
                {
                    MessageBox.Show( "Nenhuma escolha foi feita ?!", 
                                     this.Text,
                                     MessageBoxButtons.OK, 
                                     MessageBoxIcon.Asterisk);
                }

                if(escolheu)
                {
                    this.Close();
                }

            // Fim:
        }
    }
}

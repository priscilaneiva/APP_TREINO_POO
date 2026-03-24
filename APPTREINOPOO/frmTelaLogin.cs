using System.Diagnostics.Eventing.Reader;

namespace APPTREINOPOO
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string NomeUsuario = txtNomeUsuario.Text;
            string SetorUsuario = txtSetorUsuario.Text;
            string SenhaUsuario = txtSenhaUsuario.Text;

            CredenciaisUsuario cu = new CredenciaisUsuario(NomeUsuario, SetorUsuario, SenhaUsuario);

            if (cu.VerificarCredenciais()) 
            {
                frmTelaPrincipal ftp = new frmTelaPrincipal();
                ftp.Show();
                this.Visible = false;
            }

            else 
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!");
            
            }

            














        }
    }
}

namespace Projeto_aposentadoria_INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioCorreto = "rm98582@fiap.com.br";
            string senhaCorreta = "98582";

            if (txtEmail.Text == usuarioCorreto && txtSenha.Text == senhaCorreta)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormAposentadoria formAposentadoria = new FormAposentadoria();
                formAposentadoria.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

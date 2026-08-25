namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int cont = 100;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 100 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                lsbMostra.Items.Add(fatorial.ToString());
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 1;
            lsbMostra.Items.Clear();

            do
            {
                lsbMostra.Items.Add((num * num).ToString());
                num++;
            }
            while (num <= 100);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int maisvc = 0;
            lsbMostra.Items.Clear();

            for (maisvc = 1; maisvc <= 1000000; maisvc *= 5)
            {
                lsbMostra.Items.Add(maisvc.ToString());
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // Array ou vetor é uma estrutura de dados que armazena
            // valores que podem ser acessados por uma posição
            // frutas[0] = "Maça", frutas[1] = "Mamão",.....
            int []numeros = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            string[] nomes = {"João", "Maria"};

            lsbMostra.Items.Clear();
            foreach (int num in numeros)
            {
                lsbMostra.Items.Add(num);
            }

            foreach (string nome in nomes)
            {
                lsbMostra.Items.Add(nome);
            }

        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                if (cont == 2)
                {
                    break;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;

                if (cont == 2)
                {
                    continue;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }
    }
}

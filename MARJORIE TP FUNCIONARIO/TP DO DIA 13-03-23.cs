namespace MARJORIE_TP_FUNCIONARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario ();

            funcionario.CPF = mstCPF.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.DiasTrabalhados = int.Parse(txtDiasTrabalhados.Text);
            funcionario.ValorDiaria = int.Parse(txtValorDiaria.Text);
            

            funcionario.CalculoSalarioBase();

            txtSalarioBase.Text = funcionario.SalarioBase.ToString();

            funcionario.CalculoDoIR();

            txtValorDoIR.Text = funcionario.PercentualDoIR.ToString();

            funcionario.CalculoSalarioLiquido();

            txtSalarioLiquido.Text = funcionario.SalarioLiquido.ToString();
        }

            


    }
}
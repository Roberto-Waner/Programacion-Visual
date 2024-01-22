namespace Prueva_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static OperadorBinario CrearOperacion(int n1, int n2, char op)
        {
            //if (op == '+') return new Suma(n1, n2);

            return (op == '+') ? new Suma(n1, n2) :
                   (op == '-') ? new Resta(n1, n2) :
                   (op == '*') ? new Multiplicacion(n1, n2) :
                   (op == '/') ? new Division(n1, n2) :
                   (op == 'R') ? new Raiz(n1, n2) :
                   new Potencia(n1, n2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt_nu1.Text);
            int n2 = int.Parse(txt_nu2.Text);
            char op;

            op = (cb_op.Text == "Suma") ? '+' :
                 (cb_op.Text == "Resta") ? '-' :
                 (cb_op.Text == "Multiplicacion") ? '*' :
                 (cb_op.Text == "Division") ? '/' :
                 (cb_op.Text == "Raiz(suma)") ? 'R' : 'P';
            double resultado = CrearOperacion(n1, n2, op).Operacion();
            txt_resultado.Text = resultado.ToString();
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            txt_nu1.Clear();
            txt_nu2.Clear();
            txt_resultado.Clear();
            cb_op.Text = "";
            txt_nu1.Focus();
        }
    }
}
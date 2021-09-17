using System;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace ECommerce_Project
{
    public partial class FrmCompra : Form
    {
        //Inicializa o Form
        public FrmCompra()
        {
            //Chama o SplashScreen
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //Thread.Sleep(3500);
            InitializeComponent();
            //t.Abort();
            //CenterToScreen();
        }
        //Prepara o SplashScreen
        //public void StartForm()
        //{
        //Application.Run(new FrmSplashScreen());
        //}
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            //Prepara os valores dos produtos ao carregar o form
            Double[,] ValoresProdutos;
            ValoresProdutos = new Double[7, 8]
            {
                { 1890, 1299, 963.99, 2099.99, 399.99, 2599.90, 569.90, 650 }, // Gabinetes
                { 899, 779.90, 1749.90, 3433.90, 3199.99, 969.99, 2599.90, 5239.90 }, // Processadores
                { 579.90, 1299, 963.99, 2099.99, 399.99, 434.90, 689.90, 1519.90 }, // Placas Mães
                { 1799.90, 3621.90, 3799.90, 2757.03, 4099.00, 5899.90, 12962.90, 21299.90 }, // Placas de Video
                // PULEI OS SERVIÇOS AQUI
                { 398.90, 410.90, 169.90, 419.90, 949.90, 1448.90, 569.90, 2159.90 }, // Coolers
                { 869.90, 3305.90, 1399.90, 649.90, 1538.90, 959.90, 449.92, 339.90 }, // Armazenamento
                { 949.90, 459.90, 779.90, 359.90, 2215.62, 7499.90, 259.90, 2352.82 }, // Fontes
            };
            String[] Nomes = new string[7] { "Gabinete", "Processador", "PlacaMae", "PlacaVid", "Cooler", "Memoria", "Fonte" };
            String Nome;
            for (int x = 0; x <= 6; x++)
            {
                Nome = Nomes[x];
                for (int y = 1; y <= 8; y++)
                {
                    ((TextBox)this.Controls.Find($"Txt{Nome}{y}", true)[0]).Text = ValoresProdutos[x, y - 1].ToString("C");
                }
            }

            //Prepara os valores dos "serviços / windows" ao carregar o form
            Double[,] ValoresServicos;
            ValoresServicos = new Double[2, 4] {
                { 100.00, 150.00, 250.00, 100.00}, // Serviços
                { 799.90, 899.90, 1199.90, 1299.90}, // Windows
            };
            String[] NomesExtra = new string[2] { "Servicos", "Windows" };
            String NomeExtra;
            for (int x = 0; x <= 1; x++)
            {
                NomeExtra = NomesExtra[x];
                for (int y = 1; y <= 4; y++)
                {
                    ((TextBox)this.Controls.Find($"Txt{NomeExtra}{y}", true)[0]).Text = ValoresServicos[x, y - 1].ToString("C");
                }
            }
        }
        //Botão de finalizar compra
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if (TxtTotalIn.Text != "R$ 0,00")
            {

                MessageBox.Show("Pedimos desculpas, mas a plataforma está em manutenção neste momento." +
                    Environment.NewLine + Environment.NewLine + Environment.NewLine + "Volte mais tarde e veja as novidades que estamos reservando para você!",
                    "Plataforma em manutenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Selecione um item antes para poder finalizar a compra!", "Carrinho vázio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Botão de limpar o carrinho
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LtbTotal.Items.Clear();
            TxtTotalIn.Text = 0.ToString("C");
            TxtTotalOut.Text = 0.ToString("C");

            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }
        //
        // // Eventos gerais para a manipulação de valores e quantidades de produtos
        //

        // Variáveis para os nomes dos CB, TXT e Nud(s) 
        String NomeNud;
        String NomeCb;
        String NomeTxt;

        // Valores Temporários
        String UltimoEvento;
        Decimal UltimoValor = 0;
        bool IgnorarEvento;

        // Elementos Relativos
        NumericUpDown ValorNUD;
        Decimal ValorTextbox;
        CheckBox ValorCheckbox;

        // Por fim, o resultado!
        Decimal resultado = 0;

        //
        // Evento dos Checkboxes
        //
        private void CBGeneral_Changed(object sender, EventArgs e)
        {
            if (IgnorarEvento == true) { return; }
            // Checkbox que acionou o evento e seus elementos relativos
            CheckBox CBReference = (CheckBox)sender;

            // Nomes relativos
            NomeNud = CBReference.Name.ToString().Replace("Cb", "Nud");
            NomeTxt = CBReference.Name.ToString().Replace("Cb", "Txt");
            // Objetos relativos
            IgnorarEvento = true;
            ValorTextbox = Decimal.Parse(((TextBox)this.Controls.Find($"{NomeTxt}", true)[0]).Text, NumberStyles.Currency);
            ValorNUD = (NumericUpDown)this.Controls.Find($"{NomeNud}", true)[0];
            IgnorarEvento = false;


            // Define o valor do NUD baseado no valor checked da checkbox e atualiza o resultado
            if (CBReference.Checked == true)
            {
                IgnorarEvento = true;
                ValorNUD.Value = 1;
                resultado += ValorTextbox;
                IgnorarEvento = false;
                LtbTotal.Items.Add($"\n {CBReference.Text} - Unidade: {ValorTextbox} - Quantidade:  {ValorNUD.Value} - " + $"Total: { (ValorTextbox * ValorNUD.Value).ToString("C")} \n");
            }
            else
            {
                IgnorarEvento = true;
                resultado -= ValorNUD.Value * ValorTextbox;
                ValorNUD.Value = 0;
                IgnorarEvento = false;
                LtbTotal.Items.RemoveAt(LtbTotal.Items.Count - 1);
            }

            // Adiciona o NUD do Checkbox ao ultimo evento
            IgnorarEvento = true;
            UltimoEvento = ((NumericUpDown)this.Controls.Find($"{NomeNud}", true)[0]).Name;
            IgnorarEvento = false;

            // Atribuição do total e o mostra na label
            TxtTotalIn.Text = resultado.ToString("C");
            TxtTotalOut.Text = resultado.ToString("C");
            UltimoEvento = CBReference.Name;
        }
        //
        // Evento dos Numeric Up Down(s)!
        //
        private void NudGeneral_Changed(object sender, EventArgs e)
        {
            if (IgnorarEvento) { return; }
            // Numeric Up Down que deu trigger nesse evento
            NumericUpDown NUDReference = (NumericUpDown)sender;

            // Nomes Relativos
            NomeCb = NUDReference.Name.Replace("Nud", "Cb");
            NomeTxt = NUDReference.Name.Replace("Nud", "Txt");
            // Objetos Relativos
            ValorTextbox = Decimal.Parse(((TextBox)this.Controls.Find($"{NomeTxt}", true)[0]).Text, NumberStyles.Currency);
            ValorCheckbox = (CheckBox)this.Controls.Find($"{NomeCb}", true)[0];

            // Checkagem de valores
            switch (NUDReference.Value)
            {
                case 0: {
                        IgnorarEvento = true;
                        ValorCheckbox.Checked = false;
                        IgnorarEvento = false;
                        resultado -= ValorTextbox;
                        LtbTotal.Items.RemoveAt(LtbTotal.Items.Count - 1);
                        break;
                    };
                case 1: {
                        if (NUDReference.Value < UltimoValor)
                        {
                            resultado -= ValorTextbox;
                        }
                        IgnorarEvento = true;
                        ValorCheckbox.Checked = true;
                        resultado += ValorTextbox;
                        IgnorarEvento = false;
                        if (UltimoEvento == NUDReference.Name)
                        {
                            LtbTotal.Items.RemoveAt(LtbTotal.Items.Count - 1);
                        }
                        LtbTotal.Items.Add($"\n {ValorCheckbox.Text} - Unidade: {ValorTextbox} - Quantidade:  {NUDReference.Value} -  Total: { (ValorTextbox * NUDReference.Value).ToString("C")}\n");
                        break;
                    };
                default:
                    {
                        // Pega o valor da textbox, converte para um valor double e adiciona na lista!
                        if (NUDReference.Value < UltimoValor)
                        {
                            IgnorarEvento = true;
                            resultado -= ValorTextbox;
                            IgnorarEvento = false;
                        }
                        else
                        {
                            // Remover ultimo valor da lista caso seja ultimo evento (previne duplicação de valores constantemente)
                            if (UltimoEvento == NUDReference.Name)
                            {
                                LtbTotal.Items.RemoveAt(LtbTotal.Items.Count - 1);
                            }
                            LtbTotal.Items.Add($"\n {ValorCheckbox.Text} - Unidade: {ValorTextbox} - Quantidade:  {NUDReference.Value} - Total: { (ValorTextbox * NUDReference.Value).ToString("C")} \n");
                            resultado += ValorTextbox * NUDReference.Value;
                        }
                        break;
                    } 
            }
            TxtTotalIn.Text = resultado.ToString("C");
            TxtTotalOut.Text = resultado.ToString("C");
            UltimoEvento = NUDReference.Name;
            UltimoValor = NUDReference.Value;
        }
    }
}

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
            //Prepara os valores dos gabinetes ao carregar o form

            // Gabinetes -> index 1 a 8
            Double[] valoresGabinetes = { 1890, 1299, 963.99, 2099.99, 399.99, 2599.90, 569.90, 650 };

            //for()
            //{
            //    ((Label)this.Controls.Find($"{TxtValor_Geral}", true)[0]).Value = 0;
            //    ((Label)this.Controls.Find($"{TxtV_Geral}", true)[0]).Value = 0;
            //}

            TxtGabinete1.Text = valoresGabinetes[0].ToString("C");
            TxtGabinete2.Text = valoresGabinetes[1].ToString("C");
            TxtGabinete3.Text = valoresGabinetes[2].ToString("C");
            TxtGabinete4.Text = valoresGabinetes[3].ToString("C");
            TxtGabinete5.Text = valoresGabinetes[4].ToString("C");
            TxtGabinete6.Text = valoresGabinetes[5].ToString("C");
            TxtGabinete7.Text = valoresGabinetes[6].ToString("C");
            TxtGabinete8.Text = valoresGabinetes[7].ToString("C");

            //Prepara os valores dos processadores ao carregar o form

            Decimal Valor9 = Convert.ToDecimal("899");
            Decimal Valor10 = Convert.ToDecimal("1399,00");
            Decimal Valor11 = Convert.ToDecimal("1559,99");
            Decimal Valor12 = Convert.ToDecimal("3199,99");
            Decimal Valor13 = Convert.ToDecimal("969,99");
            Decimal Valor14 = Convert.ToDecimal("2599,90");
            Decimal Valor15 = Convert.ToDecimal("3499,90");
            Decimal Valor16 = Convert.ToDecimal("5239,90");

            TxtProcessador1.Text = Valor9.ToString("C");
            TxtProcessador2.Text = Valor10.ToString("C");
            TxtProcessador3.Text = Valor11.ToString("C");
            TxtProcessador4.Text = Valor12.ToString("C");
            TxtProcessador5.Text = Valor13.ToString("C");
            TxtProcessador6.Text = Valor14.ToString("C");
            TxtProcessador7.Text = Valor15.ToString("C");
            TxtProcessador8.Text = Valor16.ToString("C");

            TxtProcValor1.Text = "899,00";
            TxtProcValor2.Text = "1399,00";
            TxtProcValor3.Text = "1559,99";
            TxtProcValor4.Text = "3199,99";
            TxtProcValor5.Text = "969,99";
            TxtProcValor6.Text = "2599,90";
            TxtProcValor7.Text = "3499,90";
            TxtProcValor8.Text = "5239,90";


            //Prepara os valores das placas mães ao carregar o form

            Decimal Valor17 = Convert.ToDecimal("579,90");
            Decimal Valor18 = Convert.ToDecimal("779,90");
            Decimal Valor19 = Convert.ToDecimal("1749,90");
            Decimal Valor20 = Convert.ToDecimal("3433,90");
            Decimal Valor21 = Convert.ToDecimal("399,99");
            Decimal Valor22 = Convert.ToDecimal("434,90");
            Decimal Valor23 = Convert.ToDecimal("689,90");
            Decimal Valor24 = Convert.ToDecimal("1519,90");

            TxtPlacaMae1.Text = Valor17.ToString("C");
            TxtPlacaMae2.Text = Valor18.ToString("C");
            TxtPlacaMae3.Text = Valor19.ToString("C");
            TxtPlacaMae4.Text = Valor20.ToString("C");
            TxtPlacaMae5.Text = Valor21.ToString("C");
            TxtPlacaMae6.Text = Valor22.ToString("C");
            TxtPlacaMae7.Text = Valor23.ToString("C");
            TxtPlacaMae8.Text = Valor24.ToString("C");

            TxtPlacaMValor1.Text = "579,90";
            TxtPlacaMValor2.Text = "779,90";
            TxtPlacaMValor3.Text = "1749,90";
            TxtPlacaMValor4.Text = "3433,90";
            TxtPlacaMValor5.Text = "1999,90";
            TxtPlacaMValor6.Text = "434,90";
            TxtPlacaMValor7.Text = "689,90";
            TxtPlacaMValor8.Text = "1519,90";

            //Prepara os valores das placas de vídeo ao carregar o form

            Decimal Valor25 = Convert.ToDecimal("1799,90");
            Decimal Valor26 = Convert.ToDecimal("3621,90");
            Decimal Valor27 = Convert.ToDecimal("3799,90");
            Decimal Valor28 = Convert.ToDecimal("2757,03");
            Decimal Valor29 = Convert.ToDecimal("4099,00");
            Decimal Valor30 = Convert.ToDecimal("5899,90");
            Decimal Valor31 = Convert.ToDecimal("12962,90");
            Decimal Valor32 = Convert.ToDecimal("21299,90");

            TxtPlacaVid1.Text = Valor25.ToString("C");
            TxtPlacaVid2.Text = Valor26.ToString("C");
            TxtPlacaVid3.Text = Valor27.ToString("C");
            TxtPlacaVid4.Text = Valor28.ToString("C");
            TxtPlacaVid5.Text = Valor29.ToString("C");
            TxtPlacaVid6.Text = Valor30.ToString("C");
            TxtPlacaVid7.Text = Valor31.ToString("C");
            TxtPlacaVid8.Text = Valor32.ToString("C");

            TxtPlacaVidValor1.Text = "1799,90";
            TxtPlacaVidValor2.Text = "3621,90";
            TxtPlacaVidValor3.Text = "3799,90";
            TxtPlacaVidValor4.Text = "2757,03";
            TxtPlacaVidValor5.Text = "4099,90";
            TxtPlacaVidValor6.Text = "5899,90";
            TxtPlacaVidValor7.Text = "12962,90";
            TxtPlacaVidValor8.Text = "21299,90";

            //Prepara os valores dos "serviços / windows" ao carregar o form

            Decimal Valor33 = Convert.ToDecimal("100,00");
            Decimal Valor34 = Convert.ToDecimal("150,00");
            Decimal Valor35 = Convert.ToDecimal("250,00");
            Decimal Valor36 = Convert.ToDecimal("100,00");
            Decimal Valor37 = Convert.ToDecimal("799,90");
            Decimal Valor38 = Convert.ToDecimal("899,90");
            Decimal Valor39 = Convert.ToDecimal("1199,90");
            Decimal Valor40 = Convert.ToDecimal("1299,90");

            TxtServicos1.Text = Valor33.ToString("C");
            TxtServicos2.Text = Valor34.ToString("C");
            TxtServicos3.Text = Valor35.ToString("C");
            TxtServicos4.Text = Valor36.ToString("C");
            TxtWindows1.Text = Valor37.ToString("C");
            TxtWindows2.Text = Valor38.ToString("C");
            TxtWindows3.Text = Valor39.ToString("C");
            TxtWindows4.Text = Valor40.ToString("C");

            TxtServicosValor1.Text = "100,00";
            TxtServicosValor2.Text = "150,00";
            TxtServicosValor3.Text = "250,00";
            TxtServicosValor4.Text = "100,00";
            TxtWindowsValor1.Text = "799,90";
            TxtWindowsValor2.Text = "899,90";
            TxtWindowsValor3.Text = "1199,90";
            TxtWindowsValor4.Text = "1299,90";

            //Prepara os valores dos "Coolers" ao carregar o form

            Decimal Valor41 = Convert.ToDecimal("398,90");
            Decimal Valor42 = Convert.ToDecimal("410,90");
            Decimal Valor43 = Convert.ToDecimal("169,90");
            Decimal Valor44 = Convert.ToDecimal("559,90");
            Decimal Valor45 = Convert.ToDecimal("419,90");
            Decimal Valor46 = Convert.ToDecimal("949,90");
            Decimal Valor47 = Convert.ToDecimal("1448,90");
            Decimal Valor48 = Convert.ToDecimal("2159,90");

            TxtCooler1.Text = Valor41.ToString("C");
            TxtCooler2.Text = Valor42.ToString("C");
            TxtCooler3.Text = Valor43.ToString("C");
            TxtCooler4.Text = Valor44.ToString("C");
            TxtCooler5.Text = Valor45.ToString("C");
            TxtCooler6.Text = Valor46.ToString("C");
            TxtCooler7.Text = Valor47.ToString("C");
            TxtCooler8.Text = Valor48.ToString("C");

            TxtCoolerValor1.Text = "398,90";
            TxtCoolerValor2.Text = "410,90";
            TxtCoolerValor3.Text = "169,90";
            TxtCoolerValor4.Text = "559,90";
            TxtCoolerValor5.Text = "419,90";
            TxtCoolerValor6.Text = "949,90";
            TxtCoolerValor7.Text = "1448,90";
            TxtCoolerValor8.Text = "2159,90";

            //Prepara os valores dos "Armazenamento" ao carregar o form

            Decimal Valor49 = Convert.ToDecimal("869,90");
            Decimal Valor50 = Convert.ToDecimal("3305,90");
            Decimal Valor51 = Convert.ToDecimal("1399,90");
            Decimal Valor52 = Convert.ToDecimal("649,90");
            Decimal Valor53 = Convert.ToDecimal("1538,90");
            Decimal Valor54 = Convert.ToDecimal("959,90");
            Decimal Valor55 = Convert.ToDecimal("449,92");
            Decimal Valor56 = Convert.ToDecimal("339,90");

            TxtMemoria1.Text = Valor49.ToString("C");
            TxtMemoria2.Text = Valor50.ToString("C");
            TxtMemoria3.Text = Valor51.ToString("C");
            TxtMemoria4.Text = Valor52.ToString("C");
            TxtMemoria5.Text = Valor53.ToString("C");
            TxtMemoria6.Text = Valor54.ToString("C");
            TxtMemoria7.Text = Valor55.ToString("C");
            TxtMemoria8.Text = Valor56.ToString("C");

            TxtMemoriaValor1.Text = "869,90";
            TxtMemoriaValor2.Text = "3305,90";
            TxtMemoriaValor3.Text = "1399,90";
            TxtMemoriaValor4.Text = "649,90";
            TxtMemoriaValor5.Text = "1538,90";
            TxtMemoriaValor6.Text = "959,90";
            TxtMemoriaValor7.Text = "449,92";
            TxtMemoriaValor8.Text = "339,90";

            //Prepara os valores dos "Fontes" ao carregar o form

            Decimal Valor57 = Convert.ToDecimal("949,90");
            Decimal Valor58 = Convert.ToDecimal("459,90");
            Decimal Valor59 = Convert.ToDecimal("779,90");
            Decimal Valor60 = Convert.ToDecimal("359,90");
            Decimal Valor61 = Convert.ToDecimal("2215,62");
            Decimal Valor62 = Convert.ToDecimal("7499,90");
            Decimal Valor63 = Convert.ToDecimal("259,90");
            Decimal Valor64 = Convert.ToDecimal("2352,82");

            TxtFonte1.Text = Valor57.ToString("C");
            TxtFonte2.Text = Valor58.ToString("C");
            TxtFonte3.Text = Valor59.ToString("C");
            TxtFonte4.Text = Valor60.ToString("C");
            TxtFonte5.Text = Valor61.ToString("C");
            TxtFonte6.Text = Valor62.ToString("C");
            TxtFonte7.Text = Valor63.ToString("C");
            TxtFonte8.Text = Valor64.ToString("C");

            TxtFonteValor1.Text = "949,90";
            TxtFonteValor2.Text = "459,90";
            TxtFonteValor3.Text = "779,90";
            TxtFonteValor4.Text = "359,90";
            TxtFonteValor5.Text = "2215,62";
            TxtFonteValor6.Text = "7499,90";
            TxtFonteValor7.Text = "259,90";
            TxtFonteValor8.Text = "2352,82";
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

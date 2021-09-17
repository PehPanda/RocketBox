using System;
using System.Threading;
using System.Windows.Forms;

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

        //Vetores:
        CheckBox[] CBs;
        TextBox[] TXTs;
        NumericUpDown[] NUMs;
        
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
        private void TbcGeral_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Declara os vetores:
            decimal resultado = 0;

            CBs = new CheckBox[64] {

                CbGabinete1, CbGabinete2, CbGabinete3, CbGabinete4, CbGabinete5, CbGabinete6, CbGabinete7, CbGabinete8,
                CbProcessador1, CbProcessador2, CbProcessador3, CbProcessador4, CbProcessador5, CbProcessador6, CbProcessador7, CbProcessador8,
                CbPlacaMae1, CbPlacaMae2, CbPlacaMae3, CbPlacaMae4, CbPlacaMae5, CbPlacaMae6, CbPlacaMae7, CbPlacaMae8,
                CbPlacaVid1, CbPlacaVid2, CbPlacaVid3, CbPlacaVid4, CbPlacaVid5, CbPlacaVid6, CbPlacaVid7, CbPlacaVid8,
                CbServicos1, CbServicos2, CbServicos3, CbServicos4, CbWindows1, CbWindows2, CbWindows3, CbWindows4,
                CbCooler1, CbCooler2, CbCooler3, CbCooler4, CbCooler5, CbCooler6, CbCooler7, CbCooler8,
                CbMemoria1, CbMemoria2, CbMemoria3, CbMemoria4, CbMemoria5, CbMemoria6, CbMemoria7, CbMemoria8,
                CbFonte1, CbFonte2, CbFonte3, CbFonte4, CbFonte5, CbFonte6, CbFonte7, CbFonte8

            };
            TXTs = new TextBox[64] {

                TxtGabValor1, TxtGabValor2, TxtGabValor3, TxtGabValor4, TxtGabValor5, TxtGabValor6, TxtGabValor7, TxtGabValor8,
                TxtProcValor1, TxtProcValor2, TxtProcValor3, TxtProcValor4, TxtProcValor5, TxtProcValor6, TxtProcValor7, TxtProcValor8,
                TxtPlacaMValor1,  TxtPlacaMValor2, TxtPlacaMValor3, TxtPlacaMValor4, TxtPlacaMValor5, TxtPlacaMValor6, TxtPlacaMValor7, TxtPlacaMValor8,
                TxtPlacaVidValor1, TxtPlacaVidValor2, TxtPlacaVidValor3, TxtPlacaVidValor4, TxtPlacaVidValor5, TxtPlacaVidValor6, TxtPlacaVidValor7, TxtPlacaVidValor8,
                TxtServicosValor1, TxtServicosValor2, TxtServicosValor3, TxtServicosValor4, TxtWindowsValor1, TxtWindowsValor2, TxtWindowsValor3, TxtWindowsValor4,
                TxtCoolerValor1, TxtCoolerValor2, TxtCoolerValor3, TxtCoolerValor4, TxtCoolerValor5, TxtCoolerValor6, TxtCoolerValor7, TxtCoolerValor8,
                TxtMemoriaValor1, TxtMemoriaValor2, TxtMemoriaValor3, TxtMemoriaValor4, TxtMemoriaValor5, TxtMemoriaValor6, TxtMemoriaValor7, TxtMemoriaValor8,
                TxtFonteValor1, TxtFonteValor2, TxtFonteValor3, TxtFonteValor4, TxtFonteValor5, TxtFonteValor6, TxtFonteValor7, TxtFonteValor8

            };
            NUMs = new NumericUpDown[64] {

                NudGabinete1, NudGabinete2, NudGabinete3, NudGabinete4, NudGabinete5, NudGabinete6, NudGabinete7, NudGabinete8,
                NudProcessador1, NudProcessador2, NudProcessador3, NudProcessador4, NudProcessador5, NudProcessador6, NudProcessador7, NudProcessador8,
                NudPlacaMae1, NudPlacaMae2, NudPlacaMae3, NudPlacaMae4, NudPlacaMae5, NudPlacaMae6, NudPlacaMae7, NudPlacaMae8,
                NudPlacaVid1, NudPlacaVid2, NudPlacaVid3, NudPlacaVid4, NudPlacaVid5, NudPlacaVid6, NudPlacaVid7, NudPlacaVid8,
                NudServicos1, NudServicos2, NudServicos3, NudServicos4, NudWindows1, NudWindows2, NudWindows3, NudWindows4,
                NudCooler1, NudCooler2, NudCooler3, NudCooler4, NudCooler5, NudCooler6, NudCooler7, NudCooler8,
                NudMemoria1, NudMemoria2, NudMemoria3, NudMemoria4, NudMemoria5, NudMemoria6, NudMemoria7, NudMemoria8,
                NudFonte1, NudFonte2, NudFonte3, NudFonte4, NudFonte5, NudFonte6, NudFonte7, NudFonte8

            };
            if (TbcGeral.SelectedTab.Name == "TbpTotal")
            {
                LtbTotal.Items.Clear();
                TxtTotalIn.Text = "R$ 0,00".ToString();

                for (int i = 0; i < 64; i++)
                {
                    if (CBs[i].Checked == true)
                    {

                        Decimal operacao = Convert.ToDecimal(TXTs[i].Text) * NUMs[i].Value;
                        Decimal Total = decimal.Parse(TXTs[i].Text);

                        LtbTotal.Items.Add(Environment.NewLine + " - " + CBs[i].Text + " - Unidade: " + Total.ToString("C") +
                            " - Quantidade: " + NUMs[i].Value + " - Total: "
                            + operacao.ToString("C") + Environment.NewLine);

                        resultado += (Convert.ToDecimal(TXTs[i].Text) * NUMs[i].Value);
                    }
                }
                TxtTotalIn.Text = resultado.ToString("C");
                TxtTotalOut.Text = resultado.ToString("C");
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
            TxtTotalIn.Text = "R$ 0,00".ToString();
            TxtTotalOut.Text = "R$ 0,00".ToString();

            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }
        // Eventos gerais para a manipulação de valores e quantidades de produtos
        String NudVAL;
        String NudVal_Replaced;
        String CBVAL;
        String CBVal_Replaced;
        private void CBGeneral_Changed(object sender, EventArgs e)
        {
            CheckBox CBReference = (CheckBox)sender;
            NudVAL = CBReference.Name.ToString();
            NudVal_Replaced = NudVAL.Replace("Cb", "Nud");
            if (CBReference.Checked == true) {
                ((NumericUpDown)this.Controls.Find($"{NudVal_Replaced}", true)[0]).Value = 1;
            } else
            {
                ((NumericUpDown)this.Controls.Find($"{NudVal_Replaced}", true)[0]).Value = 0;
            }
        }
        private void NudGeneral_Changed(object sender, EventArgs e)
        {
            NumericUpDown NUDReference = (NumericUpDown)sender;
            CBVAL = NUDReference.Name.ToString();
            CBVal_Replaced = CBVAL.Replace("Nud", "Cb");
            if (NUDReference.Value == 0)
            {
                ((CheckBox)this.Controls.Find($"{CBVal_Replaced}", true)[0]).Checked = false;
            }
            else
            {
                ((CheckBox)this.Controls.Find($"{CBVal_Replaced}", true)[0]).Checked = true;
            }
        }
    }
}

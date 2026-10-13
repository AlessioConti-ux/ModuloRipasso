namespace ModuloRipasso
{
    public partial class Form1 : Form
    {

        List<string> parole = new List<string>();
        List<string> paroleCifrate = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = "";
            int cont = 0;
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoChar = alfabeto.ToCharArray();

            for (int i = 0; i < parole.Count; i++)
            {
                parola = "";
                char[] parolaArray = parole[i].ToCharArray();

                for (int h = 0; h < parolaArray.Length; h++)
                {
                    cont = 0;

                    while (parolaArray[h] != alfabetoChar[cont])
                    {
                        cont = cont + 1;
                    }

                    if (cont > 2)
                    {
                        cont = cont - 3;
                    }
                    else
                    {
                        cont = alfabetoChar.Length - (3 - cont);
                    }

                    parolaArray[h] = alfabeto[cont];
                }

                for (int k = 0; k < parolaArray.Length; k++)
                {
                    parola = parola + parolaArray[k];
                }
                lstFrasi.Items.Add(parola);
                paroleCifrate.Add(parola);
            }
 
        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
                int i = 1;
                using (StreamReader sr = new StreamReader("frasi.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                       
                        string riga = sr.ReadLine();

                        if ( i % 2 == 0 ) {

                        parole.Add(riga);

                        }
                        i = i + 1;

                    }

                }
        }
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

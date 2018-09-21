using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NumberExplorer
{
    public partial class Form1 : Form
    {
        private bool isPrime;
        private int[] primeList;
        private List<int> factors;
        private List<int> squares;
        private List<int> cubes;

        Settings settings = new Settings();
        HelpForm helpForm;

        public Form1()
        {
            InitializeComponent();

            numericUpDown.Value = 39;
  
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Changed value");

            //numericUpDown.Anchor = AnchorStyles.None;
            //Point p = numericUpDown.Location;
            //p.X = this.Width - numericUpDown.Width / 2;

            Calculate_all();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }

            //AboutForm ab = new AboutForm
            //{
            //    StartPosition = FormStartPosition.CenterParent
            //};


            //ab.ShowDialog();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //numericUpDown.Left = (this.Width - numericUpDown.Width) / 2;
            //numericUpDown.Top = (this.Height - numericUpDown.Height) / 2;

            //numericUpDown.Show();
        }

        private void Make_primes(int n)
        {
            // first check to see if we are still in valid int territory?

             if(n < 2)
            {
                primeList = new int[0];
                return;
            }

            int half = n / 2 + 1;

            primeList = new int[half];

            // find primes less than sqrt of N
            primeList[0] = primeList[1] = 1;
            for (int p = 2; p < half; p++)
            {

                if (primeList[p] == 0)
                {
                    // p is prime
                    int q = 2;
                    while (p * q < half)
                    {
                        primeList[p * q] = 1;
                        q++;
                    }
                }
            }
        }

        private void Decompose(int n)
        {
            int d = n;

            StringBuilder decomp = new StringBuilder("");

            for (int p = 2; p < primeList.Length; p++)
            {
                // prime decomp
                while (p * (d / p) == d)
                {
                    d = d / p;

                    if (decomp.Length != 0)
                    {
                        decomp.AppendFormat(" x ");
                    }
                    decomp.AppendFormat("{0}", p);
                    //decomp.AppendLine();
                }
            }

            if (decomp.Length == 0 && n > 1)
            {
                decomp.AppendFormat("{0} is prime.", n);
                isPrime = true;
                richTextBox1.AppendText(decomp.ToString() + Environment.NewLine);
            }
            else
            {
                isPrime = false;
                richTextBox1.AppendText("Prime decomposition is " + decomp.ToString() + Environment.NewLine);
            }
        }

        private int Is_perfect_square(int n)
        {
            int root = (int)Math.Sqrt(n);

            if (n == root * root)
            {
                return root;
            }
            else
            {
                return 0;
            }
        }

        private int Is_perfect_cube(int n)
        {
            int root = (int)Math.Pow(n, 1.0/3.0);

            if (n == root * root * root)
            {
                return root;
            }
            else
            {
                return 0;
            }
        }

        void Factorize(int n)
        {
            int half = n / 2;

            factors = new List<int>();

            for(int i = 2; i <= half; i++)
            {
                if( n == i * (n / i))
                {
                    factors.Add(i);
                }
            }

        }

        // shapes

        int IsTriangular(int n)
        {
            // n is triangular if sqrt(8n + 1) is an odd integer
            double x = (Math.Sqrt(8 * n + 1) - 1)/2;
            if (x - (int)(x) > 0)
            {
                return 0;
            }
            else
            {
                return (int)x;
            }
        }

        int IsPentagonal(int n)
        {
            double pent = (Math.Sqrt(24 * n + 1) + 1) / 6;
            if(pent - (int)pent == 0)
            {
                return (int)pent;
            }
            else
            {
                return 0;
            }
        }

        int IsHexagonal(int n)
        {
            double hex = (Math.Sqrt(8 * n + 1) + 1) / 4;
            if (hex - (int)hex == 0)
            {
                return (int)hex;
            }
            else
            {
                return 0;
            }
        }
        bool IsPerfect(int n)
        {
            int sum = 1;
            foreach(int f in factors)
            {
                sum += f;
            }
            if( sum == n)
            {
                return true;
            }
            return false;
        }

        string IsSumOfTwoSquares(int n)
        {
            return IsSumOfTwoSquares(n, 0);
        }

        string IsSumOfTwoSquares(int n, int restrict)
        {
            string s = "";

            if (squares.Count > 1)
            {
                for (int i = restrict; i < squares.Count - 1; i++)
                {
                    for (int j = i + 1; j < squares.Count; j++)
                    {
                        if (n == squares[i] * squares[i] + squares[j] * squares[j])
                        {
                            s = string.Format("{0}\u00B2 + {1}\u00B2", squares[i], squares[j]) + Environment.NewLine;
                        }
                    }
                }
            }
            return s;
        }

        string IsSumOfTwoCubes(int n)
        {
            return IsSumOfTwoCubes(n, 0);
        }

        string IsSumOfTwoCubes(int n, int restrict)
        {
            string s = "";

            if (cubes.Count > 1)
            {
                for (int i = restrict; i < cubes.Count - 1; i++)
                {
                    for (int j = i + 1; j < cubes.Count; j++)
                    {
                        if (n == cubes[i] * cubes[i] * cubes[i] + cubes[j] * cubes[j] * cubes[j])
                        {
                            s = string.Format("{0}\u00B3 + {1}\u00B3", cubes[i], cubes[j]) + Environment.NewLine;
                        }
                    }
                }
            }
            return s;
        }


        /*
         * Hat tip to Pavel Vladov
         * 
         * https://www.pvladov.com/2012/05/decimal-to-arbitrary-numeral-system.html
         * 
         */
        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }

        private void Calculate_all()
        {
            int n = (int)numericUpDown.Value;

            richTextBox1.AppendText(String.Format("Properties of {0}: ", n) + Environment.NewLine);

            Make_primes(n);

            Decompose(n);

            int root;
            root = Is_perfect_square(n);
            if (root != 0 && settings.bSquare)
            {
                richTextBox1.AppendText(String.Format("{1} is a perfect square with root {0}", root, n) + Environment.NewLine);
            }
            root = Is_perfect_cube(n);
            if (root != 0 && settings.bCube)
            {
                richTextBox1.AppendText(String.Format("{1} is a perfect cube with root {0}", root, n) + Environment.NewLine);
            }
            if (!isPrime)
            {
                Factorize(n);

                StringBuilder sb = new StringBuilder();
                foreach (int f in factors)
                {
                    if (sb.Length == 0)
                    {
                        sb.AppendFormat("{0}", f);
                    }
                    else
                    {
                        sb.AppendFormat(", {0}", f);
                    }

                }
                richTextBox1.AppendText("Factors are 1, " + sb + Environment.NewLine);
            }

            if (settings.bTri)
            {
                int tri = IsTriangular(n);
                if (tri != 0)
                {
                    richTextBox1.AppendText(string.Format("Is triangular number {0}", tri) + Environment.NewLine);
                }
            }

            if (settings.bPent)
            {
                int pent = IsPentagonal(n);
                if (pent != 0)
                {
                    richTextBox1.AppendText(string.Format("Is pentagonal number {0}", pent) + Environment.NewLine);
                }
            }

            if (settings.bHex)
            {
                int hex = IsHexagonal(n);
                if (hex != 0)
                {
                    richTextBox1.AppendText(string.Format("Is hexagonal number {0}", hex) + Environment.NewLine);
                }
            }

            if (settings.bPerfect)
            {
                if (IsPerfect(n))
                {
                    richTextBox1.AppendText(string.Format("Is a perfect number") + Environment.NewLine);
                }
            }


            // could be simpler just knowing largest square or cube root less than n, but...
            // refactor later :)
            // list of squares, cubes less than n
            squares = new List<int>();
            cubes = new List<int>();

            for( int x = 1; x*x < n; x++)
            {
                squares.Add(x);
            }
            for (int x = 1; x * x * x < n; x++)
            {
                cubes.Add(x);
            }

            if (settings.bSum2Cubes)
            {
                richTextBox1.AppendText(IsSumOfTwoSquares(n));
            }
            

            /// sum of three squares
            if(settings.bSum3Squares && squares.Count > 1)
            {
                for(int sq = 0; sq < squares.Count; sq++)
                {
                    int remnant = n - squares[sq] * squares[sq];

                    string s = IsSumOfTwoSquares(remnant, sq);

                    if(s.Length != 0)
                    {
                        richTextBox1.AppendText(string.Format("{0}\u00B2 + {1}", squares[sq], s));
                    }
                }
            }

            // two cubes
            if (settings.bSum2Cubes)
            {
                richTextBox1.AppendText(IsSumOfTwoCubes(n));
            }
            

            // sum of three cubes
            if (settings.bSum3Cubes && cubes.Count > 1)
            {
                for (int cu = 0; cu < cubes.Count; cu++)
                {
                    int remnant = n - cubes[cu] * cubes[cu];

                    string s = IsSumOfTwoCubes(remnant, cu);

                    if (s.Length != 0)
                    {
                        richTextBox1.AppendText(string.Format("{0}\u00B3 + {1}", cubes[cu], s));
                    }
                }
            }

            // repunits: try bases 2..16, look for simple patterns

            if (settings.bRepunit)
            {
                for (int radix = 2; radix < 17; radix++)
                {
                    if (radix == 10) continue;// we already have this result :)

                    string s = DecimalToArbitrarySystem(n, radix);

                    if (s.Length > 2)
                    {
                        string rep = new string(s.Substring(0, 1).ToCharArray()[0], s.Length);

                        if (s.Equals(rep))
                        {
                            richTextBox1.AppendText(string.Format("In base {0} is {1}", radix, rep) + Environment.NewLine);
                        }
                    }
                }
            }

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.ScrollToCaret();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog(this);
            
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string
            byte[] sst = GetEmbeddedResource("NumberExplorer.Resources.NumberExplorerHelp.pdf");

            string temp = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "NEH.pdf");
            //FileStream f = new FileStream(temp, FileMode.Create, FileAccess.ReadWrite);
            //f.Write((byte[])sst.ToCharArray(), 0, sst.ToCharArray().Length);

            if (!File.Exists(temp))
            {
                File.WriteAllBytes(temp, sst);
               // File.WriteAllText(temp, sst);
            }
            helpForm = new HelpForm();

            helpForm.axAcroPDF1.src = temp;
            helpForm.Show();
        }

        // string
        byte[] GetEmbeddedResource(string res)
        {
            var auxList = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();

            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res);

            BinaryReader r = new BinaryReader(stream);
            

            byte[] bytes = new byte[1024];
            int ilen = r.Read(bytes, 0, 1024);
            int totalLen = ilen;
            while(ilen == 1024)
            {
                ilen = r.Read(bytes, 0, 1024);
                totalLen += ilen;
            }
            stream.Position = 0;
            
            byte[] ret = new byte[totalLen];
            r.Read(ret, 0, totalLen);
            r.Dispose();

            return ret;//;reader.ReadToEnd();
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

    }
}

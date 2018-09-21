using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberExplorer
{
    public partial class Settings : Form
    {
        public bool bTri;
        public bool bSquare;
        public bool bPent;
        public bool bHex;
        public bool bCube;
        public bool bSum2Squares;
        public bool bSum2Cubes;
        public bool bSum3Squares;
        public bool bSum3Cubes;
        public bool bPerfect;
        public bool bRepunit;

        public Settings()
        {
            InitializeComponent();

            SaveChecks();
        }


        private void checkBoxAny_Click(object sender, EventArgs e)
        {

    }

        private void button_OK_Click(object sender, EventArgs e)
        {
            SaveChecks();

            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SaveChecks();
            button1.Focus();
        }

        private void SaveChecks()
        {
            bTri = checkTri.Checked; ;
            bSquare = checkSquare.Checked; ;
            bPent = checkPent.Checked; ;
            bHex = checkHex.Checked; ;
            bCube = checkCube.Checked; ;
            bSum2Squares = checkSum2Squares.Checked; ;
            bSum2Cubes = checkSum2Cubes.Checked; ;
            bSum3Squares = checkSum3Squares.Checked; ;
            bSum3Cubes = checkSum3Cubes.Checked; ;
            bPerfect = checkPerfect.Checked; ;
            bRepunit = checkRepunit.Checked; ;
        }
        private void RestoreChecks()
        {

        }
    }
}

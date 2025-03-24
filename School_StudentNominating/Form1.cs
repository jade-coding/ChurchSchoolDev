using formsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace School_StudentNominating
{
    public partial class Form1 : Form
    {
        public Timer timer;
        public Image[] images;
        public int iCurrentIndex = -1;
        public IniFile IniHandler;
        public string configPath;
        public Dictionary<string, string> DicClassImage;

        public Form1()
        {
            InitializeComponent();
            InitConfig();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitConfig()
        {
            configPath = "\\config.ini";
            IniHandler

        }
    }

    
}

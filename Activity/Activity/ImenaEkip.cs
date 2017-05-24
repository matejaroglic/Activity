using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity
{
    public partial class ImenaEkip : Form
    {
        public ImenaEkip()
        {
            InitializeComponent();
        }

        private void gumb_preimenuj_Click(object sender, EventArgs e)
        //na datoteko imena.txt vnesemo nova imena ekip
        {
            StreamWriter dat = new StreamWriter(@"..\..\Resources\imena.txt");
            TextBox[] novaImena = new TextBox[4] { ime_ekipa1, ime_ekipa2, ime_ekipa3, ime_ekipa4 };
            for (int i = 0; i < 4; i++)
            {
                dat.WriteLine(novaImena[i].Text);
            }
            dat.Close();
            //ponovno zaženemo aplikacijo, da se imena posodobijo
            Application.Restart();
        }
    }
}

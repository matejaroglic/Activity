using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity
{
    public partial class Form1 : Form
    {
        //Seznami besed po težavnosti
        List<string> lahke = new List<string>();
        List<string> srednje = new List<string>();
        List<string> tezke = new List<string>();

        List<string> nacinUgibanja = new List<string> { "NARIŠI", "RAZLOŽI", "PANTOMIMA" };
        //seznam stEkipe potrebujemo za izpisovanje - da povemo katera ekipa je na vrsti
        List<string> stEkipe = new List<string>();
        int tezavnost;
        int tockeZaZmago;
        //fiksen čas ugibanja - uporabnik lahko izbere
        int cas_ugibanja = 60;
        //ta čas odštevamo
        int cas=60;
        //vodimo stevilo ugibanj, da lahko izračunamo indeks ekipe, ki je na vrsti
        int stUgibanj = 0;
        List<Label> tockeEkip = new List<Label> { };

        //zvoka za začetek ugibanja, potečen čas in opozorilo za zadnjih 10 sekund
        System.Media.SoundPlayer zvok_tik = new System.Media.SoundPlayer(@"..\..\Resources\Tick.wav");
        System.Media.SoundPlayer zvok_zacni = new System.Media.SoundPlayer(@"..\..\Resources\Glass.wav");

        public Form1()
        {
            InitializeComponent();
            //preberemo imena ekip iz datoteke imena.txt
            StreamReader dat = new StreamReader(@"..\..\Resources\imena.txt");
            CheckBox[] ekipe = new CheckBox[4] { izberi_ekipa1, izberi_ekipa2, izberi_ekipa3, izberi_ekipa4 };
            for (int i = 0; i < 4; i++)
            {
                string s = dat.ReadLine();
                ekipe[i].Text = s;
            }
            dat.Close();
            
        }

        //navodila, izhod in nova igra v glavnem meniju
        private void navodilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navodila n = new Activity.Navodila();
            n.ShowDialog();
        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void preimenujEkipeToolStripMenuItem_Click(object sender, EventArgs e)
        //odpremo novo formo - ImenaEkip, kjer lahko spremenimo imena ekip
        {
            ImenaEkip imena = new Activity.ImenaEkip();
            imena.ShowDialog();
        }

        //izbira časa ugibanja
        private void cas_30_Click(object sender, EventArgs e)
        {
            cas_ugibanja = 30;
            cas = 30;
            stej_cas.Text = "30";
        }

        private void cas_60_Click(object sender, EventArgs e)
        {
            cas_ugibanja = 60;
            cas = 60;
            stej_cas.Text = "60";
        }

        private void cas_90_Click(object sender, EventArgs e)
        {
            cas_ugibanja = 90;
            cas = 90;
            stej_cas.Text = "90";
        }

        private void izberiDatotekoToolStripMenuItem_Click(object sender, EventArgs e)
        //uporabnik si izbere poljubno datoteko iz mape dat_besed, glede na izbrano
        //datoteko napolnimo sezname besed (lahke,srednje,tezke)
        {
            OpenFileDialog izberi = new OpenFileDialog();
            //omejimo izbiro le na txt datoteke
            izberi.Filter = "Text Files|*.txt";
            //nastavimo začetno mapo na dat_besede, kjer shranjujemo datoteke z besedami
            //tu si uporabnik izbere poljubno datoteko
            izberi.InitialDirectory = Path.Combine(Path.GetDirectoryName(Application.StartupPath), "dat_besede");
            izberi.Title = "Izberi datoteko";
            if (izberi.ShowDialog() == DialogResult.OK)
            {
                //izpraznimo sezname besed, če smo slučajno med igro spremenili
                //datoteko in dodamo nove besede 
                lahke.Clear();
                srednje.Clear();
                tezke.Clear();
                //pokličemo metodo napolni_sezname s potjo do datoteke, ki smo jo izbrali
                napolni_sezname(izberi.FileName);
            }
        }


        private void DodajDatotekoToolStripMenuItem_Click(object sender, EventArgs e)
        //uporabnik doda svojo datoteko z besedami, ki si jo izbere iz računalnika v mapo
        //dat_besede, kjer jo potem lahko izbere v meniju z izbiro Izberi datoteko
        {
            OpenFileDialog dodaj = new OpenFileDialog();
            //omejimo izbiro le na txt datoteke
            dodaj.Filter = "Text Files|*.txt";
            dodaj.InitialDirectory = Path.Combine(@"C:");
            dodaj.Title = "Dodaj datoteko z računalnika";
            if (dodaj.ShowDialog() == DialogResult.OK)
            {
                //uporabila sem File.Copy(source, destination) - izbrano datoteko z
                //računalnika kopira v interno mapo dat_besede
                string dat = dodaj.FileName;
                string pot = Path.Combine(Path.GetDirectoryName(Application.StartupPath), "dat_besede");
                File.Copy(dat, Path.Combine(pot, Path.GetFileNameWithoutExtension(dat) + ".txt"));
            }
        }

        private void napolni_sezname(string pot)
        //glede na izbrano datoteko napolni sezname besed
        {
            using (StreamReader beri = File.OpenText(pot))
            {
                //preberemo prvo vrstico, kjer piše "Lahke" in vstavimo te besede v seznam lahke
                string s = beri.ReadLine();
                while ((s = beri.ReadLine()) != "Srednje")
                {
                    lahke.Add(s);
                }
                //vstavimo srednje težke besede v seznam srednje
                while ((s = beri.ReadLine()) != "Tezke")
                {
                    srednje.Add(s);
                }
                //vstavimo še težke besede v seznam tezke
                while ((s = beri.ReadLine()) != null)
                {
                    tezke.Add(s);
                }
            }
        }

        private string GenerirajNovoBesedo()
        //Izbere naključno besedo iz seznamov besed, glede na to 
        //katera težavnost je izbrana. Nastavi tudi težavnost.
        {
            Random gen = new Random();
            int indeks;
            string beseda;
            if (tezavnost_3.Checked)
            {
                indeks = gen.Next(lahke.Count);
                beseda = lahke[indeks];
                tezavnost = 3;
            }
            else if (tezavnost_4.Checked)
            {
                indeks = gen.Next(srednje.Count);
                beseda = srednje[indeks];
                tezavnost = 4;
            }
            else
            {
                indeks = gen.Next(tezke.Count);
                beseda = tezke[indeks];
                tezavnost = 5;
            }
            return beseda;
        }

        private string GenerirajNacinUgibanja()
        //naključno izbere način ugibanja
        {
            Random gen = new Random();
            int indeks = gen.Next(3);
            string nacin = nacinUgibanja[indeks];
            return nacin;
        }


        private void gumb_ok_Click(object sender, EventArgs e)
        {
            //če si nismo izbrali datotebe z besedami uporabimo privzeto, ki se nahaja
            //v mapi Resources. Predpostavila sem, da se mora v datotekah nahajati vsaj ena beseda vsake 
            //težavnosti, da je sploh smiselno imeti tri težavnosti
            if (lahke.Count == 0) napolni_sezname(@"..\..\Resources\besede1.txt");
            //pogledamo katere ekipe(CheckBox) so izbrane, pri teh ekipah nastavimo št. točk na 0
            //in dodamo te komponente (Label) v seznam tockeEkip
            CheckBox[] ekipe = new CheckBox[4] { izberi_ekipa1, izberi_ekipa2, izberi_ekipa3, izberi_ekipa4 };
            Label[] tocke = new Label[4] { tocke_ekipa1, tocke_ekipa2, tocke_ekipa3, tocke_ekipa4 };
            for (int i = 0; i < 4; i++)
            {
                if (ekipe[i].Checked)
                {
                    tockeEkip.Add(tocke[i]);
                    tocke[i].Text = "0";
                    stEkipe.Add(ekipe[i].Text);
                }
            }
            //da je igra smiselna morajo biti izbrani vsaj dve ekipi
            if (stEkipe.Count < 2) MessageBox.Show("Izberi vsaj dve ekipi!");
            else
            {
                //nastavimo izbrane točke za zmago in naredimo ustrezne gumbe neodzivne
                if (tocke_50.Checked) tockeZaZmago = 50;
                else if (tocke_100.Checked) tockeZaZmago = 100;
                else if (tocke_150.Checked) tockeZaZmago = 150;
                tocke_50.Enabled = false;
                tocke_100.Enabled = false;
                tocke_150.Enabled = false;
                preimenujEkipeToolStripMenuItem.Enabled = false;
                časUgibanjasToolStripMenuItem.Enabled = false;
                izberi_ekipa1.Enabled = false;
                izberi_ekipa2.Enabled = false;
                izberi_ekipa3.Enabled = false;
                izberi_ekipa4.Enabled = false;
                //omogočimo klik na gumb zacni
                gumb_zacni.Enabled = true;
                //izbrišemo začetna navodila
                zacetek_navodila.Text = "";
                gumb_ok.Visible = false;
                //v info napišemo, da je na vrsti prva ekipa
                info.Text = "Na vrsti je ekipa: " + stEkipe[0];
            }
        }


        private int indeks_ekipe()
        //tukaj vodimo indeks ekipe, ki je na vrsti
        {
            int stEkip = tockeEkip.Count;
            return stUgibanj % stEkip;
        }

        private void gumb_zacni_Click(object sender, EventArgs e)
        //dogodki ko kliknemo na gumb začni
        {
            zvok_zacni.Play();
            
            info.Text = "";
            gumb_zacni.Enabled = false;
            gumb_uganil.Enabled = true;
            gumb_prekini.Enabled = true;
            tezavnost_3.Enabled = false;
            tezavnost_4.Enabled = false;
            tezavnost_5.Enabled = false;
            
            //začne se odštevati čas in izpiše se beseda, ki ustreza izbrani
            //težavnosti ter način ugibanja
            odstevanje.Start();
            izpis_beseda.Text = "BESEDA:  " + GenerirajNovoBesedo();
            string nacin = GenerirajNacinUgibanja();
            izpis_nacin_ugibanja.Text = "NAČIN UGIBANJA:  " + nacin;
            //poiščemo in prikažemo ustrezno sliko za način ugibanja
            zacetek_navodila.ImageIndex = nacinUgibanja.IndexOf(nacin);

        }

        private void odstevanje_Tick(object sender, EventArgs e)
        //za odštevanje časa
        {
            stej_cas.Text = cas.ToString();
            cas--;
            //zadnjih 10s se oglaša zvok (tiktakanje ure)
            if (cas<10) zvok_tik.Play();
            if (cas < 0)
            {
            //če čas poteče se zgodi enako kot če se tekmovalec zmoti - ekipa ne dobi točk 
                zvok_zacni.Play();
                gumb_prekini_Click(null, null);
            }
        }


        private void gumb_prekini_Click(object sender, EventArgs e)
        {
            //če kliknemo na gumb prekini pomeni, da se je tekmovalec zmotil
            //in zato ne dobi točk, čas nastavimo nazaj na 60 in nastavimo gumbe
            stUgibanj++;
            //sporočimo katera ekipa je naslednja na vrsti
            info.Text = "Na vrsti je ekipa: " + stEkipe[indeks_ekipe()];
            odstevanje.Stop();
            cas = cas_ugibanja;
            gumb_zacni.Enabled = true;
            gumb_uganil.Enabled = false;
            gumb_prekini.Enabled = false;
            tezavnost_3.Enabled = true;
            tezavnost_4.Enabled = true;
            tezavnost_5.Enabled = true;
        }

        private void gumb_uganil_Click(object sender, EventArgs e)
        {
            //tekmovalec je uganil besedo - ekipi dodelimo točke in preverimo
            //če je ekipa dosegla dovolj točk za zmago
            int i = indeks_ekipe();
            //ekipa dobi toliko točk, kot je bila težavnost besede
            tockeEkip[i].Text = (int.Parse(tockeEkip[i].Text) + tezavnost).ToString();
            if ((int.Parse(tockeEkip[i].Text) >= tockeZaZmago))
            {
                tockeEkip[i].Text = "ZMAGOVALCI";
                odstevanje.Stop();
                gumb_zacni.Enabled = false;
                gumb_uganil.Enabled = false;
                gumb_prekini.Enabled = false;
                info.Text = "Zmagovalec je: " + stEkipe[i];
            }
            else gumb_prekini_Click(null, null);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toomsalu_taringumang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TT_alustaUutManguButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7), dice2 = rnd.Next(1, 7), dice3 = rnd.Next(1, 7), dice4 = rnd.Next(1, 7);
            int jukuPunktid; int peetriPunktid;

            TT_mangibJukuButton.Enabled = true;                    
                        if(TT_mangibJukuButton.Enabled == true)
                        {
                            TT_jukuTaring1.Text = dice1.ToString();
                            TT_jukuTaring2.Text = dice2.ToString();
                            jukuPunktid = dice1 + dice2;
                            TT_jukuPunktidText.Text = jukuPunktid.ToString();
                            TT_mangibJukuButton.Enabled = false;

                            TT_mangibPeeterButton.Enabled = true;
                            TT_peeterTaring1.Text = dice3.ToString();
                            TT_peeterTaring2.Text = dice4.ToString();
                            peetriPunktid = dice3 + dice4;
                            TT_peeterPunktidText.Text = peetriPunktid.ToString();
                            TT_mangibJukuButton.Enabled = false;

                            if (peetriPunktid > jukuPunktid)
                            {
                                TT_kesVoitis.Text = "Peeter võitis";
                            } else if(peetriPunktid<jukuPunktid)
                            {
                                TT_kesVoitis.Text = "Juku võitis";
                            } else
                            {
                                TT_kesVoitis.Text = "Viik";

                            }
                            TT_alustaUutManguButton.Enabled = true;
                        }
        }
    }
}

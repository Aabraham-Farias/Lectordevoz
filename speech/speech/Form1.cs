using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;


namespace speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SpeechSynthesizer voz;
        List<VoiceInfo> listarvoces = new List<VoiceInfo>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voz = new SpeechSynthesizer();
            foreach(InstalledVoice x in voz.GetInstalledVoices())
            {
                listarvoces.Add(x.VoiceInfo);
                comboBox1.Items.Add(x.VoiceInfo.Name);
            }
            comboBox1.SelectedIndex = 0;

          

            string nombrevoces_1 = listarvoces.ElementAt(0).Name;
            voz.SelectVoice(nombrevoces_1);
            voz.Volume = 100;
            voz.Rate = 0;
            voz.SpeakAsync("Welcome Abraham");


        }

        private void Leer_Click(object sender, EventArgs e)
        {
            voz = new SpeechSynthesizer();
            int ind;
            double volumen = trackBar1.Value;
            double velocidad = trackBar2.Value;

            ind = comboBox1.SelectedIndex;
            string nombrevoces = listarvoces.ElementAt(ind).Name;
            voz.SelectVoice(nombrevoces);
            voz.Volume =(int) volumen;
            voz.Rate = (int)velocidad;
            voz.SpeakAsync(textBox1.Text);
        }

        private void Pausar_Click(object sender, EventArgs e)
        {
            if(voz!= null)
            {
                if(voz.State == SynthesizerState.Speaking)
                {
                    voz.Pause();
                }
                else if( voz.State == SynthesizerState.Paused)
                {
                    voz.Resume();
                }
            }
        }

        private void Detener_Click(object sender, EventArgs e)
        {
            if(voz != null)
            {
                voz.Dispose();
            }
        }
    }
}

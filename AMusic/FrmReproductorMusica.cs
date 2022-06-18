using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMusic.Clases;
using System.Collections;
using System.Net;

namespace AMusic
{
    
    public partial class FrmReproductorMusica : Form
    {
        int startIndex;
        bool isPlaying = true;

        /*
        public bool isPlaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;
                if (_playing)
                {
                    player.Ctlcontrols.pause();
                    btnPausa.Image = play.Image;
                }
                else
                {
                    player.Ctlcontrols.play();
                    btnPausa.Image = pause.Image;
                }
            }
        }*/

        ArrayList listaCanciones = new ArrayList();

        public FrmReproductorMusica()
        {

        }

        public FrmReproductorMusica(ArrayList listaCanciones, int startIndex)
        {
            InitializeComponent();
            this.listaCanciones = listaCanciones;
            this.startIndex = startIndex;
            stopPlayer();
            anadirLista(listaCanciones);
            lstCanciones.SelectedIndex = startIndex;
            barSonido.Value = 100;
            startPlayer(startIndex);

        }

        public void stopPlayer()
        {
            player.Ctlcontrols.stop();
        }


        //public EventHandler onAction = null;


        private void siguiente()
        {
            //proCancion.Value = 0;
            if (startIndex == lstCanciones.Items.Count - 1)
            {
                //startIndex = lstCanciones.Items.Count - 1;

                startIndex = 0;
                lstCanciones.SelectedIndex = startIndex;
            }
            else if (startIndex < lstCanciones.Items.Count)
            {
                startIndex = startIndex + 1;
                lstCanciones.SelectedIndex = startIndex;
            }

            startPlayer(startIndex);
        }


        private void startPlayer(int i)
        {
            Cancion c = (Cancion)listaCanciones[i];
            player.URL = c.cancion;
            player.Ctlcontrols.next();
            player.Ctlcontrols.play();

            var request = WebRequest.Create(c.caratula);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                picCaratula.Image = Bitmap.FromStream(stream);
            }

            lblArtista.Text = c.artista;
            lblTitulo.Text = c.nombre;
        }

        private void anadirLista(ArrayList listaCanciones)
        {

            for (int i = 0; i < listaCanciones.Count; i++)
            {

                Cancion c = (Cancion)listaCanciones[i];
                lstCanciones.Items.Add(c.nombre);
            }


        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                proCancion.MaximumValue = (int)player.Ctlcontrols.currentItem.duration;
                timCancion.Start();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timCancion.Stop();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timCancion.Stop();
                proCancion.Value = 0;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (startIndex > 0)
            {
                startIndex = startIndex - 1;
                lstCanciones.SelectedIndex = startIndex;
            }
            isPlaying = true;
            btnPausa.Image = pause.Image;
            startPlayer(startIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
            isPlaying = true;
            btnPausa.Image = pause.Image;
            
        }

        private void timCancion_Tick(object sender, EventArgs e)
        {
            lblTiempo1.Text = player.Ctlcontrols.currentPositionString;
            lblTiempo2.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                proCancion.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            stopPlayer();
            isPlaying = false;
            lblTiempo1.Text = "0:00";
            btnPausa.Image = Properties.Resources.play2;
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            //isPlaying = !isPlaying;

            if (isPlaying)
            {
                player.Ctlcontrols.pause();
                btnPausa.Image = Properties.Resources.play2;
                isPlaying = false;
            } else
            {
                player.Ctlcontrols.play();
                btnPausa.Image = Properties.Resources.pase;
                isPlaying = true;

            }

            /*
            if (onAction != null)
            {
                onAction.Invoke(this, e);
            }*/
        }

        private void pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void barSonido_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            player.settings.volume = barSonido.Value;
            lblSonido.Text = barSonido.Value.ToString();

            if (int.Parse(lblSonido.Text) > 50)
            {
                imaSonido.Image = Properties.Resources.sound;
            }
            else if (int.Parse(lblSonido.Text) == 0)
            {
                imaSonido.Image = Properties.Resources.muteSound;
            }
            else
            {
                imaSonido.Image = Properties.Resources.sonido1;
            }

        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            startIndex = lstCanciones.SelectedIndex;
            startPlayer(startIndex);
        }
    }
}


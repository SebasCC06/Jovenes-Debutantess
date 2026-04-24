using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jovenes_Debutantes
{
    public partial class Jugador : Form
    {
        public Jugador()
        {
            InitializeComponent();
        }
        private void ResetBotones()
        {
            btnInicio.BackColor = Color.FromArgb(30, 41, 59);
            btnJugadores.BackColor = Color.FromArgb(30, 41, 59);
            btnPerfil.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void Jugador_Load(object sender, EventArgs e)
        {
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnJugadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            ResetBotones();
            btnJugadores.BackColor = Color.FromArgb(59, 130, 246);

            panelContenido.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = "Pantalla de jugadores";
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(50, 50);

            panelContenido.Controls.Add(lbl);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ResetBotones();
            btnInicio.BackColor = Color.FromArgb(59, 130, 246);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ResetBotones();
            btnPerfil.BackColor = Color.FromArgb(59, 130, 246);
        }
    }
}

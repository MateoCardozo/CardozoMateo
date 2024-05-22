using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardozoMateo
{
    internal class Teatros
    {


        public PictureBox imgAsientos;
        public PictureBox imgEscenario; 


        public void CrearEscenario()
        {


            imgEscenario = new PictureBox();
            imgEscenario.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEscenario.Image = Properties.Resources.Escenario;
            imgEscenario.Size = new System.Drawing.Size(50,50);
            imgEscenario.Location = new System.Drawing.Point(210, 400);


        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ProjetoLED
{
    public partial class Form1 : Form
    {
        private Leds leds;

        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            AtualizarEstadoLeds();
            
        }
        private void AtualizarEstadoLeds()

        {
            label1.Text = leds.getEstado().ToString();

            button1.Text = (leds.getEstado(1) ? "OFF" : "ON");
            button2.Text = (leds.getEstado(2) ? "OFF" : "ON");
            button3.Text = (leds.getEstado(3) ? "OFF" : "ON");
            button4.Text = (leds.getEstado(4) ? "OFF" : "ON");
            button5.Text = (leds.getEstado(5) ? "OFF" : "ON");
            button6.Text = (leds.getEstado(6) ? "OFF" : "ON");
            button7.Text = (leds.getEstado(7) ? "OFF" : "ON");
            button8.Text = (leds.getEstado(8) ? "OFF" : "ON");
        }

        private void btn1(object sender, EventArgs e)
        {

            Estado(1);
            AtualizarEstadoLeds();

        }

            private void btn2(object sender, EventArgs e)
            {
            Estado(2);
                AtualizarEstadoLeds();
            }

            private void btn3(object sender, EventArgs e)
            {
                Estado(3);
                AtualizarEstadoLeds();
            }

            private void btn4(object sender, EventArgs e)
            {
                Estado(4);
                AtualizarEstadoLeds();
            }

            private void btn6(object sender, EventArgs e)
            {
                Estado(6);
                AtualizarEstadoLeds();
            }

            private void btn5(object sender, EventArgs e)
            {
                Estado(5);
                AtualizarEstadoLeds();
            }

            private void btn7(object sender, EventArgs e)
            {
                Estado(7);
                AtualizarEstadoLeds();
            }

            private void btn8(object sender, EventArgs e)
            {
                Estado(8);
                AtualizarEstadoLeds();
            }

        private void Estado(int ledestado)
        {
            
            if (leds.getEstado(ledestado))
            {
                leds.apagar(ledestado);
            }
            else
            {
                leds.acender(ledestado);
            }
        }





    }

}

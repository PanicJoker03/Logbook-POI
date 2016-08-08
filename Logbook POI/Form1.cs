using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Logbook_POI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
            textBoxBuscar.ForeColor = Color.Gray;
            textBoxBuscar.Text = "Buscar...";
            refreshListBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            if (canClearTextBoxBuscar)
            {
                textBoxBuscar.Clear();
                textBoxBuscar.ForeColor = Color.Black;
                canClearTextBoxBuscar = false;
            }
        }
        //Variables auxiliares
        private bool canClearTextBoxBuscar = true;

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void definicionRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            definicionRichTextBox.SelectionLength = 0;
            HideCaret(definicionRichTextBox.Handle);
        }
        private void refreshListBox()
        {
            DiarioListBox.Items.Clear();
            foreach (var concepto in Diario.Lista)
            {
                DiarioListBox.Items.Add(concepto.nombre);
            }
        }
    }
}

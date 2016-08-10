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
using System.Drawing.Drawing2D;

namespace Logbook_POI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        //Variables auxiliares
        private bool canClearTextBoxBuscar = true;
        //Code from:
        //http://www.daveoncsharp.com/2009/09/how-to-paint-a-gradient-background-for-your-forms/
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var fillRectangle = this.ClientRectangle.Size.IsEmpty ? new Rectangle(1, 1, 1, 1) : this.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(fillRectangle, Color.White, Color.FromArgb(224, 240, 255), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            //base.OnPaintBackground(e);
        }

        public Form1()
        {
            InitializeComponent();
            Diario.Cargar();
            textBoxBuscar.ForeColor = Color.Gray;
            textBoxBuscar.Text = "Buscar...";
            textBoxBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            refreshListBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscarConcepto();
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

        private void definicionRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            definicionRichTextBox.SelectionLength = 0;
            HideCaret(definicionRichTextBox.Handle);
        }

        public void diarioListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            muestraConcepto();
        }
        
        private void diarioListBox_MouseDown(object sender, MouseEventArgs e)
        {
            diarioListBox.SelectedIndex = diarioListBox.IndexFromPoint(e.X, e.Y);
        }

        private void diarioListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (diarioListBox.SelectedItem == null)
            {
                diarioContextMenu.Hide();
            }
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buscarConcepto();
            }
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarConcepto();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoConcepto();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditConcepto();
        }

        private void diarioListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                borrarToolStripMenuItem_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
                BorrarConcepto();
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
                NuevoConcepto();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Diario.Guardar();
        }
        //custom functions
        public void refreshListBox()
        {
            diarioListBox.DataSource = null;
            diarioListBox.DataSource = Diario.Lista;
            diarioListBox.DisplayMember = "nombre";
            //textbox autocomplete list
            var conceptoNombres = new AutoCompleteStringCollection();
            foreach (var concepto in Diario.Lista)
            {
                conceptoNombres.Add(concepto.nombre);
            }
            textBoxBuscar.AutoCompleteCustomSource = conceptoNombres;
        }

        private void muestraConcepto()
        {
            if (diarioListBox.SelectedItem != null)
            {
                conceptoLabel.Text = (diarioListBox.SelectedItem as Diario.Concepto).nombre;
                definicionRichTextBox.Text = (diarioListBox.SelectedItem as Diario.Concepto).definicion;
            }
            else
            {
                conceptoLabel.Text = "...";
                definicionRichTextBox.Text = "";
            }
        }

        private void buscarConcepto()
        {
            string itemString = this.textBoxBuscar.Text;
            diarioListBox.SelectedIndex = diarioListBox.FindString(itemString);
        }

        private void NuevoConcepto()
        {
            ConceptoForm conceptoForm = new ConceptoForm(this);
            conceptoForm.ShowDialog();
        }

        private void BorrarConcepto()
        {
            string conceptoString = (diarioListBox.SelectedItem as Diario.Concepto).nombre;
            if (MessageBox.Show("¿Estás seguro de borrar el concepto " + conceptoString + "?", "Borrar concepto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Diario.Lista.Remove(diarioListBox.SelectedItem as Diario.Concepto);
                refreshListBox();
                conceptoLabel.Text = "...";
                definicionRichTextBox.Text = "";
            }
        }

        private void EditConcepto()
        {
            ConceptoForm conceptoForm = new ConceptoForm(this, diarioListBox.SelectedItem as Diario.Concepto);
            conceptoForm.ShowDialog();
        }
        //Unused...
        private void Form1_Load(object sender, EventArgs e) { }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBoxBuscar_TabStopChanged(object sender, EventArgs e) { }
        private void textBoxBuscar_TabIndexChanged(object sender, EventArgs e) { }
    }
}

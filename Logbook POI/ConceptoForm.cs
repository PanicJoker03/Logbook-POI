using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook_POI
{
    public partial class ConceptoForm : Form
    {
        private bool editando;
        private Diario.Concepto concepto = null;
        private Form1 parent;
        public ConceptoForm(Form1 parent, Diario.Concepto concepto = null)
        {
            InitializeComponent();
            this.parent = parent;
            this.concepto = concepto;
            editando = concepto != null;
            buttonOk.Text = editando ? "Editar" : "Agregar";
            if(editando)
            {
                textBoxNombre.Text = concepto.nombre;
                textBoxDefinicion.Text = concepto.definicion;
            }
        }

        private void ConceptoForm_Load(object sender, EventArgs e)
        {
            if (editando)
                this.Text = "Editar concepto";
            else
                this.Text = "Nuevo concepto";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(editando)
            {
                concepto.nombre = textBoxNombre.Text;
                concepto.definicion = textBoxDefinicion.Text;
                parent.refreshListBox();
                parent.diarioListBox_SelectedIndexChanged(null, null);
                this.Close();
            }
            else
            {
                concepto = new Diario.Concepto(textBoxNombre.Text, textBoxDefinicion.Text);
                Diario.Lista.Add(concepto);
                parent.refreshListBox();
                parent.diarioListBox_SelectedIndexChanged(null, null);
                this.Close();
            }
        }
    }
}

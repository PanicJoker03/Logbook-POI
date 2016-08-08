namespace Logbook_POI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.diarioListBox = new System.Windows.Forms.ListBox();
            this.diarioContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.definicionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.conceptoLabel = new System.Windows.Forms.Label();
            this.diarioContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // diarioListBox
            // 
            this.diarioListBox.ContextMenuStrip = this.diarioContextMenu;
            this.diarioListBox.FormattingEnabled = true;
            this.diarioListBox.Location = new System.Drawing.Point(6, 48);
            this.diarioListBox.Name = "diarioListBox";
            this.diarioListBox.Size = new System.Drawing.Size(137, 251);
            this.diarioListBox.Sorted = true;
            this.diarioListBox.TabIndex = 0;
            this.diarioListBox.SelectedIndexChanged += new System.EventHandler(this.diarioListBox_SelectedIndexChanged);
            this.diarioListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diarioListBox_KeyDown);
            this.diarioListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diarioListBox_MouseDown);
            this.diarioListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.diarioListBox_MouseUp);
            // 
            // diarioContextMenu
            // 
            this.diarioContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.borrarToolStripMenuItem1});
            this.diarioContextMenu.Name = "diarioContextMenu";
            this.diarioContextMenu.Size = new System.Drawing.Size(110, 70);
            this.diarioContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarToolStripMenuItem.Text = "Nuevo";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem.Text = "Editar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(137, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TabIndexChanged += new System.EventHandler(this.textBoxBuscar_TabIndexChanged);
            this.textBoxBuscar.TabStopChanged += new System.EventHandler(this.textBoxBuscar_TabStopChanged);
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxBuscar.Enter += new System.EventHandler(this.textBoxBuscar_Enter);
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.diarioListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.definicionRichTextBox);
            this.groupBox2.Controls.Add(this.conceptoLabel);
            this.groupBox2.Location = new System.Drawing.Point(168, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 305);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concepto";
            // 
            // definicionRichTextBox
            // 
            this.definicionRichTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.definicionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.definicionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.definicionRichTextBox.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definicionRichTextBox.Location = new System.Drawing.Point(7, 36);
            this.definicionRichTextBox.Name = "definicionRichTextBox";
            this.definicionRichTextBox.ReadOnly = true;
            this.definicionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.definicionRichTextBox.Size = new System.Drawing.Size(264, 263);
            this.definicionRichTextBox.TabIndex = 3;
            this.definicionRichTextBox.TabStop = false;
            this.definicionRichTextBox.Text = "";
            this.definicionRichTextBox.SelectionChanged += new System.EventHandler(this.definicionRichTextBox_SelectionChanged);
            // 
            // conceptoLabel
            // 
            this.conceptoLabel.AutoSize = true;
            this.conceptoLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoLabel.Location = new System.Drawing.Point(6, 16);
            this.conceptoLabel.Name = "conceptoLabel";
            this.conceptoLabel.Size = new System.Drawing.Size(20, 17);
            this.conceptoLabel.TabIndex = 2;
            this.conceptoLabel.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.94D;
            this.Text = "Diario de conceptos - POI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.diarioContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label conceptoLabel;
        private System.Windows.Forms.RichTextBox definicionRichTextBox;
        private System.Windows.Forms.ContextMenuStrip diarioContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ListBox diarioListBox;
    }
}


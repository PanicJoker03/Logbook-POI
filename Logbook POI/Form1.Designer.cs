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
            this.DiarioListBox = new System.Windows.Forms.ListBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.conceptoLabel = new System.Windows.Forms.Label();
            this.definicionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiarioListBox
            // 
            this.DiarioListBox.FormattingEnabled = true;
            this.DiarioListBox.Location = new System.Drawing.Point(6, 48);
            this.DiarioListBox.Name = "DiarioListBox";
            this.DiarioListBox.Size = new System.Drawing.Size(137, 251);
            this.DiarioListBox.TabIndex = 0;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(6, 19);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(137, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxBuscar.Enter += new System.EventHandler(this.textBoxBuscar_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBuscar);
            this.groupBox1.Controls.Add(this.DiarioListBox);
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
            // conceptoLabel
            // 
            this.conceptoLabel.AutoSize = true;
            this.conceptoLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conceptoLabel.Location = new System.Drawing.Point(6, 75);
            this.conceptoLabel.Name = "conceptoLabel";
            this.conceptoLabel.Size = new System.Drawing.Size(20, 17);
            this.conceptoLabel.TabIndex = 2;
            this.conceptoLabel.Text = "...";
            // 
            // definicionRichTextBox
            // 
            this.definicionRichTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.definicionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.definicionRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.definicionRichTextBox.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definicionRichTextBox.Location = new System.Drawing.Point(7, 96);
            this.definicionRichTextBox.Name = "definicionRichTextBox";
            this.definicionRichTextBox.ReadOnly = true;
            this.definicionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.definicionRichTextBox.Size = new System.Drawing.Size(264, 203);
            this.definicionRichTextBox.TabIndex = 3;
            this.definicionRichTextBox.Text = "";
            this.definicionRichTextBox.SelectionChanged += new System.EventHandler(this.definicionRichTextBox_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.Text = "Diario de conceptos - POI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DiarioListBox;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label conceptoLabel;
        private System.Windows.Forms.RichTextBox definicionRichTextBox;
    }
}


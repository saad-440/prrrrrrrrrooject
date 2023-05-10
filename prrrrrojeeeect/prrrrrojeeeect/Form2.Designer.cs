namespace prrrrrojeeeect
{
    partial class Form2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            btsingin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = Color.DarkMagenta;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(791, 236);
            dataGridView1.TabIndex = 0;
            // 
            // btsingin
            // 
            btsingin.BackColor = Color.Lavender;
            btsingin.BorderRadius = 13;
            btsingin.CustomizableEdges = customizableEdges1;
            btsingin.DialogResult = DialogResult.Retry;
            btsingin.DisabledState.BorderColor = Color.DarkGray;
            btsingin.DisabledState.CustomBorderColor = Color.DarkGray;
            btsingin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btsingin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btsingin.FillColor = Color.DarkMagenta;
            btsingin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btsingin.ForeColor = Color.White;
            btsingin.Location = new Point(198, 347);
            btsingin.Name = "btsingin";
            btsingin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btsingin.Size = new Size(390, 29);
            btsingin.TabIndex = 9;
            btsingin.Text = "show";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(791, 461);
            Controls.Add(btsingin);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btsingin;
    }
}
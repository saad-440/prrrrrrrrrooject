namespace project_practise_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btUpdate = new Button();
            button2 = new Button();
            btdelete = new Button();
            dataGridView1 = new DataGridView();
            btshow = new Button();
            textID = new TextBox();
            textname = new TextBox();
            textdegree = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btUpdate
            // 
            btUpdate.FlatStyle = FlatStyle.System;
            btUpdate.Location = new Point(256, 423);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(75, 23);
            btUpdate.TabIndex = 0;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(127, 396);
            button2.Name = "button2";
            button2.Size = new Size(104, 50);
            button2.TabIndex = 1;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btdelete
            // 
            btdelete.FlatStyle = FlatStyle.System;
            btdelete.Location = new Point(26, 423);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(75, 23);
            btdelete.TabIndex = 2;
            btdelete.Text = "Delete";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(336, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btshow
            // 
            btshow.FlatStyle = FlatStyle.System;
            btshow.Location = new Point(123, 180);
            btshow.Name = "btshow";
            btshow.Size = new Size(121, 28);
            btshow.TabIndex = 4;
            btshow.Text = "Show";
            btshow.UseVisualStyleBackColor = true;
            btshow.Click += btshow_Click;
            // 
            // textID
            // 
            textID.BorderStyle = BorderStyle.FixedSingle;
            textID.Location = new Point(88, 243);
            textID.Name = "textID";
            textID.Size = new Size(214, 23);
            textID.TabIndex = 5;
            textID.TextChanged += textID_TextChanged;
            // 
            // textname
            // 
            textname.BorderStyle = BorderStyle.FixedSingle;
            textname.Location = new Point(88, 272);
            textname.Name = "textname";
            textname.Size = new Size(214, 23);
            textname.TabIndex = 6;
            // 
            // textdegree
            // 
            textdegree.BorderStyle = BorderStyle.FixedSingle;
            textdegree.Location = new Point(88, 301);
            textdegree.Name = "textdegree";
            textdegree.Size = new Size(214, 23);
            textdegree.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 246);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 275);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 304);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Degree";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(360, 522);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textdegree);
            Controls.Add(textname);
            Controls.Add(textID);
            Controls.Add(btshow);
            Controls.Add(dataGridView1);
            Controls.Add(btdelete);
            Controls.Add(button2);
            Controls.Add(btUpdate);
            ForeColor = Color.DodgerBlue;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdate;
        private Button button2;
        private Button btdelete;
        private DataGridView dataGridView1;
        private Button btshow;
        private TextBox textID;
        private TextBox textname;
        private TextBox textdegree;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
namespace WXStats
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xYPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturePlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTn1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTn2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNoPoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTempPlot = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.plotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // getDataToolStripMenuItem
            // 
            this.getDataToolStripMenuItem.Name = "getDataToolStripMenuItem";
            this.getDataToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.getDataToolStripMenuItem.Text = "GetData";
            this.getDataToolStripMenuItem.Click += new System.EventHandler(this.getDataToolStripMenuItem_Click);
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xYPlotToolStripMenuItem,
            this.temperaturePlotToolStripMenuItem});
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.plotToolStripMenuItem.Text = "Plot";
            // 
            // xYPlotToolStripMenuItem
            // 
            this.xYPlotToolStripMenuItem.Name = "xYPlotToolStripMenuItem";
            this.xYPlotToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.xYPlotToolStripMenuItem.Text = "XYPlot";
            this.xYPlotToolStripMenuItem.Click += new System.EventHandler(this.xYPlotToolStripMenuItem_Click);
            // 
            // temperaturePlotToolStripMenuItem
            // 
            this.temperaturePlotToolStripMenuItem.Name = "temperaturePlotToolStripMenuItem";
            this.temperaturePlotToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.temperaturePlotToolStripMenuItem.Text = "Temperature Plot";
            this.temperaturePlotToolStripMenuItem.Click += new System.EventHandler(this.temperaturePlotToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XY Plot Tables";
            // 
            // comboBoxTn1
            // 
            this.comboBoxTn1.FormattingEnabled = true;
            this.comboBoxTn1.Items.AddRange(new object[] {
            "WXIN",
            "WXOUT",
            "WXROVER",
            "WXPOOL",
            "WXBOMGHILL"});
            this.comboBoxTn1.Location = new System.Drawing.Point(179, 94);
            this.comboBoxTn1.Name = "comboBoxTn1";
            this.comboBoxTn1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTn1.TabIndex = 2;
            this.comboBoxTn1.Text = "WXIN";
            // 
            // comboBoxTn2
            // 
            this.comboBoxTn2.FormattingEnabled = true;
            this.comboBoxTn2.Items.AddRange(new object[] {
            "WXIN",
            "WXOUT",
            "WXROVER",
            "WXPOOL",
            "WXBOMGHILL"});
            this.comboBoxTn2.Location = new System.Drawing.Point(306, 94);
            this.comboBoxTn2.Name = "comboBoxTn2";
            this.comboBoxTn2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTn2.TabIndex = 3;
            this.comboBoxTn2.Text = "WXROVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Table 2";
            // 
            // textBoxNoPoints
            // 
            this.textBoxNoPoints.Location = new System.Drawing.Point(445, 94);
            this.textBoxNoPoints.Name = "textBoxNoPoints";
            this.textBoxNoPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoPoints.TabIndex = 6;
            this.textBoxNoPoints.Text = "3000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number Points";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 1, 16, 43, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(373, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(40, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(644, 2);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "XY Plot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Temperature Plot";
            // 
            // comboBoxTempPlot
            // 
            this.comboBoxTempPlot.FormattingEnabled = true;
            this.comboBoxTempPlot.Items.AddRange(new object[] {
            "WXIN",
            "WXOUT",
            "WXROVER",
            "WXPOOL",
            "WXBOMGHILL"});
            this.comboBoxTempPlot.Location = new System.Drawing.Point(179, 248);
            this.comboBoxTempPlot.Name = "comboBoxTempPlot";
            this.comboBoxTempPlot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTempPlot.TabIndex = 13;
            this.comboBoxTempPlot.Text = "WXIN";
            this.comboBoxTempPlot.SelectedIndexChanged += new System.EventHandler(this.comboBoxTempPlot_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTempPlot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNoPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTn2);
            this.Controls.Add(this.comboBoxTn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xYPlotToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTn1;
        private System.Windows.Forms.ComboBox comboBoxTn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNoPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTempPlot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem temperaturePlotToolStripMenuItem;
    }
}


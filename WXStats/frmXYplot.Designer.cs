namespace WXStats
{
    partial class frmXYplot
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblstderrT1 = new System.Windows.Forms.Label();
            this.lblNtn1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorrel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblIQRt2 = new System.Windows.Forms.Label();
            this.lblIQRt1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblq3table2 = new System.Windows.Forms.Label();
            this.lblQ3T1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQ1T2 = new System.Windows.Forms.Label();
            this.lblQ1t1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstdevT2 = new System.Windows.Forms.Label();
            this.lblstdevT1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblstderrT2 = new System.Windows.Forms.Label();
            this.lblMedT2 = new System.Windows.Forms.Label();
            this.lblMedT1 = new System.Windows.Forms.Label();
            this.lblMeanT2 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMeanT1 = new System.Windows.Forms.Label();
            this.dgXY = new System.Windows.Forms.DataGridView();
            this.dgXYrecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgXYx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgXYy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPointIndex = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgXY)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(3, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.tableLayoutPanel1.SetRowSpan(this.formsPlot1, 2);
            this.formsPlot1.Size = new System.Drawing.Size(716, 620);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.MouseMoved += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMoved);
            this.formsPlot1.MouseClicked += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseClicked);
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            this.formsPlot1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseClick);
            this.formsPlot1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseDown);
            this.formsPlot1.MouseHover += new System.EventHandler(this.formsPlot1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblstderrT1);
            this.panel1.Controls.Add(this.lblNtn1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblCorrel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblLine);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblIQRt2);
            this.panel1.Controls.Add(this.lblIQRt1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblq3table2);
            this.panel1.Controls.Add(this.lblQ3T1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblQ1T2);
            this.panel1.Controls.Add(this.lblQ1t1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblstdevT2);
            this.panel1.Controls.Add(this.lblstdevT1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblstderrT2);
            this.panel1.Controls.Add(this.lblMedT2);
            this.panel1.Controls.Add(this.lblMedT1);
            this.panel1.Controls.Add(this.lblMeanT2);
            this.panel1.Controls.Add(this.lblT2);
            this.panel1.Controls.Add(this.lblT1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMeanT1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(725, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 307);
            this.panel1.TabIndex = 4;
            // 
            // lblstderrT1
            // 
            this.lblstderrT1.AutoSize = true;
            this.lblstderrT1.Location = new System.Drawing.Point(65, 70);
            this.lblstderrT1.Name = "lblstderrT1";
            this.lblstderrT1.Size = new System.Drawing.Size(39, 13);
            this.lblstderrT1.TabIndex = 10;
            this.lblstderrT1.Text = "Std Err";
            // 
            // lblNtn1
            // 
            this.lblNtn1.AutoSize = true;
            this.lblNtn1.Location = new System.Drawing.Point(98, 175);
            this.lblNtn1.Name = "lblNtn1";
            this.lblNtn1.Size = new System.Drawing.Size(15, 13);
            this.lblNtn1.TabIndex = 30;
            this.lblNtn1.Text = "N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "N";
            // 
            // lblCorrel
            // 
            this.lblCorrel.AutoSize = true;
            this.lblCorrel.Location = new System.Drawing.Point(88, 211);
            this.lblCorrel.Name = "lblCorrel";
            this.lblCorrel.Size = new System.Drawing.Size(56, 13);
            this.lblCorrel.TabIndex = 28;
            this.lblCorrel.Text = "correlation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Correlation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Line";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(98, 192);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(23, 13);
            this.lblLine.TabIndex = 25;
            this.lblLine.Text = "line";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "IQR";
            // 
            // lblIQRt2
            // 
            this.lblIQRt2.AutoSize = true;
            this.lblIQRt2.Location = new System.Drawing.Point(140, 150);
            this.lblIQRt2.Name = "lblIQRt2";
            this.lblIQRt2.Size = new System.Drawing.Size(26, 13);
            this.lblIQRt2.TabIndex = 23;
            this.lblIQRt2.Text = "IQR";
            // 
            // lblIQRt1
            // 
            this.lblIQRt1.AutoSize = true;
            this.lblIQRt1.Location = new System.Drawing.Point(65, 150);
            this.lblIQRt1.Name = "lblIQRt1";
            this.lblIQRt1.Size = new System.Drawing.Size(26, 13);
            this.lblIQRt1.TabIndex = 22;
            this.lblIQRt1.Text = "IQR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Q2";
            // 
            // lblq3table2
            // 
            this.lblq3table2.AutoSize = true;
            this.lblq3table2.Location = new System.Drawing.Point(140, 130);
            this.lblq3table2.Name = "lblq3table2";
            this.lblq3table2.Size = new System.Drawing.Size(30, 13);
            this.lblq3table2.TabIndex = 20;
            this.lblq3table2.Text = "Q3t2";
            // 
            // lblQ3T1
            // 
            this.lblQ3T1.AutoSize = true;
            this.lblQ3T1.Location = new System.Drawing.Point(65, 130);
            this.lblQ3T1.Name = "lblQ3T1";
            this.lblQ3T1.Size = new System.Drawing.Size(30, 13);
            this.lblQ3T1.TabIndex = 19;
            this.lblQ3T1.Text = "Q3t1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Q1";
            // 
            // lblQ1T2
            // 
            this.lblQ1T2.AutoSize = true;
            this.lblQ1T2.Location = new System.Drawing.Point(140, 110);
            this.lblQ1T2.Name = "lblQ1T2";
            this.lblQ1T2.Size = new System.Drawing.Size(30, 13);
            this.lblQ1T2.TabIndex = 17;
            this.lblQ1T2.Text = "Q1t2";
            // 
            // lblQ1t1
            // 
            this.lblQ1t1.AutoSize = true;
            this.lblQ1t1.Location = new System.Drawing.Point(65, 110);
            this.lblQ1t1.Name = "lblQ1t1";
            this.lblQ1t1.Size = new System.Drawing.Size(30, 13);
            this.lblQ1t1.TabIndex = 16;
            this.lblQ1t1.Text = "Q1t1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Std Dev";
            // 
            // lblstdevT2
            // 
            this.lblstdevT2.AutoSize = true;
            this.lblstdevT2.Location = new System.Drawing.Point(140, 90);
            this.lblstdevT2.Name = "lblstdevT2";
            this.lblstdevT2.Size = new System.Drawing.Size(46, 13);
            this.lblstdevT2.TabIndex = 14;
            this.lblstdevT2.Text = "Std Dev";
            // 
            // lblstdevT1
            // 
            this.lblstdevT1.AutoSize = true;
            this.lblstdevT1.Location = new System.Drawing.Point(65, 90);
            this.lblstdevT1.Name = "lblstdevT1";
            this.lblstdevT1.Size = new System.Drawing.Size(46, 13);
            this.lblstdevT1.TabIndex = 13;
            this.lblstdevT1.Text = "Std Dev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Std Err";
            // 
            // lblstderrT2
            // 
            this.lblstderrT2.AutoSize = true;
            this.lblstderrT2.Location = new System.Drawing.Point(140, 70);
            this.lblstderrT2.Name = "lblstderrT2";
            this.lblstderrT2.Size = new System.Drawing.Size(39, 13);
            this.lblstderrT2.TabIndex = 11;
            this.lblstderrT2.Text = "Std Err";
            // 
            // lblMedT2
            // 
            this.lblMedT2.AutoSize = true;
            this.lblMedT2.Location = new System.Drawing.Point(140, 50);
            this.lblMedT2.Name = "lblMedT2";
            this.lblMedT2.Size = new System.Drawing.Size(42, 13);
            this.lblMedT2.TabIndex = 9;
            this.lblMedT2.Text = "Median";
            // 
            // lblMedT1
            // 
            this.lblMedT1.AutoSize = true;
            this.lblMedT1.Location = new System.Drawing.Point(65, 50);
            this.lblMedT1.Name = "lblMedT1";
            this.lblMedT1.Size = new System.Drawing.Size(42, 13);
            this.lblMedT1.TabIndex = 8;
            this.lblMedT1.Text = "Median";
            // 
            // lblMeanT2
            // 
            this.lblMeanT2.AutoSize = true;
            this.lblMeanT2.Location = new System.Drawing.Point(140, 30);
            this.lblMeanT2.Name = "lblMeanT2";
            this.lblMeanT2.Size = new System.Drawing.Size(26, 13);
            this.lblMeanT2.TabIndex = 7;
            this.lblMeanT2.Text = "Avg";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.Location = new System.Drawing.Point(137, 13);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(18, 13);
            this.lblT2.TabIndex = 6;
            this.lblT2.Text = "t2";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1.Location = new System.Drawing.Point(68, 13);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(18, 13);
            this.lblT1.TabIndex = 5;
            this.lblT1.Text = "t1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Median";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mean";
            // 
            // lblMeanT1
            // 
            this.lblMeanT1.AutoSize = true;
            this.lblMeanT1.Location = new System.Drawing.Point(65, 30);
            this.lblMeanT1.Name = "lblMeanT1";
            this.lblMeanT1.Size = new System.Drawing.Size(26, 13);
            this.lblMeanT1.TabIndex = 2;
            this.lblMeanT1.Text = "Avg";
            // 
            // dgXY
            // 
            this.dgXY.AllowUserToAddRows = false;
            this.dgXY.AllowUserToDeleteRows = false;
            this.dgXY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgXY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgXYrecord,
            this.dgXYx,
            this.dgXYy});
            this.dgXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgXY.Location = new System.Drawing.Point(725, 316);
            this.dgXY.Name = "dgXY";
            this.dgXY.ReadOnly = true;
            this.dgXY.RowHeadersVisible = false;
            this.dgXY.Size = new System.Drawing.Size(221, 307);
            this.dgXY.TabIndex = 5;
            // 
            // dgXYrecord
            // 
            this.dgXYrecord.HeaderText = "Record";
            this.dgXYrecord.Name = "dgXYrecord";
            // 
            // dgXYx
            // 
            this.dgXYx.HeaderText = "X";
            this.dgXYx.Name = "dgXYx";
            // 
            // dgXYy
            // 
            this.dgXYy.HeaderText = "Y";
            this.dgXYy.Name = "dgXYy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.13433F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86567F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgXY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 647);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblY);
            this.panel2.Controls.Add(this.lblPointIndex);
            this.panel2.Controls.Add(this.lblX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 629);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 15);
            this.panel2.TabIndex = 7;
            // 
            // lblPointIndex
            // 
            this.lblPointIndex.AutoSize = true;
            this.lblPointIndex.Location = new System.Drawing.Point(260, 0);
            this.lblPointIndex.Name = "lblPointIndex";
            this.lblPointIndex.Size = new System.Drawing.Size(30, 13);
            this.lblPointIndex.TabIndex = 7;
            this.lblPointIndex.Text = "point";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(85, 1);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(141, 1);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mouse Coords";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Point#";
            // 
            // frmXYplot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmXYplot";
            this.Text = "ScarpWeatherXYplot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgXY)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIQRt2;
        private System.Windows.Forms.Label lblIQRt1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblq3table2;
        private System.Windows.Forms.Label lblQ3T1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQ1T2;
        private System.Windows.Forms.Label lblQ1t1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstdevT2;
        private System.Windows.Forms.Label lblstdevT1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblstderrT2;
        private System.Windows.Forms.Label lblstderrT1;
        private System.Windows.Forms.Label lblMedT2;
        private System.Windows.Forms.Label lblMedT1;
        private System.Windows.Forms.Label lblMeanT2;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMeanT1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrel;
        private System.Windows.Forms.Label lblNtn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgXY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgXYrecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgXYx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgXYy;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPointIndex;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
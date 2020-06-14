namespace cglr4
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
            this.OGlControl = new SharpGL.OpenGLControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RotateXNUD = new System.Windows.Forms.NumericUpDown();
            this.RotateYNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RotateZNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ScaleZNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ScaleYNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleXNUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OGlControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OGlControl
            // 
            this.OGlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OGlControl.DrawFPS = false;
            this.OGlControl.FrameRate = 60;
            this.OGlControl.Location = new System.Drawing.Point(6, 6);
            this.OGlControl.Name = "OGlControl";
            this.OGlControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.OGlControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.OGlControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.OGlControl.Size = new System.Drawing.Size(931, 501);
            this.OGlControl.TabIndex = 0;
            this.OGlControl.OpenGLInitialized += new System.EventHandler(this.OGlControl_OpenGLInitialized);
            this.OGlControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.OGlControl_OpenGLDraw);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.OGlControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 513);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ScaleZNUD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ScaleYNUD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ScaleXNUD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RotateZNUD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RotateYNUD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RotateXNUD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(946, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 501);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotate X";
            // 
            // RotateXNUD
            // 
            this.RotateXNUD.Location = new System.Drawing.Point(7, 23);
            this.RotateXNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RotateXNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.RotateXNUD.Name = "RotateXNUD";
            this.RotateXNUD.Size = new System.Drawing.Size(66, 20);
            this.RotateXNUD.TabIndex = 1;
            this.RotateXNUD.ValueChanged += new System.EventHandler(this.RotateXNUD_ValueChanged);
            // 
            // RotateYNUD
            // 
            this.RotateYNUD.Location = new System.Drawing.Point(7, 63);
            this.RotateYNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RotateYNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.RotateYNUD.Name = "RotateYNUD";
            this.RotateYNUD.Size = new System.Drawing.Size(66, 20);
            this.RotateYNUD.TabIndex = 5;
            this.RotateYNUD.ValueChanged += new System.EventHandler(this.RotateYNUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rotate Y";
            // 
            // RotateZNUD
            // 
            this.RotateZNUD.Location = new System.Drawing.Point(7, 103);
            this.RotateZNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RotateZNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.RotateZNUD.Name = "RotateZNUD";
            this.RotateZNUD.Size = new System.Drawing.Size(66, 20);
            this.RotateZNUD.TabIndex = 9;
            this.RotateZNUD.ValueChanged += new System.EventHandler(this.RotateZNUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotate Z";
            // 
            // ScaleZNUD
            // 
            this.ScaleZNUD.DecimalPlaces = 1;
            this.ScaleZNUD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleZNUD.Location = new System.Drawing.Point(7, 242);
            this.ScaleZNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleZNUD.Name = "ScaleZNUD";
            this.ScaleZNUD.Size = new System.Drawing.Size(66, 20);
            this.ScaleZNUD.TabIndex = 15;
            this.ScaleZNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Scale Z";
            // 
            // ScaleYNUD
            // 
            this.ScaleYNUD.DecimalPlaces = 1;
            this.ScaleYNUD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleYNUD.Location = new System.Drawing.Point(7, 202);
            this.ScaleYNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleYNUD.Name = "ScaleYNUD";
            this.ScaleYNUD.Size = new System.Drawing.Size(66, 20);
            this.ScaleYNUD.TabIndex = 13;
            this.ScaleYNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale Y";
            // 
            // ScaleXNUD
            // 
            this.ScaleXNUD.DecimalPlaces = 1;
            this.ScaleXNUD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleXNUD.Location = new System.Drawing.Point(7, 162);
            this.ScaleXNUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleXNUD.Name = "ScaleXNUD";
            this.ScaleXNUD.Size = new System.Drawing.Size(66, 20);
            this.ScaleXNUD.TabIndex = 11;
            this.ScaleXNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Scale X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "cglr4";
            ((System.ComponentModel.ISupportInitialize)(this.OGlControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl OGlControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown RotateZNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RotateYNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RotateXNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ScaleZNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ScaleYNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ScaleXNUD;
        private System.Windows.Forms.Label label6;
    }
}


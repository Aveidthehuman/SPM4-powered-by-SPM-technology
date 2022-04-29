namespace SPM4_powered_by_SPM_technology
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2spm1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2spm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(85, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quick SPM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(315, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SPM 1.0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Location = new System.Drawing.Point(511, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Web SPM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(178, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick SPM";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(125, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 22);
            this.button8.TabIndex = 2;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Quick SPM Disabled";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Quick SPM Enabled";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2spm1
            // 
            this.groupBox2spm1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2spm1.Controls.Add(this.button9);
            this.groupBox2spm1.Controls.Add(this.button7);
            this.groupBox2spm1.Controls.Add(this.button6);
            this.groupBox2spm1.Controls.Add(this.textBox1);
            this.groupBox2spm1.Location = new System.Drawing.Point(352, 231);
            this.groupBox2spm1.Name = "groupBox2spm1";
            this.groupBox2spm1.Size = new System.Drawing.Size(152, 84);
            this.groupBox2spm1.TabIndex = 4;
            this.groupBox2spm1.TabStop = false;
            this.groupBox2spm1.Text = "SPM 1.0";
            this.groupBox2spm1.Visible = false;
            this.groupBox2spm1.Enter += new System.EventHandler(this.groupBox2spm1_Enter);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(125, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 22);
            this.button9.TabIndex = 3;
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(78, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Stop";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Start";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Text to spam...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(717, 469);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "1920x1080";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::SPM4_powered_by_SPM_technology.Properties.Resources._278452938_309284421179846_722112603248408327_n;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox2spm1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main site";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2spm1.ResumeLayout(false);
            this.groupBox2spm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2spm1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
    }
}


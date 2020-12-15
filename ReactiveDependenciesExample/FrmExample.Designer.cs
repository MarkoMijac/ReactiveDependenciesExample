namespace ReactiveDependenciesExample
{
    partial class FrmExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.gbOutputs = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbInputs.SuspendLayout();
            this.gbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(38, 19);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(38, 45);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 20);
            this.txtW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "W";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(38, 71);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P";
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.txtX);
            this.gbInputs.Controls.Add(this.txtP);
            this.gbInputs.Controls.Add(this.label1);
            this.gbInputs.Controls.Add(this.label3);
            this.gbInputs.Controls.Add(this.label2);
            this.gbInputs.Controls.Add(this.txtW);
            this.gbInputs.Location = new System.Drawing.Point(12, 12);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(158, 105);
            this.gbInputs.TabIndex = 6;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Inputs:";
            // 
            // gbOutputs
            // 
            this.gbOutputs.Controls.Add(this.textBox1);
            this.gbOutputs.Controls.Add(this.textBox2);
            this.gbOutputs.Controls.Add(this.label4);
            this.gbOutputs.Controls.Add(this.label5);
            this.gbOutputs.Controls.Add(this.label6);
            this.gbOutputs.Controls.Add(this.textBox3);
            this.gbOutputs.Location = new System.Drawing.Point(12, 123);
            this.gbOutputs.Name = "gbOutputs";
            this.gbOutputs.Size = new System.Drawing.Size(158, 105);
            this.gbOutputs.TabIndex = 7;
            this.gbOutputs.TabStop = false;
            this.gbOutputs.Text = "Outputs:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Z";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // FrmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 252);
            this.Controls.Add(this.gbOutputs);
            this.Controls.Add(this.gbInputs);
            this.Name = "FrmExample";
            this.Text = "Example";
            this.Load += new System.EventHandler(this.FrmExample_Load);
            this.gbInputs.ResumeLayout(false);
            this.gbInputs.PerformLayout();
            this.gbOutputs.ResumeLayout(false);
            this.gbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.GroupBox gbOutputs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
    }
}


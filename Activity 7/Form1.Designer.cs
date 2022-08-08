namespace Activity_7
{
    partial class form_pi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pi));
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.lbl_terms = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_input
            // 
            this.tbx_input.Location = new System.Drawing.Point(423, 123);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(100, 20);
            this.tbx_input.TabIndex = 0;
            // 
            // lbl_terms
            // 
            this.lbl_terms.AutoSize = true;
            this.lbl_terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terms.Location = new System.Drawing.Point(174, 117);
            this.lbl_terms.Name = "lbl_terms";
            this.lbl_terms.Size = new System.Drawing.Size(179, 26);
            this.lbl_terms.TabIndex = 1;
            this.lbl_terms.Text = "Enter # of terms: ";
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_calc.Location = new System.Drawing.Point(324, 167);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(99, 38);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(176, 249);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(0, 20);
            this.lbl_output.TabIndex = 3;
            // 
            // form_pi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_terms);
            this.Controls.Add(this.tbx_input);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_pi";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.Label lbl_terms;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_output;
    }
}


﻿namespace Calculator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResultDecimal = new System.Windows.Forms.Label();
            this.lblResultHex = new System.Windows.Forms.Label();
            this.lblResultBits = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.Color.Silver;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(443, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // lblResultDecimal
            // 
            this.lblResultDecimal.AutoSize = true;
            this.lblResultDecimal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDecimal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultDecimal.Location = new System.Drawing.Point(30, 53);
            this.lblResultDecimal.Name = "lblResultDecimal";
            this.lblResultDecimal.Size = new System.Drawing.Size(19, 16);
            this.lblResultDecimal.TabIndex = 2;
            this.lblResultDecimal.Text = "0";
            // 
            // lblResultHex
            // 
            this.lblResultHex.AutoSize = true;
            this.lblResultHex.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultHex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultHex.Location = new System.Drawing.Point(30, 87);
            this.lblResultHex.Name = "lblResultHex";
            this.lblResultHex.Size = new System.Drawing.Size(19, 16);
            this.lblResultHex.TabIndex = 3;
            this.lblResultHex.Text = "0";
            // 
            // lblResultBits
            // 
            this.lblResultBits.AutoSize = true;
            this.lblResultBits.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultBits.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultBits.Location = new System.Drawing.Point(30, 123);
            this.lblResultBits.Name = "lblResultBits";
            this.lblResultBits.Size = new System.Drawing.Size(19, 16);
            this.lblResultBits.TabIndex = 4;
            this.lblResultBits.Text = "0";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(382, 4);
            this.lblMode.Name = "lblMode";
            this.lblMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMode.Size = new System.Drawing.Size(70, 9);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "Mathematics Mode";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(467, 161);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblResultBits);
            this.Controls.Add(this.lblResultHex);
            this.Controls.Add(this.lblResultDecimal);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResultDecimal;
        private System.Windows.Forms.Label lblResultHex;
        private System.Windows.Forms.Label lblResultBits;
        private System.Windows.Forms.Label lblMode;
    }
}


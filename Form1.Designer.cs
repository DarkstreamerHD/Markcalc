namespace NotenrechnerII
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCalculate = new System.Windows.Forms.Button();
            this.tbRealPoints = new System.Windows.Forms.TextBox();
            this.tbMaxPoints = new System.Windows.Forms.TextBox();
            this.tbMinPointsOne = new System.Windows.Forms.TextBox();
            this.tbPoints4Minus = new System.Windows.Forms.TextBox();
            this.tbMaxPoints6 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCalculate.Location = new System.Drawing.Point(134, 462);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(97, 83);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Berechne";
            this.btCalculate.UseVisualStyleBackColor = true;
            // 
            // tbRealPoints
            // 
            this.tbRealPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRealPoints.Location = new System.Drawing.Point(132, 12);
            this.tbRealPoints.Name = "tbRealPoints";
            this.tbRealPoints.Size = new System.Drawing.Size(99, 20);
            this.tbRealPoints.TabIndex = 1;
            this.tbRealPoints.Text = "Erreichte Punkte";
            this.tbRealPoints.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbRealPoints_MouseClick);
            // 
            // tbMaxPoints
            // 
            this.tbMaxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxPoints.Location = new System.Drawing.Point(131, 38);
            this.tbMaxPoints.Name = "tbMaxPoints";
            this.tbMaxPoints.Size = new System.Drawing.Size(100, 20);
            this.tbMaxPoints.TabIndex = 2;
            this.tbMaxPoints.Text = "Erreichbare Punkte";
            this.tbMaxPoints.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMaxPoints_MouseClick);
            // 
            // tbMinPointsOne
            // 
            this.tbMinPointsOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinPointsOne.Location = new System.Drawing.Point(132, 64);
            this.tbMinPointsOne.Name = "tbMinPointsOne";
            this.tbMinPointsOne.Size = new System.Drawing.Size(99, 20);
            this.tbMinPointsOne.TabIndex = 3;
            this.tbMinPointsOne.Text = "Min. Punkte für 1";
            this.tbMinPointsOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMinPointsOne_MouseClick);
            // 
            // tbPoints4Minus
            // 
            this.tbPoints4Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPoints4Minus.Location = new System.Drawing.Point(132, 90);
            this.tbPoints4Minus.Name = "tbPoints4Minus";
            this.tbPoints4Minus.Size = new System.Drawing.Size(99, 20);
            this.tbPoints4Minus.TabIndex = 4;
            this.tbPoints4Minus.Text = "Punkte 4-";
            this.tbPoints4Minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPoints4Minus_MouseClick);
            // 
            // tbMaxPoints6
            // 
            this.tbMaxPoints6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxPoints6.Location = new System.Drawing.Point(132, 116);
            this.tbMaxPoints6.Name = "tbMaxPoints6";
            this.tbMaxPoints6.Size = new System.Drawing.Size(99, 20);
            this.tbMaxPoints6.TabIndex = 5;
            this.tbMaxPoints6.Text = "Max. Punkte 6";
            this.tbMaxPoints6.Click += new System.EventHandler(this.tbMaxPoints6_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(132, 142);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 106);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Berechne\r\nNote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 235);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 260);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbMaxPoints6);
            this.Controls.Add(this.tbPoints4Minus);
            this.Controls.Add(this.tbMinPointsOne);
            this.Controls.Add(this.tbMaxPoints);
            this.Controls.Add(this.tbRealPoints);
            this.Controls.Add(this.btCalculate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notenrechner II";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.TextBox tbRealPoints;
        private System.Windows.Forms.TextBox tbMaxPoints;
        private System.Windows.Forms.TextBox tbMinPointsOne;
        private System.Windows.Forms.TextBox tbPoints4Minus;
        private System.Windows.Forms.TextBox tbMaxPoints6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelResult;
    }
}


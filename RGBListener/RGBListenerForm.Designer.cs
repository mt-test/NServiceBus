namespace RGBListener
{
    partial class RGBListenerForm
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.numberRedsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBluesTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberGreensTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(56, 131);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtnClick);
            // 
            // numberRedsTB
            // 
            this.numberRedsTB.Location = new System.Drawing.Point(70, 30);
            this.numberRedsTB.Name = "numberRedsTB";
            this.numberRedsTB.Size = new System.Drawing.Size(100, 20);
            this.numberRedsTB.TabIndex = 1;
            this.numberRedsTB.Text = "0";
            this.numberRedsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Blue";
            // 
            // numberBluesTB
            // 
            this.numberBluesTB.Location = new System.Drawing.Point(69, 82);
            this.numberBluesTB.Name = "numberBluesTB";
            this.numberBluesTB.Size = new System.Drawing.Size(100, 20);
            this.numberBluesTB.TabIndex = 3;
            this.numberBluesTB.Text = "0";
            this.numberBluesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Green";
            // 
            // numberGreensTB
            // 
            this.numberGreensTB.Location = new System.Drawing.Point(68, 55);
            this.numberGreensTB.Name = "numberGreensTB";
            this.numberGreensTB.Size = new System.Drawing.Size(100, 20);
            this.numberGreensTB.TabIndex = 5;
            this.numberGreensTB.Text = "0";
            this.numberGreensTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RGBListenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 176);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberGreensTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberBluesTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberRedsTB);
            this.Controls.Add(this.clearBtn);
            this.Name = "RGBListenerForm";
            this.Text = "RGB Listener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox numberRedsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBluesTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberGreensTB;
    }
}


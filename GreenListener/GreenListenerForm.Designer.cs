namespace GreenListener
{
    partial class GreenListenerForm
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
            this.numberEventsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(54, 75);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtnClick);
            // 
            // numberEventsTB
            // 
            this.numberEventsTB.Location = new System.Drawing.Point(66, 30);
            this.numberEventsTB.Name = "numberEventsTB";
            this.numberEventsTB.Size = new System.Drawing.Size(100, 20);
            this.numberEventsTB.TabIndex = 1;
            this.numberEventsTB.Text = "0";
            this.numberEventsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "#";
            // 
            // GreenListenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberEventsTB);
            this.Controls.Add(this.clearBtn);
            this.Name = "GreenListenerForm";
            this.Text = "Green Listener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox numberEventsTB;
        private System.Windows.Forms.Label label1;
    }
}


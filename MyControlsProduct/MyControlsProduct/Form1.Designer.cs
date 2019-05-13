namespace MyControlsProduct
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
            this.myCotrols1 = new MyControlsProduct.MyCotrols();
            this.SuspendLayout();
            // 
            // myCotrols1
            // 
            this.myCotrols1.Location = new System.Drawing.Point(13, 13);
            this.myCotrols1.Name = "myCotrols1";
            this.myCotrols1.Size = new System.Drawing.Size(507, 287);
            this.myCotrols1.TabIndex = 0;
            this.myCotrols1.Load += new System.EventHandler(this.myCotrols1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 312);
            this.Controls.Add(this.myCotrols1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyCotrols myCotrols1;
    }
}


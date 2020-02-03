namespace Lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mealPriceTxt = new System.Windows.Forms.TextBox();
            this.lowEndLbl = new System.Windows.Forms.Label();
            this.midEndLbl = new System.Windows.Forms.Label();
            this.highEndLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price of meal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "15%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "18%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "20%";
            // 
            // mealPriceTxt
            // 
            this.mealPriceTxt.Location = new System.Drawing.Point(226, 10);
            this.mealPriceTxt.Name = "mealPriceTxt";
            this.mealPriceTxt.Size = new System.Drawing.Size(105, 31);
            this.mealPriceTxt.TabIndex = 4;
            // 
            // lowEndLbl
            // 
            this.lowEndLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowEndLbl.Location = new System.Drawing.Point(226, 70);
            this.lowEndLbl.Name = "lowEndLbl";
            this.lowEndLbl.Size = new System.Drawing.Size(105, 29);
            this.lowEndLbl.TabIndex = 5;
            // 
            // midEndLbl
            // 
            this.midEndLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midEndLbl.Location = new System.Drawing.Point(226, 128);
            this.midEndLbl.Name = "midEndLbl";
            this.midEndLbl.Size = new System.Drawing.Size(105, 30);
            this.midEndLbl.TabIndex = 6;
            // 
            // highEndLbl
            // 
            this.highEndLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highEndLbl.Location = new System.Drawing.Point(226, 183);
            this.highEndLbl.Name = "highEndLbl";
            this.highEndLbl.Size = new System.Drawing.Size(105, 32);
            this.highEndLbl.TabIndex = 7;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(161, 272);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(170, 46);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate Tip";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.highEndLbl);
            this.Controls.Add(this.midEndLbl);
            this.Controls.Add(this.lowEndLbl);
            this.Controls.Add(this.mealPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mealPriceTxt;
        private System.Windows.Forms.Label lowEndLbl;
        private System.Windows.Forms.Label midEndLbl;
        private System.Windows.Forms.Label highEndLbl;
        private System.Windows.Forms.Button calculateBtn;
    }
}


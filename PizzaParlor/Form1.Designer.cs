
namespace PizzaParlor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calculateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.numberToppingInput = new System.Windows.Forms.TextBox();
            this.priceOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(301, 337);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(227, 86);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(874, 127);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Pizza Parlor";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.ForeColor = System.Drawing.Color.Black;
            this.toppingsLabel.Location = new System.Drawing.Point(111, 208);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(357, 46);
            this.toppingsLabel.TabIndex = 2;
            this.toppingsLabel.Text = "Number of Toppings:";
            this.toppingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberToppingInput
            // 
            this.numberToppingInput.BackColor = System.Drawing.Color.White;
            this.numberToppingInput.Font = new System.Drawing.Font("Times New Roman", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberToppingInput.ForeColor = System.Drawing.Color.Black;
            this.numberToppingInput.Location = new System.Drawing.Point(494, 208);
            this.numberToppingInput.Name = "numberToppingInput";
            this.numberToppingInput.Size = new System.Drawing.Size(132, 50);
            this.numberToppingInput.TabIndex = 3;
            this.numberToppingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceOutputLabel
            // 
            this.priceOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceOutputLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.priceOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutputLabel.ForeColor = System.Drawing.Color.Black;
            this.priceOutputLabel.Location = new System.Drawing.Point(79, 506);
            this.priceOutputLabel.Name = "priceOutputLabel";
            this.priceOutputLabel.Size = new System.Drawing.Size(689, 134);
            this.priceOutputLabel.TabIndex = 4;
            this.priceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 778);
            this.Controls.Add(this.priceOutputLabel);
            this.Controls.Add(this.numberToppingInput);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.TextBox numberToppingInput;
        private System.Windows.Forms.Label priceOutputLabel;
    }
}


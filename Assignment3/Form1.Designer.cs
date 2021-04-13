namespace Assignment3
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
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputFood = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resturant Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place in Line:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPosition
            // 
            this.labelPosition.BackColor = System.Drawing.Color.White;
            this.labelPosition.Font = new System.Drawing.Font("Minion Pro", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(220, 130);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(177, 31);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutput
            // 
            this.labelOutput.BackColor = System.Drawing.Color.White;
            this.labelOutput.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(473, 73);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(281, 312);
            this.labelOutput.TabIndex = 6;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(220, 201);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(177, 22);
            this.inputName.TabIndex = 7;
            // 
            // inputFood
            // 
            this.inputFood.Location = new System.Drawing.Point(221, 261);
            this.inputFood.Name = "inputFood";
            this.inputFood.Size = new System.Drawing.Size(177, 22);
            this.inputFood.TabIndex = 8;
            this.inputFood.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputFood_KeyDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAdd.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(230, 307);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.BackColor = System.Drawing.Color.SlateGray;
            this.buttonReady.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReady.ForeColor = System.Drawing.Color.White;
            this.buttonReady.Location = new System.Drawing.Point(549, 388);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(146, 36);
            this.buttonReady.TabIndex = 10;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = false;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputFood);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resturant Queue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputFood;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReady;
    }
}


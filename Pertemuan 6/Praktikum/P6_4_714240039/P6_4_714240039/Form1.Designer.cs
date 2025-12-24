namespace P6_4_714240039
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
            this.components = new System.ComponentModel.Container();
            this.IbINumeric = new System.Windows.Forms.TextBox();
            this.IbIChar = new System.Windows.Forms.TextBox();
            this.IbIRequired = new System.Windows.Forms.TextBox();
            this.IbIRegex = new System.Windows.Forms.TextBox();
            this.IbIA1 = new System.Windows.Forms.TextBox();
            this.IbIA2 = new System.Windows.Forms.TextBox();
            this.IbILength = new System.Windows.Forms.TextBox();
            this.IbIUpper = new System.Windows.Forms.TextBox();
            this.IbILower = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // IbINumeric
            // 
            this.IbINumeric.Location = new System.Drawing.Point(188, 47);
            this.IbINumeric.Name = "IbINumeric";
            this.IbINumeric.Size = new System.Drawing.Size(100, 22);
            this.IbINumeric.TabIndex = 0;
            this.IbINumeric.Text = "Sweet Number";
            this.IbINumeric.TextChanged += new System.EventHandler(this.IbINumeric_TextChanged);
            // 
            // IbIChar
            // 
            this.IbIChar.Location = new System.Drawing.Point(188, 78);
            this.IbIChar.Name = "IbIChar";
            this.IbIChar.Size = new System.Drawing.Size(100, 22);
            this.IbIChar.TabIndex = 1;
            this.IbIChar.Text = "Lovely Letters";
            this.IbIChar.Leave += new System.EventHandler(this.IbIChar_Leave);
            // 
            // IbIRequired
            // 
            this.IbIRequired.Location = new System.Drawing.Point(188, 110);
            this.IbIRequired.Name = "IbIRequired";
            this.IbIRequired.Size = new System.Drawing.Size(100, 22);
            this.IbIRequired.TabIndex = 2;
            this.IbIRequired.Text = "Wajib Diisi";
            this.IbIRequired.Leave += new System.EventHandler(this.IbIRequired_Leave);
            // 
            // IbIRegex
            // 
            this.IbIRegex.Location = new System.Drawing.Point(188, 138);
            this.IbIRegex.Name = "IbIRegex";
            this.IbIRegex.Size = new System.Drawing.Size(100, 22);
            this.IbIRegex.TabIndex = 3;
            this.IbIRegex.Text = "Email";
            this.IbIRegex.TextChanged += new System.EventHandler(this.IbIRegex_TextChanged);
            // 
            // IbIA1
            // 
            this.IbIA1.Location = new System.Drawing.Point(188, 166);
            this.IbIA1.Name = "IbIA1";
            this.IbIA1.Size = new System.Drawing.Size(100, 22);
            this.IbIA1.TabIndex = 4;
            this.IbIA1.Leave += new System.EventHandler(this.IbIA1_Leave);
            // 
            // IbIA2
            // 
            this.IbIA2.Location = new System.Drawing.Point(188, 194);
            this.IbIA2.Name = "IbIA2";
            this.IbIA2.Size = new System.Drawing.Size(100, 22);
            this.IbIA2.TabIndex = 5;
            this.IbIA2.Leave += new System.EventHandler(this.IbIA2_Leave);
            // 
            // IbILength
            // 
            this.IbILength.Location = new System.Drawing.Point(188, 222);
            this.IbILength.Name = "IbILength";
            this.IbILength.Size = new System.Drawing.Size(100, 22);
            this.IbILength.TabIndex = 6;
            this.IbILength.Text = "5-10";
            this.IbILength.TextChanged += new System.EventHandler(this.IbILength_TextChanged);
            // 
            // IbIUpper
            // 
            this.IbIUpper.Location = new System.Drawing.Point(188, 250);
            this.IbIUpper.Name = "IbIUpper";
            this.IbIUpper.Size = new System.Drawing.Size(100, 22);
            this.IbIUpper.TabIndex = 7;
            this.IbIUpper.TextChanged += new System.EventHandler(this.IbIUpper_TextChanged);
            // 
            // IbILower
            // 
            this.IbILower.Location = new System.Drawing.Point(188, 278);
            this.IbILower.Name = "IbILower";
            this.IbILower.Size = new System.Drawing.Size(100, 22);
            this.IbILower.TabIndex = 8;
            this.IbILower.TextChanged += new System.EventHandler(this.IbILower_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(112, 342);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sweet Number    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lovely Letter        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Must Fill              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email Topping    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sugar Level 1      :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sugar Level 2      :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dessert Code      :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "UPPER Cream      :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lower cocoa       :";
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(437, 399);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.IbILower);
            this.Controls.Add(this.IbIUpper);
            this.Controls.Add(this.IbILength);
            this.Controls.Add(this.IbIA2);
            this.Controls.Add(this.IbIA1);
            this.Controls.Add(this.IbIRegex);
            this.Controls.Add(this.IbIRequired);
            this.Controls.Add(this.IbIChar);
            this.Controls.Add(this.IbINumeric);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sweet Dessert";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IbINumeric;
        private System.Windows.Forms.TextBox IbIChar;
        private System.Windows.Forms.TextBox IbIRequired;
        private System.Windows.Forms.TextBox IbIRegex;
        private System.Windows.Forms.TextBox IbIA1;
        private System.Windows.Forms.TextBox IbIA2;
        private System.Windows.Forms.TextBox IbILength;
        private System.Windows.Forms.TextBox IbIUpper;
        private System.Windows.Forms.TextBox IbILower;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}


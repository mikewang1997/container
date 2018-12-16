namespace container
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
            this.lblShipHeight = new System.Windows.Forms.Label();
            this.lblShipWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxShip = new System.Windows.Forms.GroupBox();
            this.txtBoxShipWeight = new System.Windows.Forms.TextBox();
            this.lblBoxShipWeight = new System.Windows.Forms.Label();
            this.GrpBoxContainer = new System.Windows.Forms.GroupBox();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.lblWeightContainer = new System.Windows.Forms.Label();
            this.lblTypeContainer = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnArrange = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBoxStack = new System.Windows.Forms.TextBox();
            this.lblStack = new System.Windows.Forms.Label();
            this.grpBoxShip.SuspendLayout();
            this.GrpBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShipHeight
            // 
            this.lblShipHeight.AutoSize = true;
            this.lblShipHeight.Location = new System.Drawing.Point(21, 52);
            this.lblShipHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShipHeight.Name = "lblShipHeight";
            this.lblShipHeight.Size = new System.Drawing.Size(38, 13);
            this.lblShipHeight.TabIndex = 0;
            this.lblShipHeight.Text = "Height";
            // 
            // lblShipWidth
            // 
            this.lblShipWidth.AutoSize = true;
            this.lblShipWidth.Location = new System.Drawing.Point(21, 28);
            this.lblShipWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShipWidth.Name = "lblShipWidth";
            this.lblShipWidth.Size = new System.Drawing.Size(35, 13);
            this.lblShipWidth.TabIndex = 1;
            this.lblShipWidth.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // grpBoxShip
            // 
            this.grpBoxShip.Controls.Add(this.txtBoxStack);
            this.grpBoxShip.Controls.Add(this.lblStack);
            this.grpBoxShip.Controls.Add(this.txtBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.lblBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.GrpBoxContainer);
            this.grpBoxShip.Controls.Add(this.btnArrange);
            this.grpBoxShip.Controls.Add(this.textBox2);
            this.grpBoxShip.Controls.Add(this.textBox1);
            this.grpBoxShip.Controls.Add(this.lblShipHeight);
            this.grpBoxShip.Controls.Add(this.lblShipWidth);
            this.grpBoxShip.Location = new System.Drawing.Point(9, 10);
            this.grpBoxShip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxShip.Name = "grpBoxShip";
            this.grpBoxShip.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxShip.Size = new System.Drawing.Size(436, 425);
            this.grpBoxShip.TabIndex = 4;
            this.grpBoxShip.TabStop = false;
            this.grpBoxShip.Text = "Ship";
            // 
            // txtBoxShipWeight
            // 
            this.txtBoxShipWeight.Location = new System.Drawing.Point(187, 25);
            this.txtBoxShipWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxShipWeight.Name = "txtBoxShipWeight";
            this.txtBoxShipWeight.Size = new System.Drawing.Size(76, 20);
            this.txtBoxShipWeight.TabIndex = 9;
            // 
            // lblBoxShipWeight
            // 
            this.lblBoxShipWeight.AutoSize = true;
            this.lblBoxShipWeight.Location = new System.Drawing.Point(142, 28);
            this.lblBoxShipWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoxShipWeight.Name = "lblBoxShipWeight";
            this.lblBoxShipWeight.Size = new System.Drawing.Size(41, 13);
            this.lblBoxShipWeight.TabIndex = 8;
            this.lblBoxShipWeight.Text = "Weight";
            // 
            // GrpBoxContainer
            // 
            this.GrpBoxContainer.Controls.Add(this.btnRemoveContainer);
            this.GrpBoxContainer.Controls.Add(this.btnAddContainer);
            this.GrpBoxContainer.Controls.Add(this.textBox4);
            this.GrpBoxContainer.Controls.Add(this.listBoxContainer);
            this.GrpBoxContainer.Controls.Add(this.lblWeightContainer);
            this.GrpBoxContainer.Controls.Add(this.lblTypeContainer);
            this.GrpBoxContainer.Controls.Add(this.textBox3);
            this.GrpBoxContainer.Location = new System.Drawing.Point(24, 121);
            this.GrpBoxContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxContainer.Name = "GrpBoxContainer";
            this.GrpBoxContainer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxContainer.Size = new System.Drawing.Size(205, 253);
            this.GrpBoxContainer.TabIndex = 7;
            this.GrpBoxContainer.TabStop = false;
            this.GrpBoxContainer.Text = "Container";
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Location = new System.Drawing.Point(118, 97);
            this.btnRemoveContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(62, 31);
            this.btnRemoveContainer.TabIndex = 11;
            this.btnRemoveContainer.Text = "Remove";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(14, 97);
            this.btnAddContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(64, 31);
            this.btnAddContainer.TabIndex = 10;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 55);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 9;
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.Location = new System.Drawing.Point(14, 132);
            this.listBoxContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(168, 108);
            this.listBoxContainer.TabIndex = 5;
            // 
            // lblWeightContainer
            // 
            this.lblWeightContainer.AutoSize = true;
            this.lblWeightContainer.Location = new System.Drawing.Point(12, 58);
            this.lblWeightContainer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeightContainer.Name = "lblWeightContainer";
            this.lblWeightContainer.Size = new System.Drawing.Size(41, 13);
            this.lblWeightContainer.TabIndex = 8;
            this.lblWeightContainer.Text = "Weight";
            // 
            // lblTypeContainer
            // 
            this.lblTypeContainer.AutoSize = true;
            this.lblTypeContainer.Location = new System.Drawing.Point(12, 31);
            this.lblTypeContainer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeContainer.Name = "lblTypeContainer";
            this.lblTypeContainer.Size = new System.Drawing.Size(31, 13);
            this.lblTypeContainer.TabIndex = 7;
            this.lblTypeContainer.Text = "Type";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(376, 355);
            this.btnArrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(56, 19);
            this.btnArrange.TabIndex = 4;
            this.btnArrange.Text = "Sort";
            this.btnArrange.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtBoxStack
            // 
            this.txtBoxStack.Location = new System.Drawing.Point(62, 73);
            this.txtBoxStack.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxStack.Name = "txtBoxStack";
            this.txtBoxStack.Size = new System.Drawing.Size(76, 20);
            this.txtBoxStack.TabIndex = 11;
            // 
            // lblStack
            // 
            this.lblStack.AutoSize = true;
            this.lblStack.Location = new System.Drawing.Point(21, 76);
            this.lblStack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(35, 13);
            this.lblStack.TabIndex = 10;
            this.lblStack.Text = "Stack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 446);
            this.Controls.Add(this.grpBoxShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxShip.ResumeLayout(false);
            this.grpBoxShip.PerformLayout();
            this.GrpBoxContainer.ResumeLayout(false);
            this.GrpBoxContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShipHeight;
        private System.Windows.Forms.Label lblShipWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxShip;
        private System.Windows.Forms.ListBox listBoxContainer;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GrpBoxContainer;
        private System.Windows.Forms.Button btnRemoveContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblWeightContainer;
        private System.Windows.Forms.Label lblTypeContainer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBoxShipWeight;
        private System.Windows.Forms.Label lblBoxShipWeight;
        private System.Windows.Forms.TextBox txtBoxStack;
        private System.Windows.Forms.Label lblStack;
    }
}


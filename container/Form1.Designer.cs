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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnArrange = new System.Windows.Forms.Button();
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GrpBoxContainer = new System.Windows.Forms.GroupBox();
            this.lblTypeContainer = new System.Windows.Forms.Label();
            this.lblWeightContainer = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.lblBoxShipWeight = new System.Windows.Forms.Label();
            this.txtBoxShipWeight = new System.Windows.Forms.TextBox();
            this.grpBoxShip.SuspendLayout();
            this.GrpBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShipHeight
            // 
            this.lblShipHeight.AutoSize = true;
            this.lblShipHeight.Location = new System.Drawing.Point(28, 43);
            this.lblShipHeight.Name = "lblShipHeight";
            this.lblShipHeight.Size = new System.Drawing.Size(49, 17);
            this.lblShipHeight.TabIndex = 0;
            this.lblShipHeight.Text = "Height";
            // 
            // lblShipWidth
            // 
            this.lblShipWidth.AutoSize = true;
            this.lblShipWidth.Location = new System.Drawing.Point(28, 78);
            this.lblShipWidth.Name = "lblShipWidth";
            this.lblShipWidth.Size = new System.Drawing.Size(44, 17);
            this.lblShipWidth.TabIndex = 1;
            this.lblShipWidth.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // grpBoxShip
            // 
            this.grpBoxShip.Controls.Add(this.txtBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.lblBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.GrpBoxContainer);
            this.grpBoxShip.Controls.Add(this.btnArrange);
            this.grpBoxShip.Controls.Add(this.textBox2);
            this.grpBoxShip.Controls.Add(this.textBox1);
            this.grpBoxShip.Controls.Add(this.lblShipHeight);
            this.grpBoxShip.Controls.Add(this.lblShipWidth);
            this.grpBoxShip.Location = new System.Drawing.Point(12, 12);
            this.grpBoxShip.Name = "grpBoxShip";
            this.grpBoxShip.Size = new System.Drawing.Size(581, 476);
            this.grpBoxShip.TabIndex = 4;
            this.grpBoxShip.TabStop = false;
            this.grpBoxShip.Text = "Ship";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(500, 429);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(75, 23);
            this.btnArrange.TabIndex = 4;
            this.btnArrange.Text = "Sort";
            this.btnArrange.UseVisualStyleBackColor = true;
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.ItemHeight = 16;
            this.listBoxContainer.Location = new System.Drawing.Point(19, 163);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(222, 132);
            this.listBoxContainer.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
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
            this.GrpBoxContainer.Location = new System.Drawing.Point(31, 141);
            this.GrpBoxContainer.Name = "GrpBoxContainer";
            this.GrpBoxContainer.Size = new System.Drawing.Size(273, 311);
            this.GrpBoxContainer.TabIndex = 7;
            this.GrpBoxContainer.TabStop = false;
            this.GrpBoxContainer.Text = "Container";
            // 
            // lblTypeContainer
            // 
            this.lblTypeContainer.AutoSize = true;
            this.lblTypeContainer.Location = new System.Drawing.Point(16, 38);
            this.lblTypeContainer.Name = "lblTypeContainer";
            this.lblTypeContainer.Size = new System.Drawing.Size(40, 17);
            this.lblTypeContainer.TabIndex = 7;
            this.lblTypeContainer.Text = "Type";
            // 
            // lblWeightContainer
            // 
            this.lblWeightContainer.AutoSize = true;
            this.lblWeightContainer.Location = new System.Drawing.Point(16, 71);
            this.lblWeightContainer.Name = "lblWeightContainer";
            this.lblWeightContainer.Size = new System.Drawing.Size(52, 17);
            this.lblWeightContainer.TabIndex = 8;
            this.lblWeightContainer.Text = "Weight";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(19, 119);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(85, 38);
            this.btnAddContainer.TabIndex = 10;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Location = new System.Drawing.Point(158, 119);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(83, 38);
            this.btnRemoveContainer.TabIndex = 11;
            this.btnRemoveContainer.Text = "Remove";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            // 
            // lblBoxShipWeight
            // 
            this.lblBoxShipWeight.AutoSize = true;
            this.lblBoxShipWeight.Location = new System.Drawing.Point(200, 43);
            this.lblBoxShipWeight.Name = "lblBoxShipWeight";
            this.lblBoxShipWeight.Size = new System.Drawing.Size(52, 17);
            this.lblBoxShipWeight.TabIndex = 8;
            this.lblBoxShipWeight.Text = "Weight";
            // 
            // txtBoxShipWeight
            // 
            this.txtBoxShipWeight.Location = new System.Drawing.Point(258, 40);
            this.txtBoxShipWeight.Name = "txtBoxShipWeight";
            this.txtBoxShipWeight.Size = new System.Drawing.Size(100, 22);
            this.txtBoxShipWeight.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 549);
            this.Controls.Add(this.grpBoxShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}


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
            this.grpBoxShip = new System.Windows.Forms.GroupBox();
            this.txtBoxStack = new System.Windows.Forms.TextBox();
            this.lblStack = new System.Windows.Forms.Label();
            this.txtBoxShipWeight = new System.Windows.Forms.TextBox();
            this.lblBoxShipWeight = new System.Windows.Forms.Label();
            this.GrpBoxContainer = new System.Windows.Forms.GroupBox();
            this.btnRemoveContainer = new System.Windows.Forms.Button();
            this.btnAddContainer = new System.Windows.Forms.Button();
            this.txtBoxContainerWeight = new System.Windows.Forms.TextBox();
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.lblWeightContainer = new System.Windows.Forms.Label();
            this.lblTypeContainer = new System.Windows.Forms.Label();
            this.btnArrange = new System.Windows.Forms.Button();
            this.txtBoxWidth = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.dataGridViewShip = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxContainerType = new System.Windows.Forms.ComboBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblChilled = new System.Windows.Forms.Label();
            this.lblValuable = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.grpBoxShip.SuspendLayout();
            this.GrpBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShip)).BeginInit();
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
            // grpBoxShip
            // 
            this.grpBoxShip.Controls.Add(this.txtBoxStack);
            this.grpBoxShip.Controls.Add(this.lblStack);
            this.grpBoxShip.Controls.Add(this.txtBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.lblBoxShipWeight);
            this.grpBoxShip.Controls.Add(this.GrpBoxContainer);
            this.grpBoxShip.Controls.Add(this.btnArrange);
            this.grpBoxShip.Controls.Add(this.txtBoxWidth);
            this.grpBoxShip.Controls.Add(this.txtBoxHeight);
            this.grpBoxShip.Controls.Add(this.lblShipHeight);
            this.grpBoxShip.Controls.Add(this.lblShipWidth);
            this.grpBoxShip.Location = new System.Drawing.Point(9, 10);
            this.grpBoxShip.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxShip.Name = "grpBoxShip";
            this.grpBoxShip.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxShip.Size = new System.Drawing.Size(449, 428);
            this.grpBoxShip.TabIndex = 4;
            this.grpBoxShip.TabStop = false;
            this.grpBoxShip.Text = "Ship";
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
            // txtBoxShipWeight
            // 
            this.txtBoxShipWeight.Location = new System.Drawing.Point(187, 25);
            this.txtBoxShipWeight.Margin = new System.Windows.Forms.Padding(2);
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
            this.GrpBoxContainer.Controls.Add(this.lblNormal);
            this.GrpBoxContainer.Controls.Add(this.lblChilled);
            this.GrpBoxContainer.Controls.Add(this.lblValuable);
            this.GrpBoxContainer.Controls.Add(this.comboBoxContainerType);
            this.GrpBoxContainer.Controls.Add(this.btnRemoveContainer);
            this.GrpBoxContainer.Controls.Add(this.lblTotalWeight);
            this.GrpBoxContainer.Controls.Add(this.btnAddContainer);
            this.GrpBoxContainer.Controls.Add(this.txtBoxContainerWeight);
            this.GrpBoxContainer.Controls.Add(this.listBoxContainer);
            this.GrpBoxContainer.Controls.Add(this.lblWeightContainer);
            this.GrpBoxContainer.Controls.Add(this.lblTypeContainer);
            this.GrpBoxContainer.Location = new System.Drawing.Point(24, 121);
            this.GrpBoxContainer.Margin = new System.Windows.Forms.Padding(2);
            this.GrpBoxContainer.Name = "GrpBoxContainer";
            this.GrpBoxContainer.Padding = new System.Windows.Forms.Padding(2);
            this.GrpBoxContainer.Size = new System.Drawing.Size(316, 283);
            this.GrpBoxContainer.TabIndex = 7;
            this.GrpBoxContainer.TabStop = false;
            this.GrpBoxContainer.Text = "Container";
            // 
            // btnRemoveContainer
            // 
            this.btnRemoveContainer.Location = new System.Drawing.Point(118, 97);
            this.btnRemoveContainer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveContainer.Name = "btnRemoveContainer";
            this.btnRemoveContainer.Size = new System.Drawing.Size(62, 31);
            this.btnRemoveContainer.TabIndex = 11;
            this.btnRemoveContainer.Text = "Remove";
            this.btnRemoveContainer.UseVisualStyleBackColor = true;
            // 
            // btnAddContainer
            // 
            this.btnAddContainer.Location = new System.Drawing.Point(14, 97);
            this.btnAddContainer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddContainer.Name = "btnAddContainer";
            this.btnAddContainer.Size = new System.Drawing.Size(64, 31);
            this.btnAddContainer.TabIndex = 10;
            this.btnAddContainer.Text = "Add";
            this.btnAddContainer.UseVisualStyleBackColor = true;
            this.btnAddContainer.Click += new System.EventHandler(this.btnAddContainer_Click);
            // 
            // txtBoxContainerWeight
            // 
            this.txtBoxContainerWeight.Location = new System.Drawing.Point(70, 55);
            this.txtBoxContainerWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxContainerWeight.Name = "txtBoxContainerWeight";
            this.txtBoxContainerWeight.Size = new System.Drawing.Size(110, 20);
            this.txtBoxContainerWeight.TabIndex = 9;
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.Location = new System.Drawing.Point(14, 132);
            this.listBoxContainer.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(168, 134);
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
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(359, 356);
            this.btnArrange.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(86, 44);
            this.btnArrange.TabIndex = 4;
            this.btnArrange.Text = "Sort";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // txtBoxWidth
            // 
            this.txtBoxWidth.Location = new System.Drawing.Point(62, 25);
            this.txtBoxWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxWidth.Name = "txtBoxWidth";
            this.txtBoxWidth.Size = new System.Drawing.Size(76, 20);
            this.txtBoxWidth.TabIndex = 3;
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(62, 49);
            this.txtBoxHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(76, 20);
            this.txtBoxHeight.TabIndex = 2;
            // 
            // dataGridViewShip
            // 
            this.dataGridViewShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Row,
            this.Stack,
            this.Type,
            this.Weight});
            this.dataGridViewShip.Location = new System.Drawing.Point(473, 12);
            this.dataGridViewShip.Name = "dataGridViewShip";
            this.dataGridViewShip.Size = new System.Drawing.Size(682, 580);
            this.dataGridViewShip.TabIndex = 7;
            // 
            // Column
            // 
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            // 
            // Row
            // 
            this.Row.HeaderText = "Row";
            this.Row.Name = "Row";
            // 
            // Stack
            // 
            this.Stack.HeaderText = "Stack";
            this.Stack.Name = "Stack";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // comboBoxContainerType
            // 
            this.comboBoxContainerType.FormattingEnabled = true;
            this.comboBoxContainerType.Location = new System.Drawing.Point(70, 28);
            this.comboBoxContainerType.Name = "comboBoxContainerType";
            this.comboBoxContainerType.Size = new System.Drawing.Size(110, 21);
            this.comboBoxContainerType.TabIndex = 12;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(188, 175);
            this.lblTotalWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(68, 13);
            this.lblTotalWeight.TabIndex = 12;
            this.lblTotalWeight.Text = "Total weight:";
            // 
            // lblChilled
            // 
            this.lblChilled.AutoSize = true;
            this.lblChilled.Location = new System.Drawing.Point(188, 225);
            this.lblChilled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChilled.Name = "lblChilled";
            this.lblChilled.Size = new System.Drawing.Size(67, 13);
            this.lblChilled.TabIndex = 13;
            this.lblChilled.Text = "Total chilled:";
            // 
            // lblValuable
            // 
            this.lblValuable.AutoSize = true;
            this.lblValuable.Location = new System.Drawing.Point(188, 251);
            this.lblValuable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValuable.Name = "lblValuable";
            this.lblValuable.Size = new System.Drawing.Size(77, 13);
            this.lblValuable.TabIndex = 14;
            this.lblValuable.Text = "Total valuable:";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(188, 200);
            this.lblNormal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(68, 13);
            this.lblNormal.TabIndex = 15;
            this.lblNormal.Text = "Total normal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 628);
            this.Controls.Add(this.dataGridViewShip);
            this.Controls.Add(this.grpBoxShip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxShip.ResumeLayout(false);
            this.grpBoxShip.PerformLayout();
            this.GrpBoxContainer.ResumeLayout(false);
            this.GrpBoxContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShipHeight;
        private System.Windows.Forms.Label lblShipWidth;
        private System.Windows.Forms.GroupBox grpBoxShip;
        private System.Windows.Forms.ListBox listBoxContainer;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.TextBox txtBoxWidth;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.GroupBox GrpBoxContainer;
        private System.Windows.Forms.Button btnRemoveContainer;
        private System.Windows.Forms.Button btnAddContainer;
        private System.Windows.Forms.TextBox txtBoxContainerWeight;
        private System.Windows.Forms.Label lblWeightContainer;
        private System.Windows.Forms.Label lblTypeContainer;
        private System.Windows.Forms.TextBox txtBoxShipWeight;
        private System.Windows.Forms.Label lblBoxShipWeight;
        private System.Windows.Forms.TextBox txtBoxStack;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.DataGridView dataGridViewShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.ComboBox comboBoxContainerType;
        private System.Windows.Forms.Label lblValuable;
        private System.Windows.Forms.Label lblChilled;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblNormal;
    }
}


namespace GU_DR_CSHRP
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
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnAddMake = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnPartial = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMake
            // 
            this.cbMake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(44, 47);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(232, 28);
            this.cbMake.TabIndex = 0;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            this.cbMake.TextChanged += new System.EventHandler(this.cbMake_TextChanged);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(687, 47);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 28);
            this.btnAddModel.TabIndex = 19;
            this.btnAddModel.Text = "Add";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Visible = false;
            // 
            // btnAddMake
            // 
            this.btnAddMake.Location = new System.Drawing.Point(299, 47);
            this.btnAddMake.Name = "btnAddMake";
            this.btnAddMake.Size = new System.Drawing.Size(75, 28);
            this.btnAddMake.TabIndex = 18;
            this.btnAddMake.Text = "Add";
            this.btnAddMake.UseVisualStyleBackColor = true;
            this.btnAddMake.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(788, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Year";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(434, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Model";
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(791, 47);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(116, 28);
            this.cbYear.TabIndex = 15;
            // 
            // cbModel
            // 
            this.cbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(437, 47);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(232, 28);
            this.cbModel.TabIndex = 14;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            this.cbModel.TextChanged += new System.EventHandler(this.cbModel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Make";
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNewCategory.Location = new System.Drawing.Point(1004, 127);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(113, 23);
            this.btnAddNewCategory.TabIndex = 25;
            this.btnAddNewCategory.Text = "Add Category";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveCategory.Location = new System.Drawing.Point(843, 127);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(139, 23);
            this.btnRemoveCategory.TabIndex = 26;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(399, 127);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 23);
            this.btnFull.TabIndex = 24;
            this.btnFull.Text = "Full";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnPartial
            // 
            this.btnPartial.Location = new System.Drawing.Point(279, 127);
            this.btnPartial.Name = "btnPartial";
            this.btnPartial.Size = new System.Drawing.Size(75, 23);
            this.btnPartial.TabIndex = 23;
            this.btnPartial.Text = "Partial";
            this.btnPartial.UseVisualStyleBackColor = true;
            this.btnPartial.Click += new System.EventHandler(this.btnPartial_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(151, 127);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(75, 23);
            this.btnPatch.TabIndex = 22;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(41, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 13);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Type of Job:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 156);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.Label11);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalCost);
            this.splitContainer1.Panel1.Controls.Add(this.panelCategory);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 584);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 27;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(3, 355);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 13);
            this.Label11.TabIndex = 23;
            this.Label11.Text = "Total Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(64, 355);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(28, 13);
            this.lblTotalCost.TabIndex = 22;
            this.lblTotalCost.Text = "0.00";
            // 
            // panelCategory
            // 
            this.panelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCategory.AutoScroll = true;
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCategory.Controls.Add(this.TextBox3);
            this.panelCategory.Controls.Add(this.ComboBox1);
            this.panelCategory.Controls.Add(this.TextBox2);
            this.panelCategory.Controls.Add(this.TextBox1);
            this.panelCategory.Controls.Add(this.Label10);
            this.panelCategory.Controls.Add(this.Label9);
            this.panelCategory.Controls.Add(this.Label8);
            this.panelCategory.Controls.Add(this.Label7);
            this.panelCategory.Controls.Add(this.Label6);
            this.panelCategory.Location = new System.Drawing.Point(3, 3);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(1137, 349);
            this.panelCategory.TabIndex = 8;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(308, 53);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(52, 20);
            this.TextBox3.TabIndex = 8;
            this.TextBox3.Visible = false;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(394, 52);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 7;
            this.ComboBox1.Visible = false;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(250, 52);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(52, 20);
            this.TextBox2.TabIndex = 6;
            this.TextBox2.Visible = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(115, 51);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 5;
            this.TextBox1.Visible = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(394, 36);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(45, 13);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Label10";
            this.Label10.Visible = false;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(250, 35);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(39, 13);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "Label9";
            this.Label9.Visible = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(115, 35);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Label8";
            this.Label8.Visible = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(40, 35);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 13);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Driver";
            this.Label7.Visible = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(15, 13);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(39, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Label6";
            this.Label6.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1080, 746);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 774);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnPartial);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.btnAddMake);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMake);
            this.Name = "Form1";
            this.Text = "GUDR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMake;
        internal System.Windows.Forms.Button btnAddModel;
        internal System.Windows.Forms.Button btnAddMake;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbYear;
        internal System.Windows.Forms.ComboBox cbModel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAddNewCategory;
        internal System.Windows.Forms.Button btnRemoveCategory;
        internal System.Windows.Forms.Button btnFull;
        internal System.Windows.Forms.Button btnPartial;
        internal System.Windows.Forms.Button btnPatch;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label lblTotalCost;
        internal System.Windows.Forms.Panel panelCategory;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnClose;
    }
}


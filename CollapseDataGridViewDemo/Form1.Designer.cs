namespace CollapseDataGridViewDemo
{
    partial class DemoForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnInsertGroup = new System.Windows.Forms.Button();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.btnShowGridInfo = new System.Windows.Forms.Button();
            this.btnShowGroupInfo = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.cbFreezeGroupHeader = new System.Windows.Forms.CheckBox();
            this.btnAddEmptyItem = new System.Windows.Forms.Button();
            this.btnAddEmptyGroup = new System.Windows.Forms.Button();
            this.btnInsertEmptyItem = new System.Windows.Forms.Button();
            this.btnInsertEmptyGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdgvAthleteInfo = new CollapseDataGridViewDemo.Controls.CollapseDataGridView();
            this.col_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGroupCount = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cdgvAthleteInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Collapse Data Grid View Demo";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(395, 410);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteGroup.TabIndex = 4;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(395, 383);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnInsertGroup
            // 
            this.btnInsertGroup.Location = new System.Drawing.Point(264, 410);
            this.btnInsertGroup.Name = "btnInsertGroup";
            this.btnInsertGroup.Size = new System.Drawing.Size(125, 23);
            this.btnInsertGroup.TabIndex = 6;
            this.btnInsertGroup.Text = "Insert Group";
            this.btnInsertGroup.UseVisualStyleBackColor = true;
            this.btnInsertGroup.Click += new System.EventHandler(this.btnInsertGroup_Click);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Location = new System.Drawing.Point(264, 383);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(125, 23);
            this.btnInsertItem.TabIndex = 7;
            this.btnInsertItem.Text = "Insert Item";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // btnShowGridInfo
            // 
            this.btnShowGridInfo.Location = new System.Drawing.Point(2, 383);
            this.btnShowGridInfo.Name = "btnShowGridInfo";
            this.btnShowGridInfo.Size = new System.Drawing.Size(125, 23);
            this.btnShowGridInfo.TabIndex = 8;
            this.btnShowGridInfo.Text = "Grid Info";
            this.btnShowGridInfo.UseVisualStyleBackColor = true;
            this.btnShowGridInfo.Click += new System.EventHandler(this.btnShowGridInfo_Click);
            // 
            // btnShowGroupInfo
            // 
            this.btnShowGroupInfo.Location = new System.Drawing.Point(2, 410);
            this.btnShowGroupInfo.Name = "btnShowGroupInfo";
            this.btnShowGroupInfo.Size = new System.Drawing.Size(125, 23);
            this.btnShowGroupInfo.TabIndex = 9;
            this.btnShowGroupInfo.Text = "Group Info";
            this.btnShowGroupInfo.UseVisualStyleBackColor = true;
            this.btnShowGroupInfo.Click += new System.EventHandler(this.btnShowGroupInfo_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(133, 383);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(125, 23);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(133, 410);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(125, 23);
            this.btnAddGroup.TabIndex = 11;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // cbFreezeGroupHeader
            // 
            this.cbFreezeGroupHeader.AutoSize = true;
            this.cbFreezeGroupHeader.Location = new System.Drawing.Point(644, 15);
            this.cbFreezeGroupHeader.Name = "cbFreezeGroupHeader";
            this.cbFreezeGroupHeader.Size = new System.Drawing.Size(138, 16);
            this.cbFreezeGroupHeader.TabIndex = 12;
            this.cbFreezeGroupHeader.Text = "Freeze Group Header";
            this.cbFreezeGroupHeader.UseVisualStyleBackColor = true;
            this.cbFreezeGroupHeader.CheckedChanged += new System.EventHandler(this.cbFreezeGroupHeader_CheckedChanged);
            // 
            // btnAddEmptyItem
            // 
            this.btnAddEmptyItem.Location = new System.Drawing.Point(526, 383);
            this.btnAddEmptyItem.Name = "btnAddEmptyItem";
            this.btnAddEmptyItem.Size = new System.Drawing.Size(125, 23);
            this.btnAddEmptyItem.TabIndex = 13;
            this.btnAddEmptyItem.Text = "Add Empty Item";
            this.btnAddEmptyItem.UseVisualStyleBackColor = true;
            this.btnAddEmptyItem.Click += new System.EventHandler(this.btnAddEmptyItem_Click);
            // 
            // btnAddEmptyGroup
            // 
            this.btnAddEmptyGroup.Location = new System.Drawing.Point(526, 410);
            this.btnAddEmptyGroup.Name = "btnAddEmptyGroup";
            this.btnAddEmptyGroup.Size = new System.Drawing.Size(125, 23);
            this.btnAddEmptyGroup.TabIndex = 14;
            this.btnAddEmptyGroup.Text = "Add Empty Group";
            this.btnAddEmptyGroup.UseVisualStyleBackColor = true;
            this.btnAddEmptyGroup.Click += new System.EventHandler(this.btnAddEmptyGroup_Click);
            // 
            // btnInsertEmptyItem
            // 
            this.btnInsertEmptyItem.Location = new System.Drawing.Point(657, 383);
            this.btnInsertEmptyItem.Name = "btnInsertEmptyItem";
            this.btnInsertEmptyItem.Size = new System.Drawing.Size(125, 23);
            this.btnInsertEmptyItem.TabIndex = 15;
            this.btnInsertEmptyItem.Text = "Insert Empty Item";
            this.btnInsertEmptyItem.UseVisualStyleBackColor = true;
            this.btnInsertEmptyItem.Click += new System.EventHandler(this.btnInsertEmptyItem_Click);
            // 
            // btnInsertEmptyGroup
            // 
            this.btnInsertEmptyGroup.Location = new System.Drawing.Point(657, 410);
            this.btnInsertEmptyGroup.Name = "btnInsertEmptyGroup";
            this.btnInsertEmptyGroup.Size = new System.Drawing.Size(125, 23);
            this.btnInsertEmptyGroup.TabIndex = 16;
            this.btnInsertEmptyGroup.Text = "Insert Empty Group";
            this.btnInsertEmptyGroup.UseVisualStyleBackColor = true;
            this.btnInsertEmptyGroup.Click += new System.EventHandler(this.btnInsertEmptyGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Group(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = " Item(s): ";
            // 
            // cdgvAthleteInfo
            // 
            this.cdgvAthleteInfo.AllowUserToAddRows = false;
            this.cdgvAthleteInfo.AllowUserToDeleteRows = false;
            this.cdgvAthleteInfo.AllowUserToResizeRows = false;
            this.cdgvAthleteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cdgvAthleteInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cdgvAthleteInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdgvAthleteInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Country,
            this.col_Name,
            this.col_Gender,
            this.col_Height,
            this.col_Weight,
            this.col_Item});
            this.cdgvAthleteInfo.GroupEvenColor = System.Drawing.Color.Gainsboro;
            this.cdgvAthleteInfo.GroupOddColor = System.Drawing.Color.White;
            this.cdgvAthleteInfo.ImageHeight = 15;
            this.cdgvAthleteInfo.ImageWidth = 15;
            this.cdgvAthleteInfo.ImgCollapse = global::CollapseDataGridViewDemo.Properties.Resources.Collapse;
            this.cdgvAthleteInfo.ImgExpand = global::CollapseDataGridViewDemo.Properties.Resources.Expand;
            this.cdgvAthleteInfo.IsFreezeGroupHeader = true;
            this.cdgvAthleteInfo.Location = new System.Drawing.Point(2, 34);
            this.cdgvAthleteInfo.MultiSelect = false;
            this.cdgvAthleteInfo.Name = "cdgvAthleteInfo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(41);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cdgvAthleteInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cdgvAthleteInfo.RowHeadersWidth = 25;
            this.cdgvAthleteInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cdgvAthleteInfo.RowTemplate.Height = 23;
            this.cdgvAthleteInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cdgvAthleteInfo.Size = new System.Drawing.Size(780, 343);
            this.cdgvAthleteInfo.TabIndex = 3;
            // 
            // col_Country
            // 
            this.col_Country.DataPropertyName = "Country";
            this.col_Country.HeaderText = "Country";
            this.col_Country.Name = "col_Country";
            this.col_Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Country.Width = 125;
            // 
            // col_Name
            // 
            this.col_Name.DataPropertyName = "Name";
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Name.Width = 125;
            // 
            // col_Gender
            // 
            this.col_Gender.DataPropertyName = "Gender";
            this.col_Gender.HeaderText = "Gender";
            this.col_Gender.Name = "col_Gender";
            this.col_Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Gender.Width = 125;
            // 
            // col_Height
            // 
            this.col_Height.DataPropertyName = "Height";
            this.col_Height.HeaderText = "Height(cm)";
            this.col_Height.Name = "col_Height";
            this.col_Height.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Height.Width = 125;
            // 
            // col_Weight
            // 
            this.col_Weight.DataPropertyName = "Weight";
            this.col_Weight.HeaderText = "Weight(kg)";
            this.col_Weight.Name = "col_Weight";
            this.col_Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Weight.Width = 125;
            // 
            // col_Item
            // 
            this.col_Item.DataPropertyName = "Item";
            this.col_Item.HeaderText = "Sport Item";
            this.col_Item.Name = "col_Item";
            this.col_Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Item.Width = 150;
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.AutoSize = true;
            this.lblGroupCount.Location = new System.Drawing.Point(60, 4);
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(11, 12);
            this.lblGroupCount.TabIndex = 19;
            this.lblGroupCount.Text = "0";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(60, 21);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(11, 12);
            this.lblItemCount.TabIndex = 20;
            this.lblItemCount.Text = "0";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 436);
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.lblGroupCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertEmptyGroup);
            this.Controls.Add(this.btnInsertEmptyItem);
            this.Controls.Add(this.btnAddEmptyGroup);
            this.Controls.Add(this.btnAddEmptyItem);
            this.Controls.Add(this.cbFreezeGroupHeader);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnShowGroupInfo);
            this.Controls.Add(this.btnShowGridInfo);
            this.Controls.Add(this.btnInsertItem);
            this.Controls.Add(this.btnInsertGroup);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.cdgvAthleteInfo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collapse Data Grid View Demo";
            ((System.ComponentModel.ISupportInitialize)(this.cdgvAthleteInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CollapseDataGridViewDemo.Controls.CollapseDataGridView cdgvAthleteInfo;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnInsertGroup;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.Button btnShowGridInfo;
        private System.Windows.Forms.Button btnShowGroupInfo;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.CheckBox cbFreezeGroupHeader;
        private System.Windows.Forms.Button btnAddEmptyItem;
        private System.Windows.Forms.Button btnAddEmptyGroup;
        private System.Windows.Forms.Button btnInsertEmptyItem;
        private System.Windows.Forms.Button btnInsertEmptyGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGroupCount;
        private System.Windows.Forms.Label lblItemCount;

    }
}


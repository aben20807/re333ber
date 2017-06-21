namespace RE333BER
{
    partial class FormMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkedListBoxDeckView = new System.Windows.Forms.CheckedListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxNumOfCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardLabel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardLabel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deckBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonView.Location = new System.Drawing.Point(420, 12);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(121, 35);
            this.buttonView.TabIndex = 0;
            this.buttonView.Text = "檢視牌庫";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonImport.Location = new System.Drawing.Point(420, 64);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(122, 35);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "匯入";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelete.Location = new System.Drawing.Point(419, 117);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 35);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "刪除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkedListBoxDeckView
            // 
            this.checkedListBoxDeckView.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBoxDeckView.FormattingEnabled = true;
            this.checkedListBoxDeckView.Items.AddRange(new object[] {
            "托福高級字彙",
            "日文N3單字"});
            this.checkedListBoxDeckView.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxDeckView.Name = "checkedListBoxDeckView";
            this.checkedListBoxDeckView.Size = new System.Drawing.Size(402, 532);
            this.checkedListBoxDeckView.TabIndex = 2;
            this.checkedListBoxDeckView.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDeckView_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStart.Location = new System.Drawing.Point(420, 487);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "開始複習";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardLabel1DataGridViewTextBoxColumn,
            this.cardLabel2DataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deckBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(552, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(498, 510);
            this.dataGridView1.TabIndex = 3;
            // 
            // comboBoxNumOfCard
            // 
            this.comboBoxNumOfCard.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxNumOfCard.FormattingEnabled = true;
            this.comboBoxNumOfCard.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "全部"});
            this.comboBoxNumOfCard.Location = new System.Drawing.Point(419, 451);
            this.comboBoxNumOfCard.Name = "comboBoxNumOfCard";
            this.comboBoxNumOfCard.Size = new System.Drawing.Size(121, 30);
            this.comboBoxNumOfCard.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(420, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "複習張數：";
            // 
            // cardLabel1DataGridViewTextBoxColumn
            // 
            this.cardLabel1DataGridViewTextBoxColumn.DataPropertyName = "CardLabel1";
            this.cardLabel1DataGridViewTextBoxColumn.HeaderText = "CardLabel1";
            this.cardLabel1DataGridViewTextBoxColumn.Name = "cardLabel1DataGridViewTextBoxColumn";
            // 
            // cardLabel2DataGridViewTextBoxColumn
            // 
            this.cardLabel2DataGridViewTextBoxColumn.DataPropertyName = "CardLabel2";
            this.cardLabel2DataGridViewTextBoxColumn.HeaderText = "CardLabel2";
            this.cardLabel2DataGridViewTextBoxColumn.Name = "cardLabel2DataGridViewTextBoxColumn";
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            // 
            // deckBindingSource
            // 
            this.deckBindingSource.DataSource = typeof(RE333BER.Deck);
            // 
            // deckBindingSource1
            // 
            this.deckBindingSource1.DataSource = typeof(RE333BER.Deck);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNumOfCard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBoxDeckView);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonView);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckedListBox checkedListBoxDeckView;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deckBindingSource;
        private System.Windows.Forms.ComboBox comboBoxNumOfCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource deckBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardLabel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardLabel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
    }
}
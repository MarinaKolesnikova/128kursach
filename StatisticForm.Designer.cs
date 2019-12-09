namespace GoodVision
{
    partial class StatisticForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.StatisticTable = new System.Windows.Forms.DataGridView();
            this.BackToMenuButton = new rbutton.CustRoundButton();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightEyeAcuity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StatisticLabel);
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 129);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a_AvanteInt", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тут Ви можете побачити Вашу статистику";
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Location = new System.Drawing.Point(149, 38);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(0, 17);
            this.StatisticLabel.TabIndex = 1;
            // 
            // StatisticTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.StatisticTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StatisticTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatisticTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Date,
            this.LeftEyeAcuity,
            this.RightEyeAcuity});
            this.StatisticTable.Location = new System.Drawing.Point(211, 147);
            this.StatisticTable.Name = "StatisticTable";
            this.StatisticTable.RowTemplate.Height = 24;
            this.StatisticTable.Size = new System.Drawing.Size(902, 416);
            this.StatisticTable.TabIndex = 1;
            this.StatisticTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatisticTable_CellContentClick);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.Image = global::GoodVision.Properties.Resources._14;
            this.BackToMenuButton.ImageHover = global::GoodVision.Properties.Resources._14Hover;
            this.BackToMenuButton.ImageNormal = global::GoodVision.Properties.Resources._14;
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 432);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(192, 152);
            this.BackToMenuButton.TabIndex = 2;
            this.BackToMenuButton.UseVisualStyleBackColor = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Ім\'я користувача";
            this.UserName.Name = "UserName";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // LeftEyeAcuity
            // 
            this.LeftEyeAcuity.HeaderText = "Острота лівого ока";
            this.LeftEyeAcuity.Name = "LeftEyeAcuity";
            // 
            // RightEyeAcuity
            // 
            this.RightEyeAcuity.HeaderText = "Острота правого ока";
            this.RightEyeAcuity.Name = "RightEyeAcuity";
            // 
            // StatisticForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.StatisticTable);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "StatisticForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView StatisticTable;
        private System.Windows.Forms.Label StatisticLabel;
       // private rbutton.CustRoundButton BackToMainButton;
        private System.Windows.Forms.Label label1;
        private rbutton.CustRoundButton BackToMenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftEyeAcuity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightEyeAcuity;
    }
}
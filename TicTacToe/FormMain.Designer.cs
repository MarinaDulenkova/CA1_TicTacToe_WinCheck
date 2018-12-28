namespace TicTacToe
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dgvTicTac = new System.Windows.Forms.DataGridView();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.lblLead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicTac)).BeginInit();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.Location = new System.Drawing.Point(72, 149);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 40);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // dgvTicTac
            // 
            this.dgvTicTac.AllowUserToAddRows = false;
            this.dgvTicTac.AllowUserToDeleteRows = false;
            this.dgvTicTac.AllowUserToOrderColumns = true;
            this.dgvTicTac.AllowUserToResizeColumns = false;
            this.dgvTicTac.AllowUserToResizeRows = false;
            this.dgvTicTac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicTac.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTicTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicTac.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicTac.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTicTac.Location = new System.Drawing.Point(12, 12);
            this.dgvTicTac.MultiSelect = false;
            this.dgvTicTac.Name = "dgvTicTac";
            this.dgvTicTac.RowHeadersVisible = false;
            this.dgvTicTac.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvTicTac.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvTicTac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTicTac.Size = new System.Drawing.Size(367, 367);
            this.dgvTicTac.TabIndex = 1;
            this.dgvTicTac.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTicTac_CellBeginEdit);
            this.dgvTicTac.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicTac_CellValueChanged);
            // 
            // gbParameters
            // 
            this.gbParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParameters.Controls.Add(this.btnClear);
            this.gbParameters.Controls.Add(this.lblM);
            this.gbParameters.Controls.Add(this.lblN);
            this.gbParameters.Controls.Add(this.nudM);
            this.gbParameters.Controls.Add(this.nudN);
            this.gbParameters.Controls.Add(this.btnCheck);
            this.gbParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbParameters.Location = new System.Drawing.Point(396, 12);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(198, 195);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Choose parameters:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(6, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblM.Location = new System.Drawing.Point(6, 85);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(111, 17);
            this.lblM.TabIndex = 3;
            this.lblM.Text = "Winning number";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblN.Location = new System.Drawing.Point(6, 42);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(105, 17);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Size of the field";
            // 
            // nudM
            // 
            this.nudM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudM.Location = new System.Drawing.Point(126, 81);
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(66, 23);
            this.nudM.TabIndex = 1;
            this.nudM.ValueChanged += new System.EventHandler(this.nudM_ValueChanged);
            // 
            // nudN
            // 
            this.nudN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudN.Location = new System.Drawing.Point(126, 38);
            this.nudN.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(66, 23);
            this.nudN.TabIndex = 0;
            this.nudN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // lblLead
            // 
            this.lblLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLead.AutoSize = true;
            this.lblLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLead.Location = new System.Drawing.Point(401, 359);
            this.lblLead.Name = "lblLead";
            this.lblLead.Size = new System.Drawing.Size(61, 20);
            this.lblLead.TabIndex = 3;
            this.lblLead.Text = "Move: ";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 391);
            this.Controls.Add(this.lblLead);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.dgvTicTac);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe: winner check";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicTac)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dgvTicTac;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label lblLead;
        private System.Windows.Forms.Button btnClear;
    }
}


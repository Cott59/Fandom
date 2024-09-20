namespace Fandom
{
    partial class Form1
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
            this.dgrTable = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTablesView = new System.Windows.Forms.Button();
            this.lstBoxTables = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrTable
            // 
            this.dgrTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTable.Location = new System.Drawing.Point(27, 12);
            this.dgrTable.Name = "dgrTable";
            this.dgrTable.Size = new System.Drawing.Size(697, 259);
            this.dgrTable.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(26, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTablesView
            // 
            this.btnTablesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTablesView.Location = new System.Drawing.Point(248, 289);
            this.btnTablesView.Name = "btnTablesView";
            this.btnTablesView.Size = new System.Drawing.Size(216, 49);
            this.btnTablesView.TabIndex = 1;
            this.btnTablesView.Text = "Таблицы в БД";
            this.btnTablesView.UseVisualStyleBackColor = true;
            this.btnTablesView.Click += new System.EventHandler(this.btnTablesView_Click);
            // 
            // lstBoxTables
            // 
            this.lstBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstBoxTables.FormattingEnabled = true;
            this.lstBoxTables.ItemHeight = 25;
            this.lstBoxTables.Location = new System.Drawing.Point(482, 289);
            this.lstBoxTables.Name = "lstBoxTables";
            this.lstBoxTables.Size = new System.Drawing.Size(242, 79);
            this.lstBoxTables.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxTables);
            this.Controls.Add(this.btnTablesView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgrTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTablesView;
        private System.Windows.Forms.ListBox lstBoxTables;
    }
}


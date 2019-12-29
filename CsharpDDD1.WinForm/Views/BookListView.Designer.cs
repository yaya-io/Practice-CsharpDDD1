namespace CsharpDDD1.WinForm.Views
{
    partial class BookListView
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
            this.DgvBookList = new System.Windows.Forms.DataGridView();
            this.ButtonShowData = new System.Windows.Forms.Button();
            this.ButtonShowSaveForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBookList
            // 
            this.DgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookList.Location = new System.Drawing.Point(12, 50);
            this.DgvBookList.Name = "DgvBookList";
            this.DgvBookList.RowTemplate.Height = 21;
            this.DgvBookList.Size = new System.Drawing.Size(285, 150);
            this.DgvBookList.TabIndex = 0;
            // 
            // ButtonShowData
            // 
            this.ButtonShowData.Location = new System.Drawing.Point(184, 12);
            this.ButtonShowData.Name = "ButtonShowData";
            this.ButtonShowData.Size = new System.Drawing.Size(113, 23);
            this.ButtonShowData.TabIndex = 1;
            this.ButtonShowData.Text = "一覧データ表示";
            this.ButtonShowData.UseVisualStyleBackColor = true;
            // 
            // ButtonShowSaveForm
            // 
            this.ButtonShowSaveForm.Location = new System.Drawing.Point(12, 12);
            this.ButtonShowSaveForm.Name = "ButtonShowSaveForm";
            this.ButtonShowSaveForm.Size = new System.Drawing.Size(105, 23);
            this.ButtonShowSaveForm.TabIndex = 2;
            this.ButtonShowSaveForm.Text = "登録画面表示";
            this.ButtonShowSaveForm.UseVisualStyleBackColor = true;            
            // 
            // BookListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 222);
            this.Controls.Add(this.ButtonShowSaveForm);
            this.Controls.Add(this.ButtonShowData);
            this.Controls.Add(this.DgvBookList);
            this.Name = "BookListView";
            this.Text = "BookList";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBookList;
        private System.Windows.Forms.Button ButtonShowData;
        private System.Windows.Forms.Button ButtonShowSaveForm;
    }
}
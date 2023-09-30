namespace TriviaMurder
{
    partial class Main
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
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this._questionComboBox = new System.Windows.Forms.ComboBox();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._answersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Location = new System.Drawing.Point(12, 39);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(242, 20);
            this._searchTextBox.TabIndex = 0;
            this._searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._searchTextBox_KeyPress);
            // 
            // _questionComboBox
            // 
            this._questionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._questionComboBox.Enabled = false;
            this._questionComboBox.FormattingEnabled = true;
            this._questionComboBox.Location = new System.Drawing.Point(12, 65);
            this._questionComboBox.Name = "_questionComboBox";
            this._questionComboBox.Size = new System.Drawing.Size(242, 21);
            this._questionComboBox.TabIndex = 1;
            this._questionComboBox.SelectedIndexChanged += new System.EventHandler(this._questionComboBox_SelectedIndexChanged);
            // 
            // _typeComboBox
            // 
            this._typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Items.AddRange(new object[] {
            "Standart",
            "Final"});
            this._typeComboBox.Location = new System.Drawing.Point(12, 12);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(242, 21);
            this._typeComboBox.TabIndex = 2;
            // 
            // _answersTextBox
            // 
            this._answersTextBox.Location = new System.Drawing.Point(12, 92);
            this._answersTextBox.Multiline = true;
            this._answersTextBox.Name = "_answersTextBox";
            this._answersTextBox.ReadOnly = true;
            this._answersTextBox.Size = new System.Drawing.Size(242, 291);
            this._answersTextBox.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 393);
            this.Controls.Add(this._answersTextBox);
            this.Controls.Add(this._typeComboBox);
            this.Controls.Add(this._questionComboBox);
            this.Controls.Add(this._searchTextBox);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.ComboBox _questionComboBox;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.TextBox _answersTextBox;
    }
}
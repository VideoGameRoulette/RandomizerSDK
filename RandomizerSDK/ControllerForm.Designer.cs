namespace RandomizerSDK
{
    partial class ControllerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.GetItem = new System.Windows.Forms.Button();
            this.IterationCount = new System.Windows.Forms.NumericUpDown();
            this.SeedValue = new System.Windows.Forms.NumericUpDown();
            this.ShowMap = new System.Windows.Forms.CheckBox();
            this.IsDebug = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IterationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // GetItem
            // 
            this.GetItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetItem.Location = new System.Drawing.Point(13, 200);
            this.GetItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetItem.Name = "GetItem";
            this.GetItem.Size = new System.Drawing.Size(304, 24);
            this.GetItem.TabIndex = 8;
            this.GetItem.Text = "Randomize Items";
            this.GetItem.UseVisualStyleBackColor = true;
            this.GetItem.Click += new System.EventHandler(this.GetItem_Click);
            // 
            // IterationCount
            // 
            this.IterationCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IterationCount.Enabled = false;
            this.IterationCount.Location = new System.Drawing.Point(12, 52);
            this.IterationCount.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.IterationCount.Name = "IterationCount";
            this.IterationCount.Size = new System.Drawing.Size(304, 23);
            this.IterationCount.TabIndex = 9;
            // 
            // SeedValue
            // 
            this.SeedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeedValue.Location = new System.Drawing.Point(12, 96);
            this.SeedValue.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SeedValue.Name = "SeedValue";
            this.SeedValue.Size = new System.Drawing.Size(304, 23);
            this.SeedValue.TabIndex = 10;
            // 
            // ShowMap
            // 
            this.ShowMap.AutoSize = true;
            this.ShowMap.Location = new System.Drawing.Point(90, 12);
            this.ShowMap.Name = "ShowMap";
            this.ShowMap.Size = new System.Drawing.Size(172, 19);
            this.ShowMap.TabIndex = 11;
            this.ShowMap.Text = "Show Map After Generation";
            this.ShowMap.UseVisualStyleBackColor = true;
            // 
            // IsDebug
            // 
            this.IsDebug.AutoSize = true;
            this.IsDebug.Location = new System.Drawing.Point(12, 12);
            this.IsDebug.Name = "IsDebug";
            this.IsDebug.Size = new System.Drawing.Size(72, 19);
            this.IsDebug.TabIndex = 12;
            this.IsDebug.Text = "Is Debug";
            this.IsDebug.UseVisualStyleBackColor = true;
            this.IsDebug.CheckedChanged += new System.EventHandler(this.IsDebug_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iterations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Difficulty";
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.Difficulty.Location = new System.Drawing.Point(12, 140);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(304, 23);
            this.Difficulty.TabIndex = 16;
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 236);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsDebug);
            this.Controls.Add(this.ShowMap);
            this.Controls.Add(this.SeedValue);
            this.Controls.Add(this.IterationCount);
            this.Controls.Add(this.GetItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ControllerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomizer SDK";
            ((System.ComponentModel.ISupportInitialize)(this.IterationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GetItem;
        private NumericUpDown IterationCount;
        private NumericUpDown SeedValue;
        private CheckBox ShowMap;
        private CheckBox IsDebug;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox Difficulty;
    }
}

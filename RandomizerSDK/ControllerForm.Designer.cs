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
            ((System.ComponentModel.ISupportInitialize)(this.IterationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // GetItem
            // 
            this.GetItem.Location = new System.Drawing.Point(12, 70);
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
            this.IterationCount.Location = new System.Drawing.Point(12, 41);
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
            this.SeedValue.Location = new System.Drawing.Point(12, 12);
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
            this.ShowMap.Location = new System.Drawing.Point(12, 100);
            this.ShowMap.Name = "ShowMap";
            this.ShowMap.Size = new System.Drawing.Size(172, 19);
            this.ShowMap.TabIndex = 11;
            this.ShowMap.Text = "Show Map After Generation";
            this.ShowMap.UseVisualStyleBackColor = true;
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 137);
            this.Controls.Add(this.ShowMap);
            this.Controls.Add(this.SeedValue);
            this.Controls.Add(this.IterationCount);
            this.Controls.Add(this.GetItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ControllerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powers Calc";
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
    }
}

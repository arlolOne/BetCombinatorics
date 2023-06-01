namespace BetCombinatorics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputBtn = new System.Windows.Forms.Button();
            this.sequenceLengthLabel = new System.Windows.Forms.Label();
            this.sequenceContentLabel = new System.Windows.Forms.Label();
            this.sequenceCountLabel = new System.Windows.Forms.Label();
            this.sequenceLength = new System.Windows.Forms.TextBox();
            this.sequenceContent = new System.Windows.Forms.TextBox();
            this.sequenceCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputBtn
            // 
            this.inputBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBtn.Location = new System.Drawing.Point(34, 14);
            this.inputBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(107, 39);
            this.inputBtn.TabIndex = 1;
            this.inputBtn.Text = "Choose a file";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // sequenceLengthLabel
            // 
            this.sequenceLengthLabel.AutoSize = true;
            this.sequenceLengthLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sequenceLengthLabel.Location = new System.Drawing.Point(31, 78);
            this.sequenceLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sequenceLengthLabel.Name = "sequenceLengthLabel";
            this.sequenceLengthLabel.Size = new System.Drawing.Size(135, 17);
            this.sequenceLengthLabel.TabIndex = 2;
            this.sequenceLengthLabel.Text = "The longest sequence";
            this.sequenceLengthLabel.Click += new System.EventHandler(this.sequenceLengthLabel_Click);
            // 
            // sequenceContentLabel
            // 
            this.sequenceContentLabel.AutoSize = true;
            this.sequenceContentLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sequenceContentLabel.Location = new System.Drawing.Point(31, 103);
            this.sequenceContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sequenceContentLabel.Name = "sequenceContentLabel";
            this.sequenceContentLabel.Size = new System.Drawing.Size(70, 17);
            this.sequenceContentLabel.TabIndex = 3;
            this.sequenceContentLabel.Text = "Its content";
            this.sequenceContentLabel.Click += new System.EventHandler(this.sequenceContentLabel_Click);
            // 
            // sequenceCountLabel
            // 
            this.sequenceCountLabel.AutoSize = true;
            this.sequenceCountLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sequenceCountLabel.Location = new System.Drawing.Point(31, 129);
            this.sequenceCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sequenceCountLabel.Name = "sequenceCountLabel";
            this.sequenceCountLabel.Size = new System.Drawing.Size(59, 17);
            this.sequenceCountLabel.TabIndex = 4;
            this.sequenceCountLabel.Text = "Its count";
            this.sequenceCountLabel.Click += new System.EventHandler(this.sequenceCountLabel_Click);
            // 
            // sequenceLength
            // 
            this.sequenceLength.Location = new System.Drawing.Point(173, 76);
            this.sequenceLength.Name = "sequenceLength";
            this.sequenceLength.ReadOnly = true;
            this.sequenceLength.Size = new System.Drawing.Size(35, 22);
            this.sequenceLength.TabIndex = 6;
            // 
            // sequenceContent
            // 
            this.sequenceContent.Location = new System.Drawing.Point(108, 101);
            this.sequenceContent.Name = "sequenceContent";
            this.sequenceContent.ReadOnly = true;
            this.sequenceContent.Size = new System.Drawing.Size(35, 22);
            this.sequenceContent.TabIndex = 7;
            // 
            // sequenceCount
            // 
            this.sequenceCount.Location = new System.Drawing.Point(108, 129);
            this.sequenceCount.Name = "sequenceCount";
            this.sequenceCount.ReadOnly = true;
            this.sequenceCount.Size = new System.Drawing.Size(35, 22);
            this.sequenceCount.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 172);
            this.Controls.Add(this.sequenceCount);
            this.Controls.Add(this.sequenceContent);
            this.Controls.Add(this.sequenceLength);
            this.Controls.Add(this.sequenceCountLabel);
            this.Controls.Add(this.sequenceContentLabel);
            this.Controls.Add(this.sequenceLengthLabel);
            this.Controls.Add(this.inputBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Combinations";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Label sequenceLengthLabel;
        private System.Windows.Forms.Label sequenceContentLabel;
        private System.Windows.Forms.Label sequenceCountLabel;
        private System.Windows.Forms.TextBox sequenceLength;
        private System.Windows.Forms.TextBox sequenceContent;
        private System.Windows.Forms.TextBox sequenceCount;
    }
}
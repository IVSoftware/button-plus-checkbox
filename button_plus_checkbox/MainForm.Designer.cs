
namespace button_plus_checkbox
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mButton = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mButton
            // 
            this.mButton.Location = new System.Drawing.Point(40, 94);
            this.mButton.Name = "mButton";
            this.mButton.Size = new System.Drawing.Size(114, 42);
            this.mButton.TabIndex = 0;
            this.mButton.Text = "Increment";
            this.mButton.UseVisualStyleBackColor = true;
            this.mButton.Click += new System.EventHandler(this.mButton_Click);
            // 
            // level1
            // 
            this.level1.Appearance = System.Windows.Forms.Appearance.Button;
            this.level1.Location = new System.Drawing.Point(40, 152);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(114, 42);
            this.level1.TabIndex = 1;
            this.level1.Text = "Level 1";
            this.level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level1.UseVisualStyleBackColor = true;
            this.level1.CheckedChanged += new System.EventHandler(this.level1_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.Location = new System.Drawing.Point(40, 36);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(114, 39);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.mButton);
            this.Name = "Form1";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mButton;
        private System.Windows.Forms.CheckBox level1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}


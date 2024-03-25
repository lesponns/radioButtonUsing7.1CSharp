namespace radioButtonUsing7._1CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            metinKutusu = new TextBox();
            left = new RadioButton();
            center = new RadioButton();
            right = new RadioButton();
            SuspendLayout();
            // 
            // metinKutusu
            // 
            metinKutusu.Location = new Point(15, 15);
            metinKutusu.Margin = new Padding(6);
            metinKutusu.Multiline = true;
            metinKutusu.Name = "metinKutusu";
            metinKutusu.Size = new Size(592, 150);
            metinKutusu.TabIndex = 0;
            metinKutusu.Text = "Merhaba";
            // 
            // left
            // 
            left.Appearance = Appearance.Button;
            left.AutoSize = true;
            left.Checked = true;
            left.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            left.Image = (Image)resources.GetObject("left.Image");
            left.ImageAlign = ContentAlignment.MiddleLeft;
            left.Location = new Point(15, 177);
            left.Margin = new Padding(6);
            left.Name = "left";
            left.Size = new Size(169, 70);
            left.TabIndex = 1;
            left.TabStop = true;
            left.Text = "      Sol";
            left.TextAlign = ContentAlignment.MiddleRight;
            left.UseVisualStyleBackColor = true;
            left.CheckedChanged += left_CheckedChanged;
            // 
            // center
            // 
            center.Appearance = Appearance.Button;
            center.AutoSize = true;
            center.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            center.Image = (Image)resources.GetObject("center.Image");
            center.ImageAlign = ContentAlignment.MiddleLeft;
            center.Location = new Point(219, 177);
            center.Margin = new Padding(6);
            center.Name = "center";
            center.Size = new Size(196, 70);
            center.TabIndex = 2;
            center.Text = "      Orta";
            center.TextAlign = ContentAlignment.MiddleRight;
            center.UseVisualStyleBackColor = true;
            center.CheckedChanged += center_CheckedChanged;
            // 
            // right
            // 
            right.Appearance = Appearance.Button;
            right.AutoSize = true;
            right.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            right.Image = (Image)resources.GetObject("right.Image");
            right.ImageAlign = ContentAlignment.MiddleLeft;
            right.Location = new Point(427, 177);
            right.Margin = new Padding(6);
            right.Name = "right";
            right.Size = new Size(180, 70);
            right.TabIndex = 3;
            right.Text = "      Sağ";
            right.TextAlign = ContentAlignment.MiddleRight;
            right.UseVisualStyleBackColor = true;
            right.CheckedChanged += right_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 266);
            Controls.Add(right);
            Controls.Add(center);
            Controls.Add(left);
            Controls.Add(metinKutusu);
            Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox metinKutusu;
        private RadioButton left;
        private RadioButton center;
        private RadioButton right;
    }
}

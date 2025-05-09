namespace 倒數計時器
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
            components = new System.ComponentModel.Container();
            labelTimer = new Label();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelTimer.Location = new Point(237, 57);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(271, 102);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "label1";
            labelTimer.Click += label1_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft JhengHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonStart.Location = new Point(192, 244);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(394, 194);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "開始";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

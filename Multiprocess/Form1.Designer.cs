namespace Multiprocess
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
            buttonStart = new Button();
            textBoxA = new MaskedTextBox();
            textBoxB = new MaskedTextBox();
            textBoxSteps = new MaskedTextBox();
            textBoxProcessesNums = new MaskedTextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            buttonKillProcess = new Button();
            buttonPauseProcess = new Button();
            buttonResumeProcess = new Button();
            comboBox2 = new ComboBox();
            buttonChangePriority = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Lime;
            buttonStart.Font = new Font("Microsoft Sans Serif", 12F);
            buttonStart.Location = new Point(27, 72);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(96, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxA.Location = new Point(27, 26);
            textBoxA.Mask = "00000";
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(57, 26);
            textBoxA.TabIndex = 1;
            textBoxA.Text = "1";
            textBoxA.TextAlign = HorizontalAlignment.Center;
            textBoxA.ValidatingType = typeof(int);
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxB.Location = new Point(104, 26);
            textBoxB.Mask = "00000";
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(57, 26);
            textBoxB.TabIndex = 2;
            textBoxB.Text = "1000";
            textBoxB.TextAlign = HorizontalAlignment.Center;
            textBoxB.ValidatingType = typeof(int);
            // 
            // textBoxSteps
            // 
            textBoxSteps.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxSteps.Location = new Point(178, 26);
            textBoxSteps.Mask = "00000";
            textBoxSteps.Name = "textBoxSteps";
            textBoxSteps.Size = new Size(57, 26);
            textBoxSteps.TabIndex = 3;
            textBoxSteps.Text = "99999";
            textBoxSteps.TextAlign = HorizontalAlignment.Center;
            textBoxSteps.ValidatingType = typeof(int);
            // 
            // textBoxProcessesNums
            // 
            textBoxProcessesNums.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxProcessesNums.Location = new Point(129, 72);
            textBoxProcessesNums.Mask = "0";
            textBoxProcessesNums.Name = "textBoxProcessesNums";
            textBoxProcessesNums.Size = new Size(32, 26);
            textBoxProcessesNums.TabIndex = 4;
            textBoxProcessesNums.TextAlign = HorizontalAlignment.Center;
            textBoxProcessesNums.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxProcessesNums);
            panel1.Controls.Add(textBoxSteps);
            panel1.Controls.Add(textBoxB);
            panel1.Controls.Add(textBoxA);
            panel1.Controls.Add(buttonStart);
            panel1.Location = new Point(23, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 121);
            panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(318, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonKillProcess
            // 
            buttonKillProcess.BackColor = Color.Red;
            buttonKillProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonKillProcess.Location = new Point(318, 73);
            buttonKillProcess.Name = "buttonKillProcess";
            buttonKillProcess.Size = new Size(85, 29);
            buttonKillProcess.TabIndex = 5;
            buttonKillProcess.Text = "Kill";
            buttonKillProcess.UseVisualStyleBackColor = false;
            buttonKillProcess.Click += buttonKillProcess_Click;
            // 
            // buttonPauseProcess
            // 
            buttonPauseProcess.BackColor = Color.FromArgb(255, 255, 128);
            buttonPauseProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonPauseProcess.Location = new Point(318, 108);
            buttonPauseProcess.Name = "buttonPauseProcess";
            buttonPauseProcess.Size = new Size(40, 29);
            buttonPauseProcess.TabIndex = 7;
            buttonPauseProcess.Text = "||";
            buttonPauseProcess.UseVisualStyleBackColor = false;
            buttonPauseProcess.Click += buttonPauseProcess_Click;
            // 
            // buttonResumeProcess
            // 
            buttonResumeProcess.BackColor = Color.FromArgb(128, 255, 128);
            buttonResumeProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonResumeProcess.Location = new Point(364, 108);
            buttonResumeProcess.Name = "buttonResumeProcess";
            buttonResumeProcess.Size = new Size(39, 29);
            buttonResumeProcess.TabIndex = 8;
            buttonResumeProcess.Text = ">";
            buttonResumeProcess.UseVisualStyleBackColor = false;
            buttonResumeProcess.Click += buttonResumeProcess_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "High", "Idle", "Normal" });
            comboBox2.Location = new Point(418, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // buttonChangePriority
            // 
            buttonChangePriority.Location = new Point(418, 112);
            buttonChangePriority.Name = "buttonChangePriority";
            buttonChangePriority.Size = new Size(75, 23);
            buttonChangePriority.TabIndex = 10;
            buttonChangePriority.Text = "Change";
            buttonChangePriority.UseVisualStyleBackColor = true;
            buttonChangePriority.Click += buttonChangePriority_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 272);
            Controls.Add(buttonChangePriority);
            Controls.Add(comboBox2);
            Controls.Add(buttonResumeProcess);
            Controls.Add(buttonPauseProcess);
            Controls.Add(buttonKillProcess);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private MaskedTextBox textBoxA;
        private MaskedTextBox textBoxB;
        private MaskedTextBox textBoxSteps;
        private MaskedTextBox textBoxProcessesNums;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button buttonKillProcess;
        private Button buttonPauseProcess;
        private Button buttonResumeProcess;
        private ComboBox comboBox2;
        private Button buttonChangePriority;
    }
}

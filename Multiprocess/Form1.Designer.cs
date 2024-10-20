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
            comboBox1 = new ComboBox();
            buttonKillProcess = new Button();
            buttonPauseProcess = new Button();
            buttonResumeProcess = new Button();
            comboBox2 = new ComboBox();
            buttonChangePriority = new Button();
            buttonStart = new Button();
            textBoxA = new MaskedTextBox();
            textBoxB = new MaskedTextBox();
            textBoxSteps = new MaskedTextBox();
            textBoxProcessesNums = new MaskedTextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 12);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 48);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonKillProcess
            // 
            buttonKillProcess.BackColor = Color.Red;
            buttonKillProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonKillProcess.Location = new Point(33, 128);
            buttonKillProcess.Margin = new Padding(4, 5, 4, 5);
            buttonKillProcess.Name = "buttonKillProcess";
            buttonKillProcess.Size = new Size(121, 48);
            buttonKillProcess.TabIndex = 5;
            buttonKillProcess.Text = "Kill";
            buttonKillProcess.UseVisualStyleBackColor = false;
            buttonKillProcess.Click += buttonKillProcess_Click;
            // 
            // buttonPauseProcess
            // 
            buttonPauseProcess.BackColor = Color.FromArgb(255, 255, 128);
            buttonPauseProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonPauseProcess.Location = new Point(33, 70);
            buttonPauseProcess.Margin = new Padding(4, 5, 4, 5);
            buttonPauseProcess.Name = "buttonPauseProcess";
            buttonPauseProcess.Size = new Size(57, 48);
            buttonPauseProcess.TabIndex = 7;
            buttonPauseProcess.Text = "||";
            buttonPauseProcess.UseVisualStyleBackColor = false;
            buttonPauseProcess.Click += buttonPauseProcess_Click;
            // 
            // buttonResumeProcess
            // 
            buttonResumeProcess.BackColor = Color.FromArgb(128, 255, 128);
            buttonResumeProcess.Font = new Font("Microsoft Sans Serif", 12F);
            buttonResumeProcess.Location = new Point(97, 70);
            buttonResumeProcess.Margin = new Padding(4, 5, 4, 5);
            buttonResumeProcess.Name = "buttonResumeProcess";
            buttonResumeProcess.Size = new Size(56, 48);
            buttonResumeProcess.TabIndex = 8;
            buttonResumeProcess.Text = ">";
            buttonResumeProcess.UseVisualStyleBackColor = false;
            buttonResumeProcess.Click += buttonResumeProcess_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "High", "Idle", "Normal" });
            comboBox2.Location = new Point(33, 186);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(120, 33);
            comboBox2.TabIndex = 9;
            // 
            // buttonChangePriority
            // 
            buttonChangePriority.Location = new Point(161, 186);
            buttonChangePriority.Margin = new Padding(4, 5, 4, 5);
            buttonChangePriority.Name = "buttonChangePriority";
            buttonChangePriority.Size = new Size(120, 38);
            buttonChangePriority.TabIndex = 10;
            buttonChangePriority.Text = "Change";
            buttonChangePriority.UseVisualStyleBackColor = true;
            buttonChangePriority.Click += buttonChangePriority_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Lime;
            buttonStart.Font = new Font("Microsoft Sans Serif", 12F);
            buttonStart.Location = new Point(39, 120);
            buttonStart.Margin = new Padding(4, 5, 4, 5);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(137, 48);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxA.Location = new Point(39, 43);
            textBoxA.Margin = new Padding(4, 5, 4, 5);
            textBoxA.Mask = "00000";
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(80, 35);
            textBoxA.TabIndex = 1;
            textBoxA.Text = "1";
            textBoxA.TextAlign = HorizontalAlignment.Center;
            textBoxA.ValidatingType = typeof(int);
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxB.Location = new Point(149, 43);
            textBoxB.Margin = new Padding(4, 5, 4, 5);
            textBoxB.Mask = "00000";
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(80, 35);
            textBoxB.TabIndex = 2;
            textBoxB.Text = "1000";
            textBoxB.TextAlign = HorizontalAlignment.Center;
            textBoxB.ValidatingType = typeof(int);
            // 
            // textBoxSteps
            // 
            textBoxSteps.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxSteps.Location = new Point(254, 43);
            textBoxSteps.Margin = new Padding(4, 5, 4, 5);
            textBoxSteps.Mask = "00000";
            textBoxSteps.Name = "textBoxSteps";
            textBoxSteps.Size = new Size(80, 35);
            textBoxSteps.TabIndex = 3;
            textBoxSteps.Text = "99999";
            textBoxSteps.TextAlign = HorizontalAlignment.Center;
            textBoxSteps.ValidatingType = typeof(int);
            // 
            // textBoxProcessesNums
            // 
            textBoxProcessesNums.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxProcessesNums.Location = new Point(184, 120);
            textBoxProcessesNums.Margin = new Padding(4, 5, 4, 5);
            textBoxProcessesNums.Mask = "0";
            textBoxProcessesNums.Name = "textBoxProcessesNums";
            textBoxProcessesNums.Size = new Size(44, 35);
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
            panel1.Location = new Point(12, 18);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 202);
            panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonChangePriority);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(buttonResumeProcess);
            groupBox1.Controls.Add(buttonPauseProcess);
            groupBox1.Controls.Add(buttonKillProcess);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(426, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 239);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(21, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 231);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(37, 330);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(708, 204);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 546);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button buttonKillProcess;
        private Button buttonPauseProcess;
        private Button buttonResumeProcess;
        private ComboBox comboBox2;
        private Button buttonChangePriority;
        private Button buttonStart;
        private MaskedTextBox textBoxA;
        private MaskedTextBox textBoxB;
        private MaskedTextBox textBoxSteps;
        private MaskedTextBox textBoxProcessesNums;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
    }
}

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;

namespace Multiprocess
{
    public partial class Form1 : Form
    {
        private List<Process> processes = new List<Process>();



        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        private static extern bool SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern bool ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int ProcessesNums = Int32.Parse(textBoxProcessesNums.Text);
            int A = Int32.Parse(textBoxA.Text);
            int B = Int32.Parse(textBoxA.Text);
            int Steps = Int32.Parse(textBoxSteps.Text);

            for (int i = 0; i < ProcessesNums; i++)
            {
                double StepSize = (B - A) / ProcessesNums;
                double StartA = A + i * StepSize;
                double EndB = A + (i + 1) * StepSize;

                Process process = new Process();
                process.StartInfo.FileName = Path.Combine(Application.StartupPath, "..", "..", "..", "..", "TaylorRow", "bin", "Debug", "net8.0", "TaylorRow.exe");
                process.StartInfo.Arguments = $"{StartA} {EndB} {Steps / ProcessesNums}";
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.UseShellExecute = true;
                process.Start();

                processes.Add(process);
            }
            SetComboBox();
        }

        private void SetComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Process process in processes)
            {
                comboBox1.Items.Add(processes.IndexOf(process));
            }
        }

        private void buttonKillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process selectedProcess = processes[comboBox1.SelectedIndex];

                if (selectedProcess != null && !selectedProcess.HasExited)
                {
                    selectedProcess.Kill();
                    processes.Remove(selectedProcess);
                    SetComboBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Процес вже вмер", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPauseProcess_Click(object sender, EventArgs e)
        {
            Process SelectedProcess = processes[comboBox1.SelectedIndex];

            foreach (ProcessThread thread in SelectedProcess.Threads)
            {
                IntPtr hThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);
                if (hThread != IntPtr.Zero)
                {
                    SuspendThread(hThread);
                    CloseHandle(hThread);
                }
            }
        }

        private void buttonResumeProcess_Click(object sender, EventArgs e)
        {
            Process SelectedProcess = processes[comboBox1.SelectedIndex];

            foreach (ProcessThread thread in SelectedProcess.Threads)
            {
                IntPtr hThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);
                if (hThread != IntPtr.Zero)
                {
                    ResumeThread(hThread);
                    CloseHandle(hThread);
                }
            }
        }

        private void buttonChangePriority_Click(object sender, EventArgs e)
        {
            Process SelectedProcess = processes[comboBox1.SelectedIndex];
            string priority = comboBox2.SelectedItem.ToString();

            switch (priority)
            {
                case "High":
                    SelectedProcess.PriorityClass = ProcessPriorityClass.High;
                    break;
                case "Idle":
                    SelectedProcess.PriorityClass = ProcessPriorityClass.Idle;
                    break;
                default:
                    SelectedProcess.PriorityClass = ProcessPriorityClass.Normal;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process selectedProcess = processes[comboBox1.SelectedIndex];

            // Отримуємо пріоритет процесу
            ProcessPriorityClass priorityClass = selectedProcess.PriorityClass;

            // Встановлюємо індекс в comboBox2 відповідно до пріоритету
            switch (priorityClass)
            {
                case ProcessPriorityClass.High:
                    comboBox2.SelectedIndex = 0; 
                    break;
                case ProcessPriorityClass.Idle:
                    comboBox2.SelectedIndex = 1; 
                    break;
                default:
                    comboBox2.SelectedIndex = 2; 
                    break;
            }
        }
    }
}

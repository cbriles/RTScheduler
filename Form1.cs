/* Real-Time Scheduler with RMS, EDF, and Mixed Scheduling Algorithms. Schedules 5 tasks. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
            InitializenumTaskBox();
        }

        int lcmResult = 0;
        int numTasks = 0;
        List<List<int>> ranOrNot = new List<List<int>>();
        List<List<int>> missTimes = new List<List<int>>();
        List<int> taskPeriods = new List<int>();
        StringBuilder MyStringBuilder = new StringBuilder("");

        Color[] taskColors = new Color[] {
                    Color.Yellow,
                    Color.YellowGreen,
                    Color.Lime,
                    Color.Aqua,
                    Color.DarkBlue
                    };

        class Task
        {
            public int Number { get; set; }
            public double Period { get; set; }
            public double Runtime { get; set; }
            public double PriorityLevel { get; set; }
            public double RemainingRunTime { get; set; }

            // Constructor
            public Task(int number, double period, double runtime)
            {
                Number = number;
                Period = period;
                Runtime = runtime;
            }

            // Testing / option Constructor
            public Task()
            {

            }
        }

        void DebugTasks(List<Task> tasks, List<List<int>> streams)
        {
            int streamNumber = 0;
            foreach (List<int> stream in streams)
            {
                string bw = "[";
                foreach (int i in stream)
                {
                    bw = bw + i.ToString();
                }
                bw = bw + "]";

                MyStringBuilder.AppendFormat("Stream {0}: {1}\n", streamNumber, bw);
                streamNumber++;
            }

            foreach (Task t in tasks)
            {
                MyStringBuilder.AppendFormat("{0}: P: {1}, R: {2}, PL: {3}, RemR: {4}\n",
                    t.Number, t.Period, t.Runtime, t.PriorityLevel, t.RemainingRunTime);
            }
        }

        public static double multipleLCM(double[] inputPeriod, double numTasks)
        {
            double numCounter = numTasks;
            double temp = inputPeriod[0];
            double temp2 = 0;
            for (int i = 1; i < numTasks; i++)
            {
                temp2 = inputPeriod[i];
                temp = determineLCM(temp, temp2);
            }
            return temp;
        }

        public static double determineLCM(double a, double b)
        {
            double num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Task Definitions & Get Values

            //double numTasks;
            double[] inputPeriod = new double[5];
            double[] inputRuntime = new double[5];
            double[] inputPL = new double[5];
            double[] inputk = new double[5];

            // set numTasks via comboBox (numTaskBox)
            numTasks = numTaskBox.SelectedIndex + 1;

            //get input values
            if (!double.TryParse(textBoxP0.Text, out inputPeriod[0])) { }
            if (!double.TryParse(textBoxP1.Text, out inputPeriod[1])) { }
            if (!double.TryParse(textBoxP2.Text, out inputPeriod[2])) { }
            if (!double.TryParse(textBoxP3.Text, out inputPeriod[3])) { }
            if (!double.TryParse(textBoxP4.Text, out inputPeriod[4])) { }

            if (!double.TryParse(textBoxR0.Text, out inputRuntime[0])) { }
            if (!double.TryParse(textBoxR1.Text, out inputRuntime[1])) { }
            if (!double.TryParse(textBoxR2.Text, out inputRuntime[2])) { }
            if (!double.TryParse(textBoxR3.Text, out inputRuntime[3])) { }
            if (!double.TryParse(textBoxR4.Text, out inputRuntime[4])) { }

            if (radioButton3.Checked)
            {
                if (!double.TryParse(textBoxPL0.Text, out inputPL[0])) { }
                if (!double.TryParse(textBoxPL1.Text, out inputPL[1])) { }
                if (!double.TryParse(textBoxPL2.Text, out inputPL[2])) { }
                if (!double.TryParse(textBoxPL3.Text, out inputPL[3])) { }
                if (!double.TryParse(textBoxPL4.Text, out inputPL[4])) { }
            }

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < numTasks; i++)
            {
                tasks.Add(new Task()
                {
                    Number = i,
                    Period = inputPeriod[i],
                    Runtime = inputRuntime[i],
                    PriorityLevel = inputPL[i],
                });

                ranOrNot.Add(new List<int>());
                missTimes.Add(new List<int>());
                taskPeriods.Add((int)inputPeriod[i]);
            }

            #endregion

            #region LCM & Utilization Calculation

            lcmResult = (int)multipleLCM(inputPeriod, numTasks);
            labelLCM.Text = "The LCM is: " + lcmResult;
            if (lcmResult >= 10000)
                lcmResult = 10000;
            MyStringBuilder.Append("The LCM is " + lcmResult + "\n");

            // calculate utilization
            double Utilization = 0;
            if (radioButton1.Checked || radioButton2.Checked)
            {
                for (int i = 0; i < numTasks; i++)
                {
                    Utilization += inputRuntime[i] / inputPeriod[i];
                }
            }

            // set PL for RMS & EDF to their respective Period
            if (radioButton1.Checked || radioButton2.Checked)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].PriorityLevel = tasks[i].Period;
                }
            }

            #endregion

            #region RMS (Rate Monotonic)
            if (radioButton1.Checked)
            {
                MyStringBuilder.Append("RMS lower bound: " + (double)numTasks * (Math.Pow(2, 1 / (double)numTasks) - 1) + "\n");

                Task runningTask = null;

                // sort by PL
                List<Task> tasksSortedByPriority = tasks.OrderBy(x => x.PriorityLevel).ToList();

                for (int i = 0; i < lcmResult; i++)
                {
                    // when a task hits its resepective period, reset the runtime
                    for (int t = 0; t < tasks.Count; t++)
                    {
                        if (i % tasks[t].Period == 0)
                        {
                            tasks[t].RemainingRunTime = tasks[t].Runtime;
                        }
                    }

                    // pick a running task based on sort
                    for (int t = 0; t < tasksSortedByPriority.Count; t++)
                    {
                        if (tasksSortedByPriority[t].RemainingRunTime > 0)
                        {
                            runningTask = tasksSortedByPriority[t];
                            break;
                        }
                    }

                    // if there's no running task, note that no tasks ran
                    // this needs to be done before the next loop because it can mark tasks null
                    if (runningTask == null)
                    {
                        for (int j = 0; j < numTasks; j++)
                        {
                            ranOrNot[j].Add(0);
                        }
                    }                   

                    // If there is a running task, run it, and finish it if it has run its course.
                    if (runningTask != null)
                    {                      
                        // add to ranOrNot list to later display running tasks with colors
                        for (int j = 0; j < numTasks; j++)
                        {
                            if (runningTask.Number == j)
                            {
                                ranOrNot[j].Add(1);
                            }
                            else { ranOrNot[j].Add(0); }
                        }

                        runningTask.RemainingRunTime -= 1;

                        // check for tasks that have missed their deadline
                        for (int j = 0; j < numTasks; j++)
                        {
                            // should execute 1 before the period
                            if (i % taskPeriods[j] == taskPeriods[j] - 1)
                            {
                                if (tasks[j].RemainingRunTime > 0)
                                {
                                    MyStringBuilder.Append("Task " + tasks[j].Number + " missed at time " + (i + 1) + "\n");
                                    missTimes[j].Add(i + 1);
                                }
                            }
                        }

                        // When task completes, say so and mark it null
                        if (runningTask.RemainingRunTime == 0)
                        {
                            runningTask = null;
                        }
                    }
                }
            }
            #endregion

            #region EDF (Earliest Deadline First)
            if (radioButton2.Checked)
            {
                // determine feasibility
                double isFeasible = 0;

                // this method should probably get moved somewhere else...
                for (int i = 0; i < tasks.Count; i++)
                {
                    isFeasible += (tasks[i].Runtime / tasks[i].Period);
                }

                if (isFeasible > 1)
                {
                    MyStringBuilder.Append("The schedule will contain deadline missing.\nStarting sequence... \n");
                }

                Task runningTask = null;
                // Loop until reaches LCM.
                for (int i = 0; i < lcmResult; i++)
                {
                    // when a task hits its resepective period, reset the runtime
                    for (int t = 0; t < tasks.Count; t++)
                    {
                        if (i % tasks[t].Period == 0)
                        {
                            tasks[t].RemainingRunTime = tasks[t].Runtime;
                        }
                    }

                    // sort first by distance to deadline, then in reverse order of priority (so that tasks with longer periods get a chance to run)
                    List<Task> tasksSortedByEDF = tasks.OrderBy(x => x.Period - (i % x.Period)).ThenByDescending(x => x.Period).ToList();

                    // pick a running task based on sort
                    for (int t = 0; t < tasksSortedByEDF.Count; t++)
                        {
                            if (tasksSortedByEDF[t].RemainingRunTime > 0)
                            {
                                runningTask = tasksSortedByEDF[t];
                                break;
                            }
                        }

                    // if there's no running task, note that no tasks ran
                    // this needs to be done before the next loop because it can mark tasks null
                    if (runningTask == null)
                    {
                        for (int j = 0; j < numTasks; j++)
                        {
                            ranOrNot[j].Add(0);
                        }
                    }

                    // If there is a running task, run it, and finish it if it has run its course.
                    if (runningTask != null)
                    {                        
                        // add to ranOrNot list to later display running tasks with colors
                        for (int j = 0; j < numTasks; j++)
                        {
                            if (runningTask.Number == j)
                            {
                                ranOrNot[j].Add(1);
                            }
                            else { ranOrNot[j].Add(0); }
                        }

                        runningTask.RemainingRunTime -= 1;

                        // check for tasks that have missed their deadline
                        for (int j = 0; j < numTasks; j++)
                        {
                            // should execute 1 before the period
                            if (i % taskPeriods[j] == taskPeriods[j] - 1)
                            {
                                if (tasks[j].RemainingRunTime > 0)
                                {
                                    MyStringBuilder.Append("Task " + tasks[j].Number + " missed at time " + (i + 1) + "\n");
                                    missTimes[j].Add(i + 1);
                                }
                            }
                        }

                        // When task completes, say so and mark it null
                        if (runningTask.RemainingRunTime == 0)
                        {
                            runningTask = null;
                        }
                    }
                }
            }
            #endregion

            #region Mixed (RMS + EDF)
            if (radioButton3.Checked)
            {
                // no utilization or feasibility check

                Task runningTask = null;

                // Loop until reaches LCM.
                for (int i = 0; i < lcmResult; i++)
                {
                    // when a task hits its resepective period, reset the runtime
                    for (int t = 0; t < tasks.Count; t++)
                    {
                        if (i % tasks[t].Period == 0)
                        {
                            tasks[t].RemainingRunTime = tasks[t].Runtime;
                        }
                    }

                    // sort first by PL, then distance to deadline, then reverse of period (so that tasks with longer periods get a chance to run)
                    List<Task> tasksSortedByMP = tasks.OrderBy(x => x.PriorityLevel).ThenBy(x => x.Period - (i % x.Period)).ThenByDescending(x => x.Period).ToList();

                    // pick a running task based on sort
                    for (int t = 0; t < tasksSortedByMP.Count; t++)
                    {
                        if (tasksSortedByMP[t].RemainingRunTime > 0)
                        {
                            runningTask = tasksSortedByMP[t];
                            break;
                        }
                    }

                    // if there's no running task, note that no tasks ran
                    // this needs to be done before the next loop because it can mark tasks null
                    if (runningTask == null)
                    {
                        for (int j = 0; j < numTasks; j++)
                        {
                            ranOrNot[j].Add(0);
                        }
                    }

                    // If there is a running task, run it, and finish it if it has run its course.
                    if (runningTask != null)
                    {
                        // add to ranOrNot list to later display running tasks with colors
                        for (int j = 0; j < numTasks; j++)
                        {
                            if (runningTask.Number == j)
                            {
                                ranOrNot[j].Add(1);
                            }
                            else { ranOrNot[j].Add(0); }
                        }

                        runningTask.RemainingRunTime -= 1;

                        // check for tasks that have missed their deadline
                        for (int j = 0; j < numTasks; j++)
                        {
                            // should execute 1 before the period
                            if (i % taskPeriods[j] == taskPeriods[j] - 1)
                            {
                                if (tasks[j].RemainingRunTime > 0)
                                {
                                    MyStringBuilder.Append("Task " + tasks[j].Number + " missed at time " + (i + 1) + "\n");
                                    missTimes[j].Add(i + 1);
                                }
                            }
                        }

                        // When task completes, mark it null
                        if (runningTask.RemainingRunTime == 0)
                        {
                            runningTask = null;
                        }
                    }
                }
            }
            #endregion

            timelinePanel.Refresh();

            #region Output Text Information to UI

            outputBox.Text = MyStringBuilder.ToString();

            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                labelUtil.Text = "The total utilization is: " + Utilization;
            }
            
            #endregion
        }
        #region Menu & Other various methods
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Caleb Briles");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        // refresh timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            buttonGo.Controls.Clear();
            ranOrNot.Clear();
            missTimes.Clear();
            taskPeriods.Clear();
            labelLCM.Text = "";
            labelUtil.Text = "";
            numTasks = 0;
            lcmResult = 0;
            MyStringBuilder.Clear();
            timelinePanel.Refresh();
            outputBox.Clear();
        }

        private void timelinePanel_Paint(object sender, PaintEventArgs e)
        {
            #region timelineGUI
            //declarations that probably need moved somewhere else

            int leftPadding = 7;
            int vertSpacingBase = 40;
            int tasksWidth = 20;
            int tasksHeight = 20;
            int timelineLength = lcmResult * tasksWidth;
            string numString = "";
            

            timelinePanel.AutoScrollMinSize = new Size(timelineLength + 10, 0);
            e.Graphics.TranslateTransform(timelinePanel.AutoScrollPosition.X, timelinePanel.AutoScrollPosition.Y);
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                System.Drawing.Pen blackPen = new System.Drawing.Pen(System.Drawing.Color.Black);
                System.Drawing.Pen redPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                System.Drawing.Pen missPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                missPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                System.Drawing.SolidBrush taskBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                System.Drawing.Graphics formGraphics = this.CreateGraphics();
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
                System.Drawing.StringFormat drawStringFormat = new System.Drawing.StringFormat();

                // draw left boundry line
                g.DrawLine(blackPen, leftPadding + 0, 0, leftPadding + 0, 200);

                //g.DrawString("hello", drawFont, taskBrush, 200, 200);
                //TextRenderer.DrawText(g, "hello", drawFont, 16, System.Drawing.Color.Black);

                // x1, y1, x2, y2
                g.DrawLine(blackPen, leftPadding + 0, vertSpacingBase, leftPadding + timelineLength, vertSpacingBase);
                g.DrawLine(blackPen, leftPadding + 0, vertSpacingBase * 2, leftPadding + timelineLength, vertSpacingBase * 2);
                g.DrawLine(blackPen, leftPadding + 0, vertSpacingBase * 3, leftPadding + timelineLength, vertSpacingBase * 3);
                g.DrawLine(blackPen, leftPadding + 0, vertSpacingBase * 4, leftPadding + timelineLength, vertSpacingBase * 4);
                g.DrawLine(blackPen, leftPadding + 0, vertSpacingBase * 5, leftPadding + timelineLength, vertSpacingBase * 5);

                // note: the numbers aren't padded on the left, they are in fact the reason for the padding alignment
                // draw number labels
                for (int i = 0; i < lcmResult; i++)
                {
                    if (i % 10 == 0)
                    {
                        numString = i.ToString();
                        g.DrawString(numString, drawFont, taskBrush, (i * tasksWidth), vertSpacingBase * 5);
                    }
                }

                // switch to display graphics based on how many tasks ran, default is "nothing"
                int caseSwitch = (int)numTasks;
                switch (caseSwitch)
                {
                    case 5:
                        taskBrush.Color = System.Drawing.Color.DarkBlue;
                        for (int i = 0; i < ranOrNot[4].Count; i++)
                        {
                            if (ranOrNot[4][i] == 1)
                            {
                                g.FillRectangle(taskBrush, leftPadding + (tasksWidth * i) + 1, vertSpacingBase * 5 - tasksHeight, tasksHeight, tasksWidth);
                            }                            
                        }
                        // draw deadlines, regular and missed
                        for (int i = 0; i < ranOrNot[4].Count + 1; i++)
                        {
                            if (i % taskPeriods[4] == 0)
                            {
                                g.DrawLine(blackPen, leftPadding + (i * tasksWidth), vertSpacingBase * 5, leftPadding + (i * tasksWidth), (vertSpacingBase * 5) - tasksHeight - 5);
                            }
                            if (i % taskPeriods[4] == 0 && missTimes[4].Contains(i))
                            {
                                g.DrawLine(missPen, leftPadding + (i * tasksWidth), (vertSpacingBase * 4) + 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 5) - tasksHeight - 7);
                                g.DrawLine(redPen, leftPadding + (i * tasksWidth), vertSpacingBase * 5, leftPadding + (i * tasksWidth), (vertSpacingBase * 5) - tasksHeight - 5);
                            }
                        }
                        goto case 4;
                    case 4:
                        taskBrush.Color = System.Drawing.Color.Aqua;
                        for (int i = 0; i < ranOrNot[3].Count; i++)
                        {
                            if (ranOrNot[3][i] == 1)
                            {
                                g.FillRectangle(taskBrush, leftPadding + (tasksWidth * i) + 1, vertSpacingBase * 4 - tasksHeight, tasksHeight, tasksWidth);
                            }                            
                        }
                        // draw deadlines, regular and missed
                        for (int i = 0; i < ranOrNot[3].Count + 1; i++)
                        {
                            if (i % taskPeriods[3] == 0)
                            {
                                g.DrawLine(blackPen, leftPadding + (i * tasksWidth), vertSpacingBase * 4, leftPadding + (i * tasksWidth), (vertSpacingBase * 4) - tasksHeight - 5);
                            }
                            if (i % taskPeriods[3] == 0 && missTimes[3].Contains(i))
                            {
                                g.DrawLine(missPen, leftPadding + (i * tasksWidth), (vertSpacingBase * 3) + 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 4) - tasksHeight - 7);
                                g.DrawLine(redPen, leftPadding + (i * tasksWidth), vertSpacingBase * 4, leftPadding + (i * tasksWidth), (vertSpacingBase * 4) - tasksHeight - 5);
                            }
                        }
                        goto case 3;
                    case 3:
                        taskBrush.Color = System.Drawing.Color.Lime;
                        for (int i = 0; i < ranOrNot[2].Count; i++)
                        {
                            if (ranOrNot[2][i] == 1)
                            {
                                g.FillRectangle(taskBrush, leftPadding + (tasksWidth * i) + 1, vertSpacingBase * 3 - tasksHeight, tasksHeight, tasksWidth);
                            }                           
                        }
                        // draw deadlines, regular and missed
                        for (int i = 0; i < ranOrNot[2].Count + 1; i++)
                        {
                            if (i % taskPeriods[2] == 0)
                            {
                                g.DrawLine(blackPen, leftPadding + (i * tasksWidth), vertSpacingBase * 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 3) - tasksHeight - 5);
                            }
                            if (i % taskPeriods[2] == 0 && missTimes[2].Contains(i))
                            {
                                g.DrawLine(missPen, leftPadding + (i * tasksWidth), (vertSpacingBase * 2) + 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 3) - tasksHeight - 7);
                                g.DrawLine(redPen, leftPadding + (i * tasksWidth), vertSpacingBase * 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 3) - tasksHeight - 5);
                            }
                        }
                        goto case 2;
                    case 2:
                        taskBrush.Color = System.Drawing.Color.YellowGreen;
                        for (int i = 0; i < ranOrNot[1].Count; i++)
                        {
                            if (ranOrNot[1][i] == 1)
                            {
                                g.FillRectangle(taskBrush, leftPadding + (tasksWidth * i) + 1, vertSpacingBase * 2 - tasksHeight, tasksHeight, tasksWidth);
                            }                           
                        }
                        // draw deadlines, regular and missed
                        for (int i = 0; i < ranOrNot[1].Count + 1; i++)
                        {
                            if (i % taskPeriods[1] == 0)
                            {
                                g.DrawLine(blackPen, leftPadding + (i * tasksWidth), vertSpacingBase * 2, leftPadding + (i * tasksWidth), (vertSpacingBase * 2) - tasksHeight - 5);
                            }
                            if (i % taskPeriods[1] == 0 && missTimes[1].Contains(i))
                            {
                                g.DrawLine(missPen, leftPadding + (i * tasksWidth), vertSpacingBase + 3, leftPadding + (i * tasksWidth), (vertSpacingBase * 2) - tasksHeight - 7);
                                g.DrawLine(redPen, leftPadding + (i * tasksWidth), vertSpacingBase * 2, leftPadding + (i * tasksWidth), (vertSpacingBase * 2) - tasksHeight - 5);
                            }
                        }
                        goto case 1;
                    case 1:
                        taskBrush.Color = System.Drawing.Color.Yellow;
                        for (int i = 0; i < ranOrNot[0].Count; i++)
                        {
                            if (ranOrNot[0][i] == 1)
                            {
                                g.FillRectangle(taskBrush, leftPadding + (tasksWidth * i) + 1, vertSpacingBase - tasksHeight, tasksHeight, tasksWidth);
                            }
                        }
                        // draw deadlines, regular and missed
                        for (int i = 0; i < ranOrNot[0].Count + 1; i++)
                        {
                            if (i % taskPeriods[0] == 0)
                            {
                                g.DrawLine(blackPen, leftPadding + (i * tasksWidth), vertSpacingBase, leftPadding + (i * tasksWidth), tasksHeight - 5);
                            }
                            if (i % taskPeriods[0] == 0 && missTimes[0].Contains(i))
                            {
                                g.DrawLine(missPen, leftPadding + (i * tasksWidth), 3, leftPadding + (i * tasksWidth), vertSpacingBase - tasksHeight - 7);
                                g.DrawLine(redPen, leftPadding + (i * tasksWidth), vertSpacingBase, leftPadding + (i * tasksWidth), tasksHeight - 5);
                            }
                        }
                        goto default;
                    default:
                        //
                        break;
                }
            }
            #endregion
        }


        private void InitializenumTaskBox()
        {
            string[] numTaskSelections = new string[] { "1", "2", "3", "4", "5" };
            numTaskBox.Items.AddRange(numTaskSelections);
            numTaskBox.SelectedIndex = 0;
            this.Controls.Add(this.numTaskBox);

            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.numTaskBox.SelectedIndexChanged +=
                new System.EventHandler(numTaskBox_SelectedIndexChanged);
        }
        private void numTaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // getting values when program runs
        }

        #region RadioButton / TextBox Toggles
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBoxPL0.ReadOnly = true; 
                textBoxPL1.ReadOnly = true;
                textBoxPL2.ReadOnly = true;
                textBoxPL3.ReadOnly = true;
                textBoxPL4.ReadOnly = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPL0.ReadOnly = true;
            textBoxPL1.ReadOnly = true;
            textBoxPL2.ReadOnly = true;
            textBoxPL3.ReadOnly = true;
            textBoxPL4.ReadOnly = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPL0.ReadOnly = false;
            textBoxPL1.ReadOnly = false;
            textBoxPL2.ReadOnly = false;
            textBoxPL3.ReadOnly = false;
            textBoxPL4.ReadOnly = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPL0.ReadOnly = false;
            textBoxPL1.ReadOnly = false;
            textBoxPL2.ReadOnly = false;
            textBoxPL3.ReadOnly = false;
            textBoxPL4.ReadOnly = false;
        }
        #endregion
    }
}
using Braincase.GanttChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // create a project manager
            var manager = new ProjectManager();
            // create built-in task or use your own derived task
            var task = new Braincase.GanttChart.Task() { Name = "Hello "};
            var task1 = new Braincase.GanttChart.Task() { Name = " World" };
            var task2 = new Braincase.GanttChart.Task() { Name = "Helly" };
            var task3 = new Braincase.GanttChart.Task() { Name = "Hel7875" };
            var task5 = new Braincase.GanttChart.Task() { Name = "gmmail" };
            // add the task to the manager
            manager.Add(task2);
            manager.Add(task);
            manager.Add(task1);

            manager.Add(task3);
            manager.Split(task,task1,2);

            //manager.SetDuration(task, 3);
            
            // create a chart control
            var chart = new Chart();
            // initialise the chart with the manager
            chart.Init(manager);
            // add chart to the form controls collection.
            this.Controls.Add(chart);
            
            // throughout your own code, call chart.Invalidate()
            // where you expect updates to the drawn chart,
            // to tell the chart to Paint() itself.
        }
    }
}

namespace EmployeeManagementSystem.App
{
    partial class frmDisplayCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.piChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).BeginInit();
            this.SuspendLayout();
            // 
            // piChart
            // 
            this.piChart.BorderlineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.piChart.ChartAreas.Add(chartArea1);
            this.piChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.piChart.Legends.Add(legend1);
            this.piChart.Location = new System.Drawing.Point(0, 0);
            this.piChart.Name = "piChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.piChart.Series.Add(series1);
            this.piChart.Size = new System.Drawing.Size(468, 404);
            this.piChart.TabIndex = 0;
            this.piChart.Text = "Report in Charts";
            // 
            // frmDisplayCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 404);
            this.Controls.Add(this.piChart);
            this.Name = "frmDisplayCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Charts";
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart piChart;
    }
}
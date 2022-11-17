
namespace WindowsFormsApp1
{
    partial class StaticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.PanelMale = new System.Windows.Forms.Panel();
            this.LabelMale = new System.Windows.Forms.Label();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelFemale = new System.Windows.Forms.Panel();
            this.LabelFemale = new System.Windows.Forms.Label();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelMale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.PanelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotal
            // 
            this.LabelTotal.BackColor = System.Drawing.Color.Yellow;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(0, -2);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(1037, 129);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total Student: 100%";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotal.MouseEnter += new System.EventHandler(this.LabelTotal_MouseEnter);
            this.LabelTotal.MouseLeave += new System.EventHandler(this.LabelTotal_MouseLeave);
            // 
            // PanelMale
            // 
            this.PanelMale.BackColor = System.Drawing.Color.Blue;
            this.PanelMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMale.BackgroundImage")));
            this.PanelMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelMale.Controls.Add(this.LabelMale);
            this.PanelMale.Location = new System.Drawing.Point(12, 130);
            this.PanelMale.Name = "PanelMale";
            this.PanelMale.Size = new System.Drawing.Size(527, 207);
            this.PanelMale.TabIndex = 1;
            // 
            // LabelMale
            // 
            this.LabelMale.AutoSize = true;
            this.LabelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMale.Location = new System.Drawing.Point(324, 91);
            this.LabelMale.Name = "LabelMale";
            this.LabelMale.Size = new System.Drawing.Size(70, 25);
            this.LabelMale.TabIndex = 0;
            this.LabelMale.Text = "label1";
            this.LabelMale.MouseEnter += new System.EventHandler(this.LabelMale_MouseEnter);
            this.LabelMale.MouseLeave += new System.EventHandler(this.LabelMale_MouseLeave);
            // 
            // BarChart
            // 
            chartArea3.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BarChart.Legends.Add(legend3);
            this.BarChart.Location = new System.Drawing.Point(29, 343);
            this.BarChart.Name = "BarChart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.Legend = "Legend1";
            series3.Name = "Student";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.BarChart.Series.Add(series3);
            this.BarChart.Size = new System.Drawing.Size(474, 412);
            this.BarChart.TabIndex = 3;
            this.BarChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Student Bar Chart";
            this.BarChart.Titles.Add(title3);
            // 
            // PanelFemale
            // 
            this.PanelFemale.BackColor = System.Drawing.Color.Fuchsia;
            this.PanelFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFemale.BackgroundImage")));
            this.PanelFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelFemale.Controls.Add(this.LabelFemale);
            this.PanelFemale.Location = new System.Drawing.Point(538, 129);
            this.PanelFemale.Name = "PanelFemale";
            this.PanelFemale.Size = new System.Drawing.Size(499, 208);
            this.PanelFemale.TabIndex = 2;
            // 
            // LabelFemale
            // 
            this.LabelFemale.AutoSize = true;
            this.LabelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFemale.Location = new System.Drawing.Point(301, 92);
            this.LabelFemale.Name = "LabelFemale";
            this.LabelFemale.Size = new System.Drawing.Size(70, 25);
            this.LabelFemale.TabIndex = 1;
            this.LabelFemale.Text = "label2";
            this.LabelFemale.MouseEnter += new System.EventHandler(this.LabelFemale_MouseEnter);
            this.LabelFemale.MouseLeave += new System.EventHandler(this.LabelFemale_MouseLeave);
            // 
            // PieChart
            // 
            chartArea4.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PieChart.Legends.Add(legend4);
            this.PieChart.Location = new System.Drawing.Point(563, 343);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Student";
            this.PieChart.Series.Add(series4);
            this.PieChart.Size = new System.Drawing.Size(474, 412);
            this.PieChart.TabIndex = 4;
            this.PieChart.Text = "chart2";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Student Pie Chart";
            this.PieChart.Titles.Add(title4);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 825);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.PanelFemale);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.PanelMale);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.PanelMale.ResumeLayout(false);
            this.PanelMale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.PanelFemale.ResumeLayout(false);
            this.PanelFemale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMale;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelMale;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Panel PanelFemale;
        private System.Windows.Forms.Label LabelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}
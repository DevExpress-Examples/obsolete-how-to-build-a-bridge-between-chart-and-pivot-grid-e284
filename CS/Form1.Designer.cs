namespace ChartPivot
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldMyDateTime = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMyRow = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMyData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldMyDateTime,
            this.fieldMyRow,
            this.fieldMyData});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 2);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.ChartDataVertical = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(674, 355);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CellSelectionChanged += new System.EventHandler(this.pivotGridControl1_CellSelectionChanged);
            // 
            // fieldMyDateTime
            // 
            this.fieldMyDateTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMyDateTime.AreaIndex = 0;
            this.fieldMyDateTime.Caption = "MyDateTime";
            this.fieldMyDateTime.FieldName = "MyDateTime";
            this.fieldMyDateTime.Name = "fieldMyDateTime";
            // 
            // fieldMyRow
            // 
            this.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMyRow.AreaIndex = 0;
            this.fieldMyRow.Caption = "MyRow";
            this.fieldMyRow.FieldName = "MyRow";
            this.fieldMyRow.Name = "fieldMyRow";
            // 
            // fieldMyData
            // 
            this.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMyData.AreaIndex = 0;
            this.fieldMyData.Caption = "MyData";
            this.fieldMyData.FieldName = "MyData";
            this.fieldMyData.Name = "fieldMyData";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(12, 363);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(674, 227);
            this.chartControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 602);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyDateTime;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyRow;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMyData;
    }
}


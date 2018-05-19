Imports Microsoft.VisualBasic
Imports System
Namespace ChartPivot
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldMyDateTime = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMyRow = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldMyData = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldMyDateTime, Me.fieldMyRow, Me.fieldMyData})
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 2)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(674, 355)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CellSelectionChanged += New System.EventHandler(Me.pivotGridControl1_CellSelectionChanged);
			' 
			' fieldMyDateTime
			' 
			Me.fieldMyDateTime.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldMyDateTime.AreaIndex = 0
			Me.fieldMyDateTime.Caption = "MyDateTime"
			Me.fieldMyDateTime.FieldName = "MyDateTime"
			Me.fieldMyDateTime.Name = "fieldMyDateTime"
			' 
			' fieldMyRow
			' 
			Me.fieldMyRow.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldMyRow.AreaIndex = 0
			Me.fieldMyRow.Caption = "MyRow"
			Me.fieldMyRow.FieldName = "MyRow"
			Me.fieldMyRow.Name = "fieldMyRow"
			' 
			' fieldMyData
			' 
			Me.fieldMyData.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldMyData.AreaIndex = 0
			Me.fieldMyData.Caption = "MyData"
			Me.fieldMyData.FieldName = "MyData"
			Me.fieldMyData.Name = "fieldMyData"
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Location = New System.Drawing.Point(12, 363)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesDataMember = "Series"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
			Me.chartControl1.Size = New System.Drawing.Size(674, 227)
			Me.chartControl1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(698, 602)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private fieldMyDateTime As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMyRow As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMyData As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace


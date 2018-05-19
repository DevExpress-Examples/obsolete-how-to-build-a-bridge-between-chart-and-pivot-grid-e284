Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.Collections

Namespace ChartPivot
	Partial Public Class Form1
		Inherits Form
		Private t As New DataTable()
		Private dataSet1 As DataSet

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataSet1 = New DataSet()
			dataSet1.Tables.Add("DataTable1")
			dataSet1.Tables("DataTable1").Columns.Add("MyDateTime", GetType(DateTime))
			dataSet1.Tables("DataTable1").Columns.Add("MyRow", GetType(String))
			dataSet1.Tables("DataTable1").Columns.Add("MyData", GetType(Double))


			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today, "a", 123 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today, "b", 125 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today, "c", 446 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(1), "a", 788 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(1), "b", 787 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(1), "c", 452 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(2), "a", 122 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(2), "b", 565 })
			dataSet1.Tables("DataTable1").Rows.Add(New Object() { DateTime.Today.AddDays(2), "c", 543 })
			pivotGridControl1.DataSource = dataSet1.Tables("DataTable1")

			For Each d As PropertyDescriptor In (CType(pivotGridControl1, ITypedList)).GetItemProperties(Nothing)
				If d.Name = "Arguments" Then
					t.Columns.Add(d.Name, GetType(DateTime))
				Else
					t.Columns.Add(d.Name, d.PropertyType)
				End If
			Next d
			chartControl1.DataSource = t
			chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center
			chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside
			chartControl1.SeriesTemplate.ChangeView(ViewType.Line)
			chartControl1.SeriesDataMember = "Series"
			chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			chartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime
			chartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Values" })
		End Sub

		Private Sub pivotGridControl1_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pivotGridControl1.CellSelectionChanged
			t.Rows.Clear()
			For i As Integer = 0 To (CType(pivotGridControl1, IList)).Count - 1
				Dim r As DataRow = t.Rows.Add(New Object() { })
				For Each d As PropertyDescriptor In (CType(pivotGridControl1, ITypedList)).GetItemProperties(Nothing)
					Dim o As Object = d.GetValue((CType(pivotGridControl1, IList))(i))
					If d.Name = "Arguments" Then
						Dim dt As DateTime
						Try
							dt = Convert.ToDateTime(o)
						Catch
							dt = DateTime.MinValue
						End Try
						If dt <> DateTime.MinValue Then
							r(d.Name) = dt
						End If
					Else
						r(d.Name) = o
					End If

				Next d
			Next i
			chartControl1.Refresh()
		End Sub
	End Class
End Namespace
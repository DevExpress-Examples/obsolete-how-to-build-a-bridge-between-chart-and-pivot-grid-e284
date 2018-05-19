using System;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraCharts;

namespace ChartPivot {
    public partial class Form1 : Form {
        DataTable t = new DataTable();
        DataSet dataSet1;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataSet1 = new DataSet();
            dataSet1.Tables.Add("DataTable1");
            dataSet1.Tables["DataTable1"].Columns.Add("MyDateTime", typeof(DateTime));
            dataSet1.Tables["DataTable1"].Columns.Add("MyRow", typeof(string));
            dataSet1.Tables["DataTable1"].Columns.Add("MyData", typeof(double));


            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today, "a", 123 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today, "b", 125 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today, "c", 446 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(1), "a", 788 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(1), "b", 787 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(1), "c", 452 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(2), "a", 122 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(2), "b", 565 });
            dataSet1.Tables["DataTable1"].Rows.Add(new object[] { DateTime.Today.AddDays(2), "c", 543 });
            pivotGridControl1.DataSource = dataSet1.Tables["DataTable1"];

            foreach (PropertyDescriptor d in ((ITypedList)pivotGridControl1).GetItemProperties(null)) {
                if (d.Name == "Arguments")
                    t.Columns.Add(d.Name, typeof(DateTime));
                else
                    t.Columns.Add(d.Name, d.PropertyType);
            }
            chartControl1.DataSource = t;
            chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl1.SeriesTemplate.ChangeView(ViewType.Line);
            chartControl1.SeriesDataMember = "Series";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            chartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime;
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Values" });
        }

        private void pivotGridControl1_CellSelectionChanged(object sender, EventArgs e) {
            t.Rows.Clear();
            for (int i = 0; i < ((IList)pivotGridControl1).Count; i++) {
                DataRow r = t.Rows.Add(new object[] { });
                foreach (PropertyDescriptor d in ((ITypedList)pivotGridControl1).GetItemProperties(null)) {
                    object o = d.GetValue(((IList)pivotGridControl1)[i]);
                    if (d.Name == "Arguments") {
                        DateTime dt;
                        try {
                            dt = Convert.ToDateTime(o);
                        } catch {
                            dt = DateTime.MinValue;
                        }
                        if (dt != DateTime.MinValue) {
                            r[d.Name] = dt;
                        }
                    } else {
                        r[d.Name] = o;
                    }

                }
            }
            chartControl1.Refresh();
        }
    }
}
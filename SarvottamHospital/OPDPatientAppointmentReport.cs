using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System.Configuration;
using SarvottamHospital.Dataset;
using SarvottamHospital.Object;

namespace SarvottamHospital
{
    public partial class OPDPatientAppointmentReport : Form
    {
        SarvottamHospital.Reports.AppointmentReport objrpt;

        private DateTime d1;
        private DateTime d2;

        public OPDPatientAppointmentReport()
        {
            InitializeComponent();
            DataSet1 ds = new DataSet1();
            var obj = Report.GetAppointmentFor7Days();
            if (obj != null)
            {
                ds.Tables["PatientAppointment"].Merge(obj);
            }
            objrpt = new Reports.AppointmentReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;

            var obj = Report.GetAppointmentReport(d1, d2);
            if (obj != null)
            {
                ds.Tables["PatientAppointment"].Merge(obj);
            }
            objrpt = new Reports.AppointmentReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Refresh();

        }
    }
}

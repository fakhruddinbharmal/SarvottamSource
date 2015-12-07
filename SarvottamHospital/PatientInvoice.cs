using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;
using CrystalDecisions.CrystalReports.Engine;
using SarvottamHospital.Dataset;
namespace SarvottamHospital
{
    public partial class PatientInvoice : Form
    {
        public Guid PatientGuid;
        SarvottamHospital.Reports.PatientBillReport objrpt;
        Patient objPatient;

        public PatientInvoice()
        {
            InitializeComponent();
        }

        private void PatientInvoice_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            var obj = Report.GetReport(PatientGuid);
            objPatient = new Patient(PatientGuid);

            ds.Tables[0].Merge(obj);
            objrpt = new Reports.PatientBillReport();

            TextObject txtPatientName = objrpt.ReportDefinition.ReportObjects["txtPatientName"] as TextObject;
            TextObject txtInvoiceNo = objrpt.ReportDefinition.ReportObjects["txtInvoiceNo"] as TextObject;
            TextObject txtPatientNo = objrpt.ReportDefinition.ReportObjects["txtPatientNo"] as TextObject;
            TextObject txtMobileNo = objrpt.ReportDefinition.ReportObjects["txtMobileNo"] as TextObject;
            TextObject txtCity = objrpt.ReportDefinition.ReportObjects["txtCity"] as TextObject;
            TextObject txtAddress = objrpt.ReportDefinition.ReportObjects["txtAddress"] as TextObject;

            txtPatientName.Text = objPatient.DisplayName;
            txtInvoiceNo.Text = Common.IntToString(objPatient.InvoiceNo);
            txtPatientNo.Text = Common.IntToString(objPatient.Number);
            txtMobileNo.Text = objPatient.ContactNo;
            txtCity.Text = objPatient.City;
            txtAddress.Text = objPatient.Address;

            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
        }
    }

}

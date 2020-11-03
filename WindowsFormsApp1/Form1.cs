using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<Student> listStudent = new List<Student>(); //mảng rỗng
            listStudent = new Model1().Students.ToList();
            this.reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc"; //nhớ copy report ra debug
            var reportDataSource = new ReportDataSource("StudentDataSet",listStudent); //đúng tên dataset trong thiết kế
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear trước khi dùng
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            List<Student> listStudent = new List<Student>(); //mảng rỗng
            listStudent = new Model1().Students.ToList();
            this.reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc"; //nhớ copy report ra debug
            var reportDataSource = new ReportDataSource("DataSet1", listStudent); //đúng tên dataset trong thiết kế
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear trước khi dùng
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    
    }
}

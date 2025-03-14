﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Repositories.ReportManagementRepository;
using OfficeOpenXml;

namespace BookHaven.Presentation.Comman
{
    public partial class MostBooksSaleView : Form
    {
        private readonly IReportManagementService _reportManagementService;
        public MostBooksSaleView()
        {
            InitializeComponent();
            _reportManagementService = new ReportManagementService(new ReportManagementRepository());
        }

        private async void btnGenarate_Click(object sender, EventArgs e)
        {
          
            var mostSoldBooks = await _reportManagementService.GetBestSellingBooks();

            // Check if data is returned
            if (mostSoldBooks != null && mostSoldBooks.Count > 0)
            {
                // Bind the data to the DataGridView
                dataGridView1.DataSource = mostSoldBooks;
            }
            else
            {
                MessageBox.Show("No data found for most sold books.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                FileName = "Most_Sold_Books_Report.xlsx"
            };

            // Show the dialog and check if the user selected a location
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Call the ExportDataGridViewToExcel method to export the data
                ExportDataGridViewToExcel(dataGridView1, saveFileDialog.FileName);

                // Show a message that the export was successful
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Export the DataGridView data to an Excel file
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="filePath"></param>
        private void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            // Set the license context
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Initialize the ExcelPackage to create the Excel file
            using (var package = new ExcelPackage())
            {
                // Add a worksheet to the ExcelPackage
                var worksheet = package.Workbook.Worksheets.Add("MostSoldBooks");

                // Add headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Save the file
                var file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        private void MostBooksSaleView_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportDashboard reportDashboard = new ReportDashboard();
            reportDashboard.ShowDialog();
            this.Close();
        }
    }
}

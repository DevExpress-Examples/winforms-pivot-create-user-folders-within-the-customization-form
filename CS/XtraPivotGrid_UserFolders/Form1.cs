using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace XtraPivotGrid_UserFolders {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();

            // Enable group folders in a customization window.
            pivotGridControl1.OptionsView.GroupFieldsInCustomizationWindow = true;

            // Specify the name of the folder that contains the Employees field.
            fieldSalesPerson.DisplayFolder = "Employees";
            fieldSalesPerson.Visible = false;

            // Specify the root and the nested folder names.
            fieldProductName.DisplayFolder = "Products\\Name";
            fieldCategoryName.DisplayFolder = "Products\\Category";
            fieldProductName.Visible = false;
            fieldCategoryName.Visible = false;

            // Invoke the Customization Form at the default location - the main window's bottom right corner.
            pivotGridControl1.FieldsCustomization();
            
        }
    }
}

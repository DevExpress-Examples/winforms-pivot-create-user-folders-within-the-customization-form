using System;
using System.Drawing;
using System.Windows.Forms;

namespace XtraPivotGrid_UserFolders {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Enables displaying user folders.
            pivotGridControl1.OptionsView.GroupFieldsInCustomizationWindow = true;

            // Specifies the name of the folder in which the Employees field is located.
            fieldSalesPerson.DisplayFolder = "Employees";

            // Specifies names of the main folder and nested folders in which 
            // the Product Name and Category Name fields are located.
            // Uses the "\" symbol as a delimiter when specifying folder names.
            fieldProductName.DisplayFolder = "Products\\Name";
            fieldCategoryName.DisplayFolder = "Products\\Category";

            // Invokes the Customization Form at the lower right corner of the main window.
            pivotGridControl1.FieldsCustomization();
        }
    }
}

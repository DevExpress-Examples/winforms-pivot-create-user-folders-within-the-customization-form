Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace XtraPivotGrid_UserFolders
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()

			' Enable group folders in a customization window.
			pivotGridControl1.OptionsView.GroupFieldsInCustomizationWindow = True

			' Specify the name of the folder that contains the Employees field.
			fieldSalesPerson1.DisplayFolder = "Employees"
			fieldSalesPerson1.Visible = False

			' Specify the root and the nested folder names.
			fieldProductName1.DisplayFolder = "Products\Name"
			fieldCategoryName1.DisplayFolder = "Products\Category"
			fieldProductName1.Visible = False
			fieldCategoryName1.Visible = False

			' Invoke the Customization Form at the default location - the main window's bottom right corner.
			pivotGridControl1.ShowCustomization()

		End Sub
	End Class
End Namespace

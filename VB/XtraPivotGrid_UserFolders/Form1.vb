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

			' Enable group folders in a customization window.
			pivotGridControl1.OptionsView.GroupFieldsInCustomizationWindow = True

			' Specify the name of the folder that contains the Employees field.
			fieldSalesPerson.DisplayFolder = "Employees"
			fieldSalesPerson.Visible = False

			' Specify the root and the nested folder names.
			fieldProductName.DisplayFolder = "Products\Name"
			fieldCategoryName.DisplayFolder = "Products\Category"
			fieldProductName.Visible = False
			fieldCategoryName.Visible = False

			' Invoke the Customization Form at the default location - the main window's bottom right corner.
			pivotGridControl1.FieldsCustomization()

		End Sub
	End Class
End Namespace

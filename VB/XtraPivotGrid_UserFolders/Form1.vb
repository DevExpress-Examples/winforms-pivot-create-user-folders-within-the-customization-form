Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace XtraPivotGrid_UserFolders
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Binds the pivot grid to data.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

			' Enables displaying user folders.
			pivotGridControl1.OptionsView.GroupFieldsInCustomizationWindow = True

			' Specifies the name of the folder in which the Employees field is located.
			fieldSalesPerson.DisplayFolder = "Employees"

			' Specifies names of the main folder and nested folders in which 
			' the Product Name and Category Name fields are located.
			' Uses the "\" symbol as a delimiter when specifying folder names.
			fieldProductName.DisplayFolder = "Products\Name"
			fieldCategoryName.DisplayFolder = "Products\Category"

			' Invokes the Customization Form at the lower right corner of the main window.
			pivotGridControl1.FieldsCustomization()
		End Sub
	End Class
End Namespace

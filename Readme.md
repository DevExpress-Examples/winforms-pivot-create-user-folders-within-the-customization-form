<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_UserFolders/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_UserFolders/Form1.vb))
<!-- default file list end -->
# How to create user folders within the Customization Form


<p>The following example shows how to group fields in the Customization Form by putting them in user-defined folders.</p><p>In this example, the Customization Form is invoked by calling the PivotGridControl.FieldsCustomization method.<br />
To enable displaying user folders, the PivotGridOptionsViewBase.GroupFieldsInCustomizationWindow property is set to <strong>true</strong>.</p><p>To create a folder for the Person field, the fieldSalesPerson.DisplayFolder property is set to "Employees". To create the main folder and nested folders for Product Name and Category Name fields, the fieldProductName.DisplayFolder property is set to "Products\\Name" and fieldCategoryName.DisplayFolder "Products\\Category" respectively.</p>

<br/>



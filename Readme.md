<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/281152544/20.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T915793)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# RichEdit for ASP.NET Core - How to submit document content with other values

This example illustrates a possible way to submit RichEdit's document content with other values. The main idea of this example is to call the client-side [saveDocument](https://docs.devexpress.com/AspNetCore/js-DevExpress.RichEdit.RichEdit#js_devexpress_richedit_richedit_savedocument) method in a button's click event handler. Then, save the EventArgs's e.base64 and e.format strings to the hidden fields in the [Saving](https://docs.devexpress.com/AspNetCore/DevExpress.AspNetCore.RichEdit.RichEditBuilder.OnSaving%28System.String%29) event handler.

<!-- default file list -->  
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs)
* [TestModel.cs](./CS/Models/TestModel.cs)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->

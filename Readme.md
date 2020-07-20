# RichEdit for ASP.NET Core - How to submit document content with other values

This example illustrates a possible way to submit RichEdit's document content with other values. The main idea of this example is to call the client-side [saveDocument](https://docs.devexpress.com/AspNetCore/js-DevExpress.RichEdit.RichEdit#js_devexpress_richedit_richedit_savedocument) method in a button's click event handler. Then, save the EventArgs's e.base64 and e.format strings to the hidden fields in the [Saving](https://docs.devexpress.com/AspNetCore/DevExpress.AspNetCore.RichEdit.RichEditBuilder.OnSaving%28System.String%29) event handler.

<!-- default file list -->  
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs)
* [TestModel.cs](./CS/Models/TestModel.cs)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
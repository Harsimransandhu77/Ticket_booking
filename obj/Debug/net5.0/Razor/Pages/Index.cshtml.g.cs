#pragma checksum "C:\Users\atind\source\repos\Ticket_BookingAPI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57fe460db2eb670bd857ddc691d9ce5b56bd2d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57fe460db2eb670bd857ddc691d9ce5b56bd2d7", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57fe460db2eb670bd857ddc691d9ce5b56bd2d73577", async() => {
                WriteLiteral("\r\n    <title>Booking</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a57fe460db2eb670bd857ddc691d9ce5b56bd2d73869", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57fe460db2eb670bd857ddc691d9ce5b56bd2d75982", async() => {
                WriteLiteral(@"


    <div class=""containers"">
        <div>
            <h3>Society Tour BOOKING</h3>
            <div class='withForm'>
                <div class='d-flex'>
                    <div>
                        <label>Name</label>

                        <input type=""text"" id='name' class='form-control' autocomplete=""off"">
                    </div>
                    <div>
                        <label>Phone</label>
                        <input type=""text"" id='phone' class='form-control'>
                    </div>
                    <div>
                        <label>Status</label>
                        <select class=""form-control"" id='status'>
                            <option value='Paid'>Paid</option>
                            <option value='Due'>Due</option>
                        </select>
                    </div>
                    <div class='buttn'>
                        <button type=""button"" class=""btn btn-warning"" onclick=""tbooking()""> Book </button>
  ");
                WriteLiteral(@"                  </div>
                </div>
            </div>
            <div class='tableHolder'>
                <table class=""table table-bordered"">
                    <tr>
                        <th>Name</th>
                        <th>Phone</th>
                        <th>Status</th>
                        <th>Action</th>
                    </tr>
                    <tbody id=""allbookings"">
                    </tbody>
                </table>

            </div>

        </div>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""updatebooking"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Update Booking</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                WriteLiteral(@"
                <div class=""modal-body"">
                    <form>
                        <div class=""form-group"">

                            <input type=""hidden"" class=""form-control"" id=""_id"" aria-describedby=""IdHelp"">

                        </div>
                        <div class=""form-group"">
                            <label class=""text-dark"" for=""name"">Name</label>
                            <input type=""text"" class=""form-control"" id=""update_name"" aria-describedby=""nameHelp"">

                        </div>
                        <div class=""form-group"">
                            <label class=""text-dark"" for=""status"">Phone</label>
                            <input type=""text"" class=""form-control"" id=""update_phone"" aria-describedby=""statusHelp"">

                        </div>


                        <div class=""form-group"">
                            <label class=""text-dark"" for=""phone"">Status </label>
                            <select class=""form-control"" id=""upd");
                WriteLiteral(@"ate_status"">
                                <option value='Paid'>Paid</option>
                                <option value='Due'>Due</option>
                            </select>
                            
                        </div>


                        <div class=""form-group"" id=""update_result"">


                        </div>
                        <button type=""button"" class=""btn btn-dark"" onclick=""updatebooking()"">Update </button>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                </div>
            </div>
        </div>
    </div>







    <script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/p");
                WriteLiteral(@"opper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

    <script>
        var uri = 'api/Bookings';
        //Java script
        $(document).ready(function () {
            $.getJSON(uri)
                .done(function (data) {
                    $(""#bookingtemplate"").tmpl(data).appendTo(""#allbookings"");
                });
        });
        // function to get all bookings
        function getallbookings() {
            $.getJSON(uri)
                .done(function (data) {
                    $(""#allbookings"").text("""");
                    $(""#bookingtemplate"").tmpl(data).appendTo(""#allbookings"");
                });
        }
        // function to add new booking
        function tbooking() {
      ");
                WriteLiteral(@"      var _name = $('#name').val();
            var _status = $('#status').val();
            var _phone = $('#phone').val();

            var booking = {
                name: _name,
                status: _status,
                phone: _phone

            };
            $.ajax({
                type: ""POST"",
                url: uri,
                data: JSON.stringify(booking),
                contentType: ""application/json; charset=utf-8""
            }).done(function (response) {
                $(""#result"").html(""Success"");
                getallbookings();
            }).fail(function (jqXHR, textStatus) {
                $(""#result"").html(""An error  "");
            });
        }
        // funtion to fill the data
        function getbookingForUpdate(id) {
            $.ajax({
                type: ""GET"",
                url: uri + ""/"" + id,
                contentType: ""application/json""
            }).done(function (response) {
                $('#_id').val(response.bo");
                WriteLiteral(@"oking_ID);
                $('#update_name').val(response.name);
                $('#update_status').val(response.status);
                $('#update_phone').val(response.phone);

            });
        }
        // function to update booking
        function updatebooking() {
            var _name = $('#update_name').val();
            var _status = $('#update_status').val();
            var _phone = $('#update_phone').val();

            var bookingUpdate = {
                booking_ID: parseInt($('#_id').val()),
                name: _name,
                status: _status,
                phone: _phone

            };
            $.ajax({
                type: ""PUT"",
                url: uri + ""/"" + $('#_id').val(),
                data: JSON.stringify(bookingUpdate),
                contentType: ""application/json; charset=utf-8""
            }).done(function (response) {
                $(""#update_result"").html(""Success"");
                getallbookings();
            }).fail(f");
                WriteLiteral(@"unction (jqXHR, textStatus) {
                $(""#update_result"").html(""An error "");
            });
        }
        //funtion to delete
        function remove(id) {
            var yes = confirm(""Are you sure you want to delete"");
            if (yes) {
                $.ajax({
                    type: ""DELETE"",
                    url: uri + ""/"" + id,
                }).done(function (response) {
                    getallbookings();
                });
            }
        }
    </script>

    <script id=""bookingtemplate"" type=""text/x-jquery-tmpl"">





        <tr>

            <th>${name}</th>
            <th>${phone}</th>
            <th>${status}</th>
            <th>
                <button class=""btn btn-outline-warning"" onclick=""getbookingForUpdate('${booking_ID}')"" data-toggle=""modal"" data-target=""#updatebooking"">Update</button>
                <a href=""#"" class=""btn btn-outline-danger"" onclick=""remove('${booking_ID}')"">Delete</a>
            </th>

        </");
                WriteLiteral("tr>\r\n\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket_BookingAPI.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ticket_BookingAPI.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ticket_BookingAPI.Pages.IndexModel>)PageContext?.ViewData;
        public Ticket_BookingAPI.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
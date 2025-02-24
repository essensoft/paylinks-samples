using Essensoft.Paylinks.WeChatPay.Client;
using Essensoft.Paylinks.WeChatPay.Payments.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace Essensoft.Paylinks.Razor.Pages.Samples.Web.Pages.WeChatPay.Payments;

public class RefundQueryByOutRefundNoModel(IWeChatPayClient client, IOptions<PaylinksOptions> options) : PageModel
{
    private readonly WeChatPayClientOptions _options = options.Value.WeChatPay;

    [BindProperty]
    public string OutRefundNo { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public async Task OnPostAsync()
    {
        var request = new WeChatPayRefundQueryByOutRefundNoRequest { OutRefundNo = OutRefundNo };
        var response = await client.ExecuteAsync(request, _options);
        ViewData["response"] = response.Body;
    }
}

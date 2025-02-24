using Essensoft.Paylinks.WeChatPay.Client;
using Essensoft.Paylinks.WeChatPay.Payments.Model;
using Essensoft.Paylinks.WeChatPay.Payments.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace Essensoft.Paylinks.Razor.Pages.Samples.Web.Pages.WeChatPay.Payments;

public class AbnormalRefundModel(IWeChatPayClient client, IOptions<PaylinksOptions> options) : PageModel
{
    private readonly WeChatPayClientOptions _options = options.Value.WeChatPay;

    [BindProperty]
    public string RefundId { get; set; } = string.Empty;

    [BindProperty]
    public WeChatPayApplyAbnormalRefundByRefundIdBodyModel Input { get; set; } = default!;

    public void OnGet()
    {
    }

    public async Task OnPostAsync()
    {
        var request = new WeChatPayApplyAbnormalRefundByRefundIdRequest { RefundId = RefundId };
        request.SetBodyModel(Input);
        var response = await client.ExecuteAsync(request, _options);
        ViewData["response"] = response.Body;
    }
}

using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Pages
{
    public class CarrinhoPage : CommonPageBase
    {
        public string deleteButton = "cart_delete";
        public string finalizacompraCss = "a.standard-checkout";
        public string avancarEnderecoXpath = "processAddress";
        public string avancarEntregaButton = "processCarrier";
        public string aceitarTermosCheckbox = "p .checker input";
        public string BoletoCss= ".bankwire";
        public string confirmarCss= ".cart_navigation .button-medium";
        public string validaConcluirCompraCss= ".cheque-indent";

        private readonly BrowserSession _browser;

        public CarrinhoPage(BrowserSession browser) : base(browser)
        {
            _browser = browser;
        }
        public void concluirCompra() {
            _browser.FindCss(finalizacompraCss,Options.Invisible).Click();
            _browser.ClickButton(avancarEnderecoXpath);
            _browser.FindCss(aceitarTermosCheckbox,Options.Invisible).Click();
            _browser.ClickButton(avancarEntregaButton);
            _browser.FindCss(BoletoCss).Click();
            _browser.FindCss(confirmarCss).Click();
        }
        public bool validaConclusaoCompra() {
            if (_browser.FindCss(validaConcluirCompraCss).Text.Contains("Your order on My Store is complete"))
                return true;

            else { return false; }
        }
    }
}

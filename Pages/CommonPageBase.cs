using Coypu;

namespace DatumProcesso.Pages
{
    public class CommonPageBase
    {
        private readonly BrowserSession _browser;
        public string carrinhoCss = ".shopping_cart a";
        public string pesquisarInputID = "search_query_top";
        public string contateNosID = "contact-link";
        public string loginCss = ".login";
        public string pesquisarButton = "submit_search";
        public string detalheLoginCss = "account";
        public CommonPageBase(BrowserSession browser)
        {
            _browser = browser;
        }
        public void acessarCarrinho()
        {
            _browser.FindCss(carrinhoCss).Click();
        }
        public void acessarContateNos()
        {
            _browser.FindId(contateNosID).Click();
        }
        public void acessarLogin()
        {
            _browser.FindCss(loginCss).Click();
        }
        public void filtrarCategoria() { }
        public void pesquisarNomeProduto(string texto)
        {
            _browser.FillIn(pesquisarInputID).With(texto);
            _browser.ClickButton(pesquisarButton);
        }
    }
}
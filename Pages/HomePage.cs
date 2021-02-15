using Coypu;
using DatumProcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Pages
{
   public class HomePage : CommonPageBase
    {
        private const string adicionarCarrinhoCss = ".ajax_add_to_cart_button";
        private const string finalizarCompraCss = ".button-container .button-medium";
        private const string continuarCompraCss = ".button-container .continue";
        private const string visualizarListaId = "list";
        private readonly BrowserSession _browser;

        public HomePage(BrowserSession browser) : base(browser)
        {
            _browser = browser;
        }
        public void visualizarLista() {
            _browser.FindId(visualizarListaId).Click();
        }
        public void adicionarNoCarrinho(Produto produto) {
            visualizarLista();
           _browser.FindCss(adicionarCarrinhoCss,Options.First).Hover().Click();
            _browser.FindCss(continuarCompraCss).Click();
        }
       
    }
}

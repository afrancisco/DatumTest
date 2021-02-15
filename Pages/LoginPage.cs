using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Pages
{
    public class LoginPage : CommonPageBase
    {
        private readonly BrowserSession _browser;
        public string NovoemailID = "email_create";
        public string EmailUsuarioCss = "#login_form #email";
        public string SenhaUsuarioID = "passwd";
        public string EsqueciSenhaCss = ".lost_password";
        public string LogarButton = "SubmitLogin";
        public string CriarContaButton = "SubmitCreate";

        public LoginPage(BrowserSession browser) : base(browser)
        {
            _browser = browser;
        }

        public void acessaresqueciSenha()
        {
            _browser.FindCss(EsqueciSenhaCss).Click();
        }
        public void realizarLogin(string login, string senha)
        {
            _browser.FindCss(EmailUsuarioCss).FillInWith(login);
            _browser.FillIn(SenhaUsuarioID).With(senha);
            _browser.ClickButton(LogarButton);

        }
        public bool ValidaloginSucesso(string nome) {
            return _browser.FindCss(detalheLoginCss).Text.Equals(nome);
        }
        public void criarNovaCOnta(string login)
        {
            _browser.FillIn(NovoemailID).With(login);
            _browser.ClickButton(CriarContaButton);
        }
    }
}

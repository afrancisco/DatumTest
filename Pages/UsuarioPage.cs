using Coypu;
using DatumProcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Pages
{
    public class UsuarioPage : CommonPageBase
    {
        private readonly BrowserSession _browser;
        
        //dados pessoais
        public string mrID = "uniform-id_gender1";
        public string mrsID = "uniform-id_gender2";
        public string primeiroNomeId = "customer_firstname";
        public string ultimoNomeId = "customer_lastname";
        public string emailCss = "#account-creation_form #email";
        public string senhaId = "passwd";
        public string diaId = "days";
        public string mesId = "months";
        public string anoId = "years";
        public string newsletterId = "uniform-newsletter";
        public string ofertasId = "uniform-optin";
        ///Endereço
        public string primeiroNomeRuaId = "firstname";
        public string ultimoNomeRuaId = "lastname";
        public string companiaId = "company";
        public string enderecoId = "address1";
        public string endereco2Id = "address2";
        public string cidadeId = "city";
        public string estadoId = "State";
        public string codigoPostalId = "postcode";
        public string paisId = "id_country";
        public string informacoesAdicionaisId = "other";
        public string telefoneFixoId = "phone";
        public string celularId = "phone_mobile";
        public string enderecoReeferenciaId = "alias";
        public string registrarButton = "submitAccount";

        public UsuarioPage(BrowserSession browser) : base(browser)
        {
            _browser = browser;
        }
        public void preencheInformacaoPessoal(Usuario user)
        {

            _browser.FillIn(primeiroNomeId).With(user.primeiroNome);
            _browser.FillIn(ultimoNomeId).With(user.ultimoNome);
            _browser.FindCss(emailCss).FillInWith(user.email);
            _browser.FillIn(senhaId).With(user.senha);

            _browser.FindId(getGenero(user.genero)).Check();
            if (user.dataNascimento!=new DateTime())
            {
                _browser.FindId(diaId).SelectOption(user.dataNascimento.Day.ToString());
                _browser.FindId(mesId).SelectOption(user.dataNascimento.Month.ToString());
                _browser.FindId(anoId).SelectOption(user.dataNascimento.Year.ToString());

            }

            checkNewsletter(user.newsletter);
            checkOffes(user.offers);
        }

      

        public void preencheEndereco(Usuario user)
        {
            _browser.FillIn(primeiroNomeRuaId).With(user.enderecoprimeiroNome);
            _browser.FillIn(ultimoNomeRuaId).With(user.enderecoultimoNome);
            _browser.FillIn(enderecoId).With(user.endereco1);
            _browser.FillIn(cidadeId).With(user.cidade);
            //check how to select dropdown options in coypu
            _browser.Select(user.estado,Options.Invisible).From(estadoId,Options.Substring);
            _browser.FindId(codigoPostalId).FillInWith(user.codigoPostal);
           
            _browser.FindId(paisId).SelectOption(user.pais);
            _browser.FillIn(informacoesAdicionaisId).With(user.informacoesAdicionais);
            _browser.FillIn(telefoneFixoId).With(user.telefoneResidencia);
            _browser.FillIn(celularId).With(user.celular);
            _browser.FillIn(enderecoReeferenciaId).With(user.referencia);
            _browser.ClickButton(registrarButton);


        }
        public string getGenero(Genero genero=Genero.mr)
        {
            switch (genero)
            {
                case Genero.mr:
                    return mrID;
                case Genero.mrs:
                    return mrsID;
                default:
                    return mrID;
            }
        }
        public enum Genero
        {
            mr ,
            mrs 
        }
        private void checkOffes(bool offers)
        {
            if (offers)
            {
                _browser.FindId(ofertasId).Check();
            }
            else
            {
                _browser.FindId(ofertasId).Uncheck();
            }
        }

        private void checkNewsletter(bool newsletter)
        {
            if (newsletter)
            {
                _browser.FindId(newsletterId).Check();
            }
            else
            {
                _browser.FindId(newsletterId).Uncheck();
            }
        }
      
    }
}

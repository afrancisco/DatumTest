using DatumProcesso.Models;
using DatumProcesso.Pages;
using DatumProcesso.Utils;
using NUnit.Framework;
using System;
using static DatumProcesso.Pages.UsuarioPage;

namespace DatumProcesso.Tests
{
    public class UsuarioTests : BaseTest
    {
        private LoginPage _login;
        private UsuarioPage _usuario;
        [SetUp]
        public void Setup()
        {
            _login = new LoginPage(Browser);
            _usuario = new UsuarioPage(Browser);
        }

 [Test]
        public void DeveLogarNoSistema()
        {
            var usuario= new Usuario{email="datumqatest@soprock.com",senha="datum2021",primeiroNome= ""};
             _login.acessarLogin();
             _login.realizarLogin(usuario.email,usuario.senha);
            Assert.True(_login.ValidaloginSucesso(usuario.primeiroNome));
            
        }
        [Test]
        //TODO verificar os selects de drop que não funcionaram como esperado
        //public void DeveCadastrarNovoUsuario()
        //{

        //    var usuario = new Usuario
        //    {
        //        primeiroNome = "Jonas",
        //        ultimoNome = "Pedro",
        //        email = string.Concat(Helpers.RandomString(15), "@mailinator.com"),
        //        senha = "12345",
        //        endereco1 = "Starbuteco",
        //        cidade = "Cidade Alta",
        //        estado = "Texas",
        //        codigoPostal = "12345",
        //        pais = "United States",
        //        celular = "32991111254",
        //        informacoesAdicionais = "Nenhuma",
        //        enderecoprimeiroNome = "Jonas",
        //        enderecoultimoNome = "Pedro",
        //        telefoneResidencia = "",
        //        referencia = ""
        //    };
        //    _login.acessarLogin();
        //    _login.criarNovaCOnta(usuario.email);
        //    _usuario.preencheInformacaoPessoal(usuario);
        //    _usuario.preencheEndereco(usuario);

        //    Assert.Pass();
        //}

    }
}
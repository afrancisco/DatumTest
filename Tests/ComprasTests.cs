using DatumProcesso.Models;
using DatumProcesso.Pages;
using DatumProcesso.Utils;
using NUnit.Framework;
using System.Collections.Generic;

namespace DatumProcesso.Tests
{
    [TestFixture]
    public class ComprasTests :BaseTest
    {
        private LoginPage _login;
        private CarrinhoPage _carrinho;
        private HomePage _home;

        [SetUp]
        public void Setup()
        {
            _login = new LoginPage(Browser);
            _carrinho = new CarrinhoPage(Browser);
            _home = new HomePage(Browser);
        }

        [Test]
        [TestCase]
        public void DeveRealizarCompraDeProdutos()
        {
            var usuario = new Usuario { email = "datumqatest@soprock.com", senha = "datum2021" };
           List<Produto> produtos= new List<Produto>();
            //produtos.Add(new Produto { nome = "Faded Short Sleeve T-shirts", quantidade = 1 });
            produtos.Add(new Produto { nome = "Blouse", quantidade = 1 });
            produtos.Add(new Produto { nome = "Printed Dress", quantidade = 1 });
          
            
            var pedido = new Pedido {usuario=usuario,produtos=produtos
            };
           
            _login.acessarLogin();
            _login.realizarLogin(pedido.usuario.email, pedido.usuario.senha);
            foreach (var item in pedido.produtos)
            {
                _home.pesquisarNomeProduto(item.nome);
                _home.adicionarNoCarrinho(item);
            }
            _carrinho.acessarCarrinho();
            _carrinho.concluirCompra();
            _carrinho.validaConclusaoCompra();
            Assert.True(_carrinho.validaConclusaoCompra());
        }
    }
}

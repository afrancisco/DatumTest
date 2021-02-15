using DatumProcesso.API;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumProcesso.Tests
{
    public class ApiTests
    {
        [Category("Api")]
        [Test]
        [TestCase("1", "George")]
        [TestCase("2", "Janet")]
        [TestCase("3", "Emma")]
        public async Task DeveRetornarDadosDoUsuario(string id, string expected)
        {
            Api api = new Api();
            var response = api.GetUserSingleRequest(id);
            Assert.AreEqual(response.Result.data.first_name,expected);
        }
        [Category("Api")]
        [Test]
        [TestCase("1", 6)]
        [TestCase("2", 6)]
        [TestCase("3", 0)]
        public async Task DeveRetornarListaUsuario(string page, int expectedpage)
        {
            Api api = new Api();
            var response = api.GetUserPageRequest(page);
            Assert.AreEqual(response.Result.data.Count, expectedpage);
            //Assert.Equals(response.Result.page,expected);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DatumProcesso.Pages.UsuarioPage;

namespace DatumProcesso.Models
{
    public class Usuario
    {
        public string primeiroNome { get; set; }
        public string ultimoNome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public Genero genero { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool newsletter { get; set; }
        public bool offers { get; set; }
        public string enderecoprimeiroNome { get; set; }
        public string enderecoultimoNome { get; set; }
        public string endereco1 { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string codigoPostal { get; set; }
        public string pais { get; set; }
        public string celular { get; set; }
        public string referencia { get; set; }
        public string endereco2 { get; set; }
        public string informacoesAdicionais { get; set; }
        public string telefoneResidencia { get; set; }
        public string compania { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Business.Models
{
    public class Item : Entity
    {
        //Descricao, Preço, Data Cadastro, Situação, Estoque, Imagem
        public string Descricao { get; set; }
        public double Estoque { get; set; }
        public bool Ativo { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Preco { get; set; }

        //Criar vinculo com Evento

    }
}

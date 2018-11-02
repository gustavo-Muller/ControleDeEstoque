﻿using System.Collections.Generic;

namespace Estagio.Nucleo
{
    public class ItemMovimentacao
    {
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; private set; }
        public decimal ValorMovimentacao { get
            {
                return Quantidade * ValorUnitario;
            }
        }


        public void insiraProduto(Produto novoProduto)
        {
            if(novoProduto.Id != 0)
            {
                Produto = novoProduto;
            }
            else
            {
                throw new System.ApplicationException("Selecione um produto!");
            }
        }
        // somente ler esse lista
        //public IEnumerable<ItemMovimentacao> Itens =>_itemMovimentacao.AsReadOnly();


    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;
using System.Xml.Linq;

namespace FactoryMethod.Produto
{
    public class Pagamento
    {

        private List<Item> _items = new List<Item>();

        public string CPF { get; set; }
        public string Estado { get; set; }
        public decimal ICMS { get; set; }
        public string UF { get; set; }
        public decimal ValorTotal { get; set; }

        private void CalculaTotal()
        {
            decimal total = .0M;
            foreach (var item in _items)
            {
                total += item.Valor;
            }
            ValorTotal = total;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
            CalculaTotal();    
        }
        public void RemoverItem(Item item)
        {
            _items.Remove(item);
            CalculaTotal();
        }



        public decimal CalcularICMS()
        {
            return ValorTotal * (ICMS / 100);
        }
    
        public void ProcessarPagamento()
        {
            SistemaPagamento sistemaPagamento = new PagSeguro();
            sistemaPagamento.RegistrarPagamento(this);
        }
    }
}

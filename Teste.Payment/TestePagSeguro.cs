using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetEmpresa.Payment.pagseguro;
using System.Collections;
using System.Collections.Generic;



namespace Teste.Payment
{
    [TestClass]
    public class TestePagSeguro
    {
        [TestMethod]
        public void Checkout()
        {
            PagSeguroResponse _resposta;
            PagSeguroPayment _payment;
            PagSeguroRequest _req;
            PagSeguroRequestAddress _address;
            PagSeguroRequestItem _item;
            PagSeguroRequestSender _sender;
            PagSeguroRequestShipping _shipping;

            _req = new PagSeguroRequest();
            _req.Currency = EnumCurrency.BRL;
            _req.Reference = "TESTE0001";


            _sender = new PagSeguroRequestSender();

            _sender.Email = "capella.bruno@gmail.com";
            _sender.Name = "Bruno Teste";
            _sender.Phone = "2173410100";
            _req.Sender = _sender;

            _shipping = new PagSeguroRequestShipping();
            _shipping.Type = PagSeguroRequestTypeShipping.NaoInformado;

            _address = new PagSeguroRequestAddress();
            _address.City = "Rio de Janeiro";
            _address.Complement="";
            _address.Country="BRA";
            _address.District = "Tijuca";
            _address.PostalCode="20520052";
            _address.Stade="RJ";
            _address.Street ="Rua Conde de Bonfim";
            _address.Number = "601";

            _shipping.Address = _address;

            _req.Shipping = _shipping;

            _item =  new PagSeguroRequestItem();
            _item.Amount=(decimal)0.02;
            _item.Description="teste 1";
            _item.Id=00002;
            _item.Quantity=1;
            _item.Weight=0;

            _req.Itens = new List<PagSeguroRequestItem>();
            _req.Itens.Add(_item);


            _payment = new PagSeguroPayment();
            _resposta = _payment.Checkout(_req, "bruno.capella@getempresa.com.br");

            Assert.IsTrue(true);
        }
    }
}

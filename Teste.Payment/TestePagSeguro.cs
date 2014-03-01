using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetEmpresa.Payment.pagseguro;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml;


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
            _req.Reference = "REF0001";


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
            PagSeguroCredential _credential = new PagSeguroCredential();
            _credential.Token = "FC462D87E4B6437BB819ED3D82D91AF4";
            _credential.Email = "bruno.capella@getempresa.com.br";

            _resposta = _payment.Checkout(_req, _credential);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TesteSender() {
            string _token = "FC462D87E4B6437BB819ED3D82D91AF4";
            string _mail = "bruno.capella@getempresa.com.br";
            string _data = "email=bruno.capella@getempresa.com.br&token=FC462D87E4B6437BB819ED3D82D91AF4&currency=BRL&itemId1=1&itemDescription1=Notebook Prata&itemAmount1=24300.00&itemQuantity1=1&itemWeight1=0&reference=REF1234&senderName=Jose Comprador&senderAreaCode=11&senderPhone=56273440&senderEmail=comprador@uol.com.br&shippingType=1&shippingAddressStreet=Av. Brig. Faria Lima&shippingAddressNumber=1384&shippingAddressComplement=5o andar&shippingAddressDistrict=Jardim Paulistano&shippingAddressPostalCode=01452002&shippingAddressCity=Sao Paulo&shippingAddressState=SP&shippingAddressCountry=BRA";
            //string _data = "email=bruno.capella@getempresa.com.br&token=FC462D87E4B6437BB819ED3D82D91AF4&currency=BRL&itemId1=2&itemDescription1=teste 1&itemAmount1=0.02&itemQuantity1=1&itemWeight1=0&reference=REF0001&senderName=Bruno Teste&senderAreaCode=21&senderPhone=73410100&senderEmail=capella.bruno@gmail.com&shippingType=NaoInformado&shippingAddressStreet=Rua Conde de Bonfim&shippingAddressNumber=601&shippingAddressComplement=&shippingAddressDistrict=Tijuca&shippingAddressPostalCode=20520052&shippingAddressCity=Rio de Janeiro&shippingAddressState=RJ&shippingAddressCountry=BRA";
            WebRequest request = WebRequest.Create("https://ws.pagseguro.uol.com.br/v2/checkout");
            request.ContentType =  "application/x-www-form-urlencoded; charset=ISO-8859-1";
            request.Method = "POST";
            request.Timeout =10000;
            request.Headers.Add("lib-description", ".net: 2.0.4");
            request.Headers.Add("language-engine-description", ".net:" + Environment.Version.ToString());

            using (System.IO.Stream write = request.GetRequestStream()) {
                byte[] b = Encoding.GetEncoding("ISO-8859-1").GetBytes(_data);
                write.Write(b, 0, b.Length);
                write.Close();
            }

            HttpWebResponse  response = request.GetResponse() as HttpWebResponse;

            using (XmlReader reader = XmlReader.Create(response.GetResponseStream())) {
                reader.ReadStartElement();
                reader.MoveToContent();

                while (!reader.EOF) {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.Write(reader.Name + " --> ");
                        switch (reader.Name)
                        {
                            case "date":
                               Console.Write(reader.ReadElementContentAsDateTime());
                                break;
                            case "code":
                                Console.Write(reader.ReadElementContentAsString());
                                break;
                           }
                    }
                    reader.Read();
                    reader.MoveToContent();
                }
            }


            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK);
        }
    }
}

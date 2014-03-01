using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Serialization.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace GetEmpresa.Payment.pagseguro
{
    public class PagSeguroPayment : IPagSeguroPayment
    {
        //private string token = "FC462D87E4B6437BB819ED3D82D91AF4";
        private string wsCheckout = "https://ws.pagseguro.uol.com.br/v2/checkout";
        private string wsNotifi = "https://ws.pagseguro.uol.com.br/v2/transactions/notifications";
        private string wsTransactions = "https://ws.pagseguro.uol.com.br/v2/transactions";
        private string paymentRedirect = "https://pagseguro.uol.com.br/v2/checkout/payment.html";
        private string contentType = "application/x-www-form-urlencoded; charset=ISO-8859-1";
        private string method = "POST";
        private int timeout =10000;

        #region "Checkout"
        public PagSeguroResponse Checkout(PagSeguroRequest _domain, PagSeguroCredential _credential)
        {          
            WebRequest request = WebRequest.Create(this.wsCheckout);
            string _dataSend = string.Empty;
            HttpWebResponse _response = null;
            PagSeguroResponse _retorno = null;

            request.ContentType = this.contentType;
            request.Method = method;
            request.Timeout = timeout;
            request.Headers.Add("lib-description", ".net: 2.0.4");
            request.Headers.Add("language-engine-description", ".net:" + Environment.Version.ToString());

            _dataSend =  this.ReturnDataCurl(_domain, _credential);

            if (this.method == "POST") {
                using (Stream write = request.GetRequestStream()) {
                    byte[] _bW = Encoding.GetEncoding("ISO-8859-1").GetBytes(_dataSend);
                    write.Write(_bW, 0, _bW.Length);
                    write.Close();
                }
            }

            _response = request.GetResponse() as HttpWebResponse;

            if (_response.StatusCode == HttpStatusCode.OK)
            {
                _retorno = new PagSeguroResponse();
                using (XmlReader reader = XmlReader.Create(_response.GetResponseStream())) {
                    if (!reader.IsEmptyElement)
                    {
                        reader.ReadStartElement();
                        reader.MoveToContent();
                        while (!reader.EOF)
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                switch (reader.Name)
                                {
                                    case "date":
                                        _retorno.Date = reader.ReadElementContentAsDateTime();
                                        break;
                                    case "code":
                                        _retorno.Code = reader.ReadElementContentAsString();
                                        break;
                                }
                            }
                            reader.Read();
                            reader.MoveToContent();
                        }
                    }
                    else {
                        throw new PagSeguroException("Sorry: This not possible create a payment request.");
                    }

                    _retorno.UriRedirect = new Uri(this.paymentRedirect + "?code=" + _retorno.Code);
                }
            }

            return _retorno;

        }

        private string ReturnDataCurl(PagSeguroRequest _req, PagSeguroCredential _credential)
        {
            string _urlCurl = @"email=" + _credential.Email + @"";

            _urlCurl += "&token=" + _credential.Token + @"";
            _urlCurl += "&currency=" + _req.Currency.ToString() + @"";

             if (_req.Itens == null || _req.Itens.Count == 0)
                throw new PagSeguroException("Itens is not found. Please info your Items for sale");

            for (int i = 0; i < _req.Itens.Count; i++)
            {
                PagSeguroRequestItem item = _req.Itens[i];

                _urlCurl += "&itemId" + (i+1) + "=" + item.Id + @"";
                _urlCurl += "&itemDescription" + (i+1) + "=" + item.Description + @"";
                _urlCurl += "&itemAmount" + (i+1) + "=" + item.Amount.ToString("N2").Replace(".", "").Replace(",",".") + @"";
                _urlCurl += "&itemQuantity" + (i+1) + "=" + item.Quantity + @"";
                _urlCurl += "&itemWeight" + (i+1) + "=" + item.Weight + @"";
            }

            _urlCurl += "&reference=" + _req.Reference + @"";
            
             if (_req.Sender == null)
                throw new PagSeguroException("Sender is not found");

            _urlCurl += "&senderName=" + _req.Sender.Name + @"";

            _urlCurl += "&senderAreaCode=" + _req.Sender.Phone.Substring(0, 2) + @"";
            _urlCurl += "&senderPhone=" + _req.Sender.Phone.Substring(2, _req.Sender.Phone.Length - 2) + @"";
            _urlCurl += "&senderEmail=" + _req.Sender.Email + @"";

            _urlCurl += "&shippingType=" + Convert.ToInt32(_req.Shipping.Type) + @"";
            _urlCurl += "&shippingAddressStreet=" + _req.Shipping.Address.Street;
            _urlCurl += "&shippingAddressNumber=" + _req.Shipping.Address.Number;
            _urlCurl += "&shippingAddressComplement=" + _req.Shipping.Address.Complement;
            _urlCurl += "&shippingAddressDistrict=" + _req.Shipping.Address.District;
            _urlCurl += "&shippingAddressPostalCode=" + _req.Shipping.Address.PostalCode;
            _urlCurl += "&shippingAddressCity=" + _req.Shipping.Address.City;
            _urlCurl += "&shippingAddressState=" + _req.Shipping.Address.Stade;
            _urlCurl += "&shippingAddressCountry=" + _req.Shipping.Address.Country;
            
            return _urlCurl;
        }
        #endregion

        #region "transactions"
        #endregion

        #region "Notifications"
        #endregion

    }
}

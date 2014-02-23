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
    public class PagSeguroPayment
    {
        private string token = "6E66FBCB062546B199480698D6F403FD";
        private string wsCheckout = "https://ws.pagseguro.uol.com.br/v2/checkout/";
        private string contentType = "application/x-www-form-urlencoded; charset=ISO-8859-1";

        public PagSeguroResponse Checkout(PagSeguroRequest _domain, string _emailLoja)
        {
            PagSeguroResponse _response = null;
            XmlSerializer _serializer = null;
            Stream _stream = null;
            XmlReader _xmlReader = null;
            WebRequest _request = null;
            string _xmlPOST = string.Empty;
            WebResponse _resp = null;
            string _data = "token=" + this.token + "&email=" + _emailLoja;

            _response = new PagSeguroResponse();

            _xmlPOST = this.ReturnDataCurl(_domain, _emailLoja); //this.FormataXML(_domain, _emailLoja);

            _request = WebRequest.Create(wsCheckout);

           // _request.Headers.Add("token", this.token);
           // _request.Headers.Add("email", _emailLoja);

            _request.ContentType = contentType;

            _request.Method = "POST";

            Stream _streamWrite = _request.GetRequestStream();

            byte[] _b = Encoding.GetEncoding("ISO-8859-1").GetBytes(_xmlPOST);
            _streamWrite.Write(_b, 0, _b.Length);
            _streamWrite.Close();

            _resp = _request.GetResponse();

            _stream = _resp.GetResponseStream();

            _xmlReader = XmlReader.Create(_stream);

            _serializer = new XmlSerializer(typeof(PagSeguroResponse));

            _response = (PagSeguroResponse)_serializer.Deserialize(_xmlReader);

            return _response;

        }

        private string FormataXML(PagSeguroRequest _req, string _email)
        {
            StringBuilder _builder = new StringBuilder();

            _builder.Append("<?xml version=\"1.0\" encoding=\"ISO-8859-1\" standalone=\"yes\"?>");

            _builder.Append("<checkout>");

            //_builder.Append("<credential>");
            //_builder.Append("<email>" + _email + "</email>");
            //_builder.Append("<token>" + this.token + "</token>");
            //_builder.Append("</credential>");

            _builder.Append("<currency>" + _req.Currency.ToString() + "</currency>");

            FormatItems(_req, _builder);

            _builder.Append("<reference>" + _req.Reference.ToString() + "</reference>");

            FormarSender(_req, _builder);

            FormatShipping(_req, _builder);

            _builder.Append("</checkout>");

            return _builder.ToString();
        }

        private static void FormatItems(PagSeguroRequest _req, StringBuilder _builder)
        {
            if (_req.Itens == null || _req.Itens.Count == 0)
                throw new PagSeguroException("Itens is not found. Please info your Items for sale");

            _builder.Append("<items>");
            foreach (PagSeguroRequestItem item in _req.Itens)
            {
                _builder.Append("<item>");

                _builder.Append("<id>" + item.Id.ToString() + "</id>");

                _builder.Append("<description>" + item.Description + "</description>");

                _builder.Append("<amount>" + item.Amount.ToString().Replace(",", ".").Replace(".", "") + "</amount>");

                _builder.Append("<quantity>" + item.Quantity.ToString() + "</quantity>");

                _builder.Append("<weight>" + item.Weight.ToString() + "</weight>");

                _builder.Append("</item>");

            }
            _builder.Append("</items>");
        }

        private static void FormarSender(PagSeguroRequest _req, StringBuilder _builder)
        {
            if (_req.Sender == null)
                throw new PagSeguroException("Sender is not found");

            _builder.Append("<sender>");
            _builder.Append("<name>" + _req.Sender.Name + "</name>");

            _builder.Append("<email>" + _req.Sender.Email + "</email>");

            if (!string.IsNullOrEmpty(_req.Sender.Phone))
            {
                _builder.Append("<phone>");

                _builder.Append("<areaCode>" + _req.Sender.Phone.Substring(0, 2) + "</areaCode>");

                _builder.Append("<number>" + _req.Sender.Phone.Substring(2, _req.Sender.Phone.Length - 2) + "</number>");

                _builder.Append("</phone>");
            }
            _builder.Append("</sender>");
        }

        private static void FormatShipping(PagSeguroRequest _req, StringBuilder _builder)
        {
            _builder.Append("<shipping>");

            _builder.Append("<type>" + Convert.ToInt32(_req.Shipping.Type).ToString() + "</type>");
            _builder.Append("<address>");
            _builder.Append("<street>" + _req.Shipping.Address.Street + "</street>");
            _builder.Append("<number>" + _req.Shipping.Address.Number.ToString() + "</number>");
            _builder.Append("<complement>" + _req.Shipping.Address.Complement + "</complement>");
            _builder.Append("<district>" + _req.Shipping.Address.District + "</district>");
            _builder.Append("<postalCode>" + _req.Shipping.Address.PostalCode + "</postalCode>");
            _builder.Append("<city>" + _req.Shipping.Address.City + "</city>");
            _builder.Append("<state>" + _req.Shipping.Address.Stade + "</state>");
            _builder.Append("<country>" + _req.Shipping.Address.Country + "</country>");
            _builder.Append("</address>");

            _builder.Append("</shipping>");
        }

        private string ReturnDataCurl(PagSeguroRequest _req, string _email)
        {
            string _urlCurl = @"email=" + _email + @"\";
            
            _urlCurl += "&token=" + this.token + @"\";
            _urlCurl += "&currency=" + _req.Currency.ToString() + @"\";

             if (_req.Itens == null || _req.Itens.Count == 0)
                throw new PagSeguroException("Itens is not found. Please info your Items for sale");

            for (int i = 0; i < _req.Itens.Count; i++)
            {
                PagSeguroRequestItem item = _req.Itens[i];

                _urlCurl += "&itemId" + (i+1) + "=" + item.Id + @"\";
                _urlCurl += "&itemDescription" + (i+1) + "=" + item.Description + @"\";
                _urlCurl += "&itemAmount" + (i+1) + "=" + item.Amount.ToString() + @"\";
                _urlCurl += "&itemQuantity" + (i+1) + "=" + item.Quantity + @"\";
                _urlCurl += "&itemWeight" + (i+1) + "=" + item.Weight + @"\";
            }

            _urlCurl += "&reference=" + _req.Reference + @"\";
            
             if (_req.Sender == null)
                throw new PagSeguroException("Sender is not found");

            _urlCurl += "&senderName=" + _req.Sender.Name + @"\";

            _urlCurl += "&senderAreaCode=" + _req.Sender.Phone.Substring(0, 2) + @"\";
            _urlCurl += "&senderPhone=" + _req.Sender.Phone.Substring(2, _req.Sender.Phone.Length - 2) + @"\";
            _urlCurl += "&senderEmail=" + _req.Sender.Email + @"\";


            _urlCurl += "&shippingType=" + _req.Shipping.Type + @"\";
            _urlCurl += "&shippingAddressStreet=" + _req.Shipping.Address.Street + @"\";
            _urlCurl += "&shippingAddressNumber=" + _req.Shipping.Address.Number + @"\";
            _urlCurl += "&shippingAddressComplement=" + _req.Shipping.Address.Complement + @"\";
            _urlCurl += "&shippingAddressDistrict=" + _req.Shipping.Address.District + @"\";
            _urlCurl += "&shippingAddressPostalCode=" + _req.Shipping.Address.PostalCode + @"\";
            _urlCurl += "&shippingAddressCity=" + _req.Shipping.Address.City + @"\";
            _urlCurl += "&shippingAddressState=" + _req.Shipping.Address.Stade + @"\";
            _urlCurl += "&shippingAddressCountry=" + _req.Shipping.Address.Country + "";
            
            return _urlCurl;
        }

    }
}

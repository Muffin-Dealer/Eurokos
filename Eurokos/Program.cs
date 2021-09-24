using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Eurokos
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            using (XmlWriter writer = XmlWriter.Create("products.xml",settings))
            {
                writer.WriteStartElement("products");
                writer.WriteStartElement("product");
                writer.WriteAttributeString("id", "123548");
                writer.WriteElementString("name", "Kava");
                writer.WriteElementString("price", "1.25");
                writer.WriteElementString("vatRate", "25");
                writer.WriteElementString("type", "food");
                writer.WriteElementString("productionDate", "2019-05-08");
                writer.WriteElementString("expirationDate", "2021-05-08");
                writer.WriteElementString("manufacturer", "Kavos turgus");
                writer.WriteElementString("barcode", "5564846513");
                writer.WriteElementString("barcode2", "5564845135");
                writer.WriteElementString("alias", "skani kava");
                writer.WriteElementString("alias", "Gurmanu Kava");
                writer.WriteElementString("originCountry", "Mianmar");
                writer.WriteElementString("originTown", "Birma");
                writer.WriteElementString("productionCountry", "Lithuania");
                writer.WriteElementString("productionTown", "Kaunas");
                writer.WriteElementString("supplierName", "bigfood");
                writer.WriteElementString("supplierCode", "1236859");
                writer.WriteElementString("supplierAddress", "islandijos 88A, Kaunas");
                writer.WriteEndElement();

                writer.WriteStartElement("product");
                writer.WriteAttributeString("id", "S1284");
                writer.WriteElementString("name", "spausdinimas");
                writer.WriteElementString("price", "0.1");
                writer.WriteElementString("barcode2", "1356484");
                writer.WriteElementString("alias", "spalvotas spausdini");
                writer.WriteElementString("alias", "pigus spaudinimas");
        
                writer.WriteElementString("productionCountry", "Lithuania");
                writer.WriteElementString("productionTown", "Kaunas");
                writer.WriteElementString("options", "spalvotas");
                writer.WriteElementString("options", "nespalvotas");
                writer.WriteElementString("options", "kietu lapu");
                writer.WriteElementString("options", "kartonu");
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}

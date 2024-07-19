using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument
            (new XDeclaration("1.0","utf-8","yes"),
                new XElement("bookstore",
                    new XElement("book",
                        new XElement("title", "commerce"),
                            new XElement("author", "abc"),
                                new XElement("price", 399)),

                    new XElement("book",
                        new XElement("title", "science"),
                            new XElement("author", "xyz"),
                                new XElement("price", 349)),

                    new XElement("books",
                        new XElement("title", "psycologoy"),
                            new XElement("author", "pqr"),
                                new XElement("price", 299))
            ));

            xdoc.Save("C:\\Wipro_harsh\\LinqXML\\bin\\Debug\\bookstoreinfo.xml");
        }
    }
}

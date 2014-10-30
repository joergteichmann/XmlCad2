//#define debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;


namespace XmlCad2
{
    /// <summary>
    /// Hauptfenster
    /// </summary>
    public partial class XmlCad : Form
    {
        private XElement xmlRechteck(Rechteck r)
            {
                XElement xmlTree1 = new XElement("Rechteck",
                    xmlKante("Kante1", r.kante[1]),
                    xmlKante("Kante2", r.kante[2]),
                    xmlKante("Kante3", r.kante[3]),
                    xmlKante("Kante4", r.kante[4])
                );

                return xmlTree1;

                //XElement xmlTree2 = new XElement("Root",
                //    from el in xmlTree1.Elements()
                //    where((int)el >= 3 && (int)el <= 5)
                //    select el
                //);
                //Console.WriteLine(xmlTree2);                                  
            }

        private XElement xmlKante(string name, Linie l) {
            XElement kante = new XElement(name, xmlLinie(l));
            return kante;
        }   

        private XElement xmlLinie( Linie l ) {
            XElement linie = new XElement("Linie",
                xmlPunkt(l.pAnfang),
                xmlPunkt(l.pEnde),
                xmlFarbe(l.farbe.wert)
            );

            return linie;
        }

        private XElement xmlFarbe(Color f)
        {
            return new XElement("Farbe", f.ToString());
        }

        private XElement xmlPunkt(Punkt p)
        {
            return new XElement("Punkt",
                new XElement("X-Koordinate", p.X.ToString()),
                new XElement("Y-Koordinate", p.y.ToString()),
                new XElement("farbe", p.farbe.ToString())              
            );                
        }

        //private schreibeXmlPunkt(Point pEnde)
            //{
            //    new XElement("Punkt",
            //        new XElement("X-Koordinate", pEnde.X.ToString()),
            //        new XElement("Y-Koordinate", pEnde.Y.ToString()),
            //        new XElement("farbe", farbe.ToString())              
            //    );
            //}

        private void schreibeXmlDokument()
        {
            #if debug
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<Zeichnung> </Zeichnung>");
    
                //<book genre='novel' ISBN='1-861001-57-5'>" +
                            //"<title>Pride And Prejudice</title>" +
                            //"</book>");

                //Create a new node and add it to the document.
                //The text node is the content of the price element.
                XmlElement elem = doc.CreateElement("X-Koordinate");
                XmlText text = doc.CreateTextNode(pAnfang.X.ToString());
                doc.DocumentElement.AppendChild(elem);
                doc.DocumentElement.LastChild.AppendChild(text);

    
                elem = doc.CreateElement("Y-Koordinate");
                text = doc.CreateTextNode(pAnfang.Y.ToString());
                doc.DocumentElement.AppendChild(elem);
                doc.DocumentElement.LastChild.AppendChild(text);


                elem = doc.CreateElement("Farbe");
                text = doc.CreateTextNode(farbe.ToString());
                doc.DocumentElement.AppendChild(elem);
                doc.DocumentElement.LastChild.AppendChild(text);

                //Console.WriteLine("Display the modified XML...");
                //Stream s = new Stream;
                //doc.Save(s);
                //richTextBox1.Text = s.ToString();
            #endif
        }
    }
}

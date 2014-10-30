//#define debug

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Xml;

namespace XmlCad2
{
    /// <summary>
    /// Linie mit Anfangs- und Endpunkt
    /// </summary>
    public class Linie : Figur
    {
        public Punkt pAnfang;
        public Punkt pEnde;

        #region Konstruktoren
        
            public Linie( Point p1, Point p2, Color farbe){
                pAnfang = new Punkt(p1, farbe);
                pEnde = new Punkt(p2, farbe);
                this.farbe = farbe;
            }

            public Linie(Punkt start, Punkt stop, Color farbe)
            {
                pAnfang = start;
                pEnde = stop;
                this.farbe = farbe;
            }

            public Linie(XmlTextReader xtr)
            {

            }

        #endregion Konstruktoren


        public override void zeichne( Graphics grafik )
        {
            Point p1 = new Point( pAnfang.X, pAnfang.y );
            Point p2 = new Point( pEnde.X, pEnde.y);

            grafik.DrawLine(new Pen(farbe), p1, p2);
        }

        public override void schreibeXml(XmlTextWriter writer)
        {
            writer.WriteStartElement("Linie");
            pAnfang.schreibeXml(writer);
            pEnde.schreibeXml(writer);
            writer.WriteEndElement();
        }
    }
}

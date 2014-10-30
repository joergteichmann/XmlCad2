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
    ///// <summary>
    ///// abstrakte Klasse für die Klasse Zeichnung
    ///// </summary>
    //public abstract class Figur{
    //    public virtual Color farbe { get; set; }
    //    public virtual void zeichne(Graphics grafik) { }
    //    public abstract void schreibeXml(XmlTextWriter writer);
    //}; 

    ///// <summary>
    ///// 2-dimensionaler Punkt
    ///// </summary>
    //public class Punkt : Figur
    //{
    //    #region Zusatzproperties
    //        private int x;

    //        /// <summary>
    //        /// x-Property
    //        /// </summary>
    //        public int X {
    //            get{
    //                return x;
    //            }
    //            set{
    //                x = value;
    //            }
    //        }

    //        public int y { get; set; }

    //    #endregion

    //    #region Konstruktoren
    //        /// <summary>
    //        /// konstruiert einen Punkt aus einem System-"Point"
    //        /// </summary>
    //        /// <param name="p"></param>
    //        public Punkt(Point p, Color farbe){
    //            x = p.X;
    //            y = p.Y;
    //            this.farbe = farbe;
    //        }

    //        public Punkt(int x, int y, Color farbe)
    //        {
    //            this.x = x;
    //            this.y = y;
    //            this.farbe = farbe;
    //        }
    //    #endregion

    //    public override void zeichne(Graphics grafik)
    //    {
    //        PointF p1 = new PointF((float)x, (float)y); 
    //        PointF p2 = new PointF((float)x + 1, (float)y + 1);

    //        grafik.DrawLine( new Pen(farbe), p1, p2);
    //    }

    //    public PointF ToPointF()
    //    {
    //        return new PointF(this.x, this.y);
    //    }

    //    public Point FromPointF(PointF p)
    //    {
    //        return new Point((int)p.X, (int)p.Y);
    //    }

    //    public override void schreibeXml(XmlTextWriter writer)
    //    {
    //        writer.WriteStartElement("Punkt");

    //        writer.WriteStartElement("X-Koordinate");
    //        writer.WriteValue(X);
    //        writer.WriteEndElement();

    //        writer.WriteStartElement("Y-Koordinate");
    //        writer.WriteValue(y);
    //        writer.WriteEndElement();

    //        writer.WriteStartElement("Farbe");
    //        writer.WriteValue(farbe.ToArgb());
    //        writer.WriteEndElement();

    //        writer.WriteEndElement();
    //    }        
    //}

    ///// <summary>
    ///// Linie mit Anfangs- und Endpunkt
    ///// </summary>
    //public class Linie : Figur
    //{
    //    public Punkt pAnfang;
    //    public Punkt pEnde;

    //    public Linie( Point p1, Point p2, Color farbe){
    //        pAnfang = new Punkt(p1, farbe);
    //        pEnde = new Punkt(p2, farbe);
    //        this.farbe = farbe;
    //    }

    //    public Linie(Punkt start, Punkt stop, Color farbe)
    //    {
    //        pAnfang = start;
    //        pEnde = stop;
    //        this.farbe = farbe;
    //    }

    //    public override void zeichne( Graphics grafik )
    //    {
    //        Point p1 = new Point( pAnfang.X, pAnfang.y );
    //        Point p2 = new Point( pEnde.X, pEnde.y);

    //        grafik.DrawLine(new Pen(farbe), p1, p2);
    //    }

    //    public override void schreibeXml(XmlTextWriter writer)
    //    {
    //        writer.WriteStartElement("Linie");
    //        pAnfang.schreibeXml(writer);
    //        pEnde.schreibeXml(writer);
    //        writer.WriteEndElement();
    //    }
    //}

    #if !debug
        /// <summary>
        /// Rechteck mit vier Seiten
        /// </summary>
        public class Rechteck : Figur
        {
            private Punkt p1, p2;
            private Graphics grafik;
            public Linie[] kante = new Linie[4];

            public Rechteck( Point p1, Point p2, Color farbe ){
                kante[0] = new Linie(p1, new Point(p1.X, p2.Y), farbe);
                kante[1] = new Linie(p1, new Point(p2.X, p1.Y), farbe);
                kante[2] = new Linie(new Point(p1.X, p2.Y), p1, farbe);
                kante[3] = new Linie(new Point(p1.X, p2.Y), p2, farbe);
            }

            public Rechteck( Linie[] pKanten ) {
                for ( int i = 0; i < 4; i++ ) {
                    kante[i] = pKanten[i];
                }
            }

            public Rechteck(Point pAnfang, Point pEnde, Farbe farbe, Graphics grafik)
            {
                p1 = new Punkt(pAnfang);
                p2 = new Punkt(pEnde);
                this.farbe = farbe.wert;
                this.grafik = grafik;
            }

            public override Rechteck(XmlTextReader r)
            {

            }

            public override void zeichne( Graphics grafik )
            {
                for ( int i = 0; i < 4; i++ ) {

                    kante[i].zeichne( grafik );
                }
            }
            
            #if !debug
                public override void schreibeXml(XmlTextWriter writer)
                {
                    writer.WriteStartElement("Rechteck");

                    for (int i = 0; i < 4; i++)
                    {
                        writer.WriteStartElement("Seite" + (i + 1));
                        kante[i].schreibeXml(writer);
                        //writeLinie(writer, kante[i]);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }
            #endif
        }
    #endif
}

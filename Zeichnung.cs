//#define debug

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Xml;
using System.Diagnostics;

namespace XmlCad2
{
    public class XmlLeser
    {
        public static void ueberspringeLeerzeichen(XmlTextReader reader)
        {
            while (reader.Value == "" || string.IsNullOrWhiteSpace(reader.Value))
            {
                reader.Read();
            }
        }
    }

    public class Farbe
    {
        public Color wert { get; set; }

        public Farbe(Color c)
        {
            wert = c;
        }

        public Farbe (XmlTextReader reader)
        {
            //wert = new Color();

            //leser = new XmlLeser();
            XmlLeser.ueberspringeLeerzeichen(reader);

            reader.ReadStartElement("Farbe32bitArgb");

            wert = Color.FromArgb(reader.ReadContentAsInt());

            // funzt nicht, weil ARGB schreibgeschützt! :-(

            //reader.ReadStartElement("A");
            //wert.A = reader.ReadContentAsInt();
            //reader.ReadEndElement();

            //reader.ReadStartElement("R");
            //wert.R = reader.ReadContentAsInt();
            //reader.ReadEndElement();

            //reader.ReadStartElement("G");
            //wert.G = reader.ReadContentAsInt();
            //reader.ReadEndElement();

            //reader.ReadStartElement("B");
            //wert.B = reader.ReadContentAsInt();
            //reader.ReadEndElement();

            //ColorConverter c = new ColorConverter();
            //ColorTranslator t = new ColorTranslator();
            
            reader.ReadEndElement(); // "Farbe"

            //return farbe;
        }

        public void schreibeXml ( XmlTextWriter w ) {
            w.WriteStartElement("Farbe32bitArgb");

            //w.WriteStartElement("A");
            //w.WriteValue(wert.A);
            //w.WriteEndElement();

            //w.WriteStartElement("R");
            //w.WriteValue(wert.R);
            //w.WriteEndElement();

            //w.WriteStartElement("G");
            //w.WriteValue(wert.G);
            //w.WriteEndElement();

            //w.WriteStartElement("B");
            //w.WriteValue(wert.B);
            //w.WriteEndElement();

            w.WriteValue(wert.ToArgb());

            w.WriteEndElement();
        }
    }

    /// <summary>
    /// abstrakte Klasse für die Klasse Zeichnung
    /// </summary>
    //public abstract class Figur
    //{

    //    ///// <summary>
    //    ///// konstruiert die Figur
    //    ///// </summary>
    //    ///// <param name="grafik"></param>
    //    //public abstract Figur();

    //    ///// <summary>
    //    ///// konstruiert und zeichnet die Figur
    //    ///// </summary>
    //    ///// <param name="grafik"></param>
    //    //public abstract Figur(Graphics grafik);

    //    /// <summary>
    //    /// Farbe der Figur
    //    /// </summary>
    //    public virtual Farbe farbe { get; set; }

    //    /// <summary>
    //    /// als XML schreiben
    //    /// </summary>
    //    /// <param name="writer"></param>
    //    public abstract void schreibeXml(XmlTextWriter writer);

    //    /// <summary>
    //    /// zeichnen
    //    /// </summary>
    //    /// <param name="grafik"></param>
    //    public abstract void zeichne(Graphics grafik);
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
    //        public int X
    //        {
    //            get
    //            {
    //                return x;
    //            }
    //            set
    //            {
    //                x = value;
    //            }
    //        }

    //        public int y { get; set; }

    //    #endregion

    //    #region Konstruktoren
    //        /// <summary>
    //        /// konstruiert einen Punkt aus einem System-"Point" und Color
    //        /// </summary>
    //        /// <param name="p"></param>
    //        /// <param name="c"></param>
    //        public Punkt(Point p, Color c)
    //        {
    //            x = p.X;
    //            y = p.Y;
    //            farbe = new Farbe(c);
    //            //this.farbe.wert = c;
    //        }

    //        /// <summary>
    //        /// konstruiert einen Punkt aus einem System-"Point" und Farbe
    //        /// </summary>
    //        /// <param name="p"></param>
    //        /// <param name="farbe"></param>
    //        public Punkt(Point p, Farbe f)
    //        {
    //            x = p.X;
    //            y = p.Y;
    //            farbe = f;
    //        }

    //        /// <summary>
    //        /// konstruiert einen Punkt aus x-, y-Koordinate und Farbe
    //        /// </summary>
    //        /// <param name="x"></param>
    //        /// <param name="y"></param>
    //        /// <param name="farbe"></param>      
    //        public Punkt(int pX, int pY, Farbe pFarbe)
    //        {
    //            x = pX;
    //            y = pY;
    //            farbe = pFarbe;
    //        }

    //        /// <summary>
    //        /// lädt einen Punkt aus einer XML-Datei
    //        /// </summary>
    //        /// <param name="reader"></param>
    //        public Punkt (XmlTextReader reader)
    //        {
    //            XmlLeser.ueberspringeLeerzeichen(reader);

    //            reader.ReadStartElement("Punkt");

    //            reader.ReadStartElement("xKoordinate");
    //            x = reader.ReadContentAsInt();
    //            reader.ReadEndElement();

    //            XmlLeser.ueberspringeLeerzeichen(reader);

    //            reader.ReadStartElement("yKoordinate");
    //            y = reader.ReadContentAsInt();
    //            reader.ReadEndElement();

    //            Farbe farbe = new Farbe(reader);

    //            reader.ReadEndElement(); // "Punkt"

    //            //return new Punkt( x, y , farbe);
    //        }

    //    #endregion

    //    #region Konvertierungen

    //        public PointF ToPointF()
    //        {
    //            return new PointF(x, y);
    //        }

    //        public Point FromPointF(PointF p)
    //        {
    //            return new Point((int)p.X, (int)p.Y);
    //        }

    //    #endregion Konvertierungen

    //    public override void zeichne(Graphics grafik)
    //    {
    //        PointF p1 = new PointF((float)x, (float)y);
    //        PointF p2 = new PointF((float)x + 1, (float)y + 1);

    //        grafik.DrawLine(new Pen(this.farbe.wert), p1, p2);
    //    }

    //    public override void schreibeXml(XmlTextWriter writer)
    //    {
    //        writer.WriteStartElement("Punkt");

    //        writer.WriteStartElement("xKoordinate");
    //        writer.WriteValue(X);
    //        writer.WriteEndElement();

    //        writer.WriteStartElement("yKoordinate");
    //        writer.WriteValue(y);
    //        writer.WriteEndElement();

    //        try { farbe.schreibeXml(writer); }
    //        catch (NullReferenceException ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }

    //        writer.WriteEndElement();
    //    }
    //}

    /// <summary>
    /// Linie mit Anfangs- und Endpunkt
    /// </summary>
    //public class Linie : Figur
    //{
    //    public Punkt pAnfang;
    //    public Punkt pEnde;

    //    public Linie(Point p1, Point p2, Color f)
    //    {
    //        pAnfang = new Punkt(p1, farbe);
    //        pEnde = new Punkt(p2, farbe);
    //        farbe = new Farbe(f);
    //    }

    //    public Linie(Punkt start, Punkt stop, Color f)
    //    {
    //        pAnfang = start;
    //        pEnde = stop;
    //        farbe = new Farbe(f);
    //    }

    //    public Linie(XmlTextReader r)
    //    {
    //        r.ReadStartElement("Linie");

    //        r.ReadStartElement("Anfangspunkt");
    //        pAnfang = new Punkt(r);
    //        r.ReadEndElement(); //Anfangspunkt

    //        r.ReadStartElement("Endpunkt");
    //        pEnde = new Punkt(r);
    //        r.ReadEndElement(); // Endpunkt

    //        r.ReadStartElement("Linienfarbe32bitARGB");
    //        farbe = new Farbe(r);
    //        r.ReadEndElement(); //Linienfarbe32bitARGB

    //        r.ReadEndElement(); // Linie
    //    }

    //    public override void zeichne(Graphics grafik)
    //    {
    //        Point p1 = new Point(pAnfang.X, pAnfang.y);
    //        Point p2 = new Point(pEnde.X, pEnde.y);

    //        grafik.DrawLine(new Pen(farbe.wert), p1, p2);
    //    }

    //    public override void schreibeXml(XmlTextWriter writer)
    //    {
    //        writer.WriteStartElement("Linie");

    //        writer.WriteStartElement("Anfangspunkt");
    //        pAnfang.schreibeXml(writer);
    //        writer.WriteEndElement(); // Anfangspunkt

    //        writer.WriteStartElement("Endpunkt");
    //        pEnde.schreibeXml(writer);
    //        writer.WriteEndElement(); // Endpunkt

    //        writer.WriteStartElement("Linienfarbe32bitARGB");
    //        farbe.schreibeXml(writer);
    //        writer.WriteEndElement(); // Linienfarbe32bitARGB

    //        writer.WriteEndElement(); // Linie
    //    }
    //}

    //#if !debug
    //    /// <summary>
    //    /// Rechteck mit vier Seiten
    //    /// </summary>
    //    public class Rechteck : Figur
    //    {
    //        public Linie[] kante = new Linie[4];

    //        public Rechteck(Point p1, Point p2, Color c, Graphics g)
    //        {

    //            kante[0] = new Linie(p1, new Point(p1.X, p2.Y), c);
    //            kante[1] = new Linie(p1, new Point(p2.X, p1.Y), c);
    //            kante[2] = new Linie(new Point(p2.X, p1.Y), p2, c); // !!!
    //            kante[3] = new Linie(new Point(p1.X, p2.Y), p2, c);

    //            farbe = new Farbe(c);

    //            zeichne(g);
    //        }

    //        public Rechteck(Linie[] pKanten, Graphics g)
    //        {
    //            for (int i = 0; i < 4; i++)
    //            {
    //                kante[i] = pKanten[i];
    //            }

    //            zeichne(g);
    //        }

    //        public Rechteck(XmlTextReader r)
    //        {
    //            //#if debug
    //                #region XML reader
    //                    //#if !debug
    //                        //public Rechteck readRechteck(XmlTextReader reader)
    //                        //{
    //                            //Linie[] kanten = new Linie[4];

    //                            for (int i = 0; i < 4; i++)
    //                            {
    //                                //reader.ReadStartElement("Linie");
    //                                r.ReadStartElement("Seite" + (i + 1));

    //                                //kanten[i] = readLinie(reader);
    //                                kante[i] = new Linie(r);

    //                                r.ReadEndElement();
    //                            }
    //                            //return new Rechteck( kanten );
    //                        //}
    //                    //#endif
    //                #endregion
    //            //#endif
    //        }

    //        //#if !debug
    //            public override void schreibeXml(XmlTextWriter writer)
    //            {
    //                writer.WriteStartElement("Rechteck");

    //                for (int i = 0; i < 4; i++)
    //                {
    //                    writer.WriteStartElement("Seite" + (i + 1));

    //                    try { kante[i].schreibeXml(writer); }
    //                    catch (NullReferenceException nre) { System.Diagnostics.Debug.WriteLine(nre.ToString()); }
                
    //                    //writeLinie(writer, kante[i]);
    //                    writer.WriteEndElement();
    //                }

    //                writer.WriteEndElement();
    //            }
    //        //#endif

    //    public override void zeichne(Graphics grafik)
    //        {
    //            for (int i = 0; i < 4; i++)
    //            {
    //                try
    //                {
    //                    kante[i].zeichne(grafik);
    //                } catch (NullReferenceException nre){
    //                    System.Diagnostics.Debug.WriteLine(nre.ToString());
    //                }
    //            }
    //        }
    //    }
    //#endif

    //public class Ellipse : Figur
    //{
    //    Punkt p1, p2;

    //    public Ellipse(Point p1, Point p2, Graphics grafik, Zeichnung zeichnung)
    //    {
    //        farbe = new Farbe(zeichnung.AktuelleFarbe);
    //        this.p1 = new Punkt(p1, farbe);
    //        this.p2 = new Punkt(p2, farbe);

    //        this.zeichne( grafik );
    //        zeichnung.Add(this);
    //        zeichnung.Zeichne( grafik );
    //    }

    //    public Ellipse(XmlTextReader r)
    //    {
    //        XmlLeser.ueberspringeLeerzeichen(r);

    //        r.ReadStartElement("Ellipse");
            
    //        p1 = new Punkt(r);
    //        p2 = new Punkt(r);
    //        farbe = new Farbe(r);
            
    //        r.ReadEndElement();
    //    }

    //    public override void schreibeXml(XmlTextWriter writer)
    //    {
    //        writer.WriteStartElement("Ellipse");

    //        writer.WriteStartElement("Punkt1");
    //        p1.schreibeXml(writer);
    //        writer.WriteEndElement();

    //        writer.WriteStartElement("Punkt2");
    //        p2.schreibeXml(writer);
    //        writer.WriteEndElement();

    //        writer.WriteEndElement(); // Ellipse
    //    }

    //    public override void zeichne(Graphics grafik)
    //    {
    //        Pen p = new Pen(farbe.wert);
    //        int x = Math.Min(p1.X, p2.X);
    //        int y = Math.Min(p1.y, p2.y);
    //        int breite = Math.Abs(p1.X - p2.X);
    //        int hoehe = Math.Abs(p1.y - p2.y);
    //        Rectangle Huelle = new Rectangle(x, y, breite, hoehe);

    //        grafik.DrawEllipse(p, Huelle);
    //    }
    //}

    //public class Bezier : Figur
    //{
    //    Point[] p { get; set; } // stuetzpunkte 

    //    public Bezier( Point[] p, Graphics g, Zeichnung z ) {
    //        g.DrawBezier( z.AktuellerStift, p[0], p[1], p[2], p[3] );
    //    }

    //    public override void schreibeXml( XmlTextWriter w )
    //    {
    //        w.WriteStartElement("Bezierkurve");

    //        this.farbe.schreibeXml( w );
    //        for (int i = 0; i < 4; i++)
    //        {
    //            Punkt stuetzPunkt = new Punkt( p[i], farbe.wert );
    //            stuetzPunkt.schreibeXml( w );
    //        }
    //    }

    //    public override void zeichne(Graphics g)
    //    {
    //        g.DrawBezier(new Pen(farbe.wert), p[0], p[1], p[2], p[3]);
    //    }
    //}

    //public class Text : Figur
    //{
    //    string str;
    //    Font font;
    //    Brush brush;
    //    PointF pointf;

    //    public Text(string str, Font font, Brush brush, PointF pointf)
    //    {
    //        this.str = str;
    //        this.font = font;
    //        this.brush = brush;
    //        this.pointf = pointf;
    //    }

    //    public Text(XmlTextReader reader)
    //    {
    //        XmlLeser.ueberspringeLeerzeichen(reader);

    //        str = reader.ReadContentAsString();

    //        //FontStyle fontstyle = fon
    //        //font = new Font(reader.ReadContentAsString(), reader.ReadContentAsInt, new FontStyle( reader.ReadContentAsString() ) );
    //        //brush = new Brush(();

    //    }

    //    public override void schreibeXml(XmlTextWriter w)
    //    {
    //        w.WriteStartElement("Text");

    //        w.WriteStartElement("String");
    //        w.WriteString(str);
    //        w.WriteEndElement();


    //        w.WriteStartElement("Font");
    //        w.WriteStartElement("FontFamilie");
    //        w.WriteString(font.FontFamily.ToString());
    //        w.WriteEndElement();

    //        w.WriteStartElement("Größe");
    //        w.WriteValue(font.Size);
    //        w.WriteEndElement();

    //        w.WriteStartElement("Stil");
    //        w.WriteValue(font.Style);
    //        w.WriteEndElement();

            
    //        w.WriteStartElement("Pinsel");
    //        w.WriteValue(brush);
    //        w.WriteEndElement();

    //        w.WriteStartElement("Position");
    //        w.WriteValue(pointf);
    //        w.WriteEndElement();


    //        w.WriteStartElement("Farbe");
    //        w.WriteValue(farbe);
    //        w.WriteEndElement();

    //        w.WriteEndElement(); // Text
    //    }

    //    public override void zeichne(Graphics grafik)
    //    {
    //        grafik.DrawString(str, font, brush, pointf);
    //    }
    //}

    /// <summary>
    /// Figurensammlung
    /// </summary>
    public class Zeichnung
    {
        #region Variablen und Properties

            /// <summary>
            /// Figurenliste
            /// </summary>
            private List<Figur> Figuren = new List<Figur>();


            private Pen aktuellerStift = new Pen(Color.Blue);

            public Pen AktuellerStift
            {
                get { return aktuellerStift; }
                set { aktuellerStift = value; }
            }


            private Color aktuelleFarbe = Color.Blue;

            public Color AktuelleFarbe
            {
                get { return aktuelleFarbe; }
                set
                {
                    this.aktuellerStift = new Pen(value);
                }
            }
        

            public Font aktuellerFont { get; set; }

        #endregion Variablen und Properties


        #region Konstruktor
            public Zeichnung()
            {
                aktuellerStift = new Pen(aktuelleFarbe);
            }
        #endregion Konstruktor


        #region Methoden

            public void Add(Figur figur)
            {
                Figuren.Add(figur);
            }

            public void Zeichne( Graphics g )
            {
                foreach (Figur f in Figuren)
                {
                    f.zeichne(g);
                }
            }

            public void schreibeXml(XmlTextWriter writer)
            {
                #region XmlTextWriter
                   writer.WriteStartDocument();

                    // einrücken
                    //
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartElement("Zeichnung");

                    foreach (Figur f in Figuren)
                    {
                        f.schreibeXml(writer);
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                #endregion
            }
        #endregion Methoden
    }
}

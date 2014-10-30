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
    /// 2-dimensionaler Punkt
    /// </summary>
    public class Punkt : Figur
    {
        #region Zusatzproperties
        private int x;

        /// <summary>
        /// x-Property
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int y { get; set; }

        #endregion

        #region Konstruktoren
        /// <summary>
        /// konstruiert einen Punkt aus einem System-"Point"
        /// </summary>
        /// <param name="p">Point</param>
        public Punkt(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }

        /// <summary>
        /// konstruiert einen Punkt aus einem System-"Point" und einer Farbe
        /// </summary>
        /// <param name="p"></param>
        public Punkt(Point p, Color farbe)
        {
            x = p.X;
            y = p.Y;
            this.farbe = farbe;
        }

        /// <summary>
        /// konstruiert einen Punkt aus x-, y-Koordinate und Farbe
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="farbe"></param>
        public Punkt(int x, int y, Color farbe)
        {
            this.x = x;
            this.y = y;
            this.farbe = farbe;
        }

#if !debug
        /// <summary>
        /// liest einen Punkt aus einer XML-Datei
        /// </summary>
        /// <param name="reader"></param>
        public override Punkt(XmlTextReader reader)
        {
            #region x

            // Leerzeichen überspringen
            while (reader.Value == "" || string.IsNullOrWhiteSpace(reader.Value))
            {
                reader.Read();
            }

            x = reader.ReadContentAsInt();
            reader.ReadEndElement();

            #endregion x
            #region y

            // Leerzeichen überspringen
            while (reader.Value == "" || string.IsNullOrWhiteSpace(reader.Value))
            {
                reader.Read();
            }

            y = reader.ReadContentAsInt();
            reader.ReadEndElement();

            #endregion y
            farbe = (new Farbe(reader)).wert;
        }
#endif
        #endregion

        #region Konvertierungen

        public PointF ToPointF()
        {
            return new PointF(this.x, this.y);
        }

        public Point FromPointF(PointF p)
        {
            return new Point((int)p.X, (int)p.Y);
        }

        #endregion Konvertierungen

        public override void zeichne(Graphics grafik)
        {
            PointF p1 = new PointF((float)x, (float)y);
            PointF p2 = new PointF((float)x + 1, (float)y + 1);

            grafik.DrawLine(new Pen(farbe), p1, p2);
        }

        public override void schreibeXml(XmlTextWriter writer)
        {
            writer.WriteStartElement("Punkt");

            writer.WriteStartElement("X-Koordinate");
            writer.WriteValue(X);
            writer.WriteEndElement();

            writer.WriteStartElement("Y-Koordinate");
            writer.WriteValue(y);
            writer.WriteEndElement();

            writer.WriteStartElement("Farbe");
            writer.WriteValue(farbe.ToArgb());
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}

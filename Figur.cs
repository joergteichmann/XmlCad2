//#define debug
#undef debug

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
    /// abstrakte Klasse für die Klasse Zeichnung
    /// </summary>
    public abstract class Figur{

        /// <summary>
        /// Farbe der Figur
        /// </summary>
        public virtual Color farbe { get; set; }

        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public abstract Figur();

        /// <summary>
        /// aus XML einlesen
        /// </summary>
        /// <param name="r"></param>
        public abstract Figur(XmlTextReader r);

        /// <summary>
        /// als XML schreiben
        /// </summary>
        /// <param name="writer"></param>
        public abstract void schreibeXml(XmlTextWriter writer);

        /// <summary>
        /// zeichnen
        /// </summary>
        /// <param name="grafik"></param>
        public abstract void zeichne(Graphics grafik);
    }; 
}

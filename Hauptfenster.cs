#define debug

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
        #region Variablen (Felder)
            //enum ZeichenModus {Punkt, Linie, Rechteck};
            private int modus;
            private Point pAnfang;
            private Zeichnung zeichnung = new Zeichnung();
            private Graphics grafik;

            #if !debug
                private Color farbe = Color.Green;
            #else
                private Color farbe = Color.Blue;
            #endif

            // LINQ to XML
            private XDocument srcTree = new XDocument(
                new XComment("This is a comment"),
                new XElement("Zeichnung")
            );
        #endregion

        public XmlCad()
        {
            InitializeComponent();
            grafik = pictureBox1.CreateGraphics();
        }

        //#if debug
            //#region XML reader
                //#if !debug
                //    private Rechteck readRechteck(XmlTextReader reader)
                //{
                //    //Linie[] kanten = new Linie[4];

                //    for (int i = 0; i < 4; i++)
                //    {
                //        reader.ReadStartElement("Linie");

                //        //kanten[i] = readLinie(reader);
                //        kante[i] = new Linie(reader);

                //        reader.ReadEndElement();
                //    }
                //    //return new Rechteck( kanten );
                //}
                //          #endif
            //#endregion
        //#endif

        #region XmlTextReader
            //#if debug
            //    private Linie readLinie(XmlTextReader reader)
            //    {
            //        Punkt start, stop;

            //        reader.ReadStartElement("AnfangsPunkt");
            //        start = readPunkt(reader);
            //        reader.ReadEndElement();

            //        reader.ReadStartElement("EndPunkt");
            //        stop = readPunkt(reader);
            //        reader.ReadEndElement();

            //        reader.ReadStartElement("Farbe");
            //        farbe = readFarbe(reader);
            //        reader.ReadEndElement();

            //        return new Linie(start, stop, farbe);
            //    }
            //#endif
        #endregion XmlTextReader

        private void zeichneZeichnung(Graphics g)
        {
            // Zeichenfläche aufräumen
            //
            Rectangle fullArea = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillRectangle(Brushes.White, fullArea);

            // vorher aufgebaute Zeichnung zeichnen
            //
            zeichnung.Zeichne(g);
        }

        private void transformierenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            zeichnung.aktuellerFont = fontDialog1.Font;
        }
    }
}
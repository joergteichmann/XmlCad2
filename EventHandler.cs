//#define debug
#undef debug


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
        #region Eventhandler

            #region Buttonevents
                private void buttonPunkt_Click(object sender, EventArgs e)
                {
                    modus = 0;
                }

                private void buttonLinie_Click(object sender, EventArgs e)
                {
                    modus = 1;
                }

                private void buttonRechteck_Click(object sender, EventArgs e)
                {
                    modus = 2;
                }

                private void buttonEllipse_Click(object sender, EventArgs e)
                {
                    modus = 3;
                }

                private void buttonBezier_Click(object sender, EventArgs e)
                {
                    modus = 4;
                }

                private void buttonText_Click(object sender, EventArgs e)
                {
                    modus = 5;
                }

                
            #endregion


            #region Mausevents

                int zaehler = 0;
                Point[] stuetzPunkte = new Point[4];

                private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
                {
                    if (modus == 4) { // Bezier

                        if(zaehler < 4) 
                        {
                            stuetzPunkte[zaehler++] = e.Location;
                        } 
                        else 
                        {
                            Bezier b = new Bezier(stuetzPunkte, grafik, zeichnung);
                            zaehler = 0;
                        }
                    } 
                    else
                    {
                        pAnfang = e.Location;
                    }
                }

                private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
                {
                    if (modus == 0 && e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        Point pEnde = e.Location;
                        
                        //grafik.DrawLine(new Pen(farbe), pEnde, pEnde.Offset(new Point(1, 1)));
                        //grafik.DrawLine(new Pen(farbe), pEnde, pEnde.Offset(1, 1));

                        Punkt punkt = new Punkt(pEnde, farbe);
                        punkt.zeichne(grafik);

                        zeichnung.Add(punkt);

                        XElement meinXmlPunkt = xmlPunkt(punkt);
                        try { srcTree.Add(meinXmlPunkt); }
                        catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
                    }
                }

                private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
                {
                    zeichne(e);

                    //StringBuilder sb = new StringBuilder();
                    //StringWriter textWriter = new StringWriter(sb);
                    //srcTree.Save(textWriter); //.ToString();
                    //richTextBox1.Text = textWriter.ToString();
                }

            #endregion


            #region Menüevents

                private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    richTextBox1.Text = srcTree.ToString();
                }

                #if !debug

                    private void farbeToolStripMenuItem_Click(object sender, EventArgs e)
                    {
                        if (colorDialog1.ShowDialog() == DialogResult.OK)
                        {
                            zeichnung.AktuelleFarbe = colorDialog1.Color;
                            //zeichnung.aktuellerStift = new Pen(zeichnung.aktuelleFarbe);
                            //farbe = colorDialog1.Color;
                        }
                    }

                #endif

            #endregion Menüevents

        #endregion
    }
}

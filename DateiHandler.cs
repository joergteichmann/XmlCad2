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

            #region Dateihandler

                private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    #if !debug
                        openFileDialog1.DefaultExt = "xml";
                        openFileDialog1.Filter = "XML-Dateien|*.xml|Alle Dateien|*.*";
                        openFileDialog1.InitialDirectory = ".";                
                        openFileDialog1.ShowDialog();
                        string datei = openFileDialog1.FileName;
                    #else
                        string datei = "debug.xml";
                    #endif

                    #region Dateizugriff
                        #if !debug
                            if (!File.Exists( datei ) || zeichnung == null)
                            {
                                if (zeichnung == null)
                                {
                                    System.Diagnostics.Debug.WriteLine("zeichnung == null!");
                                }
                                else
                                {
                                    // Initializes the variables to pass to the MessageBox.Show method.
                                    string message = "Datei nicht vorhanden!";
                                    string caption = "Dateifehler";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                                    // Displays the MessageBox.
                                    MessageBox.Show(message, caption, buttons);
                                }
                                return;
                            }
                        #endif
                    #endregion

                    #region XmlTextReader
                    try
                        {
                            using (XmlTextReader xmlReader = new XmlTextReader(datei))
                            {
                                while (xmlReader.Read())
                                {
                                    xmlReader.MoveToContent();

                                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Zeichnung")
                                    {
                                        continue;
                                    }

                                    #if debug
                                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Punkt")
                                        {
                                            Debug.WriteLine("Zeichne Punkt");
                                            
                                            //Punkt p = readPunkt(xmlReader);
                                            Punkt p = new Punkt(xmlReader);

                                            //zeichnung.Punkte.Add(p);
                                            zeichnung.Add(p);
                                            p.zeichne(grafik);
                                        }
                                    #endif
                                
                                    #if debug
                                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Linie")
                                        {
                                            Debug.WriteLine("Zeichne Linie");
                                            
                                            //Linie l = readLinie(xmlReader);
                                            Linie l = new Linie(xmlReader);

                                            //zeichnung.Linien.Add(l);
                                            zeichnung.Add(l);
                                            l.zeichne(grafik);
                                        }
                                    #endif

                                    #if debug
                                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Rechteck")
                                        {
                                            Debug.WriteLine("Zeichne Rechteck");
                                            
                                            //Rechteck r = readRechteck(xmlReader);
                                            Rechteck r = new Rechteck(xmlReader);
                                            
                                            //zeichnung.Rechtecke.Add(r);
                                            zeichnung.Add(r);
                                            
                                            r.zeichne(grafik);
                                        }
                                    #endif

                                    xmlReader.Close();
                                    xmlReader.Dispose();
                                }
                            }
                        }
                    #endregion

                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine("Fehler: {0} Grund: {1}", ex.GetType(), ex.Message);
                    }

                    zeichneZeichnung(grafik);
                    //pictureBox1.Refresh();
                }

                private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    #if !debug
                        #region saveFileDialog
                            saveFileDialog1.FileName = "Zeichnung.xml";

                            try
                            {
                                saveFileDialog1.Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                            }

                            saveFileDialog1.DefaultExt = "xml";
                            saveFileDialog1.OverwritePrompt = false;
                            saveFileDialog1.InitialDirectory = ".";
                            saveFileDialog1.ShowDialog();
                            string datei = saveFileDialog1.FileName;
                        #endregion
                    #else
                        string datei = "debug.xml";
                    #endif

                    XmlTextWriter writer = new XmlTextWriter(datei, Encoding.Default);
                    zeichnung.schreibeXml(writer);
                }

            #endregion // Dateihandler

        #endregion // Eventhandler
    }
}

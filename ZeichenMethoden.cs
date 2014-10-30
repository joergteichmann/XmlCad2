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

using System.Windows;


namespace XmlCad2
{
    /// <summary>
    /// Hauptfenster
    /// </summary>
    public partial class XmlCad : Form
    {
        private async void zeichne(MouseEventArgs e)
        {
            Point pEnde = e.Location;

            #region switch
                switch (modus)
                {
                    case 0: // Punkte
                        grafik.DrawLine(new Pen(farbe), pAnfang, pAnfang);
                        Punkt punkt = new Punkt(pAnfang, farbe);
                        zeichnung.Add(punkt);

                        try { srcTree.Add( xmlPunkt( punkt ) ); }
                        catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }

                        richTextBox1.AppendText(punkt.ToString());

                        break;
                    case 1: // Linie
                        grafik.DrawLine(new Pen(farbe), pAnfang, pEnde);
                        Linie linie = new Linie(pAnfang, pEnde, farbe);
                        zeichnung.Add(linie);

                        try { srcTree.Add( xmlLinie( linie ) ); }
                        catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }

                        break;

                    #if !debug
                        #region case2
                            case 2:
                                grafik.DrawRectangle(
                                    new Pen(farbe),
                                    Math.Min(pAnfang.X, pEnde.X),
                                    Math.Min(pAnfang.Y, pEnde.Y),
                                    Math.Abs(pEnde.X - pAnfang.X),
                                    Math.Abs(pEnde.Y - pAnfang.Y)
                                );

                                Rechteck rechteck = new Rechteck(pAnfang, pEnde, new Farbe(farbe), grafik);
                                zeichnung.Add(rechteck);

                                try { srcTree.Add( xmlRechteck( rechteck ) ); }
                                catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.ToString()); }


                                break;
                        #endregion // Rechteck
                    #endif

                    case 3:
                        Ellipse el = new Ellipse(pAnfang, pEnde, grafik, zeichnung);
                        break;
                }
            #endregion

            #region Dateizugriff
                //  FileStream fs = new FileStream("Zeichnung.xml", FileMode.Open);
                //fs.Read

                #region StreamReader

                    //string filename = @"Zeichnung.xml";
                    //char[] result;
                    //StringBuilder builder = new StringBuilder();

                    //using (StreamReader reader = File.OpenText(filename))
                    //{
                    //    result = new char[reader.BaseStream.Length];
                    //    await reader.ReadAsync(result, 0, (int)reader.BaseStream.Length);
                    //}

                    //foreach (char c in result)
                    //{
                    //    if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                    //    {
                    //        builder.Append(c);
                    //    }
                    //}
                    ////FileOutput.Text = builder.ToString();

                    ////richTextBox1.t

                #endregion StreamReader

                // Specify a file to read from and to create.
                string pathSource = @"Zeichnung.xml";
                string pathNew = @"NeueZeichnung.xml";

                try
                {
                    #region FileStream
                        using (FileStream fsSource = new FileStream(pathSource,
                            FileMode.Open, FileAccess.Read))
                        {

                            // Read the source file into a byte array.
                            byte[] bytes = new byte[fsSource.Length];
                            int numBytesToRead = (int)fsSource.Length;
                            int numBytesRead = 0;
                            while (numBytesToRead > 0)
                            {
                                // Read may return anything from 0 to numBytesToRead.
                                int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                                // Break when the end of the file is reached.
                                if (n == 0)
                                    break;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                             numBytesToRead = bytes.Length;

                            // Write the byte array to the other FileStream.
                            using (FileStream fsNew = new FileStream(pathNew,
                                FileMode.Create, FileAccess.Write))
                            {
                                fsNew.Write(bytes, 0, numBytesToRead);
                            }

                            StringConverter sc = new StringConverter();
                            richTextBox1.Text = sc.ConvertToString(bytes);
                        }
                    #endregion
                }
                catch (FileNotFoundException ioEx)
                {
                    Console.WriteLine(ioEx.Message);
                }

            #endregion

            richTextBox1.Text = zeichnung.ToString();
        }
    }
}

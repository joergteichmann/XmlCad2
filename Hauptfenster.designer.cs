#define debug

namespace XmlCad2
{
    partial class XmlCad
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xSLTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transformierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ergebnisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonPunkt = new System.Windows.Forms.Button();
            this.buttonLinie = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRechteck = new System.Windows.Forms.Button();
            this.buttonKreis = new System.Windows.Forms.Button();
            this.buttonPolygon = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buttonBezier = new System.Windows.Forms.Button();
            this.buttonSpline = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonAuswahl = new System.Windows.Forms.Button();
            this.buttonFüllung = new System.Windows.Forms.Button();
            this.buttonStift = new System.Windows.Forms.Button();
            this.buttonPinsel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.farbeToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.formatierungToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.öffnenToolStripMenuItem.Text = "&Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auswählenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.ausschneidenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // auswählenToolStripMenuItem
            // 
            this.auswählenToolStripMenuItem.Name = "auswählenToolStripMenuItem";
            this.auswählenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.auswählenToolStripMenuItem.Text = "&Auswählen";
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kopierenToolStripMenuItem.Text = "&Kopieren";
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ausschneidenToolStripMenuItem.Text = "&Ausschneiden";
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.einfügenToolStripMenuItem.Text = "&Einfügen";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.löschenToolStripMenuItem.Text = "&Löschen";
            // 
            // farbeToolStripMenuItem
            // 
            this.farbeToolStripMenuItem.Name = "farbeToolStripMenuItem";
            this.farbeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.farbeToolStripMenuItem.Text = "&Farbe";
            this.farbeToolStripMenuItem.Click += new System.EventHandler(this.farbeToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // formatierungToolStripMenuItem
            // 
            this.formatierungToolStripMenuItem.Name = "formatierungToolStripMenuItem";
            this.formatierungToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.formatierungToolStripMenuItem.Text = "Formatierung";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anzeigenToolStripMenuItem,
            this.xSLTToolStripMenuItem,
            this.xPathToolStripMenuItem,
            this.lINQToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "&XML";
            // 
            // anzeigenToolStripMenuItem
            // 
            this.anzeigenToolStripMenuItem.Name = "anzeigenToolStripMenuItem";
            this.anzeigenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.anzeigenToolStripMenuItem.Text = "&Anzeigen";
            this.anzeigenToolStripMenuItem.Click += new System.EventHandler(this.anzeigenToolStripMenuItem_Click);
            // 
            // xSLTToolStripMenuItem
            // 
            this.xSLTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anzeigenToolStripMenuItem1,
            this.transformierenToolStripMenuItem,
            this.ergebnisToolStripMenuItem});
            this.xSLTToolStripMenuItem.Name = "xSLTToolStripMenuItem";
            this.xSLTToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.xSLTToolStripMenuItem.Text = "&XSLT";
            // 
            // anzeigenToolStripMenuItem1
            // 
            this.anzeigenToolStripMenuItem1.Name = "anzeigenToolStripMenuItem1";
            this.anzeigenToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.anzeigenToolStripMenuItem1.Text = "&Anzeigen";
            // 
            // transformierenToolStripMenuItem
            // 
            this.transformierenToolStripMenuItem.Name = "transformierenToolStripMenuItem";
            this.transformierenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.transformierenToolStripMenuItem.Text = "&Transformieren";
            this.transformierenToolStripMenuItem.Click += new System.EventHandler(this.transformierenToolStripMenuItem_Click);
            // 
            // ergebnisToolStripMenuItem
            // 
            this.ergebnisToolStripMenuItem.Name = "ergebnisToolStripMenuItem";
            this.ergebnisToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ergebnisToolStripMenuItem.Text = "&Ergebnis";
            // 
            // xPathToolStripMenuItem
            // 
            this.xPathToolStripMenuItem.Name = "xPathToolStripMenuItem";
            this.xPathToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.xPathToolStripMenuItem.Text = "X&Path";
            // 
            // lINQToolStripMenuItem
            // 
            this.lINQToolStripMenuItem.Name = "lINQToolStripMenuItem";
            this.lINQToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.lINQToolStripMenuItem.Text = "&LINQ";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "Zeichnung.xml";
            this.openFileDialog1.Filter = "XML-Dateien|*.xml|Alle Dateien|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.FileName = "Zeichnung.xml";
            this.saveFileDialog1.InitialDirectory = ".";
            // 
            // buttonPunkt
            // 
            this.buttonPunkt.Location = new System.Drawing.Point(0, 27);
            this.buttonPunkt.Name = "buttonPunkt";
            this.buttonPunkt.Size = new System.Drawing.Size(75, 23);
            this.buttonPunkt.TabIndex = 2;
            this.buttonPunkt.Text = "&Punkt";
            this.buttonPunkt.UseVisualStyleBackColor = true;
            this.buttonPunkt.Click += new System.EventHandler(this.buttonPunkt_Click);
            // 
            // buttonLinie
            // 
            this.buttonLinie.Location = new System.Drawing.Point(0, 56);
            this.buttonLinie.Name = "buttonLinie";
            this.buttonLinie.Size = new System.Drawing.Size(75, 23);
            this.buttonLinie.TabIndex = 2;
            this.buttonLinie.Text = "&Linie";
            this.buttonLinie.UseVisualStyleBackColor = true;
            this.buttonLinie.Click += new System.EventHandler(this.buttonLinie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(82, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 539);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonRechteck
            // 
            this.buttonRechteck.Location = new System.Drawing.Point(0, 86);
            this.buttonRechteck.Name = "buttonRechteck";
            this.buttonRechteck.Size = new System.Drawing.Size(75, 23);
            this.buttonRechteck.TabIndex = 4;
            this.buttonRechteck.Text = "&Rechteck";
            this.buttonRechteck.UseVisualStyleBackColor = true;
            this.buttonRechteck.Click += new System.EventHandler(this.buttonRechteck_Click);
            // 
            // buttonKreis
            // 
            this.buttonKreis.Location = new System.Drawing.Point(0, 115);
            this.buttonKreis.Name = "buttonKreis";
            this.buttonKreis.Size = new System.Drawing.Size(75, 23);
            this.buttonKreis.TabIndex = 4;
            this.buttonKreis.Text = "&Kreis";
            this.buttonKreis.UseVisualStyleBackColor = true;
            // 
            // buttonPolygon
            // 
            this.buttonPolygon.Location = new System.Drawing.Point(0, 172);
            this.buttonPolygon.Name = "buttonPolygon";
            this.buttonPolygon.Size = new System.Drawing.Size(75, 23);
            this.buttonPolygon.TabIndex = 4;
            this.buttonPolygon.Text = "&Polygon";
            this.buttonPolygon.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1389, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buttonBezier
            // 
            this.buttonBezier.Location = new System.Drawing.Point(0, 201);
            this.buttonBezier.Name = "buttonBezier";
            this.buttonBezier.Size = new System.Drawing.Size(75, 23);
            this.buttonBezier.TabIndex = 4;
            this.buttonBezier.Text = "&Bezier";
            this.buttonBezier.UseVisualStyleBackColor = true;
            this.buttonBezier.Click += new System.EventHandler(this.buttonBezier_Click);
            // 
            // buttonSpline
            // 
            this.buttonSpline.Location = new System.Drawing.Point(0, 230);
            this.buttonSpline.Name = "buttonSpline";
            this.buttonSpline.Size = new System.Drawing.Size(75, 23);
            this.buttonSpline.TabIndex = 4;
            this.buttonSpline.Text = "&Spline";
            this.buttonSpline.UseVisualStyleBackColor = true;
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(0, 291);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(75, 23);
            this.buttonText.TabIndex = 4;
            this.buttonText.Text = "&Text";
            this.buttonText.UseVisualStyleBackColor = true;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(0, 143);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(75, 23);
            this.buttonEllipse.TabIndex = 4;
            this.buttonEllipse.Text = "&Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonAuswahl
            // 
            this.buttonAuswahl.Location = new System.Drawing.Point(1, 477);
            this.buttonAuswahl.Name = "buttonAuswahl";
            this.buttonAuswahl.Size = new System.Drawing.Size(75, 23);
            this.buttonAuswahl.TabIndex = 4;
            this.buttonAuswahl.Text = "&Auswahl";
            this.buttonAuswahl.UseVisualStyleBackColor = true;
            // 
            // buttonFüllung
            // 
            this.buttonFüllung.Location = new System.Drawing.Point(0, 408);
            this.buttonFüllung.Name = "buttonFüllung";
            this.buttonFüllung.Size = new System.Drawing.Size(75, 23);
            this.buttonFüllung.TabIndex = 4;
            this.buttonFüllung.Text = "&Füllung";
            this.buttonFüllung.UseVisualStyleBackColor = true;
            // 
            // buttonStift
            // 
            this.buttonStift.Location = new System.Drawing.Point(0, 350);
            this.buttonStift.Name = "buttonStift";
            this.buttonStift.Size = new System.Drawing.Size(75, 23);
            this.buttonStift.TabIndex = 4;
            this.buttonStift.Text = "&Stift";
            this.buttonStift.UseVisualStyleBackColor = true;
            // 
            // buttonPinsel
            // 
            this.buttonPinsel.Location = new System.Drawing.Point(0, 379);
            this.buttonPinsel.Name = "buttonPinsel";
            this.buttonPinsel.Size = new System.Drawing.Size(75, 23);
            this.buttonPinsel.TabIndex = 4;
            this.buttonPinsel.Text = "&Pinsel";
            this.buttonPinsel.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(981, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 513);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // XmlCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 566);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonPinsel);
            this.Controls.Add(this.buttonStift);
            this.Controls.Add(this.buttonFüllung);
            this.Controls.Add(this.buttonAuswahl);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonSpline);
            this.Controls.Add(this.buttonBezier);
            this.Controls.Add(this.buttonPolygon);
            this.Controls.Add(this.buttonKreis);
            this.Controls.Add(this.buttonRechteck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLinie);
            this.Controls.Add(this.buttonPunkt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XmlCad";
            this.Text = "XML-CAD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonPunkt;
        private System.Windows.Forms.Button buttonLinie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRechteck;
        private System.Windows.Forms.ToolStripMenuItem farbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Button buttonKreis;
        private System.Windows.Forms.Button buttonPolygon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonBezier;
        private System.Windows.Forms.Button buttonSpline;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonAuswahl;
        private System.Windows.Forms.Button buttonFüllung;
        private System.Windows.Forms.Button buttonStift;
        private System.Windows.Forms.Button buttonPinsel;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatierungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xSLTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transformierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ergebnisToolStripMenuItem;
    }
}


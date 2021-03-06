// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SimpleDownloader {
    
    
    public partial class MainWindow {
        
        private Gtk.VBox vbox4;
        
        private Gtk.Table table2;
        
        private Gtk.FileChooserButton downloadPath;
        
        private Gtk.Entry downloadUrl;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.Button stopButton;
        
        private Gtk.Button downloadButton;
        
        private Gtk.ProgressBar downloadProgressBar;
        
        private Gtk.Label progressLabel;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget SimpleDownloader.MainWindow
            this.Name = "SimpleDownloader.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("Simple Downloader");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child SimpleDownloader.MainWindow.Gtk.Container+ContainerChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.downloadPath = new Gtk.FileChooserButton(Mono.Unix.Catalog.GetString("Datei auswählen"), ((Gtk.FileChooserAction)(0)));
            this.downloadPath.Name = "downloadPath";
            this.table2.Add(this.downloadPath);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table2[this.downloadPath]));
            w1.TopAttach = ((uint)(1));
            w1.BottomAttach = ((uint)(2));
            w1.LeftAttach = ((uint)(1));
            w1.RightAttach = ((uint)(2));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.downloadUrl = new Gtk.Entry();
            this.downloadUrl.CanFocus = true;
            this.downloadUrl.Name = "downloadUrl";
            this.downloadUrl.IsEditable = true;
            this.downloadUrl.InvisibleChar = '●';
            this.table2.Add(this.downloadUrl);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table2[this.downloadUrl]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Download URL:");
            this.table2.Add(this.label5);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table2[this.label5]));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Download Path:");
            this.table2.Add(this.label6);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table2[this.label6]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox4.Add(this.table2);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox4[this.table2]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.hbox3.Add(this.alignment1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox3[this.alignment1]));
            w6.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.stopButton = new Gtk.Button();
            this.stopButton.CanFocus = true;
            this.stopButton.Name = "stopButton";
            this.stopButton.UseUnderline = true;
            this.stopButton.Label = Mono.Unix.Catalog.GetString("Stop");
            this.hbox3.Add(this.stopButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.stopButton]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.downloadButton = new Gtk.Button();
            this.downloadButton.CanFocus = true;
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.UseUnderline = true;
            // Container child downloadButton.Gtk.Container+ContainerChild
            Gtk.Alignment w8 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w9 = new Gtk.HBox();
            w9.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w10 = new Gtk.Image();
            w10.Pixbuf = Stetic.IconLoader.LoadIcon(this, "down", Gtk.IconSize.Menu, 16);
            w9.Add(w10);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w12 = new Gtk.Label();
            w12.LabelProp = Mono.Unix.Catalog.GetString("Download");
            w12.UseUnderline = true;
            w9.Add(w12);
            w8.Add(w9);
            this.downloadButton.Add(w8);
            this.hbox3.Add(this.downloadButton);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox3[this.downloadButton]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            this.vbox4.Add(this.hbox3);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
            w17.Position = 1;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.downloadProgressBar = new Gtk.ProgressBar();
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.vbox4.Add(this.downloadProgressBar);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox4[this.downloadProgressBar]));
            w18.Position = 2;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.progressLabel = new Gtk.Label();
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.LabelProp = Mono.Unix.Catalog.GetString("Waiting for download");
            this.vbox4.Add(this.progressLabel);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox4[this.progressLabel]));
            w19.Position = 3;
            w19.Expand = false;
            w19.Fill = false;
            this.Add(this.vbox4);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 458;
            this.DefaultHeight = 172;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
            this.stopButton.Clicked += new System.EventHandler(this.OnStopButtonClicked);
            this.downloadButton.Clicked += new System.EventHandler(this.OnDownloadButtonClicked);
        }
    }
}

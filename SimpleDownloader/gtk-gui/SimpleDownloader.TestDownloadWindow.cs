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
    
    
    public partial class TestDownloadWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FileAction;
        
        private Gtk.Action quitAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Expander expander1;
        
        private Gtk.VButtonBox vbuttonbox2;
        
        private Gtk.Button button1;
        
        private Gtk.Button button2;
        
        private Gtk.Label GtkLabel3;
        
        private Gtk.Table table1;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Label label5;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label label8;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label label1;
        
        private Gtk.ProgressBar progressCurrent;
        
        private Gtk.Label label2;
        
        private Gtk.ProgressBar progressbar2;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView downloadTree;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget SimpleDownloader.TestDownloadWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
            this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
            w1.Add(this.FileAction, null);
            this.quitAction = new Gtk.Action("quitAction", Mono.Unix.Catalog.GetString("Quit"), null, "gtk-quit");
            this.quitAction.ShortLabel = Mono.Unix.Catalog.GetString("Quit");
            w1.Add(this.quitAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "SimpleDownloader.TestDownloadWindow";
            this.Title = Mono.Unix.Catalog.GetString("TestDownloadWindow");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child SimpleDownloader.TestDownloadWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='quitAction' action='quitAction'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.vbox1.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 141;
            this.hpaned1.BorderWidth = ((uint)(5));
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.expander1 = new Gtk.Expander(null);
            this.expander1.CanFocus = true;
            this.expander1.Name = "expander1";
            this.expander1.Expanded = true;
            // Container child expander1.Gtk.Container+ContainerChild
            this.vbuttonbox2 = new Gtk.VButtonBox();
            this.vbuttonbox2.Name = "vbuttonbox2";
            this.vbuttonbox2.Homogeneous = true;
            this.vbuttonbox2.Spacing = 5;
            this.vbuttonbox2.BorderWidth = ((uint)(5));
            // Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseStock = true;
            this.button1.UseUnderline = true;
            this.button1.Label = "gtk-add";
            this.vbuttonbox2.Add(this.button1);
            Gtk.ButtonBox.ButtonBoxChild w3 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button1]));
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.button2 = new Gtk.Button();
            this.button2.CanFocus = true;
            this.button2.Name = "button2";
            this.button2.UseStock = true;
            this.button2.UseUnderline = true;
            this.button2.Label = "gtk-delete";
            this.vbuttonbox2.Add(this.button2);
            Gtk.ButtonBox.ButtonBoxChild w4 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2[this.button2]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.expander1.Add(this.vbuttonbox2);
            this.GtkLabel3 = new Gtk.Label();
            this.GtkLabel3.Name = "GtkLabel3";
            this.GtkLabel3.LabelProp = Mono.Unix.Catalog.GetString("Download");
            this.GtkLabel3.UseUnderline = true;
            this.expander1.LabelWidget = this.GtkLabel3;
            this.vbox2.Add(this.expander1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.expander1]));
            w6.Position = 0;
            w6.Expand = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 1F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Links:");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 1F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("In progress:");
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("27");
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w9.LeftAttach = ((uint)(1));
            w9.RightAttach = ((uint)(2));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("13");
            this.table1.Add(this.label6);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.label6]));
            w10.TopAttach = ((uint)(1));
            w10.BottomAttach = ((uint)(2));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 1F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Done:");
            this.table1.Add(this.label7);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.label7]));
            w11.TopAttach = ((uint)(2));
            w11.BottomAttach = ((uint)(3));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("14");
            this.table1.Add(this.label8);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.label8]));
            w12.TopAttach = ((uint)(2));
            w12.BottomAttach = ((uint)(3));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox2.Add(this.table1);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox2[this.table1]));
            w13.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Current:");
            this.vbox3.Add(this.label1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox3[this.label1]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.progressCurrent = new Gtk.ProgressBar();
            this.progressCurrent.Name = "progressCurrent";
            this.progressCurrent.Text = "";
            this.vbox3.Add(this.progressCurrent);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox3[this.progressCurrent]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Overall:");
            this.vbox3.Add(this.label2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox3[this.label2]));
            w16.Position = 2;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.progressbar2 = new Gtk.ProgressBar();
            this.progressbar2.Name = "progressbar2";
            this.progressbar2.Text = "";
            this.vbox3.Add(this.progressbar2);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox3[this.progressbar2]));
            w17.Position = 3;
            w17.Expand = false;
            w17.Fill = false;
            this.vbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
            w18.Position = 2;
            w18.Expand = false;
            w18.Fill = false;
            this.hpaned1.Add(this.vbox2);
            Gtk.Paned.PanedChild w19 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox2]));
            w19.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.downloadTree = new Gtk.TreeView();
            this.downloadTree.CanFocus = true;
            this.downloadTree.Name = "downloadTree";
            this.scrolledwindow1.Add(this.downloadTree);
            this.hpaned1.Add(this.scrolledwindow1);
            this.vbox1.Add(this.hpaned1);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox1[this.hpaned1]));
            w22.Position = 1;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 609;
            this.DefaultHeight = 413;
            this.Show();
            this.quitAction.Activated += new System.EventHandler(this.OnQuitActionActivated);
            this.button1.Clicked += new System.EventHandler(this.OnButton1Clicked);
            this.downloadTree.RowActivated += new Gtk.RowActivatedHandler(this.OnDownloadTreeRowActivated);
        }
    }
}
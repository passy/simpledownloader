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
    
    
    public partial class DownloadWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FilesAction;
        
        private Gtk.Action DownloadAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.Action actionAbout;
        
        private Gtk.Action addAction1;
        
        private Gtk.Action removeAction;
        
        private Gtk.Action quitAction;
        
        private Gtk.Action addAction;
        
        private Gtk.Action mediaPlayAction;
        
        private Gtk.Action mediaStopAction;
        
        private Gtk.Action preferencesAction;
        
        private Gtk.VBox mainVbox;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.Toolbar toolbar1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView downloadTree;
        
        private Gtk.Statusbar statusbar;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget SimpleDownloader.DownloadWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FilesAction = new Gtk.Action("FilesAction", Mono.Unix.Catalog.GetString("Files"), null, null);
            this.FilesAction.ShortLabel = Mono.Unix.Catalog.GetString("Files");
            w1.Add(this.FilesAction, null);
            this.DownloadAction = new Gtk.Action("DownloadAction", Mono.Unix.Catalog.GetString("Download"), null, null);
            this.DownloadAction.Sensitive = false;
            this.DownloadAction.ShortLabel = Mono.Unix.Catalog.GetString("Download");
            w1.Add(this.DownloadAction, null);
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("Help"), null, null);
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
            w1.Add(this.HelpAction, null);
            this.actionAbout = new Gtk.Action("actionAbout", Mono.Unix.Catalog.GetString("About"), null, "gtk-dialog-info");
            this.actionAbout.ShortLabel = Mono.Unix.Catalog.GetString("About");
            w1.Add(this.actionAbout, null);
            this.addAction1 = new Gtk.Action("addAction1", Mono.Unix.Catalog.GetString("_Add"), null, "gtk-add");
            this.addAction1.ShortLabel = Mono.Unix.Catalog.GetString("_Add");
            w1.Add(this.addAction1, null);
            this.removeAction = new Gtk.Action("removeAction", Mono.Unix.Catalog.GetString("Remove"), null, "gtk-remove");
            this.removeAction.ShortLabel = Mono.Unix.Catalog.GetString("Remove");
            w1.Add(this.removeAction, null);
            this.quitAction = new Gtk.Action("quitAction", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
            this.quitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
            w1.Add(this.quitAction, null);
            this.addAction = new Gtk.Action("addAction", Mono.Unix.Catalog.GetString("_Add Download"), null, "gtk-add");
            this.addAction.ShortLabel = Mono.Unix.Catalog.GetString("_Add");
            w1.Add(this.addAction, null);
            this.mediaPlayAction = new Gtk.Action("mediaPlayAction", Mono.Unix.Catalog.GetString("Start _Download"), null, "gtk-media-play");
            this.mediaPlayAction.ShortLabel = Mono.Unix.Catalog.GetString("_Download");
            w1.Add(this.mediaPlayAction, null);
            this.mediaStopAction = new Gtk.Action("mediaStopAction", Mono.Unix.Catalog.GetString("_Stop Download"), null, "gtk-media-stop");
            this.mediaStopAction.ShortLabel = Mono.Unix.Catalog.GetString("_Stop");
            w1.Add(this.mediaStopAction, null);
            this.preferencesAction = new Gtk.Action("preferencesAction", Mono.Unix.Catalog.GetString("_Preferences"), null, "gtk-preferences");
            this.preferencesAction.ShortLabel = Mono.Unix.Catalog.GetString("_Preferences");
            w1.Add(this.preferencesAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "SimpleDownloader.DownloadWindow";
            this.Title = Mono.Unix.Catalog.GetString("BlueLoad");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child SimpleDownloader.DownloadWindow.Gtk.Container+ContainerChild
            this.mainVbox = new Gtk.VBox();
            this.mainVbox.Name = "mainVbox";
            // Container child mainVbox.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FilesAction' action='FilesAction'><menuitem name='addAction1' action='addAction1'/><menuitem name='preferencesAction' action='preferencesAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='DownloadAction' action='DownloadAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='actionAbout' action='actionAbout'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.mainVbox.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.mainVbox[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child mainVbox.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='addAction' action='addAction'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaStopAction' action='mediaStopAction'/></toolbar></ui>");
            this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.ShowArrow = false;
            this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(2));
            this.toolbar1.IconSize = ((Gtk.IconSize)(3));
            this.mainVbox.Add(this.toolbar1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.mainVbox[this.toolbar1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child mainVbox.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.downloadTree = new Gtk.TreeView();
            this.downloadTree.CanFocus = true;
            this.downloadTree.Name = "downloadTree";
            this.downloadTree.SearchColumn = 0;
            this.GtkScrolledWindow.Add(this.downloadTree);
            this.mainVbox.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.mainVbox[this.GtkScrolledWindow]));
            w5.Position = 2;
            // Container child mainVbox.Gtk.Box+BoxChild
            this.statusbar = new Gtk.Statusbar();
            this.statusbar.Name = "statusbar";
            this.statusbar.Spacing = 6;
            this.mainVbox.Add(this.statusbar);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.mainVbox[this.statusbar]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            this.Add(this.mainVbox);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 588;
            this.DefaultHeight = 384;
            this.Show();
            this.quitAction.Activated += new System.EventHandler(this.OnActionQuitActivated);
            this.addAction.Activated += new System.EventHandler(this.OnAddActionActivated);
        }
    }
}

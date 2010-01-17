
using System;

namespace SimpleDownloader
{


	public partial class TestDownloadWindow : Gtk.Window
	{

		public TestDownloadWindow () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			this.BuildTreeColumns ();
			this.AttachDownloadTreeStore ();
		}
		
		/// <summary>
		/// Creates the static columns in the downloader.
		/// </summary>
		/// TODO: i18n
		protected void BuildTreeColumns ()
		{
			// New column for the filename
			Gtk.TreeViewColumn filenameColumn = new Gtk.TreeViewColumn ();
			filenameColumn.Title = "Filename";
			// Set this to be the largest column
			filenameColumn.Expand = true;
			
			// The cell that stores the filename
			Gtk.CellRendererText filenameCell = new Gtk.CellRendererText ();
			
			// Add the cell to the column and expand
			filenameColumn.PackStart (filenameCell, true);
			
			// Let's add a speed column
			Gtk.TreeViewColumn speedColumn = new Gtk.TreeViewColumn ();
			speedColumn.Title = "Speed";
			speedColumn.Expand = true;
			Gtk.CellRendererText speedCell = new Gtk.CellRendererText ();
			speedColumn.PackStart (speedCell, true);
			
			// Think about additional columns, but avoid redundant infos or 
			// uninteresting stuff at all cost! Can always be added later if
			// it's possible to select wanted columns as in banshee.
			
			// Add all the columns to the tree view.
			downloadTree.AppendColumn (filenameColumn);
			downloadTree.AppendColumn (speedColumn);
			
			// Tell the cell renderers how to display the model
			filenameColumn.AddAttribute (filenameCell, "text", 0);
			speedColumn.AddAttribute (speedCell, "text", 1);
		}
		
		/// <summary>
		/// Creates and attaches a ListStore object to the download tree view.
		/// </summary>
		protected void AttachDownloadTreeStore ()
		{
			Gtk.TreeStore downloadTreeStore = 
				new Gtk.TreeStore (typeof(string), typeof(string));
			downloadTree.Model = downloadTreeStore;
		}
		
		
		protected virtual void OnQuitActionActivated (object sender, System.EventArgs e)
		{
			Gtk.Application.Quit ();
		}
		
		protected virtual void OnButton1Clicked (object sender, System.EventArgs e)
		{
			// Adds a random entry
			Random rand = new Random ();
			int filenameNo = rand.Next (0, 23);
			int speed = rand.Next (1, 2000);
			
			string filename;
			string speedLabel = speed.ToString () + " kb/s";
			
			filename = "Test File " + filenameNo;
			
			Gtk.TreeIter treeIter = ((Gtk.TreeStore)downloadTree.Model).AppendValues (
				filename, speedLabel);
			
			// Now create some files inside the tree
			this.CreateRandomFileEntries (treeIter, ref speed);
		}
		
		
		protected virtual void CreateRandomFileEntries (
			Gtk.TreeIter parent, ref int totalSpeed)
		{
			Random rand = new Random ();
			int entryCount = rand.Next (3, 15);
			
			for (int i = 0; i < entryCount; i += 1)
			{
				// We try to keep the progress near to real values
				int fileSpeed;
				
				// If we are in the last run, we'll catch up a bit.
				if (i == entryCount - 1) {
					fileSpeed = totalSpeed;
				} else {
					fileSpeed = rand.Next (0, totalSpeed);
					totalSpeed -= fileSpeed;
				}
				
				string filename = "File Part " + i.ToString ();
				string fileSpeedLabel = fileSpeed.ToString () + "kb/s";
				
				((Gtk.TreeStore)downloadTree.Model).AppendValues (
					parent, filename, fileSpeedLabel);
			}
		}
		
		protected virtual void OnDownloadTreeRowActivated (object o, Gtk.RowActivatedArgs args)
		{
			Random rand = new Random();
			progressCurrent.Fraction = Convert.ToDouble((rand.Next(1, 100) / 100));
			
		}
		
		
		
		
		
	}
}

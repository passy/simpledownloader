/**
 * This window resambles a downloader research and is for demonstration
 * purposes only. (;
 */
 
using System;

namespace SimpleDownloader
{


	public partial class DownloadWindow : Gtk.Window
	{
		public DownloadWindow () : base(Gtk.WindowType.Toplevel)
		{
			// Let's get the designer started.
			this.Build ();
			
			this.BuildTreeColumns ();
			this.AttachDownloadTreeStore ();
			this.statusbar.Push (statusbar.GetContextId ("loaded"),
				"BlueLoad loaded. Feel free to add some sample data!");
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
			
			// Same procedure for the progress column
			Gtk.TreeViewColumn progressColumn = new Gtk.TreeViewColumn ();
			progressColumn.Title = "Progress";
			progressColumn.Expand = true;
			Gtk.CellRendererProgress progressCell = new Gtk.CellRendererProgress ();
			progressColumn.PackStart (progressCell, true);
			
			// Let's add a speed column
			Gtk.TreeViewColumn speedColumn = new Gtk.TreeViewColumn ();
			speedColumn.Title = "Speed";
			Gtk.CellRendererText speedCell = new Gtk.CellRendererText ();
			speedColumn.PackStart (speedCell, true);
			
			// Think about additional columns, but avoid redundant infos or 
			// uninteresting stuff at all cost! Can always be added later if
			// it's possible to select wanted columns as in banshee.
			
			// Add all the columns to the tree view.
			downloadTree.AppendColumn (filenameColumn);
			downloadTree.AppendColumn (progressColumn);
			downloadTree.AppendColumn (speedColumn);
			
			// Tell the cell renderers how to display the model
			filenameColumn.AddAttribute (filenameCell, "text", 0);
			progressColumn.AddAttribute (progressCell, "value", 1);
			speedColumn.AddAttribute (speedCell, "text", 2);
		}
		
		/// <summary>
		/// Creates and attaches a ListStore object to the download tree view.
		/// </summary>
		protected void AttachDownloadTreeStore ()
		{
			Gtk.TreeStore downloadTreeStore = 
				new Gtk.TreeStore (typeof(string), typeof(int), typeof(string));
			downloadTree.Model = downloadTreeStore;
		}
		
		/// <summary>
		/// Adds a random entry to the list to illustrate how it works.
		/// </summary>
		/// <param name="sender">
		/// A <see cref="System.Object"/>
		/// </param>
		/// <param name="e">
		/// A <see cref="System.EventArgs"/>
		/// </param>
		protected virtual void OnAddActionActivated (object sender, System.EventArgs e)
		{
			// Adds a random entry
			Random rand = new Random ();
			int filenameNo = rand.Next (0, 23);
			int progress = rand.Next (0, 100);
			int speed = rand.Next (1, 2000);
			
			string filename;
			string speedLabel = speed.ToString () + " kb/s";
			
			if (filenameNo == 15) {
				filename = "Happy Birthday (nachtraeglich)!";
			} else {
				filename = "Test File " + filenameNo;
			}
			
			Gtk.TreeIter treeIter = ((Gtk.TreeStore)downloadTree.Model).AppendValues (
				filename, progress, speedLabel);
			
			// Now create some files inside the tree
			this.CreateRandomFileEntries (treeIter, ref progress, ref speed);
			this.statusbar.Push (this.statusbar.GetContextId ("created entry"),
				"Created a new entry!");
		}
		
		protected virtual void CreateRandomFileEntries (
			Gtk.TreeIter parent, ref int totalProgress, ref int totalSpeed)
		{
			Random rand = new Random ();
			int entryCount = rand.Next (3, 15);
			
			for (int i = 0; i < entryCount; i += 1)
			{
				// We try to keep the progress near to real values
				int fileProgress, fileSpeed;
				
				// If we are in the last run, we'll catch up a bit.
				if (i == entryCount - 1) {
					fileProgress = totalProgress;
					fileSpeed = totalSpeed;
				} else {
					fileProgress = rand.Next (0, totalProgress);
					totalProgress -= fileProgress;
					fileSpeed = rand.Next (0, totalSpeed);
					totalSpeed -= fileSpeed;
				}
				
				string filename = "File Part " + i.ToString ();
				string fileSpeedLabel = fileSpeed.ToString () + "kb/s";
				
				((Gtk.TreeStore)downloadTree.Model).AppendValues (
					parent, filename, fileProgress, fileSpeedLabel);
			}
		}
		protected virtual void OnActionQuitActivated (object sender, System.EventArgs e)
		{
			Gtk.Application.Quit ();
		}
	}
}

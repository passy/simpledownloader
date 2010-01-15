using System;
using System.Threading;
using Gtk;

namespace SimpleDownloader {

	public partial class MainWindow : Gtk.Window
	{
		private Downloader downloader;
		private Thread downloadThread;
		private int percentage = -1;
		
		public MainWindow () : base(Gtk.WindowType.Toplevel)
		{
			Build ();
		}
		
		protected void UpdateProgress (long bytesRead, long totalBytes)
		{
			int percentage = Convert.ToInt32(bytesRead * 100 / totalBytes);
			if (percentage > this.percentage) {
				this.percentage = percentage;
				downloadProgressBar.Fraction = ((double)percentage/100);
				progressLabel.Text = String.Format("Downloaded {0} out of {1} total bytes ({2} %).",
					bytesRead, totalBytes, percentage);
			}
		}
	
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			OnStopButtonClicked (sender, a);
			Application.Quit ();
			a.RetVal = true;
		}
		
		protected void OnDownloadSucessful (object sender, System.EventArgs e)
		{
			progressLabel.Text = "Download successful!";
		}
		
		protected virtual void OnDownloadButtonClicked (object sender, System.EventArgs e)
		{
			downloader = new Downloader (downloadUrl.Text, downloadPath.Filename);
			downloader.ProgressUpdated += new Downloader.UpdateProgressCallback (UpdateProgress);
			downloader.DownloadSuccessful += new EventHandler (OnDownloadSucessful);
			progressLabel.Text = "Download started.";
			downloadThread = new Thread (downloader.Start);
			downloadThread.Start ();
		}
		
		protected virtual void OnStopButtonClicked (object sender, System.EventArgs e)
		{
			if (downloader != null) {
				downloader.Stop ();
			}
			progressLabel.Text = "Download stopped.";
		}
		
		
	}
}
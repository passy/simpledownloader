using System;
using Gtk;

namespace SimpleDownloader
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			
			DownloadWindow win2 = new DownloadWindow ();
			win2.Show ();
			
			Application.Run ();
		}
	}
}

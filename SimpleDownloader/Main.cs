using System;
using Gtk;

namespace SimpleDownloader
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			
			TestDownloadWindow win2 = new TestDownloadWindow ();
			win2.Show ();
			
			Application.Run ();
		}
	}
}

using System;
using System.Net;
using System.IO;

namespace SimpleDownloader
{
	public class Downloader
	{
		private int downloadBufferSize = 2048;
		
		public int DownloadBufferSize
		{
			get { return downloadBufferSize; }
			set { downloadBufferSize = value; }
		}
		
		public delegate void UpdateProgressCallback(long bytesRead, long totalBytes);
		public event UpdateProgressCallback ProgressUpdated;
		public event EventHandler DownloadSuccessful;
		
		private Stream responseStream;
		private Stream localStream;
		private HttpWebRequest webRequest;
		private HttpWebResponse webResponse;
		
		public Downloader (string downloadUrl, string downloadPath)
		{
			webRequest = CreateWebRequest (downloadUrl);
			localStream = new FileStream (downloadPath, FileMode.Create, FileAccess.Write,
				FileShare.None);
		}
		
		/// <summary>
		/// Called when the download is supposed to start.
		/// </summary>
		public void Start ()
		{
			using (WebClient client = new WebClient ()) 
			{
				// Create a response object and get the expected file size
				webResponse = (HttpWebResponse)webRequest.GetResponse ();
				// No need to use the async method, because this will be run in an
				// additional thread.
				responseStream = client.OpenRead (webRequest.RequestUri);
				Download ();
			}
		}
		
		private void Download ()
		{
			// Start the read loop.
			int bytesRead;
			byte[] downloadBuffer = new byte[downloadBufferSize];
			long filesize = webResponse.ContentLength;
			Console.WriteLine ("Total File Size: " + filesize);
			
			try
			{
				while ((bytesRead = responseStream.Read (downloadBuffer, 0, downloadBuffer.Length)) > 0)
				{
					localStream.Write (downloadBuffer, 0, bytesRead);
					if (ProgressUpdated != null) {
						ProgressUpdated (localStream.Length, filesize);
					}
				}
			}
			finally
			{
				Stop ();
			}
			
			if (DownloadSuccessful != null) {
				DownloadSuccessful (this, EventArgs.Empty);
			}
		}
		
		public void Stop ()
		{
			localStream.Close ();
			responseStream.Close ();
			webResponse.Close ();
		}
		
		private HttpWebRequest CreateWebRequest (string downloadUrl)
		{
			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create (downloadUrl);
			webRequest.Credentials = CredentialCache.DefaultCredentials;
			return webRequest;
		}
	}
}

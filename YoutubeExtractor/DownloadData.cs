﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExtractor
{
    public class DownloadData
    {
        //private WebResponse response; 


        // private Stream stream; 
        // private long size; 
        // private long start; 


        // public async static Task<DownloadData> Create(string url, string destFolder, String fileName) 
        // { 
        //     // This is what we will return 
        //     DownloadData downloadData = new DownloadData(); 


        //     long urlSize = downloadData.GetFileSize(url); 
        //     downloadData.size = urlSize; 


        //     WebRequest req = downloadData.CreateRequest(url); 
        //     try 
        //     { 
        //         downloadData.response = await (WebResponse)req.GetResponseAsync(); 
        //     } 
        //     catch (Exception e) 
        //     { 
        //         throw new ArgumentException(String.Format( 
        //             "Error downloading \"{0}\": {1}", url, e.Message), e); 
        //     } 


        //     // Check to make sure the response isn't an error. If it is this method 
        //     // will throw exceptions. 
        //     ValidateResponse(downloadData.response, url); 

        //     String downloadTo = Path.Combine(destFolder, fileName); 


        //     // If we don't know how big the file is supposed to be, 
        //     // we can't resume, so delete what we already have if something is on disk already. 
        //     if (!downloadData.IsProgressKnown && File.Exists(downloadTo)) 
        //         File.Delete(downloadTo); 


        //     if (downloadData.IsProgressKnown && File.Exists(downloadTo)) 
        //     { 
        //         // We only support resuming on http requests 
        //         if (!(downloadData.Response is HttpWebResponse)) 
        //         { 
        //             File.Delete(downloadTo); 
        //         } 
        //         else 
        //         { 
        //             // Try and start where the file on disk left off 
        //             downloadData.start = new FileInfo(downloadTo).Length; 


        //             // If we have a file that's bigger than what is online, then something  
        //             // strange happened. Delete it and start again. 
        //             if (downloadData.start > urlSize) 
        //                 File.Delete(downloadTo); 
        //           else if (downloadData.start < urlSize) 
        //             { 
        //                // Try and resume by creating a new request with a new start position 
        //                 downloadData.response.Close(); 
        //                 req = downloadData.CreateRequest(url); 
        //                 ((HttpWebRequest)req).AddRange((int)downloadData.start); 
        //                 downloadData.response = req.GetResponse(); 


        //                 if (((HttpWebResponse)downloadData.Response).StatusCode != HttpStatusCode.PartialContent) 
        //                 { 
        //                     // They didn't support our resume request.  
        //                     File.Delete(downloadTo); 
        //                     downloadData.start = 0; 
        //                 } 
        //             } 
        //         } 
        //     } 
        //     return downloadData; 
        // } 


        // // Used by the factory method 
        // private DownloadData() 
        // { 
        // } 


        // private DownloadData(WebResponse response, long size, long start) 
        // { 
        //     this.response = response; 
        //     this.size = size; 
        //     this.start = start; 
        //     this.stream = null; 
        // } 


        // /// <summary> 
        // /// Checks whether a WebResponse is an error. 
        // /// </summary> 
        // /// <param name="response"></param> 
        // private static void ValidateResponse(WebResponse response, string url) 
        // { 
        //     if (response is HttpWebResponse) 
        //     { 
        //         HttpWebResponse httpResponse = (HttpWebResponse)response; 
        //         // If it's an HTML page, it's probably an error page. Comment this 
        //         // out to enable downloading of HTML pages. 
        //         if (httpResponse.ContentType.Contains("text/html") || httpResponse.StatusCode == HttpStatusCode.NotFound) 
        //         { 
        //             throw new ArgumentException( 
        //                 String.Format("Could not download \"{0}\" - a web page was returned from the web server.", 
        //                 url)); 
        //         } 
        //     } 
        //     else if (response is FtpWebResponse) 
        //     { 
        //         FtpWebResponse ftpResponse = (FtpWebResponse)response; 
        //         if (ftpResponse.StatusCode == FtpStatusCode.ConnectionClosed) 
        //             throw new ArgumentException( 
        //                 String.Format("Could not download \"{0}\" - FTP server closed the connection.", url)); 
        //     } 
        //     // FileWebResponse doesn't have a status code to check. 
        // } 


        // /// <summary> 
        // /// Checks the file size of a remote file. If size is -1, then the file size 
        // /// could not be determined. 
        // /// </summary> 
        // /// <param name="url"></param> 
        // /// <param name="progressKnown"></param> 
        // /// <returns></returns> 
        // public long GetFileSize(string url) 
        // { 
        //     WebResponse response = null; 


        //     try 
        //     { 
        //         WebRequest request = CreateRequest(url); 
        //         request.Proxy = null; 


        //         response = request.GetResponse(); 
        //         return response.ContentLength; 
        //     } 
        //     catch (Exception) 
        //     { 
        //         // Do some logging here 
        //     } 
        //     finally 
        //     { 
        //         if (response != null) 
        //         { 
        //             response.Close(); 
        //         } 
        //     } 


        //     return -1; 
        // } 


        // private WebRequest CreateRequest(string url) 
        // { 
        //     WebRequest request = WebRequest.Create(url); 
        //     request.Proxy = null; 


        //    return request; 
        // } 


        // public void Close() 
        // { 
        //     this.response.Close(); 
        // } 


        // public WebResponse Response 
        // { 
        //     get { return response; } 
        //     set { response = value; } 
        // } 


        // public Stream DownloadStream 
        // { 
        //     get 
        //     { 
        //         if (this.start == this.size) 
        //             return Stream.Null; 
        //         if (this.stream == null) 
        //             this.stream = this.response.GetResponseStream(); 
        //         return this.stream; 
        //     } 
        // } 


        // public long FileSize 
        // { 
        //     get 
        //     { 
        //         return this.size; 
        //     } 
        // } 


        // public long StartPoint 
        // { 
        //     get 
        //     { 
        //         return this.start; 
        //     } 
        // } 


        // public bool IsProgressKnown 
        // { 
        //     get 
        //     { 
        //         // If the size of the remote url is -1, that means we 
        //         // couldn't determine it, and so we don't know 
        //         // progress information. 
        //         return this.size > -1; 
        //     } 
        // } 

    }
}

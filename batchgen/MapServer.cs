using System;
using System.Net;
using System.IO;
using System.Threading;


class MapServer
{
    public batchgen.Form1 _form1;
    public string MapFile = "";
    private Thread _serverThread;
    private HttpListener _listener;
    private int _port;
    private static bool _isrunning;

    public static bool Running
        {
            get { return _isrunning; }
            
        }


    public int Port
    {
        get { return _port; }
        private set { }
    }

    /// <summary>
    /// Construct server with given port.
    /// </summary>
    /// <param name="path">Directory path to serve.</param>
    /// <param name="port">Port of the server.</param>
    public MapServer(string path, int port, ref batchgen.Form1 form1)
    {
        _form1 = form1;
        this.Initialize(path, port);
    }

    /// <summary>
    /// Stop server and dispose all functions.
    /// </summary>
    public void Stop()
    {
        _serverThread.Abort();
        _listener.Stop();
        _isrunning = false;
    }

    private void Listen()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add("http://*:" + _port.ToString() + "/");
        _listener.Start();
        _isrunning = true;
        while (true)
        {
            try
            {
                HttpListenerContext context = _listener.GetContext();
                if (batchgen.Form1.lwhite)
                {
                    string connected = context.Request.UserHostAddress.Split(new string[] { ":" }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    if (batchgen.Form1.whitelist.Contains(connected))
                    {
                        Process(context);
                    }
                    else
                    {
                        context.Response.OutputStream.Close();
                        _form1.WriteTextSafe("Blocked IP: " + connected + Environment.NewLine);
                    }
                }
                else
                {
                    Process(context);
                }
            }
            catch (Exception ex)
            {
                //_form1.WriteTextSafe("Error: " + ex.ToString() + Environment.NewLine);
            }
        }
    }

    private void Process(HttpListenerContext context)
    {
        string filename = MapFile;
        _form1.WriteTextSafe("User-Agent:"+context.Request.UserAgent + Environment.NewLine + "User-IP:"+context.Request.UserHostAddress+Environment.NewLine);
        Stream input = new FileStream(filename, FileMode.Open);
        context.Response.ContentType = "application/x-binary";
        context.Response.ContentLength64 = input.Length;
        context.Response.AddHeader("Date", DateTime.Now.ToString("r"));
        context.Response.AddHeader("Last-Modified", System.IO.File.GetLastWriteTime(filename).ToString("r"));

        byte[] buffer = new byte[1024 * 16];
        int nbytes;
        while ((nbytes = input.Read(buffer, 0, buffer.Length)) > 0)
            context.Response.OutputStream.Write(buffer, 0, nbytes);
        input.Close();

        context.Response.StatusCode = (int)HttpStatusCode.OK;
        context.Response.OutputStream.Flush();
        context.Response.OutputStream.Close();
    }

    private void Initialize(string path, int port)
    {
        MapFile = path;
        this._port = port;
        _serverThread = new Thread(this.Listen);
        _serverThread.Start();
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Calculadora
{
    class Http
    {
        private static Http instance;

        public enum Services
        {
            CONNECT = 0, LOAD_FILE = 1, SUM = 2, SUB = 3, MULT = 4, DIV = 5
        }

        private Http()
        { }

        public static Http GetInstance()
        {
            if(instance == null) instance = new Http();

            return instance;
        }

        public string SendToServer(Dictionary<string, string> parameters)
        {
            string outputData = "";

            try  
            {
                // Create a new HttpWebRequest object.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/calculator_server/requests.php");
                myHttpWebRequest.Method = "POST";
                myHttpWebRequest.KeepAlive = false;
                myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";

                StringBuilder builder = new StringBuilder();

                foreach (KeyValuePair<string, string> kvp in parameters) 
                    builder.Append(kvp.Key + "=" + kvp.Value + "&");

                byte[] bytes = Encoding.ASCII.GetBytes(builder.ToString());

                myHttpWebRequest.ContentLength = bytes.Length;

                Stream os = myHttpWebRequest.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
                os.Close();
                
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if(myHttpWebResponse != null)
                {
                    Stream streamResponse = myHttpWebResponse.GetResponseStream();
                    StreamReader streamRead = new StreamReader(streamResponse,Encoding.Default);
                    
                    outputData = streamRead.ReadToEnd();
                    
                    streamResponse.Close();
                    streamRead.Close();                    
                    myHttpWebResponse.Close();
                }

                return outputData;
            }
            catch(Exception e)
            {      
                Console.WriteLine("Source :{0} " , e.Source);
                Console.WriteLine("Message :{0} " , e.Message);
                return "";
            }
        }
    }
}
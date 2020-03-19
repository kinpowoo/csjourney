using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace WindowsFormsApp1
{
    class HttpRequest
    {

        /// <summary>
        /// 不做catch处理，需要在外部做
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method">默认GET，空则补充为GET</param>
        /// <param name="contenttype">默认json，空则补充为json</param>
        /// <param name="header">请求头部</param>
        /// <param name="data">请求body内容</param>
        /// <returns></returns>
        public static string Http(string url, string method = "GET", string contenttype = "application/json;charset=utf-8", Hashtable header = null, string data = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = string.IsNullOrEmpty(method) ? "GET" : method;
            request.ContentType = string.IsNullOrEmpty(contenttype) ? "application/json;charset=utf-8" : contenttype;
            if (header != null)
            {
                foreach (var i in header.Keys)
                {
                    request.Headers.Add(i.ToString(), header[i].ToString());
                }
            }
            if (!string.IsNullOrEmpty(data))
            {
                Stream RequestStream = request.GetRequestStream();
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                RequestStream.Write(bytes, 0, bytes.Length);
                RequestStream.Close();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream ResponseStream = response.GetResponseStream();
            StreamReader StreamReader = new StreamReader(ResponseStream, Encoding.GetEncoding("utf-8"));
            string re = StreamReader.ReadToEnd();
            StreamReader.Close();
            ResponseStream.Close();
            return re;
        }
    }


        public class RestClient
        {
            private string BaseUri;
            public RestClient(string baseUri)
            {
                this.BaseUri = baseUri;
            }

            #region Get请求
            public string Get(string uri)
            {
                //先根据用户请求的uri构造请求地址
                string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
                //创建Web访问对  象
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
                //通过Web访问对象获取响应内容
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                //通过响应内容流创建StreamReader对象，因为StreamReader更高级更快
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                //string returnXml = HttpUtility.UrlDecode(reader.ReadToEnd());//如果有编码问题就用这个方法
                string returnXml = reader.ReadToEnd();//利用StreamReader就可以从响应内容从头读到尾
                reader.Close();
                myResponse.Close();
                return returnXml;
            }
        #endregion


        #region Get静态请求
        public static string GetX(string uri)
        {
            //先根据用户请求的uri构造请求地址
            string serviceUrl = string.Format("{0}",  uri);
            //创建Web访问对  象
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
            //通过Web访问对象获取响应内容
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            //通过响应内容流创建StreamReader对象，因为StreamReader更高级更快
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

            //string returnXml = HttpUtility.UrlDecode(reader.ReadToEnd());//如果有编码问题就用这个方法
            string returnXml = reader.ReadToEnd();//利用StreamReader就可以从响应内容从头读到尾
            reader.Close();
            myResponse.Close();
            return returnXml;
        }
        #endregion

        #region Post请求
        public string Post(string data, string uri)
            {
                //先根据用户请求的uri构造请求地址
                string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
                //创建Web访问对象
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
                //把用户传过来的数据转成“UTF-8”的字节流
                byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(data);

                myRequest.Method = "POST";
                myRequest.ContentLength = buf.Length;
                myRequest.ContentType = "application/json";
                myRequest.MaximumAutomaticRedirections = 1;
                myRequest.AllowAutoRedirect = true;
                //发送请求
                Stream stream = myRequest.GetRequestStream();
                stream.Write(buf, 0, buf.Length);
                stream.Close();

                //获取接口返回值
                //通过Web访问对象获取响应内容
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                //通过响应内容流创建StreamReader对象，因为StreamReader更高级更快
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                //string returnXml = HttpUtility.UrlDecode(reader.ReadToEnd());//如果有编码问题就用这个方法
                string returnXml = reader.ReadToEnd();//利用StreamReader就可以从响应内容从头读到尾
                reader.Close();
                myResponse.Close();
                return returnXml;

            }
            #endregion

            #region Put请求
            public string Put(string data, string uri)
            {
                //先根据用户请求的uri构造请求地址
                string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
                //创建Web访问对象
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
                //把用户传过来的数据转成“UTF-8”的字节流
                byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(data);

                myRequest.Method = "PUT";
                myRequest.ContentLength = buf.Length;
                myRequest.ContentType = "application/json";
                myRequest.MaximumAutomaticRedirections = 1;
                myRequest.AllowAutoRedirect = true;
                //发送请求
                Stream stream = myRequest.GetRequestStream();
                stream.Write(buf, 0, buf.Length);
                stream.Close();

                //获取接口返回值
                //通过Web访问对象获取响应内容
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                //通过响应内容流创建StreamReader对象，因为StreamReader更高级更快
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                //string returnXml = HttpUtility.UrlDecode(reader.ReadToEnd());//如果有编码问题就用这个方法
                string returnXml = reader.ReadToEnd();//利用StreamReader就可以从响应内容从头读到尾
                reader.Close();
                myResponse.Close();
                return returnXml;

            }
            #endregion


            #region Delete请求
            public string Delete(string data, string uri)
            {
                //先根据用户请求的uri构造请求地址
                string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
                //创建Web访问对象
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);
                //把用户传过来的数据转成“UTF-8”的字节流
                byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(data);

                myRequest.Method = "DELETE";
                myRequest.ContentLength = buf.Length;
                myRequest.ContentType = "application/json";
                myRequest.MaximumAutomaticRedirections = 1;
                myRequest.AllowAutoRedirect = true;
                //发送请求
                Stream stream = myRequest.GetRequestStream();
                stream.Write(buf, 0, buf.Length);
                stream.Close();

                //获取接口返回值
                //通过Web访问对象获取响应内容
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                //通过响应内容流创建StreamReader对象，因为StreamReader更高级更快
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                //string returnXml = HttpUtility.UrlDecode(reader.ReadToEnd());//如果有编码问题就用这个方法
                string returnXml = reader.ReadToEnd();//利用StreamReader就可以从响应内容从头读到尾
                reader.Close();
                myResponse.Close();
                return returnXml;

            }
            #endregion
        }

}

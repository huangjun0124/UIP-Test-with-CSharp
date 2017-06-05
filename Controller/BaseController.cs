using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Controller.cn.com.webxml.www;
using Microsoft.ApplicationBlocks.UIProcess;

namespace Controller
{
    public class BaseController : ControllerBase
    {
        public BaseController(Navigator navigator) : base(navigator)
        {
        }

        public void ShowForm(string key)
        {
            State.NavigateValue = key;
            Navigate();
        }

        public void ShowUserControl(string key)
        {
             ITask startingTask = new UIPTask();
             UIPManager.StartUserControlsTask(key, startingTask);
        }

        public DataTable GetExampleSvc()
        {
            LocalExampleSvc.ExampleSvcSoapClient ws = new LocalExampleSvc.ExampleSvcSoapClient();
            DataTable DT = ws.GetDataTable("COL", 6, 5);
            return DT;
        }

        public DataSet GetRegionDS()
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap12");
            return ws.getRegionDataset();
        }

        public List<string> GetRegionCountry()
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap12");
            return ws.getRegionCountry().ToList();
        }

        public List<string> GetRegionProvince()
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap12");
            return ws.getRegionProvince().ToList();
        }

        public List<string> GetSuppotedCityString(string code)
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap12");
            return ws.getSupportCityString(code).ToList();
        }

        public DataSet GetSuppotedCityDS(string code)
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap12");
            return ws.getSupportCityDataset(code);
        }

        // this will popup error, because it is not compitable
        public List<string> GetWeather(string code)
        {
            WeatherSvc.WeatherWSSoapClient ws = new WeatherSvc.WeatherWSSoapClient("WeatherWSSoap");
            return ws.getWeather(code,null).ToList();
        }

        /*
         * Add Service Reference ---> Advanced
         * --> bottom Add Web Reference
         */
        public List<string> GetWeatherRev1(string code)
        {
            cn.com.webxml.www.WeatherWS ws = new WeatherWS();
            return ws.getWeather(code, "").ToList();
        }

        public string GetPM25(string cityName)
        {
            string cityPinYin = ChinesePY.GetPinYin(cityName);
            string sURL = "http://www.pm25.in/api/querys/pm2_5.json?city={0}&token=5j1znBVAsnSf5xQyNQyq";
            sURL = string.Format(sURL, cityPinYin);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
    }
}

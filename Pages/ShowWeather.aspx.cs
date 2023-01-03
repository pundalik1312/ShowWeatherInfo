using System;
using System.Drawing;
using System.Net;
using System.Web.Script.Serialization;


namespace ShowWeatherInfo.Pages
{
    public partial class ShowWeather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void showWeather_Click(object sender, EventArgs e)
        {
            if (txtCity.Text != string.Empty)
            {
                errLabel.Visible = false;
                errLabel.Text = "";
                string City = txtCity.Text;
                string appId = "384885c28ad209a656b006c2f7b8c1fa";
                var url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", City, appId);
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string json = client.DownloadString(url);

                        //********************//  
                        //     JSON RECIVED information   
                        //********************//  
                        //{"coord":{ "lon":72.85,"lat":19.01},  
                        //"weather":[{"id":711,"main":"Smoke","description":"smoke","icon":"50d"}],  
                        //"base":"stations",  
                        //"main":{"temp":31.75,"feels_like":31.51,"temp_min":31,"temp_max":32.22,"pressure":1014,"humidity":43},  
                        //"visibility":2500,  
                        //"wind":{"speed":4.1,"deg":140},  
                        //"clouds":{"all":0},  
                        //"dt":1578730750,  
                        //"sys":{"type":1,"id":9052,"country":"IN","sunrise":1578707041,"sunset":1578746875},  
                        //"timezone":19800,  
                        //"id":1275339,  
                        //"name":"Mumbai",  
                        //"cod":200}  

                        //Converting to OBJECT from JSON string.  
                        if (json != string.Empty)
                        {
                            RootObject weatherInfo = (new JavaScriptSerializer()).Deserialize<RootObject>(json);
                            lblCountry.Text = weatherInfo.sys.country;
                            lblCity.Text = weatherInfo.name;
                            lblLat.Text = Convert.ToString(weatherInfo.coord.lat);
                            lblLon.Text = Convert.ToString(weatherInfo.coord.lon);
                            lblDescription.Text = weatherInfo.weather[0].description;
                            lblHumidity.Text = Convert.ToString(weatherInfo.main.humidity);
                            lblTemp.Text = Convert.ToString(weatherInfo.main.temp);
                            lblTempFeelsLike.Text = Convert.ToString(weatherInfo.main.feels_like);
                            lblTempMin.Text = Convert.ToString(weatherInfo.main.temp_max);
                            lblTempMax.Text = Convert.ToString(weatherInfo.main.temp_min);
                        }
                        else
                        {
                            errLabel.Visible = true;
                            errLabel.Text = "Please enter valid city";
                            errLabel.ForeColor = Color.Red;
                        }
                    }
                    catch
                    {
                        errLabel.Visible = true;
                        errLabel.Text = "Please enter valid city";
                        errLabel.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                errLabel.Visible = true;
                errLabel.Text = "Please enter valid city";
                errLabel.ForeColor = Color.Red;
            }
        }
    }
}
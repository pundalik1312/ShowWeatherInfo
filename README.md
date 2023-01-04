# ShowWeatherInfo

Technology: C#. net, Asp.net web forms 
Hosted on : Azure web app
Dev-ops pipeline: Azure dev-ops
Weather API: https://openweathermap.org/
Code Repository: Git Hub
Demo Web site: https://showweather.azurewebsites.net/

Browse https://showweather.azurewebsites.net/
![image](https://user-images.githubusercontent.com/47704111/210596975-e865ce80-85f3-463b-9669-6ce55eef25eb.png)

Enter City name or zip code to get current weather information 

![image](https://user-images.githubusercontent.com/47704111/210597400-ac5fb0d7-155f-4cdd-8e25-0887fd8ef430.png)

![image](https://user-images.githubusercontent.com/47704111/210597535-7766d263-b566-45b8-bca9-63a95bdd28c4.png)


Code:
ShowWeather.aspx is a Home page of web application which takes city or zip code as input and after clicking on "Show Weather" Button it invokes API from https://openweathermap.org/ to get current weather information

API: http://api.openweathermap.org/data/2.5/weather
Parameter: 
     q : is to invoke weather info as per city name 
   zip : is to invoke weather info as per Zip code 
 APPID : Security token to authenticate API
 
 JSON Receiving after invoke:
        ********************//  
             JSON RECIVED information   
        ********************//  
        {"coord":{ "lon":72.85,"lat":19.01},  
        "weather":[{"id":711,"main":"Smoke","description":"smoke","icon":"50d"}],  
        "base":"stations",  
        "main":{"temp":31.75,"feels_like":31.51,"temp_min":31,"temp_max":32.22,"pressure":1014,"humidity":43},  
        "visibility":2500,  
        "wind":{"speed":4.1,"deg":140},  
        "clouds":{"all":0},  
        "dt":1578730750,  
        "sys":{"type":1,"id":9052,"country":"IN","sunrise":1578707041,"sunset":1578746875},  
        "timezone":19800,  
        "id":1275339,  
        "name":"Mumbai",  
        "cod":200}  
        
  WeatherClass.cs: is used to serialize JSON object in to C# object.
  
  Error handling: simple error handling with if else loop.
  
  Dev-Ops Pipeline:
  
  CI/CD pipeline created using azure dev-ops portal.
  Portal URL: https://dev.azure.com/WeatherDisplay/ShowWeather/_build?definitionId=5
  
  “ShowWeather-Azure Web App for ASP.NET-CI” pipe line is created to push data on azure web app after committing code in GIT repository.
  
  ![image](https://user-images.githubusercontent.com/47704111/210598310-beb8d55b-ae1d-418a-84ef-28b9e9cb01fa.png)
  
  ![image](https://user-images.githubusercontent.com/47704111/210598764-e767f673-0939-492c-a26f-b827b14d6d79.png)


  
  
  



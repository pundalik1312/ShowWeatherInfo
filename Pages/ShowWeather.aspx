<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowWeather.aspx.cs" Inherits="ShowWeatherInfo.Pages.ShowWeather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Weather</title>
    <style type="text/css">
        .form-style-9 {
            max-width: 450px;
            background: #FAFAFA;
            padding: 30px;
            margin: 50px auto;
            box-shadow: 1px 1px 25px rgba(0, 0, 0, 0.35);
            border-radius: 10px;
            border: 6px solid #305A72;
        }
    </style>
</head>
<body>

 <form id="form1" runat="server" class="form-style-9">
        <div>
            <h1>Welcome to Weather Portal: priya</h1>
        </div>
        <div>
            <div>
                <asp:TextBox runat="server" ID="txtCity" ></asp:TextBox> 
                <asp:Button ID="showWeather" Text="Show Weather" runat="server" OnClick="showWeather_Click" />
                <asp:Label ID="errLabel" runat="server" Visible="false" ></asp:Label>
            </div>
        </div>

        <div>
            <h2>Weather Info</h2>
            <table>
                <tr>
                    <td>
                        <strong>City: </strong>
                        <asp:Label runat="server" ID="lblCity"></asp:Label>
                        </td>
                    </tr>
                <tr>
                    <td>
                        <strong>Country: </strong>
                        <asp:Label runat="server" ID="lblCountry"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Latitude: </strong>
                        <asp:Label runat="server" ID="lblLat"></asp:Label>
                        <br />
                        <strong>Longitude: </strong>
                        <asp:Label runat="server" ID="lblLon"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Description:</strong>
                        <asp:Label runat="server" ID="lblDescription"></asp:Label>
                        <br />
                        <strong>Humidity:</strong>
                        <asp:Label runat="server" ID="lblHumidity"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Temperature (Feels Like) :</strong>
                        <asp:Label runat="server" ID="lblTempFeelsLike"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Temperature :</strong>
                        <asp:Label runat="server" ID="lblTemp"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Temperature (Min) :</strong>
                        <asp:Label runat="server" ID="lblTempMin"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>Temperature (Max) :</strong>
                        <asp:Label runat="server" ID="lblTempMax"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

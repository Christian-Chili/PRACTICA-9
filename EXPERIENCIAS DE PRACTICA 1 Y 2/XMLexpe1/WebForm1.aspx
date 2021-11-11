<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="XMLexpe1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="cmdReadXml" runat="server" OnClick="Button1_Click" Text="Crear XML" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="cdmReadXml" runat="server" Text="Leer XML (como texto)" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="cdmReadXmlAsObjects" runat="server" Text="Leer XML (como objeto)" />
        <br />
        <br />
        <asp:Label ID="lblXml" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gridResults" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
<?xml version="1.0" encoding="utf-8" ?> 

<Movies> 

<Movie> 

<Title>Shrek</Title> 

<Director>Andrew Adamson</Director> 

<Genre>0</Genre> 

<ReleaseDate>5/16/2001</ReleaseDate> 

<RunTime>89</RunTime> 

</Movie> 

<Movie> 

<Title>Fletch</Title> 

<Director>Michael Ritchie</Director> 

<Genre>0</Genre> 

<ReleaseDate>5/31/1985</ReleaseDate> 

<RunTime>96</RunTime> 

</Movie> 

<Movie> 

<Title>Casablanca</Title> 

<Director>Michael Curtiz</Director> 

<Genre>1</Genre> 

<ReleaseDate>1/1/1942</ReleaseDate> 

<RunTime>102</RunTime> 

</Movie> 

</Movies> 
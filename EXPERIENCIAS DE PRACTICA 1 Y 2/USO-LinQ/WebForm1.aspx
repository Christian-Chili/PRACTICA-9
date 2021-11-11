<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="USO_LinQ.WebForm1" %>

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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testWebform.aspx.cs" Inherits="OfficesServices.testWebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="GetEmployeers"></asp:Label>

        <asp:Button ID="Button1" runat="server" Text="GetEmployee"  />

    </div>
      <div>
          <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      </div>
    </form>
</body>
</html>

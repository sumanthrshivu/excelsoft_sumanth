# Cross Page posting
* The Cross Page posting technique allows a web form to post on another web form on button click. 
* The PostbackUrl property of the button is set to the page where you want to do cross-page posting.<br /><br />
**Example:**
page1.aspx
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>cross page posting</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <label>Name:</label>
        < asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <label>Dob:</label>
        < asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />
      < asp:Button ID="Button2" runat="server" Text="Submit" PostBackUrl="~/page2.aspx" /><br/>
    </form>
</body>
</html><br />
    page2.aspx
   <form id="form1" runat="server"> 
        <div> 
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
    
    

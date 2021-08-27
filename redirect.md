# Redirecting Techniques in ASP.Net

- Cross Page Posting 
- Response.Redirect 
- Server.Transer
- Server.Execute 

## Cross Page Posting
* The Cross Page posting technique allows a web form to post on another web form on button click. 
* The PostbackUrl property of the button is set to the page where you want to do cross-page posting.<br /><br />
**Example:**
   __page1.aspx__ <br />
   <form id="form1" runat="server">
        <label>Name:</label>
        < asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <label>Dob:</label>
        < asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />
      < asp:Button ID="Button2" runat="server" Text="Submit" PostBackUrl="~/page2.aspx" /><br/>
    </form><br />
   page2.aspx<br>
    < asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    
    protected void Page_Load(object sender, EventArgs e)<br />
        {<br/>
            TextBox textBox2; <br />
            Calendar calendar2;<br />
            textBox2 = (TextBox)PreviousPage.FindControl("TextBox1");<br />
            calendar2 = (Calendar)PreviousPage.FindControl("Calendar1");<br >
            Label1.Text = "Hi" + "  " + textBox2.Text + "  " + "Dob is" + calendar2.SelectedDate.ToString();<br />
        }<br />
    
---
## Response.Redirect
* It is one of the Redirecting technique in ASP.NET to move from one web form to another.
* In response.redirect the given URL is first sent to browser and browser will send request to that page.
* We can navigate to another URL using response.redirect either on the same server or a different server<br /><br />
**Example:**
   __page1.aspx__ <br />
        protected void Button1_Click(object sender, EventArgs e)<br />
        {<br />
            try{}<br/>
            catch(Exception ex){<br />
            Response.Redirect("page2.aspx"); // now the page2.aspx will execute<br />
            Response.Write("hello"); // this line won't execute unless its bool value set to false<br />
            }<br />
        }
        
---
## Server.Transer
* It transfers a current page request to another .aspx page on the same server.
* server.transfer is fast compare to response.redirect.<br/>
       **Example:**
   __page1.aspx__ <br />
        protected void Button1_Click(object sender, EventArgs e)<br />
        {<br />
            try{}<br/>
            catch(Exception ex){<br />
            Server.Transer("page2.aspx"); //browser url does not change<br />
            Response.Write("hello"); // this line won't execute unless its bool value set to false<br />
            }<br />
        } <br />
          page2.aspx<br />
          Server.Transer("www.google.com"); //Arguement Exception
        
---      
## Server.Execute
* It is similar to server.transfer but has a different behavior when doing the process
* here codes that are present after Server.Execute will  be executed since it process the page2 without terminating the page1<br />
**Example:**
   __page1.aspx__ <br />
 protected void Button1_Click(object sender, EventArgs e)<br />
        {<br />
        try{}<br/>
            catch(Exception ex){<br />
            Server.Execute("Page2.aspx");now the page2.aspx will execute<br />
            Response.Write("Two"); now this line will be executed after the completion of Server.Execute<br />
             }<br />
        }

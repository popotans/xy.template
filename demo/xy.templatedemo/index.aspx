<%@ Page Language="C#" Inherits="System.Web.UI.Page" %>

<% 
    /*
     * 功能描述：WebForm1
     * 作者:niejunhua
     * 日期:2017/1/10 17:50:59
	*/   
%>
<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Linq" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Threading" %>
<%@ Import Namespace="System.Threading.Tasks" %>

<script runat="server">
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\template.html";
        XY.Template.IHTemplate template = XY.Template.BuildManager.CreateTemplate(path);
        template.Context.TempData["title"] = "my template";
        List<Person> perlist = new List<Person>() { 
        new Person{ Name="张三", Age=22}, new Person{Name="李四s", Age=32}
        };
        template.Context.TempData["list"] = perlist;

        String rs = template.Render();
        Response.Write(rs);
    }
</script>

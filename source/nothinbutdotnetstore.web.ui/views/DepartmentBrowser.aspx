<%@ MasterType VirtualPath="Store.master" %>
<%@ Page Language="C#" AutoEventWireup="true" 
Inherits="nothinbutdotnetstore.web.ui.views.DepartmentBrowser"
CodeFile="DepartmentBrowser.aspx.cs"
 MasterPageFile="Store.master" %>
<%@ Import Namespace="nothinbutdotnetstore.web.application.catalogbrowsing" %>
<asp:Content ID="content" runat="server" ContentPlaceHolderID="childContentPlaceHolder">
    <p class="ListHead">Select An Department</p>
            <table>            
              <%-- for each department --%>
              <% foreach (var department in this.model)
                 {%>
              <tr class="ListItem">
               <td><a href="#"><%= department.name %></a></td>
           	  </tr>        
              <%
                 }%>
      	    </table>            
</asp:Content>
<asp:Content id="secondaryContent" runat="server" ContentPlaceHolderID="secondaryContentPlaceHolder">
<h1>ASDLFKJALSDKFJ</h1>
</asp:Content>
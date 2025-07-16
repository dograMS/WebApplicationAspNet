<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdminPanel.aspx.cs" Inherits="WebApplication2.AdminPanel" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="d-flex justify-content-end">
        <asp:Button ID="btnLogout" class="m-2 p-1 rounded-3 text-bg-primary" Text="logout" runat="server" OnClick="btnLogout_Click" />
    </div>
    <div class="d-flex justify-content-center align-items-center">
        <div class=" card p-4 shadow " style="width:500px">
            <h2 class="text-center">Admin Panel</h2>
          
                <div class="mb-3">
                  <label for="defaultT1" class="form-label">Default Page Text 1</label>
                  <asp:TextBox ID="defaultT1" runat="server" CssClass="form-control" rows="2" TextMode="MultiLine" style="width:100%;max-width:100%;" />
                </div>

                <div class="mb-3">
                  <label for="defaultT2" class="form-label">Default Page Text 2</label>
                  <asp:TextBox ID="defaultT2" runat="server" CssClass="form-control" rows="2"  TextMode="MultiLine" style="width:100%;max-width:100%;"/>
                </div>

                 <div class="mb-3">
                   <label for="headerT" class="form-label">Header Text</label>
                   <asp:TextBox ID="headerT" rows="2"  runat="server" CssClass="form-control" TextMode="MultiLine" style="width:100%;max-width:100%;"/>
                 </div>

                <div class="mb-3">
                  <label for="footerT" class="form-label">Footer Text</label>
                  <asp:TextBox ID="footerT" runat="server" CssClass="form-control" Rows="2"  TextMode="MultiLine" style="width:100%;max-width:100%;"/>
                </div>

                <div class="d-grid">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" style="width:100%;max-width:100%;"/>
                </div>


        </div>
    </div>

    

</asp:Content>

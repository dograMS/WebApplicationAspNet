<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="d-flex justify-content-center align-items-center" style="height: 70vh;">
        <div class="text-center align-content-center p-2">
            <h2>Login</h2>
            <asp:Login ID="Login1" runat="server" CssClass="card shadow p-5" OnAuthenticate="Login1_Authenticate">
    <LayoutTemplate>
        <div class="form-group mb-3">
    
            <asp:TextBox ID="UserName" runat="server" CssClass="form-control" placeholder="Username"/>
            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server"
                ControlToValidate="UserName" ErrorMessage="Username required" CssClass="text-danger" />
        </div>

        <div class="form-group">
            
            <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"/>
            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server"
                ControlToValidate="Password" ErrorMessage="Password required" CssClass="text-danger" />
        </div>

        <asp:Button ID="LoginButton" runat="server" CommandName="Login"
            Text="Log In" CssClass="btn btn-primary w-100" action />

        <div class="text-danger mt-2">
            <asp:Literal ID="FailureText" runat="server" EnableViewState="False" />
        </div>

        
    </LayoutTemplate>
</asp:Login>


        </div>
    </div>

    

</asp:Content>

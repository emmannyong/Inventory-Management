<%@ Page Title="" Language="C#" MasterPageFile="~/PreLogMaster.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="BugTrack.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='col-md-12'>
        <asp:Literal
            ID='LiteralText' 
            runat="server"  
            Text="">
        </asp:Literal>
    </div>
    <div class="col-md-4 col-md-offset-4">
        <div class="row">
            <div class="panel-group">
              <div class="panel panel-default">
                <div class="panel-heading">
                  <h4 class="panel-title">
                    <a data-toggle="collapse" href="#">Add New Admin Member</a>
                  </h4>
                </div>
                <div id="collapse1" class="panel-collapse collapse in">
                  <div class="panel-body">
                      <form id="form1" runat="server">
                        <div class="form-group">
                            <label for="email">Full Name:</label>
                            <asp:TextBox ID="fname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="email">eMail:</label>
                            <asp:TextBox ID="email" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="email">Username:</label>
                            <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="email">Password:</label>
                            <asp:TextBox TextMode="Password" ID="pass" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-12">
                            <label for="email">New User Role:</label><br />
                            <asp:DropDownList CssClass="form-control" ID="role" runat="server"
                                  AppendDataBoundItems="true">
                            <asp:ListItem Value="-1">Select</asp:ListItem>
                            <asp:ListItem Value="-1">Sales</asp:ListItem>
                            <asp:ListItem Value="-1">Stock</asp:ListItem>
                            <asp:ListItem Value="-1">Manager</asp:ListItem>
                            
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <br />
                            <asp:Button ID="Button1" CssClass="btn btn-primary col-lg-12" runat="server" Text="Register" OnClick="Button1_Click" />
                        </div>
                      </form>
                  </div>
                  
                </div>
              </div>
            </div>
        </div>
    </div>
</asp:Content>

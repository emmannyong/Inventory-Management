<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="stores.aspx.cs" Inherits="InventoryMgt.stores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class='col-md-12'>
        <asp:Literal
            ID='LiteralMsg' 
            runat="server"  
            Text="">
        </asp:Literal>
    </div>
    <div class="col-md-12">
        <div class="row">
            <div class="panel-group">
              <div class="panel panel-default">
                <div class="panel-heading">
                  <h4 class="panel-title">
                    <a data-toggle="collapse" href="#collapse1">Add New Store</a>
                  </h4>
                </div>
                <div id="collapse1" class="panel-collapse collapse">
                  <div class="panel-body">
                      <form id="form1" runat="server">
                        <div class="form-group col-md-6">
                            <label for="email">Project Name:</label>
                            <asp:TextBox ID="PrNam" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        
                        <div class="form-group col-md-6">
                            <br />
                            <asp:Button ID="Button1" CssClass="btn btn-primary col-lg-12" runat="server" Text="Add New Project" OnClick="Button1_Click" />
                        </div>
                      </form>
                  </div>
                  
                </div>
              </div>
            </div>
        </div>
    </div>
    <div><br /></div>
    <div class="col-md-12">
        <div class="row">
            <div class="panel-group">
              <div class="panel panel-default">
                <div class="panel-heading">
                  <h4 class="panel-title">
                    <a data-toggle="collapse" href="#">Bug Track Projects</a>
                  </h4>
                </div>
                <div id="collapse2" class="panel-collapse collapse in">
                  <div class="panel-body">
                      <asp:Literal
                            ID='LiteralText' 
                            runat="server"  
                            Text="">
                      </asp:Literal>
                  </div>
                </div>
              </div>
            </div>
        </div>
    </div>
</asp:Content>

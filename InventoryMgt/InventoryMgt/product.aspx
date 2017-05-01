<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="InventoryMgt.product1" %>
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

                   <a data-toggle="collapse" href="#collapse4">Manage Stock For Item </a>
                  </h4>
                </div>
                <div id="collapse4" class="panel-collapse collapse">
                  <div class="panel-body">
                      <form id="form3" runat="server">
                        <div class="form-group col-md-6">
                            <label for="email">Product ID:</label>
                            <asp:TextBox ID="rspid" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Name:</label>
                            <asp:TextBox ID="rspn" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-5">
                            <label for="email">Stock(Count):</label>
                            <asp:TextBox ID="rsst" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-2">
                            <label for="email">Action:</label><br />
                            <asp:DropDownList CssClass="form-control" required ID="act" runat="server"
                                  AppendDataBoundItems="true">
                            <asp:ListItem Value="">Select</asp:ListItem>
                            <asp:ListItem Value="add">Add</asp:ListItem>
                            <asp:ListItem Value="deduct">Deduct</asp:ListItem>
                            
                            </asp:DropDownList>
                        </div>
                        <div class="form-group col-md-5">
                            <label for="email">Incoming Quantity</label>
                            <asp:TextBox ID="newSt" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <br />
                            <asp:Button ID="Button3" CssClass="btn btn-primary col-lg-12" runat="server" Text="ReStock Product" OnClick="Button1_Click" />
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
                    <a data-toggle="collapse" href="#">Product Information</a>
                  </h4>
                </div>
                <div id="collapse2" class="panel-collapse collapse in">
                  <div class="panel-body">
                      <asp:Literal
                            ID='LiteralGo' 
                            runat="server"  
                            Text="">
                      </asp:Literal>
                      <asp:Literal
                            ID='LiteralInfo' 
                            runat="server"  
                            Text=" ">
                      </asp:Literal>
                  </div>
                </div>
              </div>
            </div>
        </div>
    </div>
</asp:Content>
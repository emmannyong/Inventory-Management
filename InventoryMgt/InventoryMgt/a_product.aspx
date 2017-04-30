<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="a_product.aspx.cs" Inherits="InventoryMgt.product" %>
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
                    <a data-toggle="collapse" href="#collapse3">Update Stock Details</a>
                  </h4>
                </div>
                <div id="collapse3" class="panel-collapse collapse">
                  <div class="panel-body">
                      <form id="form2" runat="server">
                        
                        <div class="form-group col-md-6">
                            <label for="email">Name:</label>
                            <asp:TextBox ID="pid" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Name:</label>
                            <asp:TextBox ID="pname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Stock(Count):</label>
                            <asp:TextBox ID="stock" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Store:</label><br />
                            <asp:DropDownList CssClass="form-control" ID="store" runat="server"
                                  AppendDataBoundItems="true">
                            <asp:ListItem Value="-1">Select</asp:ListItem>
                            
                            </asp:DropDownList>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Cost Price:</label>
                            <asp:TextBox ID="cost" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Selling Price:</label>
                            <asp:TextBox ID="sale" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Expiry:</label>
                            <asp:TextBox ID="exp" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        
                        <div class="form-group col-md-6">
                            <br />
                            <asp:Button ID="Button2" CssClass="btn btn-primary col-lg-12" runat="server" Text="Add New Project" OnClick="Button1_Click" />
                        </div>
                      </form>
                  </div>
                </div>
              </div>
            </div>
        </div>
    </div>
    <div class="col-md-12">
        <div class="row">
            <div class="panel-group">
              <div class="panel panel-default">
                <div class="panel-heading">
                  <h4 class="panel-title">
                    <a data-toggle="collapse" href="#collapse4">Manage Stock For Item <%= pname.Text %></a>
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
                            <p>+</p>
                        </div>
                        <div class="form-group col-md-5">
                            <label for="email">Add This Quantity</label>
                            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <br />
                            <asp:Button ID="Button3" CssClass="btn btn-primary col-lg-12" runat="server" Text="ReStock Product" OnClick="reStock_Click" />
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

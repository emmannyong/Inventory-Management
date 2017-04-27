<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="members.aspx.cs" Inherits="InventoryMgt.members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><br /></div>
    <div class="col-md-12">
        <div class="row">
            <div class="panel-group">
              <div class="panel panel-default">
                <div class="panel-heading">
                  <h4 class="panel-title">
                    <a data-toggle="collapse" href="#">Project Members</a>
                  </h4>
                </div>
                <div id="collapse2" class="panel-collapse collapse in">
                  <div class="panel-body">
                      <asp:Literal
                            ID='LiteralText' 
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

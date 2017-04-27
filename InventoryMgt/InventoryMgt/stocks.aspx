<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="stocks.aspx.cs" Inherits="BugTrack.bugs" %>
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
                    <a data-toggle="collapse" href="#collapse1">Add New Project To Bug Track</a>
                  </h4>
                </div>
                <div id="collapse1" class="panel-collapse collapse">
                  <div class="panel-body">
                      <form id="form1" runat="server">
                        
                        <div class="form-group col-md-6">
                            <label for="email">Name:</label>
                            <asp:TextBox ID="pname" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Error Message(Short):</label>
                            <asp:TextBox ID="stock" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Project:</label><br />
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
                            <label for="email">Class Name:</label>
                            <asp:TextBox ID="exp" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">On Line(s):</label>
                            <asp:TextBox ID="line" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="email">Previously Checked At:</label>
                            <asp:TextBox ID="link2" CssClass="form-control" runat="server"></asp:TextBox>
                            <small>Enter Related Bug BugCode Or Generate New BugCode For this Bug</small>
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
                            Text=" ">
                      </asp:Literal>
                  </div>
                </div>
              </div>
            </div>
        </div>
    </div>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
<script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
<link href="Content/css/calendar-blue.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#exp").dynDateTime({
            showsTime: true,
            ifFormat: "%Y/%m/%d %H:%M",
            daFormat: "%l;%M %p, %e %m, %Y",
            align: "BR",
            electric: false,
            singleClick: false,
            displayArea: ".siblings('.dtcDisplayArea')",
            button: ".next()"
        });
    });
</script>
</asp:Content>

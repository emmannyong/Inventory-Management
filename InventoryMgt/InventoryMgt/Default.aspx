<%@ Page Title="" Language="C#" MasterPageFile="~/PreLogMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InventoryMgt.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
            <div class="row carousel-holder">
                <div class="col-md-12">
                    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner">
                            <div class="item active">
                                <img style="height:500px" class="img-responsive slide-image" src="Content/p1.jpg" alt="" />
                            </div>
                            <div class="item">
                                <img style="height:500px" class="img-responsive slide-image" src="Content/p3.jpg" alt="" />
                            </div>
                            <div class="item">
                                <img style="height:500px" class="img-responsive slide-image" src="Content/p2.jpg" alt="" />
                            </div>
                        </div>
                        <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </a>
                        <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-12">
            <a class="col-md-12 btn btn-primary btn-md" href="/login.aspx"> Get Started </a>
        </div>
</asp:Content>

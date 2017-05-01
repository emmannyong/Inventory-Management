<%@ Page Title="" Language="C#" MasterPageFile="~/Prelogin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PatientApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="image-bg-fluid-height">
        <img class="img-responsive img-center" src="http://placehold.it/200x200&text=Logo" alt="">
    </header>

    <!-- Content Section -->
    <section>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="section-heading">Section Heading</h1>
                    <p class="lead section-lead">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</p>
                    <p class="section-paragraph">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid, suscipit, rerum quos facilis repellat architecto commodi officia atque nemo facere eum non illo voluptatem quae delectus odit vel itaque amet.</p>
                    <div class="row">
                      <div class="col-md-4">
                        <a class="thumbnail" href="/login.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                      </div>          
                      <div class="col-md-4">
                        <a class="thumbnail" href="/register.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                      </div>
                      <div class="col-md-4">
                        <a class="thumbnail" href="/about.aspx"><img alt="" src="http://placehold.it/150x150"></a>
                      </div>        
                   </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

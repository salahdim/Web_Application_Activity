<%@ Page Title="" Language="C#" MasterPageFile="~/Mail/Mail.Master" AutoEventWireup="true" CodeBehind="ReadMailSent.aspx.cs" Inherits="Web_Application_Activity.Mail.ReadMailSent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="nav_menu" runat="server">
    
<section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
            <asp:Image ID="Image1" runat="server" class="img-circle" alt="User Image" />
        </div>
        <div class="pull-left info">
          <p>
        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label> </p>
          <a href="#"><i class="fa fa-circle text-success"></i> Online</a>
        </div>
      </div>
      <!-- search form -->
   
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      <ul class="sidebar-menu">
        <li class="header">MAIN NAVIGATION</li>
       <li>
          <a href="../Home/HomePage.aspx">
            <i class="fa fa-dashboard" ></i> <span>Accueil</span> 
          </a>
          
        </li>
        
        <li>
          <a href="../Tableau_De_Bord/TableauDeBord.aspx">
            <i class="fa fa-th"></i> <span>Tableau De Bord</span>
            <small class="label pull-right bg-green">new</small>
          </a>
        </li>
           <li>
          <a href="../Profil/Profil.aspx">
            <i class="fa fa-fw fa-user"></i> <span>Profil</span>
          </a>
        </li>
          <li class="treeview">
          <a href="../Support Voyageur/Support.aspx">
            <i class="fa fa-fw fa-plane"></i> <span>Support Voyageur</span>
          </a>
        </li>
         <li class="treeview">
          <a href="../Charts/ChartJs.aspx">
            <i class="fa fa-pie-chart"></i>
            <span>Les Graphiques</span>
          </a>
          
        </li>
        
       
        
        <li>
          <a href="../Calendar/Calendar.aspx">
            <i class="fa fa-calendar"></i> <span>Calendar</span>
            <small class="label pull-right bg-red"></small>
          </a>
        </li>
        <li class="active treeview">
          <a href="#" class="active">
            <i class="fa fa-envelope"></i> <span>Mailbox</span>
            <small class="label pull-right bg-yellow"></small>
            <i class="fa fa-angle-left pull-right"></i>

          </a>
            <ul class="treeview-menu">
            <li ><a href="../Mail/Compose.aspx"><i class="fa fa-circle-o"></i> Nouveau Message</a></li>
            <li><a href="../Mail/Inbox.aspx"><i class="fa fa-circle-o"></i> Boîte de réception</a></li>
            <li class="active"><a href="../Mail/Sent.aspx"><i class="fa fa-circle-o"></i> Messages envoyés</a></li>
          </ul>
        </li>
        
        
        
      </ul>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form runat="server">
    <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Lire le courier
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Accueil</a></li>
        <li class="active">Mailbox</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-md-3">
          <a href="../Mail/Compose.aspx" class="btn btn-primary btn-block margin-bottom">Nouveau Message</a>

          <div class="box box-solid">
            <div class="box-header with-border">
              <h3 class="box-title">Folders</h3>

              <div class="box-tools">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
              </div>
            </div>
            <div class="box-body no-padding">
              <ul class="nav nav-pills nav-stacked">
                <li class="active"><a href="#"><i class="fa fa-inbox"></i> Boîte de réception
                <li><a href="#"><i class="fa fa-envelope-o"></i> Messages envoyés</a></li>
                
              </ul>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /. box -->
          <div class="box box-solid">
            <div class="box-header with-border">
              <h3 class="box-title">Labels</h3>

              <div class="box-tools">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
              </div>
            </div>
            <div class="box-body no-padding">
              <ul class="nav nav-pills nav-stacked">
                <li><a href="#"><i class="fa fa-circle-o text-red"></i> Important</a></li>
                <li><a href="#"><i class="fa fa-circle-o text-yellow"></i> Promotions</a></li>
                <li><a href="#"><i class="fa fa-circle-o text-light-blue"></i> Social</a></li>
              </ul>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class="col-md-9">
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Lire le courier</h3>

              
            </div>
            <!-- /.box-header -->
            <div class="box-body no-padding">
              <div class="mailbox-read-info">
                <asp:Label ID="LabelSubject" runat="server" Text="Subject"></asp:Label>
                <h5>From: <asp:Label ID="LabelMail" runat="server" Text="Email"></asp:Label>
                  <span class="mailbox-read-time pull-right"><asp:Label ID="LabelDate" runat="server" Text="Date"></asp:Label></span></h5>
              </div>
              <!-- /.mailbox-read-info -->
              <div class="mailbox-controls with-border text-center">
                <div class="btn-group">
                 
                </div>
                <!-- /.btn-group -->
                
              </div>
              <!-- /.mailbox-controls -->
              <div class="mailbox-read-message">
                <asp:Label ID="LabelContent" runat="server" Text="Content"></asp:Label>
              </div>
              <!-- /.mailbox-read-message -->
            </div>
            <!-- /.box-body -->
            <div class="box-footer">

              <ul class="mailbox-attachments clearfix">
       <!--         <li>
                  <span class="mailbox-attachment-icon"><i class="fa fa-file-pdf-o"></i></span>

                  <div class="mailbox-attachment-info">

                    <a href="#" class="mailbox-attachment-name"><i class="fa fa-paperclip"></i> Sep2014-report.pdf</a>
                        <span class="mailbox-attachment-size">
                          1,245 KB
                          <a href="#" class="btn btn-default btn-xs pull-right"><i class="fa fa-cloud-download"></i></a>
                        </span>
                  </div>
                </li>
                  -->
                  
                
                  
                <li>
                  <span class="mailbox-attachment-icon has-img"><asp:Image ID="Image2" runat="server" AlternateText="Attachment" /></span>
                        
                  <div class="mailbox-attachment-info">
                    <a href="#" class="mailbox-attachment-name"><i class="fa fa-camera"></i> photo1.png</a>
                        <span class="mailbox-attachment-size">
                          2.67 MB
                        </span>
                  </div>
                </li>
                
              </ul>

       <asp:GridView ID="GridView1" runat="server"  BorderColor="White"  AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="filename" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Large"/>
        <asp:TemplateField ItemStyle-HorizontalAlign="Center">

            <ItemTemplate>
                                    <span class="mailbox-attachment-icon"><i class="fa fa-file-pdf-o"></i>

                <asp:LinkButton ID="lnkView" runat="server" Text="view" OnClick="View" CommandArgument='<%# Eval("id") %>'></asp:LinkButton>
            
                  </span>

                </ItemTemplate>

        </asp:TemplateField>
    </Columns>
</asp:GridView>
<hr />
<div>
    <asp:Literal ID="ltEmbed" runat="server" />
</div>

            </div>
            <!-- /.box-footer -->
            <div class="box-footer">
               
              <asp:Button runat="server" OnClick="DoSQLQueryDelete" Text="Delete" class="btn btn-default" ></asp:Button>

            </div>




            <!-- /.box-footer -->
          </div>
          <!-- /. box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
  </div>
        </form>

</asp:Content>

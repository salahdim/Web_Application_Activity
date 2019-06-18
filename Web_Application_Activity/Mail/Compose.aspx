<%@ Page Title="" Language="C#" MasterPageFile="~/Mail/Mail.Master" AutoEventWireup="true" CodeBehind="Compose.aspx.cs" Inherits="Web_Application_Activity.Mail.Compose" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
      <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        
        <small></small>
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
          <a href="../Mail/Inbox.aspx" class="btn btn-primary btn-block margin-bottom">Retour à la boîte de réception</a>

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
                <li><a href="../Mail/Inbox.aspx"><i class="fa fa-inbox"></i>Boîte de réception
        <!--          <span class="label label-primary pull-right">12</span>--></a></li> 
                <li><a href="../Mail/Sent.aspx"><i class="fa fa-envelope-o"></i> Messages envoyés</a></li>
               
              </ul>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /. box -->
          <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class="col-md-9">
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Nouveau Message</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <div class="form-group">
                <asp:TextBox ID="TextTo" runat="server" class="form-control" placeholder="To:"></asp:TextBox>
              </div>
              <div class="form-group">
                <asp:TextBox ID="TextSubject" runat="server" class="form-control" placeholder="Subject:"></asp:TextBox>

              </div>
              <div class="form-group">
          <asp:TextBox ID="TextContent" runat="server" TextMode="MultiLine" class="form-control" style="height: 300px" placeholder="Please enter your message:"></asp:TextBox>

                      


              </div>
              <div class="form-group">
                <div class="btn btn-default btn-file">
                  <i class="fa fa-paperclip"></i> Attachment
                              <asp:FileUpload ID="Textattachment" runat="server" name="attachment" />

                </div>
                <p class="help-block">Max. 4GB</p>
              </div>


            </div>
            <!-- /.box-body -->
            <div class="box-footer">
              <div class="pull-right">
                <asp:Button ID="Button1" runat="server" class="btn btn-primary"  Text="Envoyer" OnClick="SendEmail"  />
                
               
              </div>

             <button type="reset" runat="server" class="btn btn-default"><i class="fa fa-times"></i> Vider</button>
             <asp:Button ID="Button2" runat="server" class="btn btn-default"  Text="Actualiser" OnClick="SendRefrech"  />

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

<asp:Content ID="Content3" ContentPlaceHolderID="nav_menu" runat="server">

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
            <i class="fa fa-dashboard" ></i> <span>Home</span> 
          </a>
          
        </li>
        
        <li>
          <a href="../Tableau_De_Bord/TableauDeBord.aspx">
            <i class="fa fa-th"></i> <span>Les Activités</span>
            <small class="label pull-right bg-green">new</small>
          </a>
        </li>

           <li class="treeview">
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
            <span>Les Statistiques</span>
          </a>
          
        </li>
        
       
        
        <li>
          <a href="../Calendar/Calendar.aspx">
            <i class="fa fa-calendar"></i> <span>Calendrier</span>
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
            <li class="active"><a href="../Mail/Compose.aspx"><i class="fa fa-circle-o"></i> Nouveau Message</a></li>
            <li><a href="../Mail/Inbox.aspx"><i class="fa fa-circle-o"></i> Boîte de réception</a></li>
            <li><a href="../Mail/Sent.aspx"><i class="fa fa-circle-o"></i> Messages envoyés</a></li>
          </ul>
        </li>
        
        
        
      </ul>
    </section>
    <!-- /.sidebar -->
  
</asp:Content>

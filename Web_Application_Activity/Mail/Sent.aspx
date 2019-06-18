<%@ Page Title="" Language="C#" MasterPageFile="~/Mail/Mail.Master" AutoEventWireup="true" CodeBehind="Sent.aspx.cs" Inherits="Web_Application_Activity.Mail.Sent" %>
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
      <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Messages envoyés
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
                <li><a href="../Mail/Inbox.aspx" ><i class="fa fa-inbox"></i> Boîte de réception
              <!--    <span class="label label-primary pull-right">12</span>
                    -->
                    </a></li>
                <li class="active"><a href="../Mail/Sent.aspx"><i class="fa fa-envelope-o"></i> Messages envoyés</a></li>
               
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
              <h3 class="box-title">Messages envoyés</h3>

              <div class="box-tools pull-right">
                <div class="has-feedback">
                  <input type="text" class="form-control input-sm" placeholder="Search Mail">
                  <span class="glyphicon glyphicon-search form-control-feedback"></span>
                </div>
              </div>
              <!-- /.box-tools -->
            </div>
            <!-- /.box-header -->
            <div class="box-body no-padding">
              <div class="mailbox-controls">
                <!-- Check all button -->
                
                
                <!-- /.btn-group -->
               
                <!-- /.pull-right -->
              </div>
              <div class="table-responsive mailbox-messages">


                
                


        <asp:DataGrid ID="MyDataGrid" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                PageSize="5000"
                ForeColor="#333333"
                GridLines="Vertical"
                AutoGenerateColumns="False"
                AllowSorting="True" 
                class="table table-bordered table-hover"
           >
               
     
            <Columns  >
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:ButtonColumn DataTextField="emailTo" HeaderText="Email"  ButtonType="LinkButton" />
                    <asp:ButtonColumn DataTextField="subject" HeaderText="Subject" HeaderStyle-Width="800px" ButtonType="LinkButton" />
                    <asp:BoundColumn HeaderText="Date"  DataField="date">
                    </asp:BoundColumn>

                    </Columns>
                <AlternatingItemStyle BackColor="#d6f8ff" />

                <HeaderStyle  Font-Bold="True" BackColor="#d6f8ff" BorderStyle="None"  />

            </asp:DataGrid>
                  <p><asp:Label id="lblMessage" runat="server" /></p> 

 


                <!-- /.table -->
              </div>
              <!-- /.mail-box-messages -->
            </div>
            <!-- /.box-body -->
            <div class="box-footer no-padding">
              <div class="mailbox-controls">
                <!-- Check all button -->
               
                <!-- /.btn-group -->
                
                <!-- /.pull-right -->
              </div>
            </div>
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

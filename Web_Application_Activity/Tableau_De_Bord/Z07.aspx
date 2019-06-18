<%@ Page Title="" Language="C#" MasterPageFile="~/Tableau_De_Bord/Details.Master" AutoEventWireup="true" CodeBehind="Z07.aspx.cs" Inherits="Web_Application_Activity.Tableau_De_Bord.Z07" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
                <title>Les Activités</title>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentHeader" runat="server">
                <div class="box-body">
              <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                  <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                  <li data-target="#carousel-example-generic" data-slide-to="1" class=""></li>
                  <li data-target="#carousel-example-generic" data-slide-to="2" class=""></li>

                </ol>
                <div class="carousel-inner">
                  <div class="item active">
                    <img src="http://placehold.it/1650x250/39CCCC/ffffff&text=Bienvenue+Dans+Business+Report" alt="Première diapositive">
                    <div class="carousel-caption">
                      <!-- Première diapositive -->
                    </div>
                  </div>
                     <div class="item">
                    <img src="http://placehold.it/1650x250/39CCCC/ffffff&text=<% =secteur %>" alt="Deuxième diapositive">
                                                                  <!--  -->

                    <div class="carousel-caption">
                     <!-- Deuxième diapositive -->
                    </div>
                  </div>
                  <div class="item">
                   <img src="http://placehold.it/1650x250/39CCCC/ffffff&text=tableau+de+<% = z07 %>" alt="Troisième diapositive">


                    <div class="carousel-caption">
                    <!--  Troisième diapositive -->
                    </div>
                  </div>
                   
                </div>
                <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                  <span class="fa fa-angle-left"></span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                  <span class="fa fa-angle-right"></span>
                </a>
              </div>
            </div>

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
      <form action="#" method="get" class="sidebar-form">
        <div class="input-group">
          <input type="text" name="q" class="form-control" placeholder="Search...">
              <span class="input-group-btn">
                <button type="submit" name="search" id="search-btn" class="btn btn-flat"><i class="fa fa-search"></i>
                </button>
              </span>
        </div>
      </form>
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
       <ul class="sidebar-menu">
        <li class="header">MAIN NAVIGATION</li>
          <li >
          <a href="../Home/HomePage.aspx" >
            <i class="fa fa-dashboard" ></i> <span>Accueil</span> 
          </a>
          
        </li>
        
        <li class="active treeview">
          <a href="../../Tableau_De_Bord/TableauDeBord.aspx" >
            <i class="fa fa-th"></i> <span>Les Activités</span>
            <small class="label pull-right bg-green">new</small>

          </a>
            <ul class="treeview-menu">
            <li><a href="../../Tableau_De_Bord/Z01.aspx"><i class="fa fa-circle-o"></i><asp:Label ID="LabelT1" runat="server" Text="t1"></asp:Label> </a></li>
            <li><a href="../../Tableau_De_Bord/Z02.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT2" runat="server" Text="t2"></asp:Label></a></li>
            <li><a href="../../Tableau_De_Bord/Z03.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT3" runat="server" Text="t3"></asp:Label></a></li>
            <li><a href="../../Tableau_De_Bord/Z04.aspx"><i class="fa fa-circle-o"></i><asp:Label ID="LabelT4" runat="server" Text="t4"></asp:Label> </a></li>
            <li><a href="../../Tableau_De_Bord/Z05.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT5" runat="server" Text="t5"></asp:Label></a></li>
            <li><a href="../../Tableau_De_Bord/Z06.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT6" runat="server" Text="t6"></asp:Label></a></li>
            <li class="active"><a href="../../Tableau_De_Bord/Z07.aspx"><i class="fa fa-circle-o"></i><asp:Label ID="LabelT7" runat="server" Text="t7"></asp:Label> </a></li>
            <li><a href="../../Tableau_De_Bord/Z08.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT8" runat="server" Text="t8"></asp:Label></a></li>
            <li><a href="../../Tableau_De_Bord/Z09.aspx"><i class="fa fa-circle-o"></i> <asp:Label ID="LabelT9" runat="server" Text="t9"></asp:Label></a></li>
            <li><a href="../../Tableau_De_Bord/Z10.aspx"><i class="fa fa-circle-o"></i><asp:Label ID="LabelT10" runat="server" Text="t10"></asp:Label> </a></li>
          </ul>
        </li>
           <li class="treeview">
          <a href="../Profil/Profil.aspx" >
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
        <li>
          <a >
            <i class="fa fa-envelope"></i> <span>Mailbox</span>
            <small class="label pull-right bg-yellow"></small>
            <i class="fa fa-angle-left pull-right"></i>

          </a>
            <ul class="treeview-menu">
            <li><a href="../Mail/Compose.aspx"><i class="fa fa-circle-o"></i> Nouveau Message</a></li>
            <li><a href="../Mail/Inbox.aspx"><i class="fa fa-circle-o"></i> Boîte de réception</a></li>
            <li><a href="../Mail/Sent.aspx"><i class="fa fa-circle-o"></i> Messages envoyés</a></li>
          </ul>
        </li>

    </ul>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tableNom" runat="server">
       <section class="content-header">
      <h1>
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Accueil</a></li>
        <li><a href="#">Les Activités</a></li>
        <li class="active"><asp:Label ID="LabelZ07" runat="server" Text="Label"></asp:Label></li>
      </ol>
    </section>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <div class="row">
        <div class="col-xs-12">
          <!-- /.box -->

          <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">


    <form id="form2" runat="server">
        <asp:DataGrid ID="DataGrid7" runat="server" PageSize="20" AllowPaging="True" 
AutoGenerateColumns="False" CellPadding="20" ForeColor="#333333" GridLines="Vertical"  AllowSorting="True" class="table table-bordered table-hover" OnPageIndexChanged="Grid_PageIndexChanged"  >
                    
            
            <Columns >
                
                     
                    <asp:BoundColumn  DataField="t1" >
                    </asp:BoundColumn>
                    <asp:BoundColumn  DataField="t2">
                    </asp:BoundColumn>
                    <asp:BoundColumn  DataField="t3">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t4" >
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t5" >
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t6" >
                    </asp:BoundColumn>
                    <asp:BoundColumn  DataField="t7">
                    </asp:BoundColumn>
                    <asp:BoundColumn  DataField="t8">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t9">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t10" >
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t11" >
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t12" >
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="t13">
                    </asp:BoundColumn>
                   

                    </Columns>
                 <FooterStyle BackColor="#333333" Font-Bold="True" ForeColor="#333333" BorderStyle="Solid" />
                <SelectedItemStyle  Font-Bold="True" ForeColor="Navy" />
                <PagerStyle BackColor="#d6f8ff" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages"  />
                <AlternatingItemStyle  />
                <ItemStyle ForeColor="#333333" BorderStyle="Groove" />
                <HeaderStyle  Font-Bold="True" BackColor="#d6f8ff" BorderStyle="None"  />

            </asp:DataGrid>
                    </form>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>

</asp:Content>


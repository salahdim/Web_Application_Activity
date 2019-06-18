<%@ Page Title="" Language="C#" MasterPageFile="~/Tableau_De_Bord/TableauDeBord.Master" AutoEventWireup="true" CodeBehind="TableauDeBord.aspx.cs" Inherits="Web_Application_Activity.TableauDeBord" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Les Activités</title>

    </asp:Content>








<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="row">
                <div class="text-center">
                    <h1><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h1>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="well">
                     <!--       <img  class="thumbnail img-responsive" alt="Bootstrap template" src="http://www.prepbootstrap.com/Content/images/shared/houses/h9.jpg" />  -->
                                         <asp:Image ID="ImageDate" class="thumbnail img-responsive" runat="server" />

                               <h2><a href="#"><asp:Label ID="Label13" runat="server" Text="Date"></asp:Label></a></h2> 
                        		<span class="solid-line"></span>

                                <asp:Label ID="Label1" runat="server" Text="lastmaj"></asp:Label>
                                                        
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z01.aspx" ><asp:Image ID="ImageC11" class="thumbnail img-responsive"  runat="server" /></a>
                          <h2 ><a href="../Tableau_De_Bord/Z01.aspx" ><asp:Label ID="Label3" runat="server" Text="t01"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label15" runat="server" Text="01"></asp:Label>
                                    <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                             <a href="../Tableau_De_Bord/Z02.aspx" ><asp:Image ID="ImageC12" class="thumbnail img-responsive"  runat="server" /></a>
                           
                            <h2><a href="../Tableau_De_Bord/Z02.aspx" ><asp:Label ID="Label4" runat="server" Text="t02"></asp:Label> </a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label16" runat="server" Text="02"></asp:Label>
	                            <br />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z03.aspx" ><asp:Image ID="ImageC21" class="thumbnail img-responsive"  runat="server" /></a>
                            
                            <h2><a href="../Tableau_De_Bord/Z03.aspx" ><asp:Label ID="Label5" runat="server" Text="t03"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label17" runat="server" Text="03"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                             <a href="../Tableau_De_Bord/Z04.aspx" ><asp:Image ID="ImageC22" class="thumbnail img-responsive"  runat="server" /></a>
                           
                            <h2><a href="../Tableau_De_Bord/Z04.aspx" ><asp:Label ID="Label6" runat="server" Text="t04"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label18" runat="server" Text="04"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z05.aspx" ><asp:Image ID="ImageC31" class="thumbnail img-responsive"  runat="server" /></a>
                           
                             <h2><a href="../Tableau_De_Bord/Z05.aspx" ><asp:Label ID="Label7" runat="server" Text="t05"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label19" runat="server" Text="05"></asp:Label>
                            <br />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <div class="well">
                             <a href="../Tableau_De_Bord/Z06.aspx" ><asp:Image ID="ImageC32" class="thumbnail img-responsive"  runat="server" /></a>
                           
                           <h2><a href="../Tableau_De_Bord/Z06.aspx" ><asp:Label ID="Label8" runat="server" Text="t06"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label20" runat="server" Text="06"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z07.aspx" ><asp:Image ID="ImageC41" class="thumbnail img-responsive"  runat="server" /></a>
                            
                            <h2><a href="../Tableau_De_Bord/Z07.aspx" ><asp:Label ID="Label9" runat="server" Text="t07"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label21" runat="server" Text="07"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z08.aspx"><asp:Image ID="ImageC42" class="thumbnail img-responsive"  runat="server" /></a>
                            
                            <h2><a href="../Tableau_De_Bord/Z08.aspx"><asp:Label ID="Label10" runat="server" Text="t08"></asp:Label></a></h2>
							<span class="solid-line"></span>
                            <asp:Label ID="Label22" runat="server" Text="08"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z09.aspx"><asp:Image ID="ImageC51" class="thumbnail img-responsive"  runat="server" /></a>
                            
                            <h3><a href="../Tableau_De_Bord/Z09.aspx"><asp:Label ID="Label11" runat="server" Text="t09"></asp:Label></a></h3>
							<span class="solid-line"></span>
                            <asp:Label ID="Label23" runat="server" Text="09"></asp:Label>
                            <br />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="well">
                            <a href="../Tableau_De_Bord/Z10.aspx" ><asp:Image ID="ImageC52" class="thumbnail img-responsive"  runat="server" /></a>
                            
                            <h3><a href="../Tableau_De_Bord/Z10.aspx" ><asp:Label ID="Label12" runat="server" Text="t10"></asp:Label></a></h3>
							<span class="solid-line"></span>
                            <asp:Label ID="Label24" runat="server" Text="10"></asp:Label>
                            <br />
                        </div>
                    </div>
                </div>
          </div>
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
          <li >
          <a href="../Home/HomePage.aspx" >
            <i class="fa fa-dashboard" ></i> <span>Accueil</span> 
          </a>
          
        </li>
        
        <li class="active treeview">
          <a href="../Tableau_De_Bord/TableauDeBord.aspx" class="active">
            <i class="fa fa-th"></i> <span>Les Activités</span>
            <small class="label pull-right bg-green">new</small>
          </a>
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







       
        
        
        
       
       
      </ul>    </section>
    <!-- /.sidebar -->
  
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Profil/Profil.Master" AutoEventWireup="true" CodeBehind="ProfilAmis.aspx.cs" Inherits="Web_Application_Activity.Profil.ProfilAmis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Le Profil de mon collegue</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="nav_menu" runat="server">
    
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
          <asp:Image ID="Image2" runat="server" class="img-circle" alt="User Image" />

        </div>
        <div class="pull-left info">
          <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </p>
          <a href="#"><i class="fa fa-circle text-success"></i> En ligne</a>
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
        
        <li>
          <a href="../Tableau_De_Bord/TableauDeBord.aspx">
            <i class="fa fa-th"></i> <span>Les Activités</span>
            <small class="label pull-right bg-green">new</small>
          </a>
        </li>
           <li class="active treeview">
          <a href="../Profil/Profil.aspx" class="active">
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
          <a href="#">
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
    <!-- /.sidebar -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form runat="server" class="form-horizontal">


     <div class="row">
        <div class="col-md-3">

          <!-- Profile Image -->
          <div class="box box-primary">
            <div class="box-body box-profile">
                <asp:Image ID="Image1" runat="server" class="profile-user-img img-responsive img-circle"  alt="User profile picture" />
              <h3 class="profile-username text-center"><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></h3>

              <p class="text-muted text-center">
                  <asp:Label ID="LabelDetail" runat="server" Text="detail"></asp:Label></p>

                <asp:Button ID="ButtonAmis" runat="server" class="btn btn-block btn-primary btn-lg" OnClick="UpdateNbrAmis" Text="Ajouter un(e) nouveau partenaire" />
              <ul class="list-group list-group-unbordered">
                <li class="list-group-item">
                  <b>UserName</b> <a class="pull-right">
         <asp:Label ID="LabelUname" runat="server" Text="Label"></asp:Label> </a>
                </li>
                <li class="list-group-item">
                  <b>First Name</b> <a class="pull-right">
             <asp:Label ID="LabelFirst" runat="server" Text="Label"></asp:Label> </a>
                </li>
                <li class="list-group-item">
                  <b>Last Name</b> <a class="pull-right">
                 <asp:Label ID="LabelLast" runat="server" Text="Label"></asp:Label> </a>
                </li>
                   <li class="list-group-item">
                  <b>Email</b> <a class="pull-right">
                     <asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label> </a>
                </li>
                  <li class="list-group-item">
                  <b>Age</b> <a class="pull-right">
                         <asp:Label ID="LabelAge" runat="server" Text="Label"></asp:Label> </a>
                </li>
              </ul>
                

            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          <!-- About Me Box -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">About Me</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
             <h4> <strong><i class="fa fa-book margin-r-5"></i> Education</strong></h4>

              <p class="text-muted">
                <asp:Label ID="LabelEducation" runat="server" Text=""></asp:Label>
              </p>

              <hr>

              <h4><strong><i class="fa fa-map-marker margin-r-5"></i> Location</strong></h4>

              <p class="text-muted">
                  <asp:Label ID="LabelLocation" runat="server" Text=""></asp:Label></p>

              <hr>

                <asp:GridView ID="GridView1" runat="server"  BorderColor="White" AutoGenerateColumns="false">
    <Columns>
       
        <asp:BoundField DataField="name" HeaderText="compétence"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
         <asp:TemplateField ItemStyle-HorizontalAlign="Center">

            <ItemTemplate>
                <span class="label label-success">
<i class="fa fa-pencil margin-r-5"></i>

            
                  </span>

                </ItemTemplate>

        </asp:TemplateField>
    </Columns>
                    
</asp:GridView>
                <hr />
            
                <asp:Button ID="ButtonDesactiver" runat="server" Text="Désactivation de Compte" class="btn btn-block btn-danger btn-lg" OnClick="DesactiverCompte"  Font-Bold="true"  />
                <asp:Button ID="ButtonActiver" runat="server" Text="Activer le Compte" class="btn btn-block btn-success btn-lg" OnClick="ActiverCompte"  Font-Bold="true" />
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class="col-md-9">
          <div class="nav-tabs-custom">
            <ul class="nav nav-tabs">
              <li class="active"><a href="#activity" data-toggle="tab">Journal</a></li>
    
 


            </ul>
            <div class="tab-content">
              <div class="active tab-pane" id="activity">
                <!-- Post -->



<asp:DataGrid ID="MyDataGrid" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
               
     
            <Columns  >
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Sorties"   />
                    
                
                    </Columns>
                </asp:DataGrid>

<hr />
<asp:DataGrid ID="DataGrid1" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    
            <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Sports"   />

            </Columns>
    


  

    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid2" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
      <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Arts ou artisanat"   />

            </Columns>

   


    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid3" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Travail, réparation, rénovation"   />

            </Columns>
    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid4" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
      <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Jeux"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid5" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Lire et écrire"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid6" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large"  HeaderStyle-Width="1100px" HeaderText="Vêtements"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid7" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Rendre service"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid8" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Alimentation"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid9" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Sujets de conversations"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid10" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Activités mentales"   />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid11" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="gouter à un plaisir simple"   />

            </Columns>

    
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid12" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Spiritualité"   />

            </Columns>

   
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid13" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Être avec d'autres"   />

            </Columns>

    
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid14" runat="server"
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Développer de nouvelles habiletés"   />
        

            </Columns> 
 
    </asp:DataGrid>






                <!-- /.post -->
                <!-- Post -->
               

                <!-- /.post -->
      <!-- /.example-modal -->
      <!-- /.example-modal -->

                <!-- Post -->
                <!-- /.post -->
              </div>
              <!-- /.tab-pane -->
              <!-- /.tab-pane -->
              <!-- /.tab-pane -->
          
            </div>
            <!-- /.tab-content -->
          </div>
          <!-- /.nav-tabs-custom -->
        </div>
               </div>
              
        <!-- /.col -->

  
                </form>


</asp:Content>

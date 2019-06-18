<%@ Page Title="" Language="C#" MasterPageFile="~/Profil/Profil.Master" AutoEventWireup="true" CodeBehind="ListeUser.aspx.cs" Inherits="Web_Application_Activity.Profil.ListeUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Liste des utilisateurs</title>

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
            <i class="fa fa-dashboard" ></i> <span> Accueil</span> 
          </a>
          
        </li>
        
        <li>
          <a href="../Tableau_De_Bord/TableauDeBord.aspx">
            <i class="fa fa-th"></i> <span>Tableau De Bord</span>
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
            <span>Les Graphiques</span>
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
    <!-- /.sidebar -->
  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
      <!-- Default box -->
      <div class="box">
        <div class="box-header with-border">
          <h2 style="margin-top:0px;text-align:center;"><strong><i class="fa fa-fw fa-users"></i>Liste des utilisateurs</strong></h2>

          <div class="box-tools pull-right">
            <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="Collapse">
              <i class="fa fa-minus"></i></button>
            <button type="button" class="btn btn-box-tool" data-widget="remove" data-toggle="tooltip" title="Remove">
              <i class="fa fa-times"></i></button>
          </div>
        </div>
        <div class="box-body">
            <form runat="server">
            <asp:DataGrid ID="MyListUser" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
                class="table table-bordered table-striped"
           >
               
     
            <Columns  >
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="username" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Nom d'utilisateur"   />
                    <asp:BoundColumn DataField="firstname" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Nom"   />
                    <asp:BoundColumn DataField="lastname" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Prenom"   />
                    <asp:BoundColumn DataField="detail" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Poste Actuel"   />
                    <asp:BoundColumn DataField="email" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Email"   />
                    <asp:BoundColumn DataField="age" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Age"   />
                    <asp:BoundColumn DataField="education" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="formation"   />
                    <asp:BoundColumn DataField="localisation" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Localisation"   />
                    <asp:BoundColumn DataField="codeuser" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Departement"   />
                    <asp:BoundColumn DataField="role" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Role"   />

                    <asp:ButtonColumn  Text="Supprimer" ButtonType="LinkButton" />
                    
                
                    </Columns>
                </asp:DataGrid>



</form>
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
            <h4> <strong><i class="fa fa-user-plus margin-r-5"></i> <a href="../Profil/AddProfil.aspx" translate="yes" >Ajouter Un Nouveau Utilisateur</a></strong></h4>
        </div>
        <!-- /.box-footer-->
      </div>
      <!-- /.box -->
</asp:Content>

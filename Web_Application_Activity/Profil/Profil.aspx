<%@ Page Title="" Language="C#" MasterPageFile="~/Profil/Profil.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="Web_Application_Activity.Profil.Profil1" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Profil</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                

              <a href="../Profil/ModifierProfile.aspx" class="btn btn-primary btn-block"><b>Modifier Profile</b></a>
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
             <div class="col-xs-5">

                <asp:TextBox ID="SkillsTxt" class="form-control" runat="server"></asp:TextBox>

             </div>
                <asp:Button ID="Buttom1" runat="server"  class="btn btn-success" Font-Bold="true" OnClick="AddSkills" Text="Ajouter une compétence" />

              <hr/>

                             <h4> <strong><i class="fa fa-edit margin-r-5"></i> Note</strong></h4>

              <a href="../notebook.html" class="btn btn-app" >
                <i class="fa fa-edit"></i> Note
              </a>
                <hr/>


              
                
              <asp:Button ID="ButtonAdd" class="btn btn-block btn-warning btn-lg" Font-Bold="true" runat="server" OnClick="AddUser" Text="Ajouter Un Utilisateur" />
                <hr />
              <asp:Button ID="ButtonAddDep" class="btn btn-block btn-primary btn-lg" Font-Bold="true" runat="server" OnClick="AddDep" Text="Ajouter Un nouvel departement" />
                <hr />
                <asp:Button ID="ButtonListe" runat="server" class="btn btn-block btn-info btn-lg" OnClick="ListeUser"  Font-Bold="true" Text="Voir La Liste des utilisateur" />
                
                 <div class="form-group">
                      <div class="col-sm-offset-2 col-sm-10">
                          <!-- Modal -->
                <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
          
                        <button type="button" class="close" data-dismiss="modal" runat="server" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" runat="server" id="myModalLabel">Voir Autre Secteur</h4>
          
                      </div>
                      <div class="modal-body">
                          <asp:Label ID="LabelContent" runat="server" Text="Content"></asp:Label>

                      </div>
                      <div class="modal-footer">
                          <asp:Button ID="Button16" class="btn btn-default" runat="server" Text="Fermer" data-dismiss="modal"/>
                          <asp:Button ID="Button17" class="btn btn-primary" runat="server" OnClick="DoSQLUpdateSecteur"  href="~/Profil/Profil.aspx"  Text="Suivant" />
        
                      </div>
                    </div>
                  </div>
                </div>
           
                      </div>
                    </div>

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
              <li ><a href="#collegues" data-toggle="tab">Liste des utilisateurs</a></li>
              <li ><a href="#amis" data-toggle="tab">Liste des partenaires</a></li>
              <li ><a href="#demande" data-toggle="tab">les demandes de collabroration</a></li>


            </ul>
            <div class="tab-content">
              <div class="active tab-pane" id="activity">
                <!-- Post -->
                <section class="panel panel-default">
                            <textarea id="ContentData" class="form-control no-border" runat="server" rows="4" placeholder="What are you doing..."></textarea>
                          <footer class="panel-footer bg-light lter">
                              <ul class="nav nav-pills nav-sm">
                                
                              <li >
                                  <asp:Button ID="Button1" runat="server" Width="100px" Font-Bold="true" OnClick="AddSortie" class="btn btn-default"  Text="Sorties" />          
                                  <asp:Button ID="Button2" runat="server" Width="100px" class="btn btn-danger" OnClick="AddSports" Font-Bold="true" Text="Sports" />
                                  <asp:Button ID="Button3" runat="server"  class="btn btn-success" Font-Bold="true" OnClick="AddArts" Text="Arts ou artisanat" />
                                  <asp:Button ID="Button4" runat="server"  class="btn btn-info" Font-Bold="true" OnClick="AddTravail" Text="Travail, réparation, rénovation" />
                                  <asp:Button ID="Button5" runat="server" Width="100px" class="btn btn-warning" OnClick="AddJeux" Font-Bold="true" Text="Jeux" />
                                  <asp:Button ID="Button6" runat="server"  class="btn btn-primary" Font-Bold="true" OnClick="AddLire" Text="Lire et écrire" />
                                  <asp:Button ID="Button7" runat="server"  class="btn btn-default" Font-Bold="true" OnClick="AddVetements" Text="Vêtements" />
                                  <asp:Button ID="Button8" runat="server"  class="btn btn-danger" Font-Bold="true" OnClick="AddRendreService" Text="Rendre service" />
                                  <asp:Button ID="Button9" runat="server"  class="btn btn-success" Font-Bold="true" OnClick="AddAlimentation" Text="Alimentation" />
                                  <asp:Button ID="Button10" runat="server" Width="200px"  class="btn btn-info" OnClick="AddSujets" Font-Bold="true" Text="Sujets de conversations" />
                                  <asp:Button ID="Button11" runat="server"  class="btn btn-warning" Font-Bold="true" OnClick="AddActivitesMentales" Text="Activités mentales" />
                                  <asp:Button ID="Button12" runat="server" Width="200px" class="btn btn-primary" OnClick="AddGouter" Font-Bold="true" Text="gouter à un plaisir simple" />
                                  <asp:Button ID="Button13" runat="server" Width="150px" class="btn btn-default" OnClick="AddSpiritualite" Font-Bold="true" Text="Spiritualité" />
                                  <asp:Button ID="Button14" runat="server" Width="145px" class="btn btn-danger" OnClick="AddEtreAvecAutres" Font-Bold="true" Text="Être avec d'autres" />
                                  <asp:Button ID="Button15" runat="server"  class="btn btn-success" Font-Bold="true" OnClick="AddDevelopper" Text="Développer de nouvelles habiletés" />
                                   
                              </li>
                            </ul>
                          </footer>
                        </section>



<asp:DataGrid ID="MyDataGrid" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
               
     
            <Columns  >
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Sorties"   />
                    <asp:ButtonColumn  Text="Delete" ButtonType="LinkButton" />
                    
                
                    </Columns>
                </asp:DataGrid>

<hr />
<asp:DataGrid ID="DataGrid1" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    
            <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Sports"   />
                    <asp:ButtonColumn  Text="Delete" ButtonType="LinkButton" />

            </Columns>
    


  

    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid2" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
      <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Width="1100px" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderText="Arts ou artisanat"   />
                    <asp:ButtonColumn  Text="Delete" ButtonType="LinkButton" />

            </Columns>

   


    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid3" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Travail, réparation, rénovation"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />
<asp:DataGrid ID="DataGrid4" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
      <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Jeux"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid5" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Lire et écrire"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid6" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large"  HeaderStyle-Width="1100px" HeaderText="Vêtements"   />
                    <asp:ButtonColumn  Text="Delete" ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid7" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Rendre service"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid8" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Alimentation"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid9" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Sujets de conversations"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid10" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Activités mentales"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid11" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="gouter à un plaisir simple"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>

    
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid12" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Spiritualité"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>

   
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid13" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
     <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Être avec d'autres"   />
                    <asp:ButtonColumn  Text="Delete"  ButtonType="LinkButton" />

            </Columns>

    
    </asp:DataGrid>
<hr />

<asp:DataGrid ID="DataGrid14" runat="server"
                OnItemCommand="maGrille_ItemCommand"            
                 BorderColor="White" AutoGenerateColumns="false"
           >
    <Columns>

                <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="content" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Size="Large" HeaderStyle-Width="1100px" HeaderText="Développer de nouvelles habiletés"   />
                    <asp:ButtonColumn  CommandName="Delete" Text="Delete"   ButtonType="LinkButton" />
        

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
              <div class="tab-pane" id="collegues">
                  <br />
                   <h1 style="margin-top:0px;text-align:center;"> <strong><i class="fa fa-fw fa-users"></i> La liste des utilisateurs de l'application</strong></h1>
                  <br />
                  <hr />
                  <br />
                  <asp:DataGrid ID="DataGridCollegue" runat="server"
                OnItemCommand="maGrille_ItemCommandAmis"            
                 BorderColor="White" AutoGenerateColumns="false">   
            <Columns  >
                
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:ButtonColumn DataTextField="username" HeaderText="UserName"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false"  ItemStyle-Font-Size="Large" ItemStyle-Height="50px" HeaderStyle-Font-Size="X-Large"  ButtonType="LinkButton" />
                    <asp:BoundColumn DataField="firstname" HeaderText="Prenom" HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />
                    <asp:BoundColumn DataField="lastname" HeaderText="Nom"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />
                    <asp:BoundColumn DataField="detail" HeaderText="Detail"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />

                    </Columns>
                </asp:DataGrid>



                </div>
              <!-- /.tab-pane -->
              <div class="tab-pane" id="amis">

                  <br />
                   <h1 style="margin-top:0px;text-align:center;"> <strong><i class="fa fa-fw fa-users"></i> La liste des partenaires </strong></h1>
                  <br />
                  <hr />
                  <br />
                  <asp:DataGrid ID="DataGridAmis" runat="server"
                OnItemCommand="maGrille_ItemCommandAmis"            
                 BorderColor="White" AutoGenerateColumns="false">   
            <Columns  >
                
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:ButtonColumn DataTextField="username" HeaderText="UserName"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false"  ItemStyle-Font-Size="Large" ItemStyle-Height="50px" HeaderStyle-Font-Size="X-Large"  ButtonType="LinkButton" />
                    <asp:BoundColumn DataField="firstname" HeaderText="Prenom" HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />
                    <asp:BoundColumn DataField="lastname" HeaderText="Nom"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />
                    <asp:BoundColumn DataField="detail" HeaderText="Detail"  HeaderStyle-Font-Bold="true" ItemStyle-Width="300px" ItemStyle-Font-Bold="false" HeaderStyle-Font-Size="X-Large" ItemStyle-Height="50px" ItemStyle-Font-Size="Large" />

                    </Columns>
                </asp:DataGrid>


              </div>
                <div class="tab-pane" id="demande">
                     <asp:DataGrid ID="MyDemandeAmis" runat="server"
                OnItemCommand="maGrille_ItemDemande"      
                class="table table-bordered table-hover todo-list"
                 AutoGenerateColumns="false"
                    BorderColor="White"
           >
               
     
            <Columns  >
                    <asp:BoundColumn DataField="id" Visible="False" /> 
                    <asp:BoundColumn DataField="username" ItemStyle-BorderColor="White"  ItemStyle-Font-Bold="true" HeaderStyle-BorderStyle="None"  ItemStyle-Font-Size="Medium"    />
                     <asp:BoundColumn DataField="detail"   ItemStyle-BorderColor="White"  HeaderStyle-BorderStyle="None" HeaderStyle-Width="300px"  ItemStyle-BorderStyle="None"  ItemStyle-ForeColor="#cc3300"   ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center"  ItemStyle-Font-Size="Small"    />
                     <asp:BoundColumn DataField="sexe"   ItemStyle-BorderColor="White"  HeaderStyle-BorderStyle="None" HeaderStyle-Width="300px"  ItemStyle-BorderStyle="None"  ItemStyle-ForeColor="#cc3300"   ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center"  ItemStyle-Font-Size="Small"    />
                     <asp:BoundColumn DataField="email"   ItemStyle-BorderColor="White"  HeaderStyle-BorderStyle="None" HeaderStyle-Width="300px"  ItemStyle-BorderStyle="None"  ItemStyle-ForeColor="#cc3300"   ItemStyle-VerticalAlign="Top" ItemStyle-HorizontalAlign="Center"  ItemStyle-Font-Size="Small"    />

                    <asp:ButtonColumn  Text="Accepter la demande" ItemStyle-BorderColor="White" ItemStyle-BackColor="White" ItemStyle-ForeColor="BlueViolet" ItemStyle-CssClass="btn btn-block btn-default btn-lg" HeaderStyle-Width="50px"   HeaderStyle-BorderStyle="None" ButtonType="PushButton" />
                    
                
                    </Columns>
                </asp:DataGrid>
              </div>
            </div>
            <!-- /.tab-content -->
          </div>
          <!-- /.nav-tabs-custom -->
        </div>
               </div>
              
        <!-- /.col -->

  
                </form>

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="nav_menu" runat="server">

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

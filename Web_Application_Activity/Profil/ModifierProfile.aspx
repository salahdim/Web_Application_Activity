<%@ Page Title="" Language="C#" MasterPageFile="~/Profil/Profil.Master" AutoEventWireup="true" CodeBehind="ModifierProfile.aspx.cs" Inherits="Web_Application_Activity.Profil.ModifierProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <title>Profil</title>

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
            <i class="fa fa-dashboard" ></i> <span>Accueil</span> 
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
    
    <form runat="server" class="form-horizontal">


     <div class="row">
        <div class="col-md-3">

          <!-- Profile Image -->
          <div class="box box-primary">
            <div class="box-body box-profile">
                <asp:Image ID="Image1" runat="server" class="profile-user-img img-responsive img-circle"  alt="User profile picture" />
              <h3 class="profile-username text-center"><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></h3>

              <p class="text-muted text-center">Software Engineer</p>

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
                <button runat="server" class="btn btn-block btn-primary disabled"><b>Modifier Profile</b></button>
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
<!--
              <strong><i class="fa fa-pencil margin-r-5"></i> Skills</strong>

              <p>
                <span class="label label-danger">
                    <asp:Label ID="Labelskills1" runat="server" Text=""></asp:Label></span>
                <span class="label label-success">
                    <asp:Label ID="Labelskills2" runat="server" Text=""></asp:Label></span>
                <span class="label label-info">
                    <asp:Label ID="Labelskills3" runat="server" Text=""></asp:Label></span>
                <span class="label label-warning">
                    <asp:Label ID="Labelskills4" runat="server" Text=""></asp:Label></span>
                <span class="label label-primary">
                    <asp:Label ID="Labelskills5" runat="server" Text=""></asp:Label></span>
              </p>
-->
                <asp:GridView ID="GridView1" runat="server"  BorderColor="White" AutoGenerateColumns="false">
    <Columns>
        <asp:TemplateField ItemStyle-HorizontalAlign="Center">

            <ItemTemplate>
                <span class="label label-danger">
<i class="fa fa-fw fa-book"></i>

            
                  </span>

                </ItemTemplate>

        </asp:TemplateField>
        <asp:BoundField DataField="name" HeaderText="Skills"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
        
    </Columns>
                    
</asp:GridView>

                <div class="col-xs-5">

                <asp:TextBox ID="SkillsTxt" class="form-control" runat="server"></asp:TextBox>

             </div>
                <asp:Button ID="Buttom1" runat="server"  class="btn btn-success" Font-Bold="true" OnClick="AddSkills" Text="Ajouter une compétence" />


              <hr>


              <a href="../notebook.html" class="btn btn-app" >
                <i class="fa fa-edit"></i> Note
              </a>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
        <div class="col-md-9">
          <div class="nav-tabs-custom">
            <ul class="nav nav-tabs">
              <li class="active"><a href="#settings" data-toggle="tab" >Settings</a></li>
                   


            </ul>
            <div class="tab-content">
              <!-- /.tab-pane -->
              <!-- /.tab-pane -->

              <div class="active tab-pane" id="settings">
                  <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Username</label>

                    <div class="col-sm-10">
                        <asp:TextBox ID="usernametxt" runat="server" class="form-control" type="text" ></asp:TextBox>
                    </div>
                  </div>
                  <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Firstname</label>

                    <div class="col-sm-10">
                    <asp:TextBox ID="firstnametxt" runat="server" class="form-control" type="text" ></asp:TextBox>

                    </div>
                  </div>
                  <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">LastName</label>

                    <div class="col-sm-10">
                    <asp:TextBox ID="lastnametxt" runat="server" class="form-control" type="text" ></asp:TextBox>
                    </div>
                  </div>
                     <div class="form-group">
                    <label for="inputEmail" class="col-sm-2 control-label">Email</label>

                    <div class="col-sm-10">
                    <asp:TextBox ID="emailtxt" runat="server" class="form-control" type="text" ></asp:TextBox>
                    </div>
                  </div>
                    <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">password</label>

                    <div class="col-sm-10">
                    <asp:TextBox ID="passwordtxt" runat="server" class="form-control" type="password" ></asp:TextBox>
                    </div>
                  </div>
           
                        <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Age</label>

                    <div class="col-sm-10">
                     <asp:TextBox ID="inputAge" runat="server" class="form-control" type="text" ></asp:TextBox>


                        

                    </div>
                            </div>
                        <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Education</label>

                    <div class="col-sm-10">
                     <asp:TextBox ID="educationtxt" runat="server" class="form-control" type="text" ></asp:TextBox>


                        

                    </div>
                  </div>
                            <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Localisation</label>

                    <div class="col-sm-10">
                     <asp:TextBox ID="localisationtxt" runat="server" class="form-control" type="text" ></asp:TextBox>


                        

                    </div>
                  </div>
                   <div class="form-group">
                    <label for="inputName" class="col-sm-2 control-label">Choisir Image</label>

                    <div class="col-sm-10">


                            <asp:FileUpload ID="UploadImage" runat="server" />
                    </div>
                  </div>

                  <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <button type="button" class="btn btn-block btn-success btn-lg" data-toggle="modal" runat="server" data-target="#myModal">Modifier</button>
                        <a href="../Profil/Profil.aspx" class="btn btn-block btn-default btn-lg">Annuler</a>
                        <!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
          
        <button type="button" class="close" data-dismiss="modal" runat="server" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" runat="server" id="myModalLabel">Changement des informations personnelles</h4>
          
      </div>
      <div class="modal-body">
        Voulez-vous vraiment modifier votre compte ?

      </div>
      <div class="modal-footer">
          <asp:Button ID="Button1" class="btn btn-default" runat="server" Text="Close" data-dismiss="modal"/>
          <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="submitUpdateMethod" href="~/Profil/Profil.aspx"  Text="Save changes" />
        
      </div>
    </div>
  </div>
</div>
           
                    </div>
                  </div>
              </div>
              <!-- /.tab-pane -->
            </div>
            <!-- /.tab-content -->
          </div>
          <!-- /.nav-tabs-custom -->
        </div>
             
        <!-- /.col -->

    </div>

                </form>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Support Voyageur/Support.Master" AutoEventWireup="true" CodeBehind="Support.aspx.cs" Inherits="Web_Application_Activity.Support_Voyageur.Support1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="nav_menu" runat="server">
    
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
            <asp:Image ID="Image1" runat="server" class="img-circle"  alt="User Image" />
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
           <li class="treeview">
          <a href="../Profil/Profil.aspx" >
            <i class="fa fa-fw fa-user"></i> <span>Profil</span>
          </a>
        </li>
           <li class="active treeview">
          <a href="../Support Voyageur/Support.aspx" class="active">
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
    <form runat="server">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Support Voyageur
        <small></small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="~/Home/HomePage"><i class="fa fa-dashboard"></i> Accueil</a></li>
        <li class="active">Support Voyageur</li>
      </ol>
    </section>
        <section class="content">
      <div class="row">
                  <div class="col-md-12">
                        <section class="panel panel-default">
                            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                            <textarea id="ContentData" class="form-control no-border" runat="server" rows="4" placeholder="Ecrire quelque chose..."></textarea>
                          <footer class="panel-footer bg-light lter">
                            <asp:Button ID="ButtonPost" runat="server"  class="btn btn-info pull-right btn-sm" OnClick="DoSQLQueryVoyageur" Text="Publier" /> 
                              <ul class="nav nav-pills nav-sm">
                                
                              <li >
                                   <asp:FileUpload ID="FileUpload1" runat="server"  style="width:auto; height:auto" CssClass="fa fa-fw fa-camera"  />
                              </li>
                            </ul>
                          </footer>
                        </section>

         

    <table runat="server" id="table1" style="width:100%"  >
      <tr runat="server" id="itemPlaceholder" >
                    
      <td id="td1">
         
        <div class="box box-widget" >
            <div class="box-header with-border" >
              <div class="user-block" >
                <a href="../Profil/Profil.aspx"><asp:Image ID="Image2" runat="server" ImageUrl="../image/user.png" class="img-circle" alt="User Image" /></a>
               <a href="../Profil/Profil.aspx"> <span class="username"><asp:Label ID="LabelProfil" Visible="true"  CssClass="widget-user-username"  runat="server" Text="UserName"></asp:Label></span></a>
                <span class="description">Shared at <asp:Label ID="LabelDate" runat="server" Text="Date"></asp:Label></span>
              </div>
              <!-- /.user-block -->
              <div class="box-tools" >
                <button type="button" class="btn btn-box-tool" runat="server" data-toggle="tooltip" title="Mark as read">
                  <i class="fa fa-circle-o"></i></button>
                <button type="button" class="btn btn-box-tool" runat="server" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" runat="server" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
              <!-- /.box-tools -->
            </div>
            <!-- /.box-header -->
            <div class="box-body" >
                <asp:Image ID="Image3" runat="server" class="img-responsive pad"    alt="Photo" />
              <p>  <asp:Label ID="LabelContent" runat="server" Text="Content"></asp:Label> </p>
             <i class="fa fa-thumbs-o-up"><asp:Button ID="Button2" class="btn btn-default btn-xs" OnClick="DoSQLCountLike" runat="server" Text="j'aime" ></asp:Button></i>
              <span class="pull-right text-muted">le nombre de j'aime <i class="fa-thumbs-o-up"></i><asp:Label ID="LabelLike" runat="server" Text="countLike"></asp:Label> - nombre des commentaire <i class="fa-commenting-o"></i> <asp:Label ID="LaCountComment" runat="server" Text="null"></asp:Label></span>
            </div>
            <!-- /.box-body -->

              <div class="box-comment" >

                <div class="comment-text" >




                                      
        <asp:DataGrid ID="MyDataGridComment" runat="server"
                PageSize="5000"
                Width="100%"
                ForeColor="#000"
                GridLines="Vertical"
                AutoGenerateColumns="False"
            OnItemCommand="maGrille_ItemCommand"
                AllowSorting="True" 
                class="table table-bordered table-responsive"

           >
               
     
            <Columns  >
                    <asp:BoundColumn     DataField="id" Visible="false" >
                        </asp:BoundColumn>

                    <asp:BoundColumn HeaderText="Username" ItemStyle-BackColor="#d6f8ff" HeaderStyle-ForeColor="#c0dfe5" ItemStyle-Font-Bold="true"  DataField="username" >
                         
                    </asp:BoundColumn>
                    <asp:BoundColumn  HeaderText="Contenu" ItemStyle-BackColor="#d6f8ff" HeaderStyle-ForeColor="#c0dfe5" HeaderStyle-Width="1300px" DataField="description">
                    </asp:BoundColumn>
                 
                    <asp:BoundColumn  HeaderText="Date" ItemStyle-BackColor="#d6f8ff" HeaderStyle-ForeColor="#c0dfe5" DataField="date">
                    </asp:BoundColumn>



                    </Columns>
                <AlternatingItemStyle  />

                <HeaderStyle  Font-Bold="True" BackColor="#ffffff"  BorderStyle="None"  />

            </asp:DataGrid>
                  
















                     
                </div>
              </div>
              


              
           
              <div class="box-footer" >
                <asp:Image ID="Image4" runat="server" class="img-responsive img-circle img-sm" alt="Alt Text" />
                <div class="img-push" >
                                    <div class="input-group input-group-sm" >

                      <asp:TextBox ID="Comment_id" runat="server" class="form-control input-sm"  style="width:100%; height:75px" TextMode="MultiLine" placeholder=" poster votre commentaire"></asp:TextBox>
                                        <span class="input-group-btn">
    
                    <asp:Button ID="Button1" runat="server" class="btn btn-info btn-flat" style="width:100%; height:75px" Text="Ajouter un commentaire" OnClick="DoSQLQueryComment" />
                                            </span>
                                        </div>
                </div>
            </div>
            <!-- /.box-footer -->
          </div>
          <!-- /.box -->
      </td>
      </tr>  
   
   </table>






          <!-- /.box -->





                      </div>
          
      </div>  
        <!-- /.col -->
                   
              </section>
 </form>           
</asp:Content>

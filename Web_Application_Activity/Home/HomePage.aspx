<%@ Page Title="" Language="C#" MasterPageFile="~/Home/Home.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Web_Application_Activity.HomePage" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Accueil</title>

    </asp:Content>








    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="row">
        <div class="col-md-3 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-aqua"><i class="fa fa-fw fa-envelope-o"></i></span>
               <div class="info-box-content">
              <span class="info-box-text">nombre des emails non lu</span>
              <span class="info-box-number">
                  <asp:Label ID="LabelnbMail" runat="server" Text="0"></asp:Label></span>
            </div>
           
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <div class="col-md-3 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-red"><i class="ion ion-ios-people-outline"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Nombre des partenaires</span>
              <span class="info-box-number">
                  <asp:Label ID="LabelNbAmis" runat="server" Text="nbamis"></asp:Label></span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->

        <!-- fix for small devices only -->
        <div class="clearfix visible-sm-block"></div>

        <div class="col-md-3 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-green"><i class="ion ion-ios-cart-outline"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Les Activités qui vous intéressent</span>
                 <span class="info-box-number"><asp:Label ID="count2" runat="server" Text=""/></span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <div class="col-md-3 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-yellow"><i class="ion ion-ios-people-outline"></i></span>

            <div class="info-box-content">
             <span class="info-box-text">Le nombre de visiteurs</span>
                 <span class="info-box-number"><asp:Label ID="count1" runat="server" Text=""/></span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>

        <!-- /.col -->

              <div class="row">
        <div class="col-md-12">
          <div class="box">
            <div class="box-header with-border">
                              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <div class="btn-group">
                  <button type="button" class="btn btn-box-tool dropdown-toggle" data-toggle="dropdown">
                    <i class="fa fa-wrench"></i></button>
                  <ul class="dropdown-menu" role="menu">
                    <li><a href="#">Action</a></li>
                    <li><a href="#">Another action</a></li>
                    <li><a href="#">Something else here</a></li>
                    <li class="divider"></li>
                    <li><a href="#">Separated link</a></li>
                  </ul>
                </div>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>

                
                 <h3><i class="fa fa-inbox"></i> Le nombre de salariés selon leur Age</h3>
                

               
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <div class="row">
                <div class="col-md-12">
                  <h3 class="text-center">
               <!--     <strong> 1 January, 2015 - 30 December, 2015</strong> -->
                  </h3>

                 <div class="box-body">
                    
              <!-- Morris chart - Sales --> 
                         <h4 class="box-title">  <a class="text-light-blue" href="#"><i class="fa fa-square"></i></a> Le Nombre de salariés </h4>
                     <div class="chart">
                 <canvas id="areaChart" style="height:250px"></canvas>
                     </div>
            
              

            </div>

                  <!-- /.chart-responsive -->
                </div>
                <!-- /.col -->
                <div class="col-md-4">
                  <p class="text-center">
                  </p>

                  
                  <!-- /.progress-group -->
                  
                  <!-- /.progress-group -->
                 
                  <!-- /.progress-group -->
                  
                  <!-- /.progress-group -->
                </div>
                <!-- /.col -->
              </div>
              <!-- /.row -->
            </div>
            <!-- ./box-body -->
            <div class="box-footer">
              <div class="row">
                
                <!-- /.col -->
                
                <!-- /.col -->
                
                <!-- /.col -->
                
              </div>
              <!-- /.row -->
            </div>
            <!-- /.box-footer -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
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
          <a href="#"><i class="fa fa-circle text-success"></i> En ligne <br /></a>
            
        </div>
      </div>
        
      <!-- search form -->
   
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      <ul class="sidebar-menu">
                  

        <li class="header">MAIN NAVIGATION</li>
       <li class="active treeview">
          <a href="../Home/HomePage.aspx" class="active">
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
          <a href="../Charts/ChartJs.aspx" >
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


<asp:Content ID="Content5" ContentPlaceHolderID="ContentBar" runat="server">

<div class="box-header with-border">
              <h3 class="box-title">
        

              </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
                                         <h4 class="box-title">  <a class="text-success" href="#"><i class="fa fa-square"></i></a> Salaire</h4>
                                         <h4 class="box-title">  <a class="text-aqua" href="#"><i class="fa fa-square"></i></a> Minute produite</h4>

                              <div class="chart">

              <canvas id="lineChart" style="height:250px"></canvas>
                                  </div>
            </div>


  

  </asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="ContentMail" runat="server">

            <div class="box-body">
                <div class="form-group">
                  <asp:TextBox ID="emailTxtTo" runat="server" class="form-control" placeholder="Email to:" ></asp:TextBox>
                </div>
                <div class="form-group">
                  <asp:TextBox ID="subjectTxt" runat="server" class="form-control" placeholder="Subject" ></asp:TextBox>
                </div>
                <div>

                 <asp:TextBox ID="TextMessagee"  runat="server" TextMode="MultiLine" style="width: 100%; height: 125px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;" placeholder="Please enter your message:"></asp:TextBox>
                </div>
            </div>
            <div class="box-footer clearfix">
                                <asp:Button ID="ButtSend"  Text="Send" class="pull-right btn btn-default" runat="server" OnClick="SendEmail1" />

              
            </div>
  </asp:Content>
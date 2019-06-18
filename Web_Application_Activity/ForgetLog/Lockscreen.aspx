<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lockscreen.aspx.cs" Inherits="Web_Application_Activity.ForgetLog.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title> Business Report | Lockscreen</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="../../bootstrap/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/AdminLTE.min.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition lockscreen">
<!-- Automatic element centering -->
<div class="lockscreen-wrapper">
  <div class="lockscreen-logo">
    <a href="#"><b>Business</b>Report</a>
  </div>
  <!-- User name -->
  <div class="lockscreen-name"><asp:Label ID="LabelUName" runat="server" Text="John"></asp:Label></div>
      
    <div class="text-center">
    
        <asp:Label ID="LabelNom" runat="server" Text="John"></asp:Label>

    </div>
  <!-- START LOCK SCREEN ITEM -->
  <div class="lockscreen-item">
    <!-- lockscreen image -->
    <div class="lockscreen-image">
            <asp:Image ID="Image1" runat="server" class="img-circle" alt="User Image" />
    </div>
    <!-- /.lockscreen-image -->

    <!-- lockscreen credentials (contains the form) -->
    <form class="lockscreen-credentials">
        <div class="input-group">
            <asp:Label ID="Labeltitre" class="form-control" runat="server" Text="Aller au Accueil"></asp:Label>

        <div class="input-group-btn">
          <a href="../Home/HomePage.aspx" class="btn"><i class="fa fa-arrow-right text-muted"></i></a>
        </div>
      </div>
     
    </form>
    <!-- /.lockscreen credentials -->

  </div>
  <!-- /.lockscreen-item -->
    <br />
    <br />
    <hr />
  <div class="help-block text-center">
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
  </div>
  <div class="text-center">
    <a href="../Login/LoginPage.aspx"  onclick="logoutEventMethod">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        </a>
  </div>
  <div class="lockscreen-footer text-center">
    Copyright &copy; 2015-2016 <b><a href="#" class="text-black">Dimassi Salah</a></b><br>
    All rights reserved
  </div>
</div>
<!-- /.center -->

<!-- jQuery 2.2.0 -->
<script src="../../plugins/jQuery/jQuery-2.2.0.min.js"></script>
<!-- Bootstrap 3.3.6 -->
<script src="../../bootstrap/js/bootstrap.min.js"></script>
</body>
</html>

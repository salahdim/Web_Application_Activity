<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProfil.aspx.cs" Inherits="Web_Application_Activity.Profil.AddProfil" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 2 | Registration Page</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.6 -->
  <link rel="stylesheet" href="../bootstrap/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../dist/css/AdminLTE.min.css">
  <!-- iCheck -->
  <link rel="stylesheet" href="../plugins/iCheck/square/blue.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition register-page">
<div class="register-box">
  <div class="register-logo">
    <a href="../index2.html"><b>Business</b>Report</a>
  </div>

  <div class="register-box-body">
    <p class="login-box-msg">Ajouter nouveau utilisateur</p>

    <form runat="server">
      <div class="form-group has-feedback">
         <asp:TextBox ID="TextUsername" runat="server" class="form-control" placeholder="Username"></asp:TextBox>
        <span class="glyphicon glyphicon-user form-control-feedback"></span>
      </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextNom" runat="server" class="form-control" placeholder="Nom"></asp:TextBox>
        <span class="glyphicon glyphicon-user form-control-feedback"></span>
      </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextPrenom" runat="server" class="form-control" placeholder="Prenom"></asp:TextBox>
        <span class="glyphicon glyphicon-user form-control-feedback"></span>
      </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextSexe" runat="server" class="form-control" placeholder="Sexe"></asp:TextBox>
        <span class="glyphicon glyphicon-user form-control-feedback"></span>
      </div>
        
      <div class="form-group has-feedback">
         <asp:TextBox ID="TextEmail" runat="server" class="form-control" TextMode="Email" placeholder="Email" data-error="Bruh, email est incorrect" required="" ></asp:TextBox>
          <asp:RegularExpressionValidator runat="server" ControlToValidate="TextEmail" ErrorMessage="L'email saisi n'est pas correct" Display="none"
	                            ValidationExpression="^[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.(([0-9]{1,3})|([a-zA-Z]{2,3})|(aero|coop|info|museum|name))$" />
        <span class="glyphicon glyphicon-envelope form-control-feedback" aria-hidden="true"></span>
      </div>
      <div class="form-group has-feedback">
         <asp:TextBox ID="TextPassword" runat="server" class="form-control" TextMode="Password" placeholder="Password" data-toggle="validator" data-minlength="6"></asp:TextBox>
          <asp:RequiredFieldValidator runat="server" ControlToValidate="TextPassword" ErrorMessage="Le password doit être saisi" Display="none" />
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
         <asp:TextBox ID="TextPassword1" runat="server" class="form-control" TextMode="Password" placeholder="Retype password" data-toggle="validator" data-minlength="6"></asp:TextBox>
          <asp:RequiredFieldValidator runat="server" ControlToValidate="TextPassword1" ErrorMessage="retapez le mot de passe" Display="none" />

        <span class="glyphicon glyphicon-log-in form-control-feedback"></span>
      </div>
                                <asp:ValidationSummary runat="server" ShowMessageBox="true" ShowSummary="false" />

        <div class="form-group has-feedback">
         <asp:TextBox ID="TextCIN" runat="server" class="form-control" placeholder="CIN"></asp:TextBox>
        <span class="glyphicon glyphicon-barcode form-control-feedback"></span>
      </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextTelephone" runat="server" class="form-control" TextMode="Number" placeholder="Telephone"></asp:TextBox>
        <span class="glyphicon glyphicon-phone form-control-feedback"></span>
      </div>
       <div class="form-group has-feedback">
        <asp:TextBox ID="TextDetail" runat="server" class="form-control" placeholder="Poste"></asp:TextBox>
        <span class="glyphicon glyphicon-list-alt form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextAge" runat="server" class="form-control" TextMode="Number" placeholder="Age"></asp:TextBox>
        <span class="glyphicon glyphicon-user form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
             <asp:FileUpload ID="UploadImage" runat="server" />
            <span class="fa fa-fw fa-image form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextEducation" runat="server" class="form-control" placeholder="Education"></asp:TextBox>
        <span class="glyphicon glyphicon-education form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
            <asp:TextBox ID="TextLocalisation" runat="server" class="form-control" placeholder="Localisation"></asp:TextBox>
        <span class="glyphicon glyphicon-map-marker form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
            <asp:TextBox ID="TextPostal" runat="server" class="form-control" placeholder="Code Postale"></asp:TextBox>
        <span class=" form-control-feedback"></span>
        </div>
        <div class="form-group has-feedback">
         <asp:TextBox ID="TextCodeUser" runat="server" class="form-control" TextMode="Number" placeholder="Departement"></asp:TextBox>
        <span class="glyphicon glyphicon-plus form-control-feedback"></span>
                <asp:GridView ID="GridDepartement" runat="server"  BorderColor="White" AutoGenerateColumns="false">
            <Columns>
       
            <asp:BoundField DataField="id"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Width="30px" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
            <asp:BoundField DataField="libelle"  ItemStyle-ForeColor="#00cc66"  ItemStyle-Font-Bold="true" HeaderStyle-Width="255px"  ItemStyle-Font-Size="Medium" />

            <asp:TemplateField ItemStyle-HorizontalAlign="Center">

            <ItemTemplate>
                <span class="label label-success">
                <i class="fa fa-fw fa-institution margin-r-5"></i>

            
                  </span>

            </ItemTemplate>

        </asp:TemplateField>
    </Columns>
                    
</asp:GridView>

        </div>
        <div class="form-group has-feedback">
            Responsable: <asp:RadioButton ID="RadioResponsable" runat="server"  />
            Utilisateur Simple: <asp:RadioButton ID="RadioUser" runat="server" />
        <span class="glyphicon glyphicon-briefcase form-control-feedback"></span>
        </div>
      <div class="row">
        <div class="col-xs-8">
          
        </div>
        <!-- /.col -->
        <div class="col-xs-4">
                <asp:Button ID="Button1" class="btn btn-primary btn-block btn-flat" runat="server" OnClick="AddUser" Text="Ajouter" />
        </div>
        <!-- /.col -->
      </div>
    </form>

    

  </div>
  <!-- /.form-box -->
</div>
<!-- /.register-box -->

<!-- jQuery 2.2.0 -->
<script src="../plugins/jQuery/jQuery-2.2.0.min.js"></script>
<!-- Bootstrap 3.3.6 -->
<script src="../bootstrap/js/bootstrap.min.js"></script>
<!-- iCheck -->
<script src="../plugins/iCheck/icheck.min.js"></script>
<script>
  $(function () {
    $('input').iCheck({
      checkboxClass: 'icheckbox_square-blue',
      radioClass: 'iradio_square-blue',
      increaseArea: '20%' // optional
    });
  });
</script>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Login/Login.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Web_Application_Activity.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="login-body">
            <div class="login-heading">
                <h1>Login</h1>
            </div>
            <div class="login-info">
    <form id="form2" runat="server" data-toggle="validator">
        
        												<div class="form-group has-feedback">

                        <asp:TextBox ID="emailTextBox" runat="server"  placeholder="Email" class="form-control" data-error="Bruh, email est incorrect" required=""  />
                       <asp:RegularExpressionValidator runat="server" ControlToValidate="emailTextBox" ErrorMessage="L'email saisi n'est pas correct" Display="none"
	                            ValidationExpression="^[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.(([0-9]{1,3})|([a-zA-Z]{2,3})|(aero|coop|info|museum|name))$" />
                                <span class="glyphicon form-control-feedback" aria-hidden="true"></span>
												</div>
        <div class="form-group">
                        <asp:TextBox ID="passwordTextBox"  runat="server" data-toggle="validator" data-minlength="6" class="form-control"  placeholder="Password" type="password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Le password doit être saisi" Display="none" />
        </div>
                        <asp:ValidationSummary runat="server" ShowMessageBox="true" ShowSummary="false" />

                         <asp:Label ID="errorLabel" runat="server" Text="" />
                    <div class="forgot-top-grids">
                        <div class="forgot-grid">
                            <ul>
                                <li>
                                    <input type="checkbox" id="brand1" value=""/>
                                    <label for="brand1"><span></span>Remember me</label>
                                </li>
                            </ul>
                        </div>
                        <div class="forgot">
                            <a href="../ForgetLog/ForgetLog.aspx">Oublier mot de passe?</a>
                        </div>
                        <div class="clearfix"> </div>
                    </div>
                    <asp:Button ID="submitButtton" Text="Login" runat="server" OnClick="submitAuthMethod"  />
                    <div class="signup-text">
                    <h5>Cette application est privé </h5>
                    </div>
                    <hr/>
                  <!--  <h2>or login with</h2> -->
                  <!--  <div class="login-icons">
                        <ul>
                            <li><a href="#" class="facebook"><i class="fa fa-facebook"></i></a></li>
                            <li><a href="#" class="twitter"><i class="fa fa-twitter"></i></a></li>
                            <li><a href="#" class="google"><i class="fa fa-google-plus"></i></a></li>
                            <li><a href="#" class="dribbble"><i class="fa fa-dribbble"></i></a></li>
                        </ul>
                    </div> -->
                </form>
            </div>
        </div>
        <div class="go-back login-go-back">
            <a href="#">Voir le page facebook</a>
        </div>
        <div class="copyright login-copyright">
            <p>© Developper par <a href="#">Intersoft</a></p>
        </div>

</asp:Content>

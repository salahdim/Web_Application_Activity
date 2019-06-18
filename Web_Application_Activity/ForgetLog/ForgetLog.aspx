<%@ Page Title="" Language="C#" MasterPageFile="~/ForgetLog/Forget.Master" AutoEventWireup="true" CodeBehind="ForgetLog.aspx.cs" Inherits="Web_Application_Activity.ForgetLog.ForgetLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="login-body">
            <div class="login-heading">
                <h1>Oublier Mot De Passe</h1>
            </div>
            <div class="login-info">
    <form id="form2" runat="server" data-toggle="validator">
        
        				<div class="form-group has-feedback">
                                                        <div class="form-group">
<h3>

                            <span>Tappez Votre Email : </span>
    </h3>
                                                            <br />
                                                    </div>
                            <div class="box-body">
                 <div class="form-group">
                  <asp:TextBox ID="emailTxt" runat="server" class="form-control" placeholder="Email :" ></asp:TextBox>
                </div>
                
                
                
            </div>
            <div class="box-footer clearfix">
                                <asp:Button ID="ButtSend"  Text="Send" class="pull-right btn btn-default" runat="server" OnClick="ForgetUser"  />

              
            </div>
                            <div class="form-group">
                            <asp:Label ID="LabelTitrePwd" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="form-group">
                            <asp:Label ID="LabelPwd" runat="server" Text=""></asp:Label>
                            </div>
                       </div>
        
                        
                   
                </form>
            </div>
        </div>
        <div class="go-back login-go-back">
            <a href="../Login/LoginPage.aspx">Voir le page login</a>
        </div>
        <div class="copyright login-copyright">
            <p>© Developper par <a href="#">Intersoft</a></p>
        </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Charts/ChartMaster.Master" AutoEventWireup="true" CodeBehind="ChartJs1.aspx.cs" Inherits="Web_Application_Activity.Charts.ChartJs1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="content-header">
      <h1>
        Les Statistiques
        <small>Aperçu simple</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Les Statistiques</a></li>
      </ol>
    </section>
    
    <!-- Main content -->
    <section class="content" >
      <div class="row" >
        <div class="col-md-6">
          <!-- Pie CHART -->
          <div class="box box-primary">
            <div class="box-header with-border">
            Suivi production de of interne : <b><asp:Label ID="LabelOfInterne" runat="server" Text="of interne"></asp:Label></b> 
              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
             <div class="col-md-8">
              <div class="chart">
                <canvas id="pieChart" style="height:250px"></canvas>
              </div>
                 </div>
                <div class="col-md-4">
                  <asp:GridView ID="GridView2" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Of Interne :"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                    <span class="label label-success">
                    <i class="fa fa-pencil margin-r-5"></i>     
                    </span>
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>                  
                    </asp:GridView>

                    </div>
           </div>
                <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                <td><b> Of Interne </b> :</td>
                               
                                

                                <td>
                                   
                <asp:TextBox ID="TextOfInterne2" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button1" runat="server"  class="btn btn-info" OnClick="UpdatePie1" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>

          </div>
            <div class="box box-danger">
            <div class="box-header with-border">
             Of Expedies de client : <b><asp:Label ID="LabelClient" runat="server" Text="client"></asp:Label></b> de modele : <b><asp:Label ID="LabelModele" runat="server" Text="modele"></asp:Label></b> avec le numero de facture <b><asp:Label ID="LabelFacture" runat="server" Text="Facture"></asp:Label></b>
            <br />
                <b>la date exp D : </b><asp:Label ID="LabelDateExpD" runat="server" Text="date1"></asp:Label>
                <b>la date exp R : </b><asp:Label ID="LabelDateExpR" runat="server" Text="date2"></asp:Label>
              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
              
            </div>
            <div class="box-body">
                <div class="col-md-8">
              <div class="chart">
                <canvas id="pieChart1" style="height:250px"></canvas>
              </div>
                    </div>
                <div class="col-md-4">
                    <asp:GridView ID="GridView1" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Of Interne :"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                    <span class="label label-success">
                    <i class="fa fa-pencil margin-r-5"></i>     
                    </span>
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>                  
                    </asp:GridView>
                    </div>
           </div>
                
             <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                <td><b> Of Interne </b> :</td>
                               
                                

                                <td>
                                   
                <asp:TextBox ID="TextOfInterne" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button5" runat="server"  class="btn btn-info" OnClick="UpdatePie" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
                    
          </div>
        </div>
        <div class="col-md-6">
                        <div class="box box-danger">
            <div class="box-header with-border">
             Taux 2ieme choix de l'atelier  <b> <asp:Label ID="LabelAtelier" runat="server" Text="atelier"></asp:Label></b> le Taux : <b><asp:Label ID="LabelTaux" runat="server" Text="taux"></asp:Label></b>
            <br />
                
              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
              
            </div>
            <div class="box-body">
                <div class="col-md-8">
              <div class="chart">
                <canvas id="pieChart2" style="height:250px"></canvas>
              </div>
                    </div>
                <div class="col-md-4">
                    <asp:GridView ID="GridView3" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Atelier :"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Medium" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                    <span class="label label-success">
                    <i class="fa fa-pencil margin-r-5"></i>     
                    </span>
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>                  
                    </asp:GridView>
                    </div>
           </div>
                
             <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                <td><b> Atelier </b> :</td>
                               
                                

                                <td>
                                   
                <asp:TextBox ID="TextAtelier" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button2" runat="server"  class="btn btn-info" OnClick="UpdatePie2" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
                    
          </div>

        </div>
      </div>
    </section>


<!-- jQuery 2.2.0 -->
<script src="../plugins/jQuery/jQuery-2.2.0.min.js"></script>
<!-- Bootstrap 3.3.6 -->
<script src="../bootstrap/js/bootstrap.min.js"></script>
<!-- ChartJS 1.0.1 -->
<script src="../plugins/chartjs/Chart.min.js"></script>
<!-- FastClick -->
<script src="../plugins/fastclick/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="../dist/js/app.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../dist/js/demo.js"></script>
<!-- page script -->
<script>
  $(function () {
   

       //-------------
    //- PIE CHART 2 -
    //-------------
    var pieChartCanvas = $("#pieChart").get(0).getContext("2d");
    var pieChart = new Chart(pieChartCanvas);
    var PieData = [
     {
        value: <% = this.Qteof%>,
         color: "#f56954",
         highlight: "#f56954",
          label: "Quantité OF"
      },
      {
        value: <% = this.Coupe%>,
          color: "#00a65a",
          highlight: "#00a65a",
          label: "Coupe"
      },
      {
        value: <% = this.Montage%>,
          color: "#f39c12",
          highlight: "#f39c12",
          label: "Montage"
      },
      {
        value: <% = this.Controle%>,
          color: "#00c0ef",
          highlight: "#00c0ef",
          label: "Controle"
      },
      {
        value: <% = this.Finition%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
          label: "Finition"
      },
      {
        value: <% = this.Exped%>,
          color: "#3c7abc",
          highlight: "#3c7abc",
          label: "Exped"
      }
    ];
    var pieOptions = {
      //Boolean - Whether we should show a stroke on each segment
      segmentShowStroke: true,
      //String - The colour of each segment stroke
      segmentStrokeColor: "#fff",
      //Number - The width of each segment stroke
      segmentStrokeWidth: 2,
      //Number - The percentage of the chart that we cut out of the middle
      percentageInnerCutout: 50, // This is 0 for Pie charts
      //Number - Amount of animation steps
      animationSteps: 100,
      //String - Animation easing effect
      animationEasing: "easeOutBounce",
      //Boolean - Whether we animate the rotation of the Doughnut
      animateRotate: true,
      //Boolean - Whether we animate scaling the Doughnut from the centre
      animateScale: false,
      //Boolean - whether to make the chart responsive to window resizing
      responsive: true,
      // Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio: true,
      //String - A legend template
    };
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    pieChart.Doughnut(PieData, pieOptions);





 

  

      
 //-------------
    //- PIE CHART 1 -
    //-------------
    var pieChartCanvas1 = $("#pieChart1").get(0).getContext("2d");
    var pieChart1 = new Chart(pieChartCanvas1);
    var PieData1 = [
     {
        value: <% = this.Qtedemand%>,
         color: "#f56954",
         highlight: "#f56954",
         label: "Quantité Demandé"
      },
      {
        value: <% = this.Qtexp%>,
          color: "#00a65a",
          highlight: "#00a65a",
          label: "Quantité Expedies"
      }
    ];
    var pieOptions1 = {
      //Boolean - Whether we should show a stroke on each segment
      segmentShowStroke: true,
      //String - The colour of each segment stroke
      segmentStrokeColor: "#fff",
      //Number - The width of each segment stroke
      segmentStrokeWidth: 2,
      //Number - The percentage of the chart that we cut out of the middle
      percentageInnerCutout: 50, // This is 0 for Pie charts
      //Number - Amount of animation steps
      animationSteps: 100,
      //String - Animation easing effect
      animationEasing: "easeOutBounce",
      //Boolean - Whether we animate the rotation of the Doughnut
      animateRotate: true,
      //Boolean - Whether we animate scaling the Doughnut from the centre
      animateScale: false,
      //Boolean - whether to make the chart responsive to window resizing
      responsive: true,
      // Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio: true,
      //String - A legend template
    };
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    pieChart1.Doughnut(PieData1, pieOptions1);



       //
      //
    var pieChartCanvas2 = $("#pieChart2").get(0).getContext("2d");
    var pieChart2 = new Chart(pieChartCanvas2);
    var PieData2 = [
     {
        value: <% = this.Qtelivree%>,
         color: "#00c0ef",
         highlight: "#00c0ef",
         label: "Quantité livrée"
     },
      {
        value: <% = this.Qte2CH%>,
          color: "#f56954",
          highlight: "#f56954",
          label: "Quantité 2CH"
      }
     
    ];
    var pieOptions2 = {
      //Boolean - Whether we should show a stroke on each segment
      segmentShowStroke: true,
      //String - The colour of each segment stroke
      segmentStrokeColor: "#fff",
      //Number - The width of each segment stroke
      segmentStrokeWidth: 2,
      //Number - The percentage of the chart that we cut out of the middle
      percentageInnerCutout: 50, // This is 0 for Pie charts
      //Number - Amount of animation steps
      animationSteps: 100,
      //String - Animation easing effect
      animationEasing: "easeOutBounce",
      //Boolean - Whether we animate the rotation of the Doughnut
      animateRotate: true,
      //Boolean - Whether we animate scaling the Doughnut from the centre
      animateScale: false,
      //Boolean - whether to make the chart responsive to window resizing
      responsive: true,
      // Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio: true,
      //String - A legend template
    };
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    pieChart2.Doughnut(PieData2, pieOptions2);



  });
</script>

</asp:Content>


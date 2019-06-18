<%@ Page Title="" Language="C#" MasterPageFile="~/Charts/ChartMaster.Master" AutoEventWireup="true" CodeBehind="ChartJs2.aspx.cs" Inherits="Web_Application_Activity.Charts.ChartJs2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       
    <section class="content-header">
      <h1>
        Les Statistiques
        <small>Aperçu simple</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Accueil</a></li>
        <li class="active"><a href="#">Les Statistiques</a></li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content" >
      <div class="row" >
        <div class="col-md-6">
          <!-- AREA CHART -->
          <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Statistique de <asp:Label ID="LabelChiffre2" runat="server" Text="null"></asp:Label> de <a class="text-teal" href="#"><i class="fa fa-square"></i></a>
        <asp:Label ID="LabelAnn1" runat="server" Text="2015"></asp:Label> <a class="text-light-blue" href="#"><i class="fa fa-square"></i></a> <asp:Label ID="LabelAnn2" runat="server" Text="2016"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <div class="chart">
                <canvas id="areaChartCA" style="height:250px"></canvas>
              </div>

                <div class="box-footer">
                    <div>
                        <table>
                            <tr>
                                
                                <td>
                                <asp:Label ID="LabelChiffre3" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                <td> <a class="text-teal"  href="#"><i class="fa fa-square"></i></a></td>
                                
                                <td>
                                    
                <asp:TextBox ID="TextAnn1" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                                    et l'année 
                                </td>
                                <td> <a class="text-light-blue" href="#"><i class="fa fa-square"></i></a></td>
                                
                                <td>
                                   
                <asp:TextBox ID="TextAnn2" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Buttom1" runat="server"  class="btn btn-info" OnClick="UpdateArea" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
                 </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          <!-- Bar CHART Client -->
          <div class="box box-danger">
            <div class="box-header with-border">
              <h3 class="box-title">Solde client de <asp:Label ID="LabelBarClient" runat="server" Text="null"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
                <div class="col-md-9">
              <canvas id="barChartClient" style="height:250px"></canvas>
                    </div>
                <div class="col-md-3">
                    <asp:GridView ID="GridViewbarClient" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Clients :"  ItemStyle-ForeColor="#3c8dbc" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Small" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                    <span class="label label-primary">
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
                                
                                <td>
                              
                                Choisir autre client
                                      </td>
                                <td>
                                   
                <asp:TextBox ID="TextBarClient" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button2" runat="server"  class="btn btn-info" OnClick="UpdateBarClient" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
                      <div class="box box-info">
 
                             <div class="box-header with-border">
              <h3 class="box-title">Solde Banque :</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <canvas id="pieChartBanque" style="height:250px"></canvas>
            </div>


                        </div>


        </div>
        <!-- /.col (LEFT) -->
        <div class="col-md-6">

          <div class="box box-info">
            <div class="box-header with-border">
              <h3 class="box-title">Solde Fournisseur de <asp:Label ID="LabelBarFournisseur" runat="server" Text="null"></asp:Label>   </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <div class="box-body">
                  <div class="col-md-9">
              <canvas id="barChartFournisseur" style="height:250px"></canvas>

                  </div>
                  <div class="col-md-3">
                    <asp:GridView ID="GridViewbarFournisseur" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Fournisseurs :"  ItemStyle-ForeColor="#3c8dbc" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Small" />
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                    <span class="label label-primary">
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
                                
                                <td>
                                    Choisir autre fournisseur :
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextBarFournisseur" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button3" runat="server"  class="btn btn-info" OnClick="UpdateBarFournisseur" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          
          <div class="box box-danger">

                              <div class="box-header with-border">
              <h3 class="box-title">Solde fournisseur de <asp:Label ID="LabelPieFournisseur" runat="server" Text="null"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
                                  <div class="col-md-9">

              <canvas id="pieChartFournisseur" style="height:250px"></canvas>
                                      </div>
                <div class="col-md-3">

                    <asp:GridView ID="GridViewpieFournisseur" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Fournisseurs :"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Small" />
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
                                
                                <td>
                                Choisir autre fournisseur :
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextPieFournisseur" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button1" runat="server"  class="btn btn-info" OnClick="UpdatePieFournisseur" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
                        </div>
 
            <!-- /.box -->

        </div>
         
        <!-- /.col (RIGHT) -->
         <div class="col-md-6">
                      <div class="box box-danger">

                              <div class="box-header with-border">
              <h3 class="box-title">Solde client de <asp:Label ID="LabelPieClient" runat="server" Text="null"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
                <div class="col-md-9">

              <canvas id="pieChartClient" style="height:250px"></canvas>

                    </div>
                <div class="col-md-3">
                    <asp:GridView ID="GridViewpieClient" runat="server"  BorderColor="White" AutoGenerateColumns="false">
                    <Columns>
                    <asp:BoundField DataField="t1" HeaderText="Clients :"  ItemStyle-ForeColor="#cc3300" HeaderStyle-Font-Size="Large" ItemStyle-Font-Bold="true" ItemStyle-Font-Size="Small" />
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
                                
                                <td>
                                Choisir autre client :
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextPieClient" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button5" runat="server"  class="btn btn-info" OnClick="UpdatePieClient" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
                        </div>


        </div>
      </div>
      <!-- /.row -->

    </section>
    <!-- /.content -->






    
<!-- jQuery 2.2.0 -->
<script src="../../plugins/jQuery/jQuery-2.2.0.min.js"></script>
<!-- Bootstrap 3.3.6 -->
<script src="../../bootstrap/js/bootstrap.min.js"></script>
<!-- ChartJS 1.0.1 -->
<script src="../../plugins/chartjs/Chart.min.js"></script>
<!-- FastClick -->
<script src="../../plugins/fastclick/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/app.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
<!-- page script -->
<script>
  $(function () {
    /* ChartJS
     * -------
     * Here we will create a few charts using ChartJS
     */

    //--------------
    //- AREA CHART CA-
    //--------------

    // Get context with jQuery - using jQuery's .get() method.
    var areaChartCanvas = $("#areaChartCA").get(0).getContext("2d");
    // This will get the first returned node in the jQuery collection.
    var areaChart = new Chart(areaChartCanvas);

    var areaChartData = {
        labels: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
          {
              label: "Electronics",
              fillColor: "rgba(210, 214, 222, 1)",
              strokeColor: "rgba(210, 214, 222, 1)",
              pointColor: "rgba(210, 214, 222, 1)",
              pointStrokeColor: "#c1c7d1",
              pointHighlightFill: "#fff",
              pointHighlightStroke: "rgba(220,220,220,1)",
              data: [<% = this.January%>,<% = this.February%>,<% = this.March%>,<% = this.April%>,<% = this.May%>,<% = this.June%>,<% = this.July%>,<% = this.August%>,<% = this.September%>,<% = this.October%>,<% = this.November%>,<% = this.December%>]
          },
        {
            label: "Digital Goods",
            fillColor: "rgba(60,141,188,0.9)",
            strokeColor: "rgba(60,141,188,0.8)",
            pointColor: "#3b8bba",
            pointStrokeColor: "rgba(60,141,188,1)",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(60,141,188,1)",
            data: [<% = this.Januar%>,<% = this.Februar%>,<% = this.Marc%>,<% = this.Apri%>,<% = this.Ma%>,<% = this.Jun%>,<% = this.Jul%>,<% = this.Augus%>,<% = this.Septembe%>,<% = this.Octobe%>,<% = this.Novembe%>,<% = this.Decembe%>]
        }
      ] 
    };

    var areaChartOptions = {
      //Boolean - If we should show the scale at all
      showScale: true,
      //Boolean - Whether grid lines are shown across the chart
      scaleShowGridLines: false,
      //String - Colour of the grid lines
      scaleGridLineColor: "rgba(0,0,0,.05)",
      //Number - Width of the grid lines
      scaleGridLineWidth: 1,
      //Boolean - Whether to show horizontal lines (except X axis)
      scaleShowHorizontalLines: true,
      //Boolean - Whether to show vertical lines (except Y axis)
      scaleShowVerticalLines: true,
      //Boolean - Whether the line is curved between points
      bezierCurve: true,
      //Number - Tension of the bezier curve between points
      bezierCurveTension: 0.3,
      //Boolean - Whether to show a dot for each point
      pointDot: false,
      //Number - Radius of each point dot in pixels
      pointDotRadius: 4,
      //Number - Pixel width of point dot stroke
      pointDotStrokeWidth: 1,
      //Number - amount extra to add to the radius to cater for hit detection outside the drawn point
      pointHitDetectionRadius: 20,
      //Boolean - Whether to show a stroke for datasets
      datasetStroke: true,
      //Number - Pixel width of dataset stroke
      datasetStrokeWidth: 2,
      //Boolean - Whether to fill the dataset with a color
      datasetFill: true,
      //String - A legend template
      //Boolean - whether to maintain the starting aspect ratio or not when responsive, if set to false, will take up entire container
      maintainAspectRatio: true,
      //Boolean - whether to make the chart responsive to window resizing
      responsive: true
    };

    areaChart.Line(areaChartData, areaChartOptions);




       //-------------
    //- PIE CHART Banque -
    //-------------
    // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas = $("#pieChartBanque").get(0).getContext("2d");
    var pieChart = new Chart(pieChartCanvas);
    var PieData = [
      {
        value: <% = this.BIATD%>,
          color: "#d2d6de",
          highlight: "#d2d6de",
          label: "BIAT DT"
      },
      {
        value: <% = this.BIATE%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
          label: "BIAT EUR"
      },
      {
        value: <% = this.STB%>,
        color: "#f39c12",
        highlight: "#f39c12",
        label: "STB DT"
      },
   
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
      //- PIE CHART Solde Client -
      //-------------
      // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas2 = $("#pieChartClient").get(0).getContext("2d");
    var pieChart2 = new Chart(pieChartCanvas2);
    var PieData2 = [
      {
          value: <% = this.Debit1%>,
          color: "#f56954",
          highlight: "#f56954",
          label: "Debit "
      },
      {
          value: <% = this.Credit1%>,
          color: "#00a65a",
          highlight: "#00a65a",
          label: "Credit "
      },
      {
          value: <% = this.Solde1%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
          label: "Solde"
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


       //-------------
      //- PIE CHART Solde Fournisseur -
      //-------------
      // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas2 = $("#pieChartFournisseur").get(0).getContext("2d");
    var pieChart2 = new Chart(pieChartCanvas2);
    var PieData2 = [
      {
          value: <% = this.DebitF1%>,
          color: "#f56954",
          highlight: "#f56954",
          label: "Debit "
      },
      {
          value: <% = this.CreditF1%>,
          color: "#00a65a",
          highlight: "#00a65a",
          label: "Credit "
      },
      {
          value: <% = this.SoldeF1%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
          label: "Solde"
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





  
   

    //-------------
    //- BAR CHART Client -
    //-------------
    var barChartCanvas = $("#barChartClient").get(0).getContext("2d");
    var barChart = new Chart(barChartCanvas);
    var barChartData = {
        labels: ["Debit", "Credit", "Solde"],
        datasets: [
            
          
          {
              fillColor: "rgba(210, 214, 222, 1)",
              strokeColor: "rgba(210, 214, 222, 1)",
              pointColor: "rgba(210, 214, 222, 1)",
              pointStrokeColor: "#c1c7d1",
              pointHighlightFill: "#fff",
              pointHighlightStroke: "rgba(220,220,220,1)",
              data: [<% = this.Debit%>,<% = this.Credit%>,<% = this.Solde%>]
          },
          {

          }
      ] 
    };
    barChartData.datasets[1].fillColor = "#00a65a";
    barChartData.datasets[1].strokeColor = "#00a65a";
    barChartData.datasets[1].pointColor = "#00a65a";
    var barChartOptions = {
      //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
      scaleBeginAtZero: true,
      //Boolean - Whether grid lines are shown across the chart
      scaleShowGridLines: true,
      //String - Colour of the grid lines
      scaleGridLineColor: "rgba(0,0,0,.05)",
      //Number - Width of the grid lines
      scaleGridLineWidth: 1,
      //Boolean - Whether to show horizontal lines (except X axis)
      scaleShowHorizontalLines: true,
      //Boolean - Whether to show vertical lines (except Y axis)
      scaleShowVerticalLines: true,
      //Boolean - If there is a stroke on each bar
      barShowStroke: true,
      //Number - Pixel width of the bar stroke
      barStrokeWidth: 2,
      //Number - Spacing between each of the X value sets
      barValueSpacing: 5,
      //Number - Spacing between data sets within X values
      barDatasetSpacing: 1,
      //String - A legend template
      //Boolean - whether to make the chart responsive
      responsive: true,
      maintainAspectRatio: true
    };

    barChartOptions.datasetFill = false;
    barChart.Bar(barChartData, barChartOptions);



        //-------------
    //- BAR CHART Fournisseur -
    //-------------
    var barChartCanvas1 = $("#barChartFournisseur").get(0).getContext("2d");
    var barChart1 = new Chart(barChartCanvas1);
    var barChartData1 = {
        labels: ["Debit", "Credit", "Solde"],
        datasets: [
          {
              fillColor: "rgba(210, 214, 222, 1)",
              strokeColor: "rgba(210, 214, 222, 1)",
              pointColor: "rgba(210, 214, 222, 1)",
              pointStrokeColor: "#c1c7d1",
              pointHighlightFill: "#fff",
              pointHighlightStroke: "rgba(220,220,220,1)",
              data: [<% = this.DebitF%>,<% = this.CreditF%>,<% = this.SoldeF%>]
          },
          {
             
          }
      ] 
    };
    barChartData1.datasets[1].fillColor = "#00a65a";
    barChartData1.datasets[1].strokeColor = "#00a65a";
    barChartData1.datasets[1].pointColor = "#00a65a";
    var barChartOptions1 = {
      //Boolean - Whether the scale should start at zero, or an order of magnitude down from the lowest value
      scaleBeginAtZero: true,
      //Boolean - Whether grid lines are shown across the chart
      scaleShowGridLines: true,
      //String - Colour of the grid lines
      scaleGridLineColor: "rgba(0,0,0,.05)",
      //Number - Width of the grid lines
      scaleGridLineWidth: 1,
      //Boolean - Whether to show horizontal lines (except X axis)
      scaleShowHorizontalLines: true,
      //Boolean - Whether to show vertical lines (except Y axis)
      scaleShowVerticalLines: true,
      //Boolean - If there is a stroke on each bar
      barShowStroke: true,
      //Number - Pixel width of the bar stroke
      barStrokeWidth: 2,
      //Number - Spacing between each of the X value sets
      barValueSpacing: 5,
      //Number - Spacing between data sets within X values
      barDatasetSpacing: 1,
      //String - A legend template
      //Boolean - whether to make the chart responsive
      responsive: true,
      maintainAspectRatio: true
    };

    barChartOptions1.datasetFill = false;
    barChart1.Bar(barChartData1, barChartOptions1);
      

  


  });
</script>
</asp:Content>

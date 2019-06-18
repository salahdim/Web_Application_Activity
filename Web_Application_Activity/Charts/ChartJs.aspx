<%@ Page Title="" Language="C#" MasterPageFile="~/Charts/ChartMaster.Master" AutoEventWireup="true" CodeBehind="ChartJs.aspx.cs" Inherits="Web_Application_Activity.Charts.ChartJs" %>
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
                <canvas id="areaChart" style="height:250px"></canvas>
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

          <!-- Bar CHART 2 -->
          <div class="box box-danger">
            <div class="box-header with-border">
              <h3 class="box-title">Statistique <a class="text-gray" href="#"><i class="fa fa-square"></i></a> <asp:Label ID="LabelChiffre4" runat="server" Text="null"></asp:Label> / <a class="text-orange" href="#"><i class="fa fa-square"></i></a> <asp:Label ID="LabelAchat1" runat="server" Text="null"></asp:Label> en <asp:Label ID="LabelAnn4" runat="server" Text="2015"></asp:Label>  </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <canvas id="barChart2" style="height:250px"></canvas>
            </div>
              
                
                <div class="box-footer">
                    <div>
                        <table>
                            <tr>
                                
                                <td>
                                <asp:Label ID="LabelChiffre5" runat="server" Text="null"></asp:Label> / <asp:Label ID="LabelAchat2" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextAnn4" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button2" runat="server"  class="btn btn-info" OnClick="UpdateBar2" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

        </div>
        <!-- /.col (LEFT) -->
        <div class="col-md-6">
          <!-- LINE CHART -->
          <div class="box box-info">
            <div class="box-header with-border">
              <h3 class="box-title">Statistique <a class="text-gray" href="#"><i class="fa fa-square"></i></a> <asp:Label ID="LabelChiffre6" runat="server" Text="null"></asp:Label> / <a class="text-success" href="#"><i class="fa fa-square"></i></a> <asp:Label ID="LabelMasse1" runat="server" Text="null"></asp:Label>  en <asp:Label ID="LabelAnn5" runat="server" Text="2015"></asp:Label>  </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <div class="chart">
                <canvas id="lineChart" style="height:250px"></canvas>
              </div>
                
                <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                
                                <td>
                                <asp:Label ID="LabelChiffre7" runat="server" Text="null"></asp:Label> / <asp:Label ID="LabelMasse2" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextAnneeLine" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button3" runat="server"  class="btn btn-info" OnClick="UpdateLine" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          <!-- BAR CHART -->

            
          <div class="box box-danger">
            <div class="box-header with-border">
              <h3 class="box-title">Statistique <a class="text-gray" href="#"><i class="fa fa-square"></i></a>
                            <asp:Label ID="LabelChiffre8" runat="server" Text="null"></asp:Label>  / <a class="text-success" href="#"><i class="fa fa-square"></i></a><asp:Label ID="LabelPiece1" runat="server" Text="null"></asp:Label>  en <asp:Label ID="LabelAnn3" runat="server" Text="2015"></asp:Label>  </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <canvas id="barChart" style="height:250px"></canvas>
            </div>
              
                
                <div class="box-footer">
                    <div>
                        <table>
                            <tr>
                                
                                <td>
                                <asp:Label ID="LabelChiffre9" runat="server" Text="null"></asp:Label> / <asp:Label ID="LabelPiece2" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextAnn3" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button1" runat="server"  class="btn btn-info" OnClick="UpdateBar" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
           
            <!-- /.box-body -->
          </div>
      
            <!-- /.box -->

        </div>
         <div class="col-md-6">
                   <div class="box box-info">
 
                             <div class="box-header with-border">
              <h3 class="box-title">Statistique de <asp:Label ID="LabelTresorerie1" runat="server" Text="null"></asp:Label> de 
        <asp:Label ID="LabelAnn6" runat="server" Text="2015"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <canvas id="pieChart" style="height:250px"></canvas>
            </div>

                            <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                
                                <td>
                                <asp:Label ID="LabelTresorerie2" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextAnn6" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button4" runat="server"  class="btn btn-info" OnClick="UpdatePie1" Font-Bold="true" Text="Modifier" />                             

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
              <h3 class="box-title">Statistique de <asp:Label ID="LabelActif1" runat="server" Text="null"></asp:Label> de 
        <asp:Label ID="LabelAnn7" runat="server" Text="2015"></asp:Label> Total : <asp:Label ID="LabelTotal" runat="server" Text="null"></asp:Label> </h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <canvas id="pieChart1" style="height:250px"></canvas>
            </div>
             <div class="box-footer">
                    <div>
                        <table>
                             <tr>
                                
                                <td>
                                <asp:Label ID="LabelActif2" runat="server" Text="null"></asp:Label> de l'année 
                                </td>
                                

                                <td>
                                   
                <asp:TextBox ID="TextAnn7" class="form-control" runat="server"></asp:TextBox>
                                </td>

                                <td>
                <asp:Button ID="Button5" runat="server"  class="btn btn-info" OnClick="UpdatePie2" Font-Bold="true" Text="Modifier" />                             

                                </td>

                            </tr>
                        </table>

                   

                    
                        </div>
                </div>
                        </div>


           </div>
        <!-- /.col (RIGHT) -->
          

      </div>
      <!-- /.row -->

    </section>
    <!-- /.content -->


    <!-- ./wrapper -->

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
    //- AREA CHART -
    //--------------

    // Get context with jQuery - using jQuery's .get() method.
    var areaChartCanvas = $("#areaChart").get(0).getContext("2d");
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

    //Create the line chart
    areaChart.Line(areaChartData, areaChartOptions);




       //-------------
    //- PIE CHART  -
    //-------------
    // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas = $("#pieChart").get(0).getContext("2d");
    var pieChart = new Chart(pieChartCanvas);
    var PieData = [
      {
        value: <% = this.Banque1%>,
          color: "#d2d6de",
          highlight: "#d2d6de",
        label: "Solde Banque principale"
      },
      {
        value: <% = this.Banque2%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
        label: "Solde Banque secondaire"
      },
      {
        value: <% = this.Cheque%>,
        color: "#f39c12",
        highlight: "#f39c12",
        label: "Cheques postaux"
      },
      {
        value: <% = this.Caisse%>,
        color: "#00c0ef",
        highlight: "#00c0ef",
        label: "Caisse"
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
      // Get context with jQuery - using jQuery's .get() method.
    var pieChartCanvas2 = $("#pieChart1").get(0).getContext("2d");
    var pieChart2 = new Chart(pieChartCanvas2);
    var PieData2 = [
      {
          value: <% = this.Liquidites%>,
          color: "#f56954",
          highlight: "#f56954",
          label: "Liquidites"
      },
      {
          value: <% = this.stocks%>,
          color: "#00a65a",
          highlight: "#00a65a",
          label: "Creances et stocks"
      },
      {
          value: <% = this.Fonds%>,
          color: "#f39c12",
          highlight: "#f39c12",
          label: "Fonds places"
      },
      {
          value: <% = this.meubles%>,
          color: "#00c0ef",
          highlight: "#00c0ef",
          label: "Immobilisations meubles"
      },
      {
          value: <% = this.immeubles%>,
          color: "#3c8dbc",
          highlight: "#3c8dbc",
          label: "Immobilisations immeubles"
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
    //- LINE CHART -
    //--------------
    var lineChartCanvas = $("#lineChart").get(0).getContext("2d");
    var lineChart = new Chart(lineChartCanvas);
    var lineChartData = {
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
              data: [<% = this.t1%>,<% = this.t2%>,<% = this.t3%>,<% = this.t4%>,<% = this.t5%>,<% = this.t6%>,<% = this.t7%>,<% = this.t8%>,<% = this.t9%>,<% = this.t10%>,<% = this.t11%>,<% = this.t12%>]
          },
        {
            label: "Digital Goods",
            fillColor: "rgba(60,141,188,0.9)",
            strokeColor: "rgba(60,141,188,0.8)",
            pointColor: "#3b8bba",
            pointStrokeColor: "rgba(60,141,188,1)",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(60,141,188,1)",
            data: [<% = this.tt1%>,<% = this.tt2%>,<% = this.tt3%>,<% = this.tt4%>,<% = this.tt5%>,<% = this.tt6%>,<% = this.tt7%>,<% = this.tt8%>,<% = this.tt9%>,<% = this.tt10%>,<% = this.tt11%>,<% = this.tt12%>]
        }
      ] 
    };
      var lineChartOptions = {
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
    lineChartOptions.datasetFill = false;
    lineChart.Line(lineChartData, lineChartOptions);

   

    //-------------
    //- BAR CHART 1 -
    //-------------
    var barChartCanvas = $("#barChart").get(0).getContext("2d");
    var barChart = new Chart(barChartCanvas);
    var barChartData = {
        labels: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
          {
              label: "CA",
              fillColor: "rgba(210, 214, 222, 1)",
              strokeColor: "rgba(210, 214, 222, 1)",
              pointColor: "rgba(210, 214, 222, 1)",
              pointStrokeColor: "#c1c7d1",
              pointHighlightFill: "#fff",
              pointHighlightStroke: "rgba(220,220,220,1)",
              data: [<% = this.January1%>,<% = this.February1%>,<% = this.March1%>,<% = this.April1%>,<% = this.May1%>,<% = this.June1%>,<% = this.July1%>,<% = this.August1%>,<% = this.September1%>,<% = this.October1%>,<% = this.November1%>,<% = this.December1%>]
          },
        {
            label: "Nembre de piece",
            fillColor: "rgba(60,141,188,0.9)",
            strokeColor: "rgba(60,141,188,0.8)",
            pointColor: "#3b8bba",
            pointStrokeColor: "rgba(60,141,188,1)",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(60,141,188,1)",
            data: [<% = this.Januar1%>,<% = this.Februar1%>,<% = this.Marc1%>,<% = this.Apri1%>,<% = this.Ma1%>,<% = this.Jun1%>,<% = this.Jul1%>,<% = this.Augus1%>,<% = this.Septembe1%>,<% = this.Octobe1%>,<% = this.Novembe1%>,<% = this.Decembe1%>]
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
    //- BAR CHART 2 -
    //-------------
    var barChartCanvas2 = $("#barChart2").get(0).getContext("2d");
    var barChart2 = new Chart(barChartCanvas2);
    var barChartData2 = {
        labels: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
        datasets: [
          {
              label: "CA",
              fillColor: "rgba(210, 214, 222, 1)",
              strokeColor: "rgba(210, 214, 222, 1)",
              pointColor: "rgba(210, 214, 222, 1)",
              pointStrokeColor: "#ff851b",
              pointHighlightFill: "#fff",
              pointHighlightStroke: "rgba(220,220,220,1)",
              data: [<% = this.January2%>,<% = this.February2%>,<% = this.March2%>,<% = this.April2%>,<% = this.May2%>,<% = this.June2%>,<% = this.July2%>,<% = this.August2%>,<% = this.September2%>,<% = this.October2%>,<% = this.November2%>,<% = this.December2%>]
          },
        {
            label: "Achat",
            fillColor: "rgba(60,141,188,0.9)",
            strokeColor: "rgba(60,141,188,0.8)",
            pointColor: "#dd4b39",
            pointStrokeColor: "rgba(60,141,188,1)",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(60,141,188,1)",
            data: [<% = this.Januar2%>,<% = this.Februar2%>,<% = this.Marc2%>,<% = this.Apri2%>,<% = this.Ma2%>,<% = this.Jun2%>,<% = this.Jul2%>,<% = this.Augus2%>,<% = this.Septembe2%>,<% = this.Octobe2%>,<% = this.Novembe2%>,<% = this.Decembe2%>]
        }
      ] 
    };
      barChartData2.datasets[1].fillColor = "#ff851b";
      barChartData2.datasets[1].strokeColor = "#ff851b";
      barChartData2.datasets[1].pointColor = "#ff851b";
    var barChartOptions2 = {
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

    barChartOptions2.datasetFill = false;
    barChart2.Bar(barChartData2, barChartOptions2);


  });
</script>

</asp:Content>

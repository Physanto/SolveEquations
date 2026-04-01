using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using ProjectIntegrated2.Model;
namespace ProjectIntegrated2.View
{
    public partial class Frm : Form
    {
        private PlotModel plotModel;
        private PlotView plotView;

        public Frm()
        {
            InitializeComponent();

            plotModel = new PlotModel();
            plotView = new PlotView();

            this.FormClosing += new FormClosingEventHandler(Frm_FormClosing);
        }

        public void InitializePlot()
        {

            plotView.Dock = DockStyle.Fill;
            plotModel.Background = OxyColor.FromRgb(245, 255, 250);

            var xAxis = AxisX();
            var yAxis = AxisY();

            plotModel.Axes.Add((Axis)xAxis);
            plotModel.Axes.Add((Axis)yAxis);
        }
        public void LinearSeries(double a, double b)
        {
            InitializePlot();

            var linearSeries = new LineSeries();
            linearSeries = new FunctionSeries(x => a * x + b, -10, 10, 0.1, $"y = {a}x + {b}");

            plotModel.Series.Add(linearSeries);
            plotView.InvalidatePlot(true);

            plotView.Model = plotModel;
            pnlGrafico.Controls.Add(plotView);
        }

        public void LinearSeries2(double a, double b, double c, double a2, double b2, double c2)
        {
            InitializePlot();
            MessageBox.Show($" coeficientes identificados en orden: {a}   {b}    {c}    {a2}    {b2}    {c2}");

            var linearSeries = new LineSeries();
            var lineSeries = new LineSeries();

            linearSeries = new FunctionSeries(x => (a * x + b) / c, -10, 10, 0.1, $"y = {a}x + {b}");
            lineSeries = new FunctionSeries(x => (a2 * x + b2) / c2, -10, 10, 0.1, $"y = {a2}x + {b2}");

            plotModel.Series.Add(linearSeries);
            plotModel.Series.Add(lineSeries);

            //plotView.InvalidatePlot(true);

            plotView.Model = plotModel;
            pnlGrafico.Controls.Add(plotView);
        }

        public void QuadraticSeries(double a, double b, double c, double x1, double x2)
        {
            InitializePlot();

            var linearSeries = new LineSeries();
            linearSeries = new FunctionSeries(x => a * Math.Pow(x, 2) + b * x + c, x1 - 20, x2 + 20, 0.1, $"y = {a}x^2 + {b}x + {c}");
            plotModel.Series.Add(linearSeries);

            linearSeries.Color = OxyColor.FromRgb(30, 144, 255);
            plotView.InvalidatePlot(true);

            plotView.Model = plotModel;
            pnlGrafico.Controls.Add(plotView);

        }
        private object AxisX()
        {
            var axis = new LinearAxis()
            {
                TextColor = OxyColor.FromRgb(0, 5, 5),
                Position = AxisPosition.Bottom,
                PositionAtZeroCrossing = true,
                AxislineStyle = LineStyle.Solid,
                AxislineThickness = 2,
                AxislineColor = OxyColors.Black,
                MajorGridlineStyle = LineStyle.LongDash,
                MinorGridlineStyle = LineStyle.LongDash,
                Minimum = -25,
                Maximum = 25
            };

            return axis;
        }

        private object AxisY()
        {
            var axis = new LinearAxis()
            {
                TextColor = OxyColor.FromRgb(0, 5, 5),
                Position = AxisPosition.Left,
                PositionAtZeroCrossing = true,
                AxislineStyle = LineStyle.Solid,
                AxislineThickness = 2,
                AxislineColor = OxyColors.Black,
                MajorGridlineStyle = LineStyle.LongDash,
                MinorGridlineStyle = LineStyle.LongDash,
                Minimum = -30,
                Maximum = 30
            };

            return axis;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm frm = new Frm();
            frm.Close();

            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
        }
    }
}

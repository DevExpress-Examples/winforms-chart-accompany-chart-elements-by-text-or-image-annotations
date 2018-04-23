Namespace AnnotationsSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisX1 As New DevExpress.XtraCharts.SecondaryAxisX()
            Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(15R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(6R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(19R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(9R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(21R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(13R, Object))})
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (DirectCast(240R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (DirectCast(160R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (DirectCast(260R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("4", New Object() { (DirectCast(190R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("5", New Object() { (DirectCast(310R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("6", New Object() { (DirectCast(170R, Object))})
            Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisX1.AxisID = 0
            secondaryAxisX1.Name = "Secondary AxisX 1"
            secondaryAxisX1.VisibleInPanesSerializable = "0"
            secondaryAxisX1.VisualRange.Auto = False
            secondaryAxisX1.VisualRange.AutoSideMargins = True
            secondaryAxisX1.VisualRange.MaxValueSerializable = "5"
            secondaryAxisX1.VisualRange.MinValueSerializable = "1"
            secondaryAxisX1.WholeRange.AutoSideMargins = True
            xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() { secondaryAxisX1})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY1.WholeRange.AutoSideMargins = True
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6})
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
            splineSeriesView1.AxisXName = "Secondary AxisX 1"
            splineSeriesView1.AxisYName = "Secondary AxisY 1"
            splineSeriesView1.PaneName = "Pane 1"
            series2.View = splineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            Me.chartControl1.Size = New System.Drawing.Size(691, 473)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(691, 473)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl


    End Class
End Namespace


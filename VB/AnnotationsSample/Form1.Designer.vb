Imports Microsoft.VisualBasic
Imports System
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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim XyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim SecondaryAxisX1 As DevExpress.XtraCharts.SecondaryAxisX = New DevExpress.XtraCharts.SecondaryAxisX()
            Dim SecondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(15.0R, Object)})
            Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(6.0R, Object)})
            Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(19.0R, Object)})
            Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(9.0R, Object)})
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {CType(21.0R, Object)})
            Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("F", New Object() {CType(13.0R, Object)})
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("1", New Object() {CType(240.0R, Object)})
            Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2", New Object() {CType(160.0R, Object)})
            Dim SeriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("3", New Object() {CType(260.0R, Object)})
            Dim SeriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("4", New Object() {CType(190.0R, Object)})
            Dim SeriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("5", New Object() {CType(310.0R, Object)})
            Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("6", New Object() {CType(170.0R, Object)})
            Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SecondaryAxisX1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            XyDiagram1.EnableAxisXScrolling = True
            XyDiagramPane1.Name = "Pane 1"
            XyDiagramPane1.PaneID = 0
            XyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane1})
            SecondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            SecondaryAxisX1.AxisID = 0
            SecondaryAxisX1.Name = "Secondary AxisX 1"
            SecondaryAxisX1.VisibleInPanesSerializable = "0"
            SecondaryAxisX1.VisualRange.Auto = False
            SecondaryAxisX1.VisualRange.AutoSideMargins = True
            SecondaryAxisX1.VisualRange.MaxValueSerializable = "5"
            SecondaryAxisX1.VisualRange.MinValueSerializable = "1"
            SecondaryAxisX1.WholeRange.AutoSideMargins = True
            XyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() {SecondaryAxisX1})
            SecondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            SecondaryAxisY1.AxisID = 0
            SecondaryAxisY1.GridLines.Visible = True
            SecondaryAxisY1.Name = "Secondary AxisY 1"
            SecondaryAxisY1.VisibleInPanesSerializable = "0"
            SecondaryAxisY1.WholeRange.AutoSideMargins = True
            XyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY1})
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series1.Name = "Series 1"
            Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5, SeriesPoint6})
            Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series2.Name = "Series 2"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint7, SeriesPoint8, SeriesPoint9, SeriesPoint10, SeriesPoint11, SeriesPoint12})
            SplineSeriesView1.AxisXName = "Secondary AxisX 1"
            SplineSeriesView1.AxisYName = "Secondary AxisY 1"
            SplineSeriesView1.PaneName = "Pane 1"
            Series2.View = SplineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            Me.chartControl1.Size = New System.Drawing.Size(713, 514)
            Me.chartControl1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(713, 514)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SecondaryAxisX1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl


	End Class
End Namespace


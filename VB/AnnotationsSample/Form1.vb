#Region "#usings"
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.XtraCharts

' ...
#End Region  ' #usings
Namespace AnnotationsSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#generalcode"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Add a text annotation to the chart control's repository.
            chartControl1.AnnotationRepository.Add(New TextAnnotation("Annotation 1"))
            ' And, assign a series point to the annotation's AnchorPoint property.
            ' This adds the annotation to the series point's Annotations collection.
            chartControl1.AnnotationRepository(0).AnchorPoint = New SeriesPointAnchorPoint(chartControl1.Series(0).Points(2))
            ' Now, create an image annotation, and add it to the chart's collection.
            chartControl1.Annotations.AddImageAnnotation("Annotation 2", DXImage.FromStream(New FileStream("...\...\image.png", FileMode.Open, FileAccess.Read, FileShare.Read)))
            ' Define the X and Y absolute coordinates for the annotation, in pixels.
            CType(chartControl1.Annotations(0).AnchorPoint, ChartAnchorPoint).X = 150
            CType(chartControl1.Annotations(0).AnchorPoint, ChartAnchorPoint).Y = 150
            ' Obtain the additional pane from the diagram's collection.
            Dim myPane As XYDiagramPaneBase = CType(chartControl1.Diagram, XYDiagram).Panes(0)
            ' And, position the chart's annotation in this pane's right top corner;
            CType(chartControl1.Annotations(0).ShapePosition, FreePosition).DockTarget = myPane
            CType(chartControl1.Annotations(0).ShapePosition, FreePosition).DockCorner = DockCorner.RightTop
            ' Another annotation is now being added to the collection of this pane.
            myPane.Annotations.AddImageAnnotation("Annotation 3", DXImage.FromStream(New FileStream("...\...\image.png", FileMode.Open, FileAccess.Read, FileShare.Read)))
            ' Define its axis coordinates (in units appropriate for the scale type of the axes).
            CType(myPane.Annotations(0).AnchorPoint, PaneAnchorPoint).AxisXCoordinate.AxisValue = 2
            CType(myPane.Annotations(0).AnchorPoint, PaneAnchorPoint).AxisYCoordinate.AxisValue = 180
            ' Position the annotation in relation to its anchor point.
            CType(myPane.Annotations(0).ShapePosition, RelativePosition).Angle = -135
            CType(myPane.Annotations(0).ShapePosition, RelativePosition).ConnectorLength = 50
            ' You can get an annotation either via the collection of the element to which it is anchored,
            ' or centrally, via the chart control's repository (e.g. by its name).
            Dim myTextAnnotation As TextAnnotation = CType(chartControl1.AnnotationRepository.GetElementByName("Annotation 1"), TextAnnotation)
            Dim myImageAnnotation As ImageAnnotation = CType(chartControl1.AnnotationRepository.GetElementByName("Annotation 3"), ImageAnnotation)
            ' Define the text for the text annotation.
            myTextAnnotation.Text = "<i>Basic</i> <b>HTML</b> <u>is</u> <color=blue>supported</color>."
            ' Enable the interactive positioning for the image annotation.
            myImageAnnotation.RuntimeMoving = True
            myImageAnnotation.RuntimeAnchoring = True
            myImageAnnotation.RuntimeResizing = True
            myImageAnnotation.RuntimeRotation = True
            ' Specify image annotation size mode.
            myImageAnnotation.SizeMode = ChartImageSizeMode.Tile
            ' And, adjust image annotation appearance options.
            myImageAnnotation.ShapeKind = ShapeKind.RoundedRectangle
            myImageAnnotation.ShapeFillet = 10
            myImageAnnotation.ConnectorStyle = AnnotationConnectorStyle.Arrow
        End Sub
#End Region  ' #generalcode
    End Class
End Namespace

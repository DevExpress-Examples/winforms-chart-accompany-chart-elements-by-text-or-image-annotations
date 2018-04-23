#region #usings
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace AnnotationsSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #generalcode
private void Form1_Load(object sender, EventArgs e) {
    // Add a text annotation to the chart control's repository.
    chartControl1.AnnotationRepository.Add(new TextAnnotation("Annotation 1", "Some text..."));

    // And, assign a series point to the annotation's AnchorPoint property.
    // This adds the annotation to the series point's Annotations collection.
    chartControl1.AnnotationRepository[0].AnchorPoint = 
        new SeriesPointAnchorPoint(chartControl1.Series[0].Points[2]);

    // Now, create an image annotation, and add it to the chart's collection.
    chartControl1.Annotations.AddImageAnnotation("Annotation 2", 
        Bitmap.FromFile(@"...\...\image.png"));

    // Define the X and Y absolute coordinates for the annotation, in pixels.
    ((ChartAnchorPoint)chartControl1.Annotations[0].AnchorPoint).X = 150;
    ((ChartAnchorPoint)chartControl1.Annotations[0].AnchorPoint).Y = 150;

    // Obtain the additional pane from the diagram's collection.
    XYDiagramPaneBase myPane = ((XYDiagram)chartControl1.Diagram).Panes[0];

    // And, position the chart's annotation in this pane's right top corner;
    ((FreePosition)chartControl1.Annotations[0].ShapePosition).DockTarget = myPane;
    ((FreePosition)chartControl1.Annotations[0].ShapePosition).DockCorner = DockCorner.RightTop;

    // Another annotation is now being added to the collection of this pane.
    myPane.Annotations.AddImageAnnotation("Annotation 3", Bitmap.FromFile(@"...\...\image.png"));

    // Define its axis coordinates (in units appropriate for the scale type of the axes).
    ((PaneAnchorPoint)myPane.Annotations[0].AnchorPoint).AxisXCoordinate.AxisValue = 2;
    ((PaneAnchorPoint)myPane.Annotations[0].AnchorPoint).AxisYCoordinate.AxisValue = 180;

    // Position the annotation in relation to its anchor point.
    ((RelativePosition)myPane.Annotations[0].ShapePosition).Angle = -135;
    ((RelativePosition)myPane.Annotations[0].ShapePosition).ConnectorLength = 50;

    // You can get an annotation either via the collection of the element to which it is anchored,
    // or centrally, via the chart control's repository (e.g. by its name).
    ImageAnnotation myImageAnnotation = 
        (ImageAnnotation)chartControl1.AnnotationRepository.GetElementByName("Annotation 3");

    // Enable the interactive positioning for this annotation.
    myImageAnnotation.RuntimeMoving = true;
    myImageAnnotation.RuntimeAnchoring = true;
    myImageAnnotation.RuntimeResizing = true;
    myImageAnnotation.RuntimeRotation = true;

    // Specify its image size mode.
    myImageAnnotation.SizeMode = ChartImageSizeMode.Tile;

    // And, adjust its appearance options.
    myImageAnnotation.ShapeKind = ShapeKind.RoundedRectangle;
    myImageAnnotation.ShapeFillet = 10;
    myImageAnnotation.ConnectorStyle = AnnotationConnectorStyle.Arrow;
}
#endregion #generalcode

    }
}

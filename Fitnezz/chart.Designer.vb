<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chart
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(43829.0R, 45.0R)
		Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(43830.0R, 70.0R)
		Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
		Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Chart1
		'
		Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
		Me.Chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Chart1.BorderlineColor = System.Drawing.Color.Gainsboro
		Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
		Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
		Me.Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
		Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent
		Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle1
		ChartArea1.Area3DStyle.Inclination = 20
		ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
		ChartArea1.Area3DStyle.PointDepth = 200
		ChartArea1.Area3DStyle.PointGapDepth = 50
		ChartArea1.Area3DStyle.Rotation = 10
		ChartArea1.Area3DStyle.WallWidth = 10
		ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
		ChartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		ChartArea1.BorderColor = System.Drawing.Color.White
		ChartArea1.IsSameFontSizeForAllAxes = True
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Me.Chart1.Location = New System.Drawing.Point(12, 35)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))}
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series1.EmptyPointStyle.BorderWidth = 2
		Series1.Font = New System.Drawing.Font("Lucida Bright", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Series1.IsValueShownAsLabel = True
		Series1.IsVisibleInLegend = False
		Series1.IsXValueIndexed = True
		Series1.Label = "#VAL"
		Series1.LabelBackColor = System.Drawing.Color.Navy
		Series1.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Series1.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Series1.LabelToolTip = "#VALX"
		Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Series1.MarkerColor = System.Drawing.Color.Navy
		Series1.MarkerSize = 8
		Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5
		Series1.Name = "Weight"
		DataPoint1.AxisLabel = ""
		DataPoint1.CustomProperties = "LabelStyle=Top"
		DataPoint1.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataPoint1.IsValueShownAsLabel = True
		DataPoint1.Label = "#VAL"
		DataPoint1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		DataPoint1.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		DataPoint1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
		DataPoint1.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		DataPoint1.LabelToolTip = "#VALX"
		DataPoint2.IsValueShownAsLabel = True
		DataPoint2.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		DataPoint2.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Series1.Points.Add(DataPoint1)
		Series1.Points.Add(DataPoint2)
		Series1.Points.Add(DataPoint3)
		Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No
		Series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
		Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
		Series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
		Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(648, 222)
		Me.Chart1.TabIndex = 0
		Me.Chart1.Text = "Chart1"
		Title1.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Title1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Title1.Name = "Title1"
		Title1.Text = "Weight"
		Me.Chart1.Titles.Add(Title1)
		'
		'chart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Chart1)
		Me.Name = "chart"
		Me.Text = "chart"
		Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer))
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class

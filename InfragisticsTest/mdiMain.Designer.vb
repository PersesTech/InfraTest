<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
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
        Me.components = New System.ComponentModel.Container()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Tool1")
        Dim RibbonTab1 As Infragistics.Win.UltraWinToolbars.RibbonTab = New Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon1")
        Dim RibbonGroup1 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup1")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim RibbonGroup2 As Infragistics.Win.UltraWinToolbars.RibbonGroup = New Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup2")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool7")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool5")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool6")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Tool1")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool4")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool5")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool6")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool7")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._mdiMain_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._mdiMain_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._mdiMain_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._mdiMain_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1})
        RibbonTab1.Caption = "ribbon1"
        RibbonGroup1.Caption = "ribbonGroup1"
        RibbonGroup1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6})
        RibbonGroup2.Caption = "ribbonGroup2"
        ButtonTool15.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.ImageOnly
        ButtonTool12.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large
        RibbonGroup2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool15, ButtonTool11, ButtonTool12})
        RibbonTab1.Groups.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonGroup() {RibbonGroup1, RibbonGroup2})
        Me.UltraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(New Infragistics.Win.UltraWinToolbars.RibbonTab() {RibbonTab1})
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        ButtonTool2.SharedPropsInternal.Caption = "Tool1"
        ButtonTool7.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool8.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool9.SharedPropsInternal.Caption = "ButtonTool3"
        ButtonTool10.SharedPropsInternal.Caption = "ButtonTool4"
        Appearance1.Image = Global.InfragisticsTest.My.Resources.Resources.android_chrome_512x512
        ButtonTool13.SharedPropsInternal.AppearancesSmall.Appearance = Appearance1
        ButtonTool13.SharedPropsInternal.Caption = "ButtonTool5"
        Appearance2.Image = Global.InfragisticsTest.My.Resources.Resources.android_chrome_512x512
        ButtonTool14.SharedPropsInternal.AppearancesLarge.Appearance = Appearance2
        ButtonTool14.SharedPropsInternal.Caption = "ButtonTool6"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        ButtonTool16.SharedPropsInternal.AppearancesSmall.Appearance = Appearance3
        ButtonTool16.SharedPropsInternal.Caption = "ButtonTool7"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool2, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool13, ButtonTool14, ButtonTool16})
        '
        '_mdiMain_Toolbars_Dock_Area_Left
        '
        Me._mdiMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._mdiMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._mdiMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._mdiMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._mdiMain_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8
        Me._mdiMain_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 189)
        Me._mdiMain_Toolbars_Dock_Area_Left.Name = "_mdiMain_Toolbars_Dock_Area_Left"
        Me._mdiMain_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(8, 239)
        Me._mdiMain_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_mdiMain_Toolbars_Dock_Area_Right
        '
        Me._mdiMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._mdiMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._mdiMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._mdiMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._mdiMain_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8
        Me._mdiMain_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(792, 189)
        Me._mdiMain_Toolbars_Dock_Area_Right.Name = "_mdiMain_Toolbars_Dock_Area_Right"
        Me._mdiMain_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(8, 239)
        Me._mdiMain_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_mdiMain_Toolbars_Dock_Area_Top
        '
        Me._mdiMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._mdiMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._mdiMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._mdiMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._mdiMain_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._mdiMain_Toolbars_Dock_Area_Top.Name = "_mdiMain_Toolbars_Dock_Area_Top"
        Me._mdiMain_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(800, 189)
        Me._mdiMain_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_mdiMain_Toolbars_Dock_Area_Bottom
        '
        Me._mdiMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._mdiMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._mdiMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._mdiMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._mdiMain_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 428)
        Me._mdiMain_Toolbars_Dock_Area_Bottom.Name = "_mdiMain_Toolbars_Dock_Area_Bottom"
        Me._mdiMain_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(800, 0)
        Me._mdiMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripSplitButton1, Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me._mdiMain_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._mdiMain_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._mdiMain_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me._mdiMain_Toolbars_Dock_Area_Top)
        Me.IsMdiContainer = True
        Me.Name = "mdiMain"
        Me.Text = "mdiMain"
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _mdiMain_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _mdiMain_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _mdiMain_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _mdiMain_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSplitButton1 As Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripDropDownButton1 As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton2 As Windows.Forms.ToolStripDropDownButton
End Class

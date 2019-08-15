Public Class mdiMain
    Public Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Me.Cursor = Windows.Forms.Cursors.WaitCursor

        Select Case e.Tool.Key
            Case "Tool1"  'AnnualAuto Renew Rate Adjustment letters FOR SHOP EMPLOYERS

                Dim F As New Form1()
                F.Tag = 1
                F.MdiParent = Me
                F.Text = "tool1 Test Form"
                F.Show()
                e.Tool.SharedProps.AppearancesSmall.Appearance.ForeColor = Drawing.Color.Blue
            Case "ButtonTool1"  'AnnualAuto Renew Rate Adjustment letters FOR SHOP EMPLOYERS

                Dim F As New Form1()
                F.Tag = 1
                F.MdiParent = Me
                F.Text = "button tool 1 Test Form"
                F.Show()
                e.Tool.SharedProps.AppearancesSmall.Appearance.ForeColor = Drawing.Color.Blue
            Case "ButtonTool2"  'AnnualAuto Renew Rate Adjustment letters FOR SHOP EMPLOYERS

                Dim F As New Form1()
                F.Tag = 1
                F.MdiParent = Me
                F.Text = "Button tool 2 Test Form"
                F.Show()
                e.Tool.SharedProps.AppearancesSmall.Appearance.ForeColor = Drawing.Color.Blue
            Case "ButtonTool3"  'AnnualAuto Renew Rate Adjustment letters FOR SHOP EMPLOYERS

                Dim F As New Form1()
                F.Tag = 1
                F.MdiParent = Me
                F.Text = "Button tool 3 Test Form"
                F.Show()
                e.Tool.SharedProps.AppearancesSmall.Appearance.ForeColor = Drawing.Color.Blue
            Case Else
                MsgBox("Click one of first 3 tools")
        End Select
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub


End Class
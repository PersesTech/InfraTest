Imports System.Data

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        '   SplitContainer3.Panel1.Controls.Add()
        loadnodes()
        loadGrid()
    End Sub

    Private Sub loadnodes()
        Dim Node As Infragistics.Win.UltraWinTree.UltraTreeNode
        Dim SubNode As Infragistics.Win.UltraWinTree.UltraTreeNode
        Dim rnd As New Random
        Dim Rando

        tvwSelect.Nodes.Clear()

        'Add random amount of nodes
        Rando = rnd.Next(1, 3)
        For i As Integer = 1 To Rando
            Node = tvwSelect.Nodes.Add(Guid.NewGuid.ToString, "ABC 201" + i.ToString)
            Node.LeftImages.Add(My.Resources.images)
        Next

        'Add single node
        Node = tvwSelect.Nodes.Add(Guid.NewGuid.ToString, "Data")
        Node.LeftImages.Add(My.Resources.ts)

        'Node with Subs
        SubNode = tvwSelect.Nodes.Add(Guid.NewGuid.ToString, "Lotta Nodes")
        SubNode.LeftImages.Add(imageList1.Images("FolderNotLoaded"))

        'Random Subnodes
        Rando = rnd.Next(10, 20)
        For i As Integer = 1 To Rando
            Node = SubNode.Nodes.Add(Guid.NewGuid.ToString, "File Number 454" + (i.ToString.PadLeft(2, "0")))
            Node.LeftImages.Add(imageList1.Images("Table"))
        Next


        'Add disabled italics node
        Node = tvwSelect.Nodes.Add(Guid.NewGuid.ToString, "Data")
        Node.LeftImages.Add(My.Resources.images)
        Node.Override.NodeAppearance.FontData.Italic = Infragistics.Win.DefaultableBoolean.True
        Node.Enabled = False

    End Sub

    Private Sub loadGrid()
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Name")
        dt.Columns.Add("Branch")
        dt.Columns.Add("Officer")
        dt.Columns.Add("CustAcct")
        dt.Columns.Add("Grade")
        dt.Columns.Add("Rate")
        dt.Columns.Add("OrigBal")
        dt.Columns.Add("BookBal")
        dt.Columns.Add("Available")
        dt.Columns.Add("Effective")
        dt.Columns.Add("Maturity")
        dt.Columns.Add("Collateral")
        dt.Columns.Add("LoanSource")
        dt.Columns.Add("RBCCode")
        dt.Rows.Add(New Object() {"James Bond, LLC", 120, "Garrison Neely", "123 3428749020", 35, "6.000", "$24,590", "$13,432", "$12,659", "12/13/21", "1/30/27", 55, "ILS", "R"})
        dt.Rows.Add(New Object() {"Cletus Kassady, LLC", 110, "Carnage", "3428749020", 66, "2.000", "$44,590", "$63,432", "$92,659", "11/11/11", "10/10/99", 2, "CCC", "F"})
        dt.Rows.Add(New Object() {"Chicago Bulls, INC", 20, "Michael Jordan", "32", 32, "32.000", "$32,590", "$320,432", "$329", "05/28/06", "09/19/81", 32, "MVP", "3PT"})
        grdResult.DataSource = dt
    End Sub

End Class
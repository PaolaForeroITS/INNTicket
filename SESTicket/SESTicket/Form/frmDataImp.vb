Public Class frmDataImp

    Public sLayoutType As String
    Public sUsername As String

    Dim util As New clsUtils

    Private Sub frmDataImp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sLayoutType = "CONTRACTPRICELIST" Then
            TabControl1.TabPages.Remove(tabEquipment)
            TabControl1.TabPages.Remove(tabWorker)
            TabControl1.TabPages.Remove(tabInvItem)
            TabControl1.TabPages.Remove(tabWell)

        ElseIf sLayoutType = "EQUIPMENT" Then
            TabControl1.TabPages.Remove(tabContrPrice)
            TabControl1.TabPages.Remove(tabWorker)
            TabControl1.TabPages.Remove(tabInvItem)
            TabControl1.TabPages.Remove(tabWell)

        ElseIf sLayoutType = "WORKER" Then
            TabControl1.TabPages.Remove(tabContrPrice)
            TabControl1.TabPages.Remove(tabEquipment)
            TabControl1.TabPages.Remove(tabInvItem)
            TabControl1.TabPages.Remove(tabWell)

        ElseIf sLayoutType = "INVENTORYITEM" Then
            TabControl1.TabPages.Remove(tabContrPrice)
            TabControl1.TabPages.Remove(tabEquipment)
            TabControl1.TabPages.Remove(tabWorker)
            TabControl1.TabPages.Remove(tabWell)

        ElseIf sLayoutType = "WELL" Then
            TabControl1.TabPages.Remove(tabContrPrice)
            TabControl1.TabPages.Remove(tabEquipment)
            TabControl1.TabPages.Remove(tabWorker)
            TabControl1.TabPages.Remove(tabInvItem)

        End If

    End Sub

    Private Sub btnImportData_Click(sender As Object, e As EventArgs) Handles btnImportData.Click

        If txtFilePath.Text = "" Then
            MsgBox("Choose the file", vbInformation)
            Exit Sub
        End If

        If MsgBox("Do you want import the file?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        If sLayoutType = "CONTRACTPRICELIST" Then

            Dim frm As New frmDataImpContrPriceList
            frm.sContractId = ""
            frm.sContractNumber = ""
            frm.sCustomerName = ""

            frm.ShowDialog()

            If frm.sContractId <> "" Then

                Me.Cursor = Cursors.WaitCursor

                txtCustomer.Text = frm.sCustomerName
                txtContract.Text = frm.sContractNumber

                Dim bResult As Boolean
                Dim cls As New clsDataImp
                cls.sUsername = Me.sUsername
                bResult = cls.ContractPriceList(txtFilePath.Text, frm.sContractId)

                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.IMP_CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.IMP_CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.IMP_CONTRACTPRICELIST)

                If bResult = False Then
                    MsgBox("Some Errors were found during the Import Process." & Environment.NewLine & "Check your File. The import is cancelled.", vbInformation)
                Else
                    MsgBox("Data imported successfully", vbInformation)
                End If

                cls.Dispose()
                cls = Nothing

                Me.Cursor = Cursors.Arrow

            Else
                MsgBox("Canceled", vbInformation)
            End If

            frm.Dispose()
            frm = Nothing

        ElseIf sLayoutType = "EQUIPMENT" Then

            Me.Cursor = Cursors.WaitCursor

            Dim bResult As Boolean
            Dim cls As New clsDataImp
            cls.sUsername = Me.sUsername
            bResult = cls.Equipment(txtFilePath.Text)

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.IMP_EQUIPMENT' table. You can move, or remove it, as needed.
            Me.IMP_EQUIPMENTTableAdapter.Fill(Me.SESTicketSQLDataSet.IMP_EQUIPMENT)

            If bResult = False Then
                MsgBox("Some Errors were found during the Import Process." & Environment.NewLine & "Check your File. The import is cancelled.", vbInformation)
            Else
                MsgBox("Data imported successfully", vbInformation)
            End If

            cls.Dispose()
            cls = Nothing

            Me.Cursor = Cursors.Arrow

        ElseIf sLayoutType = "WORKER" Then

            Me.Cursor = Cursors.WaitCursor

            Dim bResult As Boolean
            Dim cls As New clsDataImp
            cls.sUsername = Me.sUsername
            bResult = cls.Worker(txtFilePath.Text)

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.IMP_WORKER' table. You can move, or remove it, as needed.
            Me.IMP_WORKERTableAdapter.Fill(Me.SESTicketSQLDataSet.IMP_WORKER)

            If bResult = False Then
                MsgBox("Some Errors were found during the Import Process." & Environment.NewLine & "Check your File. The import is cancelled.", vbInformation)
            Else
                MsgBox("Data imported successfully", vbInformation)
            End If

            cls.Dispose()
            cls = Nothing

            Me.Cursor = Cursors.Arrow

        ElseIf sLayoutType = "INVENTORYITEM" Then

            Me.Cursor = Cursors.WaitCursor

            Dim bResult As Boolean
            Dim cls As New clsDataImp
            cls.sUsername = Me.sUsername
            bResult = cls.InventoryItem(txtFilePath.Text)

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.IMP_INVENTORYITEM' table. You can move, or remove it, as needed.
            Me.IMP_INVENTORYITEMTableAdapter.Fill(Me.SESTicketSQLDataSet.IMP_INVENTORYITEM)

            If bResult = False Then
                MsgBox("Some Errors were found during the Import Process." & Environment.NewLine & "Check your File. The import is cancelled.", vbInformation)
            Else
                MsgBox("Data imported successfully", vbInformation)
            End If

            cls.Dispose()
            cls = Nothing

            Me.Cursor = Cursors.Arrow

        ElseIf sLayoutType = "WELL" Then

            Me.Cursor = Cursors.WaitCursor

            Dim bResult As Boolean
            Dim cls As New clsDataImp
            cls.sUsername = Me.sUsername
            bResult = cls.Well(txtFilePath.Text)

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.IMP_WELL' table. You can move, or remove it, as needed.
            Me.IMP_WELLTableAdapter.Fill(Me.SESTicketSQLDataSet.IMP_WELL)

            If bResult = False Then
                MsgBox("Some Errors were found during the Import Process." & Environment.NewLine & "Check your File. The import is cancelled.", vbInformation)
            Else
                MsgBox("Data imported successfully", vbInformation)
            End If

            cls.Dispose()
            cls = Nothing

            Me.Cursor = Cursors.Arrow

        End If

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        'abre uma caixa de diálogo
        OpenFileDialog1.ShowDialog()
        txtFilePath.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub dgvImpContrPrice_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpContrPrice.CellDoubleClick
        Dim frm As New frmDataImpDetail
        With frm
            .txtDetail.Text = util.TrataDBNull(dgvImpContrPrice.CurrentCell.Value.ToString).ToString.Replace("#", Environment.NewLine)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub dgvImpEquipment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpEquipment.CellDoubleClick
        Dim frm As New frmDataImpDetail
        With frm
            .txtDetail.Text = util.TrataDBNull(dgvImpEquipment.CurrentCell.Value.ToString).ToString.Replace("#", Environment.NewLine)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub dgvImpWorker_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpWorker.CellDoubleClick
        Dim frm As New frmDataImpDetail
        With frm
            .txtDetail.Text = util.TrataDBNull(dgvImpWorker.CurrentCell.Value.ToString).ToString.Replace("#", Environment.NewLine)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub dgvImpInvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpInvItem.CellDoubleClick
        Dim frm As New frmDataImpDetail
        With frm
            .txtDetail.Text = util.TrataDBNull(dgvImpInvItem.CurrentCell.Value.ToString).ToString.Replace("#", Environment.NewLine)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub dgvImpWell_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImpWell.CellDoubleClick
        Dim frm As New frmDataImpDetail
        With frm
            .txtDetail.Text = util.TrataDBNull(dgvImpWell.CurrentCell.Value.ToString).ToString.Replace("#", Environment.NewLine)
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub
End Class
Public Class Account_List

    Private Sub AccountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AccountBindingSource.EndEdit()
            Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Account_List_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HaulerTableAdapter.Fill(Me.IRS_ScaleDataSet.Hauler)
        Dim systemSetup As New Setup()
        If systemSetup.SetupItems.AllowEmail = False Then
            AccountDataGridView.Columns("Email_Ticket").Visible = False
            AccountDataGridView.Columns("Email").Visible = False
        End If
        Dim HRow As IRS_ScaleDataSet.HaulerRow = Me.IRS_ScaleDataSet.Hauler.NewHaulerRow
        HRow.Hauler_Name = ""
        Me.IRS_ScaleDataSet.Hauler.AddHaulerRow(HRow)
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.cboAccount.Items.Clear()
        For Each row As IRS_ScaleDataSet.AccountRow In Me.IRS_ScaleDataSet.Account
            Me.cboAccount.Items.Add(row.Account_Name)

        Next
    End Sub

    Private Sub AccountDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AccountDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = Me.EditBtn.Index Then
                Dim position As Integer = Me.AccountBindingSource.Position

                Me.EditAccount()
                Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
                Me.AccountBindingSource.Position = position
            End If
        End If
    End Sub

    Private Sub NewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            Dim frmAdd_Edit_Account As New Add_Edit_Account
            frmAdd_Edit_Account.WindowState = FormWindowState.Normal '.Maximized
            frmAdd_Edit_Account.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If Me.AccountBindingSource.Position > -1 Then
                Dim Account_Name As String = Me.AccountDataGridView.Item("Account_Name", Me.AccountDataGridView.CurrentRow.Index).Value
                If MsgBox("Are you sure you want to delete" + vbCrLf + Account_Name + "???", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm Delete") = MsgBoxResult.Yes Then
                    Me.AccountBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.AccountBindingSource.EndEdit()
                    Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEdit.Click
        EditAccount()
    End Sub

    Private Sub EditAccount()
        Try
            Try
                If Me.AccountBindingSource.Position > -1 Then
                    Dim Account_Name As String = Me.AccountDataGridView.Item("Account_Name", Me.AccountDataGridView.CurrentRow.Index).Value
                    Dim frmAdd_Edit_Account As New Add_Edit_Account(Account_Name)
                    frmAdd_Edit_Account.WindowState = FormWindowState.Normal '.Maximized
                    frmAdd_Edit_Account.ShowDialog()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAccount.TextChanged
        If Me.cboAccount.Text = "" Then
            Me.AccountBindingSource.Filter = ""
        Else
            Me.AccountBindingSource.Filter = "Account_Name like'" + Me.cboAccount.Text + "*'"
        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Me.Validate()
            Me.AccountBindingSource.EndEdit()
            Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub AccountDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles AccountDataGridView.DataError

    End Sub

    Private Sub AccountDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AccountDataGridView.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            Me.EditAccount()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.AccountBindingSource.EndEdit()
            Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class
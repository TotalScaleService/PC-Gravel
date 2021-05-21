Imports System.Windows.Forms

Public Class Add_Edit_Account
    Dim Firstload As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FillTables()
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Me.AccountBindingSource.AddNew()

    End Sub

    Public Sub New(ByVal Account_Name As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        FillTables()
        Me.AccountTableAdapter.Fill(Me.IRS_ScaleDataSet.Account)
        Dim row As IRS_ScaleDataSet.AccountRow
        Dim I As Integer = Me.AccountBindingSource.Find("Account_Name", Account_Name)
        Me.AccountBindingSource.Position = I
        If I = -1 Then
            Me.AccountBindingSource.AddNew()

            row = CType(CType(Me.AccountBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.AccountRow)
            row.Account_Name = Account_Name
            Me.Account_NameTextBox.Text = Account_Name
            Me.AccountBindingNavigator.Visible = False
            Me.lblPrompt.Text = "Confirm/Edit New Account Information"
            Me.OK_Button.Focus()
            'Else
            '    row = Me.IRS_ScaleDataSet.Account(I)
            '    Me.CityComboBox.Text = row.City
        End If

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub FillTables()
        Me.Distinct_Zip_CodesTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_Zip_Codes)
        Me.Distinct_States_From_Zip_CodeTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_States_From_Zip_Code)
        Me.Distinct_Cities_From_Zip_CodeTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_Cities_From_Zip_Code)
        Me.Zip_CodesTableAdapter1.Fill(Me.IRS_ScaleDataSet.Zip_Codes)
    End Sub

    Private Sub CheckComboBoxes()
        Dim Row As IRS_ScaleDataSet.AccountRow
        Row = CType(CType(Me.AccountBindingSource.Current, DataRowView).Row, IRS_ScaleDataSet.AccountRow)

        If Me.PhoneMaskedTextBox.Text = "(   )    -" Then
            Row.SetPhoneNull()
        End If


        If Me.CityComboBox.SelectedIndex = -1 Then
            Me.CityComboBox.Text = ""
            Row.SetCityNull()
        End If

        If Me.StateComboBox.SelectedIndex = -1 Then
            Row.SetStateNull()
            Me.StateComboBox.Text = ""
        End If

        If Me.ZipComboBox.SelectedIndex = -1 Then
            Me.ZipComboBox.Text = ""
            Row.SetZipNull()
        End If


    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            CheckComboBoxes()
            Me.Validate()
            Me.AccountBindingSource.EndEdit()
            Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)
            Me.AccountProductsBindingSource.EndEdit()
            Me.AccountProductsTableAdapter.Update(Me.IRS_ScaleDataSet.AccountProducts)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            My.Forms.Account_List.AccountTableAdapter.Fill(My.Forms.Account_List.IRS_ScaleDataSet.Account)
            My.Forms.Account_List.AccountBindingSource.Position = My.Forms.Account_List.AccountBindingSource.Find("Account_Name", Me.Account_NameTextBox.Text)
            My.Forms.Account_List.cboAccount.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AccountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AccountBindingSource.EndEdit()
            Me.AccountTableAdapter.Update(Me.IRS_ScaleDataSet.Account)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ZipComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipComboBox.SelectedIndexChanged
        If Not Firstload Then


            If Me.ZipComboBox.SelectedIndex > -1 Then
                If Me.ZipComboBox.Focused Then
                    Me.Distinct_States_From_Zip_CodeTableAdapter.FillByZip(Me.IRS_ScaleDataSet.Distinct_States_From_Zip_Code, Me.ZipComboBox.Text)
                    Me.Distinct_Cities_From_Zip_CodeTableAdapter.FillByZip(Me.IRS_ScaleDataSet.Distinct_Cities_From_Zip_Code, Me.ZipComboBox.Text)
                Else
                    Me.Distinct_States_From_Zip_CodeTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_States_From_Zip_Code)
                    Me.Distinct_Cities_From_Zip_CodeTableAdapter.Fill(Me.IRS_ScaleDataSet.Distinct_Cities_From_Zip_Code)
                End If

            End If
        End If
    End Sub

    Private Sub TermsComboBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.SelectedIndex = -1 Then
            sender.Text = ""
        End If
    End Sub

    Private Sub Txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ZipComboBox.KeyDown, TermsComboBox.KeyDown, StateComboBox.KeyDown, PhoneMaskedTextBox.KeyDown, CityComboBox.KeyDown, AddressTextBox.KeyDown, Account_NameTextBox.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.SuppressKeyPress = True

        End If


    End Sub

    Private Sub StateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StateComboBox.SelectedIndexChanged
        If Me.StateComboBox.Focused Then
            If Me.StateComboBox.SelectedIndex <> -1 Then
                Dim City As String = Me.CityComboBox.Text
                Dim state As String = Me.StateComboBox.Text
                Me.Distinct_Cities_From_Zip_CodeTableAdapter.FillByState(Me.IRS_ScaleDataSet.Distinct_Cities_From_Zip_Code, state)

            End If
        End If
    End Sub


    Private Sub Add_Edit_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.IRS_ScaleDataSet.Product)
        'TODO: This line of code loads data into the 'IRS_ScaleDataSet.AccountProducts' table. You can move, or remove it, as needed.
        Me.AccountProductsTableAdapter.Fill(Me.IRS_ScaleDataSet.AccountProducts)
        Firstload = False
    End Sub

    Private Sub Field_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipComboBox.Enter, TermsComboBox.Enter, TaxableCheckBox.Enter, StateComboBox.Enter, PhoneMaskedTextBox.Enter, OK_Button.Enter, CityComboBox.Enter, Cancel_Button.Enter, AddressTextBox.Enter
        sender.backcolor = Color.Yellow

    End Sub

    Private Sub Field_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipComboBox.Leave, TermsComboBox.Leave, TaxableCheckBox.Leave, StateComboBox.Leave, PhoneMaskedTextBox.Leave, OK_Button.Leave, CityComboBox.Leave, Cancel_Button.Leave, AddressTextBox.Leave, Account_NameTextBox.Leave
        sender.backcolor = Color.White
    End Sub

    Private Sub Account_NameTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Account_NameTextBox.Enter
        sender.backcolor = Color.Yellow
        Me.Account_NameTextBox.SelectionStart = Me.Account_NameTextBox.Text.Length
    End Sub

    Private Sub AccountProductsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AccountProductsDataGridView.CellContentClick

    End Sub

    Private Sub AccountProductsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles AccountProductsDataGridView.DataError

    End Sub
End Class

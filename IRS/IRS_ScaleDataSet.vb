Partial Class IRS_ScaleDataSet
    Partial Public Class TrucksDataTable
        Private Sub TrucksDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Truck_IdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ProductsFilteredDataTable



    End Class

    Partial Class AccountsFilteredDataTable

        Private Sub AccountsFilteredDataTable_AccountsFilteredRowChanging(ByVal sender As System.Object, ByVal e As AccountsFilteredRowChangeEvent) Handles Me.AccountsFilteredRowChanging

        End Sub

    End Class

    Partial Class ReportSetupDataTable

        Private Sub ReportSetupDataTable_ReportSetupRowChanging(ByVal sender As System.Object, ByVal e As ReportSetupRowChangeEvent) Handles Me.ReportSetupRowChanging

        End Sub

    End Class

    Partial Class Job_ProductsDataTable

        Private Sub Job_ProductsDataTable_Job_ProductsRowChanging(ByVal sender As System.Object, ByVal e As Job_ProductsRowChangeEvent) Handles Me.Job_ProductsRowChanging

        End Sub
    End Class

    Partial Class SetupDataTable

        Private Sub SetupDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

    End Class

    Partial Class ProductDataTable

        Private Sub ProductDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Price_Per_UOMColumn.ColumnName) Then
                Try
                    Dim D As Double = CType(e.ProposedValue, Double)

                Catch ex As Exception
                    e.ProposedValue = e.Row.Item(e.Column.ColumnName)
                End Try
            End If

        End Sub

    End Class

    Partial Class Distinct_Zip_CodesDataTable

        Private Sub Distinct_Zip_CodesDataTable_Distinct_Zip_CodesRowChanging(ByVal sender As System.Object, ByVal e As Distinct_Zip_CodesRowChangeEvent) Handles Me.Distinct_Zip_CodesRowChanging

        End Sub

    End Class

End Class

Namespace IRS_ScaleDataSetTableAdapters

    Partial Public Class AccountProductsTableAdapter
    End Class
End Namespace

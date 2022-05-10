Imports System.ComponentModel

Public Class Form1

    Public MyRowIndex As Integer = 0
    Public AddNewData As Boolean = False

    Private Sub TableConstructionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableConstructionBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.TableConstructionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BIMConstructionDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIMConstructionDBDataSet.TableConstruction' table. You can move, or remove it, as needed.
        Me.TableConstructionTableAdapter.Fill(Me.BIMConstructionDBDataSet.TableConstruction)

    End Sub

    Private Sub TableConstructionDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableConstructionDataGridView.CellDoubleClick
        'GET THE TABLE DATA ROW NUMBER'
        MyRowIndex = e.RowIndex
        Form2.Show()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        AddNewData = True
        Form2.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'TODO: Search for organisation
        If TxtSearch.Text IsNot "" Then

            Dim FindedRow As Integer
            FindedRow = Me.TableConstructionBindingSource.Find("Name of Organisation", TxtSearch.Text)

            If Not FindedRow = -1 Then
                TableConstructionBindingSource.Position = FindedRow
                MyRowIndex = FindedRow
                Form2.Show()
            Else
                MessageBox.Show("Unable to find organiser name '" & TxtSearch.Text & "'!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub TxtSearch_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        AboutBox.Show()
    End Sub
End Class

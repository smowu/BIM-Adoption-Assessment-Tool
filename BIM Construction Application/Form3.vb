Imports System.Drawing.Printing
Public Class Form3
    ReadOnly MainLabelsStr = New String() {"BIM Construction", "Items", "Score Achieved", "Score Available", "Percentage Score Achieved", "Section Weight", "Section Score (%)"}
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form2.Hide()

        'TODO: This line of code loads data into the 'BIMConstructionDBDataSet.TableConstruction' table. You can move, or remove it, as needed.
        Me.TableConstructionTableAdapter.Fill(Me.BIMConstructionDBDataSet.TableConstruction)
        Me.TableConstructionBindingSource.Position = Form2.PrintRow

        SetAllLabels()
        UpdateChart()

    End Sub

    Private Sub SetAllLabels()

        Dim MainLabelsArr As Label() = {Label1, Label2, Label3, Label4, Label5, Label6, Label7}
        Dim Question1Labels As Label() = {Label8, Label9, Label10, Label11, Label12}
        Dim Question2Labels As Label() = {Label13, Label14, Label15, Label16, Label17}
        Dim Question3Labels As Label() = {Label18, Label19, Label20, Label21, Label22}
        Dim Question4Labels As Label() = {Label23, Label24, Label25, Label26, Label27}

        Dim Q1Strings = New String() {"1", "3D Coordination", "5", String.Format("{0:N2}", CalcPercentage(0)) & "%", "5.574"}
        Dim Q2Strings = New String() {"2", "Record Model", "5", String.Format("{0:N2}", CalcPercentage(1)) & "%", "5.254"}
        Dim Q3Strings = New String() {"3", "3D Control and Planning", "5", String.Format("{0:N2}", CalcPercentage(2)) & "%", "5.167"}
        Dim Q4Strings = New String() {"4", "Construction System Design", "5", String.Format("{0:N2}", CalcPercentage(3)) & "%", "5.167"}

        SetLabels(MainLabelsArr, MainLabelsStr)
        SetLabels(Question1Labels, Q1Strings)
        SetLabels(Question2Labels, Q2Strings)
        SetLabels(Question3Labels, Q3Strings)
        SetLabels(Question4Labels, Q4Strings)

    End Sub

    Private Sub UpdateChart()

        'TODO: Updates the chart according to the binding source position
        ScoreChart.Series("Score Achieved").Points.Clear()
        ScoreChart.Series("Section Score (%)").Points.Clear()

        ScoreChart.Series("Score Achieved").Points.AddXY("3D Coordination", Score_Achieved_OneTextBox.Text)
        ScoreChart.Series("Score Achieved").Points.AddXY("Record Model", Score_Achieved_TwoTextBox.Text)
        ScoreChart.Series("Score Achieved").Points.AddXY("3D Control and Planning", Score_Achieved_ThreeTextBox.Text)
        ScoreChart.Series("Score Achieved").Points.AddXY("Construction System Design", Score_Achieved_FourTextBox.Text)

        ScoreChart.Series("Section Score (%)").Points.AddXY("3D Coordination", Section_Score_OneTextBox.Text)
        ScoreChart.Series("Section Score (%)").Points.AddXY("Record Model", Section_Score_TwoTextBox.Text)
        ScoreChart.Series("Section Score (%)").Points.AddXY("3D Control and Planning", Section_Score_ThreeTextBox.Text)
        ScoreChart.Series("Section Score (%)").Points.AddXY("Construction System Design", Section_Score_FourTextBox.Text)

    End Sub

    Private Function CalcPercentage(QNum As Integer) As Double

        'TODO: Calculate the percentage of the score
        Dim ScoresAchieved As TextBox() = {Score_Achieved_OneTextBox, Score_Achieved_TwoTextBox, Score_Achieved_ThreeTextBox, Score_Achieved_FourTextBox}
        Return (Val(ScoresAchieved(QNum).Text) / 5) * 100

    End Function

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.PrintRow = 0
        Form2.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub SetLabels(MainLabelsArr As Label(), LabelsString As String())

        For i = 0 To (MainLabelsArr.Count - 1)
            MainLabelsArr(i).Text = LabelsString(i)
        Next

    End Sub

    Private Sub TableConstructionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles TableConstructionBindingSource.PositionChanged
        'TODO: Update the data according to binding position
        SetAllLabels()
        UpdateChart()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        'TODO: Page setup for printing
        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings
        PrintDoc.PrinterSettings = PrintDialog.PrinterSettings

        Dim PageSetup As New PageSettings
        With PageSetup
            .Margins.Left = 30
            .Margins.Right = 30
            .Margins.Top = 30
            .Margins.Bottom = 30
            .Landscape = True
        End With

        PrintDoc.DefaultPageSettings = PageSetup

        PrintPreviewDialog.Document = PrintDoc
        PrintPreviewDialog.ShowDialog()

    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        'TODO: Set the main panel as bitmap and prints them as a page
        Dim BmpPanel As New Bitmap(Me.Width, Me.Height + 100)
        BmpPanel.SetResolution(300, 300)
        MainPanel.DrawToBitmap(BmpPanel, New Rectangle(0, 0, MainPanel.Width, MainPanel.Height))
        e.Graphics.DrawImage(BmpPanel, e.MarginBounds)
        BmpPanel.Dispose()

    End Sub

End Class
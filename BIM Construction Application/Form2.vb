Public Class Form2
    Dim Scores = New Double(3)() {}
    Dim Questions = New String(3)() {}
    Dim TextBoxQ1 As TextBox()
    Dim TextBoxQ2 As TextBox()
    Dim TextBoxQ3 As TextBox()
    Dim TextBoxQ4 As TextBox()
    ReadOnly MainLabels = New String() {"BIM Construction", "Items", "Description", "Non-Existent", "Initial", "Defined", "Managed", "Integrated", "Optimised"}
    ReadOnly ScoreLabels = New Integer() {0, 1, 2, 3, 4, 5}
    ReadOnly ResultLabels = New String() {"Score Achieved", "Score Available", "Percentage Score Achieved", "Section Weight", "Section Score (%)"}
    Dim AddingData As Boolean = False
    Public PrintRow As Integer = 0

    Private Sub TableConstructionBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableConstructionBindingNavigatorSaveItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        Me.Validate()
        Me.TableConstructionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BIMConstructionDBDataSet)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'BIMConstructionDBDataSet.TableConstruction' table. You can move, or remove it, as needed.
        Me.TableConstructionTableAdapter.Fill(Me.BIMConstructionDBDataSet.TableConstruction)

        Me.LoadData()

        If Form1.AddNewData Then
            'TODO: Insert new data
            Me.TableConstructionBindingSource.AddNew()
            Me.AddNewData()
            BindingNavigatorAddNewItem.Enabled = False
        Else
            'TODO: Display data based on selected row in Form1
            Me.TableConstructionBindingSource.Position = Form1.MyRowIndex
        End If

        Name_of_OrganisationTextBox.Focus()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'TODO: Disable adding new data when the current new data is not saved yet
        BindingNavigatorAddNewItem.Enabled = False
        AddingData = True
    End Sub

    Private Sub AddNewData()

        'TODO: Set all the TextBox to their default state
        IDTextBox.Text = TableConstructionBindingSource.Count
        Name_of_OrganisationTextBox.Text = "New Organisation " & TableConstructionBindingSource.Count
        Name_of_ProjectTextBox.Text = "New Project " & TableConstructionBindingSource.Count
        Assessor_NameTextBox.Text = "New Name " & TableConstructionBindingSource.Count
        Assessor_DesignationTextBox.Text = "New Designation " & TableConstructionBindingSource.Count
        Score_Achieved_OneTextBox.Text = 0
        Score_Achieved_TwoTextBox.Text = 0
        Score_Achieved_ThreeTextBox.Text = 0
        Score_Achieved_FourTextBox.Text = 0
        Section_Score_OneTextBox.Text = String.Format("{0:N3}", 0)
        Section_Score_TwoTextBox.Text = String.Format("{0:N3}", 0)
        Section_Score_ThreeTextBox.Text = String.Format("{0:N3}", 0)
        Section_Score_FourTextBox.Text = String.Format("{0:N3}", 0)
        Total_ScoreLabel1.Text = String.Format("{0:N3}", 0)

        Form1.AddNewData = False

    End Sub

    Private Sub UpdateFormat()

        'TODO: Decimal formatting
        Score_Achieved_OneTextBox.Text = String.Format("{0:N3}", Score_Achieved_OneTextBox.Text)
        Score_Achieved_TwoTextBox.Text = String.Format("{0:N3}", Score_Achieved_TwoTextBox.Text)
        Score_Achieved_ThreeTextBox.Text = String.Format("{0:N3}", Score_Achieved_ThreeTextBox.Text)
        Score_Achieved_FourTextBox.Text = String.Format("{0:N3}", Score_Achieved_FourTextBox.Text)
        Section_Score_OneTextBox.Text = String.Format("{0:N3}", Section_Score_OneTextBox.Text)
        Section_Score_TwoTextBox.Text = String.Format("{0:N3}", Section_Score_TwoTextBox.Text)
        Section_Score_ThreeTextBox.Text = String.Format("{0:N3}", Section_Score_ThreeTextBox.Text)
        Section_Score_FourTextBox.Text = String.Format("{0:N3}", Section_Score_FourTextBox.Text)
        Total_ScoreLabel1.Text = String.Format("{0:N3}", Total_ScoreLabel1.Text)

    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Form1.Hide()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.TableConstructionTableAdapter.Fill(Form1.BIMConstructionDBDataSet.TableConstruction)
        Form1.Show()
    End Sub

    Private Sub LoadData()

        'TODO: Set labels and their questions
        Me.SetQuestion1()
        Me.SetQuestion2()
        Me.SetQuestion3()
        Me.SetQuestion4()

    End Sub

    Private Sub SetLabels(MainLabelsArr As Label(), ScoreLabelsArr As Label(), ResultLabelsArr As Label())

        For i = 0 To (MainLabelsArr.Count - 1)
            MainLabelsArr(i).Text = MainLabels(i)
        Next

        For i = 0 To (ScoreLabelsArr.Length - 1)
            ScoreLabelsArr(i).Text = ScoreLabels(i)
        Next

        For i = 0 To (ResultLabelsArr.Length - 1)
            ResultLabelsArr(i).Text = ResultLabels(i)
        Next

    End Sub

    Private Sub SetQuestion1()

        Dim MainLabels As Label() = {Label0, Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8}
        Dim ScoreLabels As Label() = {Label1Score0, Label1Score1, Label1Score2, Label1Score3, Label1Score4, Label1Score5}
        Dim ResultLabels As Label() = {Label18, Label19, Label20, Label21, Label22}
        SetLabels(MainLabels, ScoreLabels, ResultLabels)

        Dim Question1 = New String() {
                                      "1",
                                      "3D Coordination",
                                      "3D Building Information Model created at early design stage and thus allows the 3D coordination process to take place to ensure that any space interference (hard clashes) or clearance (soft clashes) conflicts are resolved",
                                      "No 3D coordination",
                                      "3D coordination is identified",
                                      "3D coordination is identified, addressed gained  feedback from the project team",
                                      "3D coordination is addressed and recorded; gained feedback from the project team",
                                      "3D coordination is addressed; more specified, measureable and recorded; gained feedback from the project team",
                                      "3D coordination is addressed, more specified; gained continuous feedback and update from the project team"
                                     }
        Scores(0) = New Double() {0, 5, 0.0, 5.574, 0}

        Dim QuestionLabelsArr As Label() = {Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17}
        For i = 0 To (QuestionLabelsArr.Length - 1)
            QuestionLabelsArr(i).Text = Question1(i)
        Next

        Dim RadioBtn As RadioButton() = {RadioButton1, RadioButton2, RadioButton3, RadioButton4, RadioButton5, RadioButton6}
        RadioSelection(Score_Achieved_OneTextBox.Text, RadioBtn)

        TextBoxQ1 = {Score_Achieved_OneTextBox, TextBox1, TextBox2, TextBox3, Section_Score_OneTextBox}
        CalcScore(0, TextBoxQ1)

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Score_Achieved_OneTextBox.Text = Label1Score0.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Score_Achieved_OneTextBox.Text = Label1Score1.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Score_Achieved_OneTextBox.Text = Label1Score2.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Score_Achieved_OneTextBox.Text = Label1Score3.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click
        Score_Achieved_OneTextBox.Text = Label1Score4.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub RadioButton6_Click(sender As Object, e As EventArgs) Handles RadioButton6.Click
        Score_Achieved_OneTextBox.Text = Label1Score5.Text
        CalcScore(0, TextBoxQ1)
    End Sub

    Private Sub SetQuestion2()

        Dim MainLabels As Label() = {Label23, Label24, Label25, Label26, Label27, Label28, Label29, Label30, Label31}
        Dim ScoreLabels As Label() = {Label2Score0, Label2Score1, Label2Score2, Label2Score3, Label2Score4, Label2Score5}
        Dim ResultLabels As Label() = {Label41, Label42, Label43, Label44, Label45}
        SetLabels(MainLabels, ScoreLabels, ResultLabels)

        Dim Question2 = New String() {
                                      "2",
                                      "Record Model",
                                      "The process is to depict the information relating to architectural, structural, and MEP elements and documented them in the form of model. The model is the final model that consists of information throughout the project including information on maintenance and facilities in order to facilitate its use by the facilities manager",
                                      "No record model",
                                      "Record model is established",
                                      "Record model is established, developed with an information",
                                      "Record model is established, developed and coordinated by a single entity with an information obtained",
                                      "Record model is established; developed, interconnected and integrated into all the information obtained",
                                      "Record model is established, developed, and integrated into all the information obtained. Revisited, and continuously updated and realigned"
                                     }
        Scores(1) = New Double() {0, 5, 0.0, 5.254, 0}

        Dim QuestionLabelsArr As Label() = {Label32, Label33, Label34, Label35, Label36, Label37, Label38, Label39, Label40}
        For i = 0 To (QuestionLabelsArr.Length - 1)
            QuestionLabelsArr(i).Text = Question2(i)
        Next

        Dim RadioBtn As RadioButton() = {RadioButton7, RadioButton8, RadioButton9, RadioButton10, RadioButton11, RadioButton12}
        RadioSelection(Score_Achieved_TwoTextBox.Text, RadioBtn)

        TextBoxQ2 = {Score_Achieved_TwoTextBox, TextBox6, TextBox7, TextBox8, Section_Score_TwoTextBox}
        CalcScore(1, TextBoxQ2)

    End Sub

    Private Sub RadioButton7_Click(sender As Object, e As EventArgs) Handles RadioButton7.Click
        Score_Achieved_TwoTextBox.Text = Label2Score0.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub RadioButton8_Click(sender As Object, e As EventArgs) Handles RadioButton8.Click
        Score_Achieved_TwoTextBox.Text = Label2Score1.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub RadioButton9_Click(sender As Object, e As EventArgs) Handles RadioButton9.Click
        Score_Achieved_TwoTextBox.Text = Label2Score2.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub RadioButton10_Click(sender As Object, e As EventArgs) Handles RadioButton10.Click
        Score_Achieved_TwoTextBox.Text = Label2Score3.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub RadioButton11_Click(sender As Object, e As EventArgs) Handles RadioButton11.Click
        Score_Achieved_TwoTextBox.Text = Label2Score4.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub RadioButton12_Click(sender As Object, e As EventArgs) Handles RadioButton12.Click
        Score_Achieved_TwoTextBox.Text = Label2Score5.Text
        CalcScore(1, TextBoxQ2)
    End Sub

    Private Sub SetQuestion3()

        Dim MainLabels As Label() = {Label46, Label47, Label48, Label49, Label50, Label51, Label52, Label53, Label54}
        Dim ScoreLabels As Label() = {Label3Score0, Label3Score1, Label3Score2, Label3Score3, Label3Score4, Label3Score5}
        Dim ResultLabels As Label() = {Label64, Label65, Label66, Label67, Label68}
        SetLabels(MainLabels, ScoreLabels, ResultLabels)

        Dim Question3 = New String() {
                                      "3",
                                      "3D Control and Planning",
                                      "The utilization a building information model to assemble and manage the movement of equipment’s and location in accurate position or layout (Pennsylvania State University., (2013).",
                                      "No 3D control and planning",
                                      "3D control and planning is identified",
                                      "3D control and planning is identified, addressed gained feedback from the project team",
                                      "3D control and planning is addressed and recorded; gained feedback from the project team",
                                      "3D coordination is addressed; more specified, measureable and recorded; gained feedback from the project team",
                                      "3D coordination is addressed, more specified; gained continuous feedback and update from the project team"
                                     }
        Scores(2) = New Double() {0, 5, 0.0, 5.167, 0}

        Dim QuestionLabelsArr As Label() = {Label55, Label56, Label57, Label58, Label59, Label60, Label61, Label62, Label63}
        For i = 0 To (QuestionLabelsArr.Length - 1)
            QuestionLabelsArr(i).Text = Question3(i)
        Next

        Dim RadioBtn As RadioButton() = {RadioButton13, RadioButton14, RadioButton15, RadioButton16, RadioButton17, RadioButton18}
        RadioSelection(Score_Achieved_ThreeTextBox.Text, RadioBtn)

        TextBoxQ3 = {Score_Achieved_ThreeTextBox, TextBox11, TextBox12, TextBox13, Section_Score_ThreeTextBox}
        CalcScore(2, TextBoxQ3)

    End Sub

    Private Sub RadioButton13_Click(sender As Object, e As EventArgs) Handles RadioButton13.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score0.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub RadioButton14_Click(sender As Object, e As EventArgs) Handles RadioButton14.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score1.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub RadioButton15_Click(sender As Object, e As EventArgs) Handles RadioButton15.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score2.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub RadioButton16_Click(sender As Object, e As EventArgs) Handles RadioButton16.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score3.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub RadioButton17_Click(sender As Object, e As EventArgs) Handles RadioButton17.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score4.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub RadioButton18_Click(sender As Object, e As EventArgs) Handles RadioButton18.Click
        Score_Achieved_ThreeTextBox.Text = Label3Score5.Text
        CalcScore(2, TextBoxQ3)
    End Sub

    Private Sub SetQuestion4()

        Dim MainLabels As Label() = {Label69, Label70, Label71, Label72, Label73, Label74, Label75, Label76, Label77}
        Dim ScoreLabels As Label() = {Label4Score0, Label4Score1, Label4Score2, Label4Score3, Label4Score4, Label4Score5}
        Dim ResultLabels As Label() = {Label87, Label88, Label89, Label90, Label91}
        SetLabels(MainLabels, ScoreLabels, ResultLabels)

        Dim Question4 = New String() {
                                     "4",
                                     "Construction System Design",
                                     "3D modelling process in designing, creating, constructing and buildability of complex building system such as formwork system, glass veneers, anchors system (Pennsylvania State University., (2013); (Chou & Chen, 2017) and building façade (Maing & Vargas, 2013).",
                                     "No construction system design",
                                     "Construction system design is identified",
                                     "Construction system design is identified, addressed gained  feedback from the project team",
                                     "Construction system design is addressed and recorded; gained feedback from the project team",
                                     "Construction system design is addressed; more specified, measureable and recorded; gained feedback from the project team",
                                     "Construction system design is addressed, more specified; gained continuous feedback and update from the project team"
                                    }
        Scores(3) = New Double() {0, 5, 0.0, 5.167, 0}

        Dim QuestionLabelsArr As Label() = {Label78, Label79, Label80, Label81, Label82, Label83, Label84, Label85, Label86}
        For i = 0 To (QuestionLabelsArr.Length - 1)
            QuestionLabelsArr(i).Text = Question4(i)
        Next

        Dim RadioBtn As RadioButton() = {RadioButton19, RadioButton20, RadioButton21, RadioButton22, RadioButton23, RadioButton24}
        RadioSelection(Score_Achieved_FourTextBox.Text, RadioBtn)

        TextBoxQ4 = {Score_Achieved_FourTextBox, TextBox16, TextBox17, TextBox18, Section_Score_FourTextBox}
        CalcScore(3, TextBoxQ4)

    End Sub

    Private Sub RadioButton19_Click(sender As Object, e As EventArgs) Handles RadioButton19.Click
        Score_Achieved_FourTextBox.Text = Label4Score0.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub RadioButton20_Click(sender As Object, e As EventArgs) Handles RadioButton20.Click
        Score_Achieved_FourTextBox.Text = Label4Score1.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub RadioButton21_Click(sender As Object, e As EventArgs) Handles RadioButton21.Click
        Score_Achieved_FourTextBox.Text = Label4Score2.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub RadioButton22_Click(sender As Object, e As EventArgs) Handles RadioButton22.Click
        Score_Achieved_FourTextBox.Text = Label4Score3.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub RadioButton23_Click(sender As Object, e As EventArgs) Handles RadioButton23.Click
        Score_Achieved_FourTextBox.Text = Label4Score4.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub RadioButton24_Click(sender As Object, e As EventArgs) Handles RadioButton24.Click
        Score_Achieved_FourTextBox.Text = Label4Score5.Text
        CalcScore(3, TextBoxQ4)
    End Sub

    Private Sub CalcScore(QuestionNo As Integer, TextBox As TextBox())

        Dim ScoreAchieved As Integer = Val(TextBox(0).Text)
        Dim ScoreAvailable As Integer = Scores(QuestionNo)(1)
        Dim SectionWeight As Double = Scores(QuestionNo)(3)
        Dim PercentageScoreAchieved As Double
        Dim SectionScore As Double

        PercentageScoreAchieved = (ScoreAchieved / ScoreAvailable) * 100
        SectionScore = (PercentageScoreAchieved * SectionWeight) / 100

        Scores(QuestionNo)(2) = PercentageScoreAchieved
        Scores(QuestionNo)(4) = SectionScore

        TextBox(1).Text = Scores(QuestionNo)(1)
        TextBox(2).Text = String.Format("{0:N3}", Scores(QuestionNo)(2)) & "%"
        TextBox(3).Text = String.Format("{0:N3}", Scores(QuestionNo)(3)) & "%"
        TextBox(4).Text = String.Format("{0:N3}", Scores(QuestionNo)(4))

        Me.CalcTotalSectionScore()

    End Sub

    Private Sub CalcTotalSectionScore()

        Dim total As Double
        total = Val(Section_Score_OneTextBox.Text) + Val(Section_Score_TwoTextBox.Text) + Val(Section_Score_ThreeTextBox.Text) + Val(Section_Score_FourTextBox.Text)
        Total_ScoreLabel1.Text = String.Format("{0:N3}", total)

    End Sub

    Private Sub RadioSelection(TextBoxScore As String, RadioBtn As RadioButton())

        'TODO: Updates the radio button checked state based on the current position
        If Val(TextBoxScore) = 0 Then
            RadioBtn(0).Checked = True
        ElseIf Val(TextBoxScore) = 1 Then
            RadioBtn(1).Checked = True
        ElseIf Val(TextBoxScore) = 2 Then
            RadioBtn(2).Checked = True
        ElseIf Val(TextBoxScore) = 3 Then
            RadioBtn(3).Checked = True
        ElseIf Val(TextBoxScore) = 4 Then
            RadioBtn(4).Checked = True
        ElseIf Val(TextBoxScore) = 5 Then
            RadioBtn(5).Checked = True
        End If

    End Sub

    Private Sub TableConstructionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles TableConstructionBindingSource.PositionChanged

        If AddingData = True Then
            Me.AddNewData()
            Me.LoadData()
            AddingData = False
        Else
            Me.LoadData()
        End If

    End Sub

    Private Sub FormatZero(ZeroText As Object)
        If ZeroText.Text = "0" Then
            ZeroText.Text = String.Format("{0:N3}", 0)
        End If
    End Sub

    Private Sub Total_ScoreLabel1_TextChanged(sender As Object, e As EventArgs) Handles Total_ScoreLabel1.TextChanged
        FormatZero(Total_ScoreLabel1)
    End Sub

    Private Sub Section_Score_OneTextBox_TextChanged(sender As Object, e As EventArgs) Handles Section_Score_OneTextBox.TextChanged
        FormatZero(Section_Score_OneTextBox)
    End Sub

    Private Sub Section_Score_TwoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Section_Score_TwoTextBox.TextChanged
        FormatZero(Section_Score_TwoTextBox)
    End Sub

    Private Sub Section_Score_ThreeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Section_Score_ThreeTextBox.TextChanged
        FormatZero(Section_Score_ThreeTextBox)
    End Sub

    Private Sub Section_Score_FourTextBox_TextChanged(sender As Object, e As EventArgs) Handles Section_Score_FourTextBox.TextChanged
        FormatZero(Section_Score_FourTextBox)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        'TODO: Save data and proceed to printing form
        TableConstructionBindingNavigatorSaveItem.PerformClick()
        Form1.TableConstructionTableAdapter.Fill(Form1.BIMConstructionDBDataSet.TableConstruction)
        PrintRow = Me.TableConstructionBindingSource.Position
        Form3.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        TableConstructionBindingNavigatorSaveItem.PerformClick()
        Form1.TableConstructionTableAdapter.Fill(Form1.BIMConstructionDBDataSet.TableConstruction)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        BindingNavigatorDeleteItem.PerformClick()
        Form1.TableConstructionTableAdapter.Fill(Form1.BIMConstructionDBDataSet.TableConstruction)
    End Sub

End Class
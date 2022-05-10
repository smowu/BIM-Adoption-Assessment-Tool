<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Name_of_OrganisationLabel As System.Windows.Forms.Label
        Dim Name_of_ProjectLabel As System.Windows.Forms.Label
        Dim Assessor_NameLabel As System.Windows.Forms.Label
        Dim Assessor_DesignationLabel As System.Windows.Forms.Label
        Dim Total_ScoreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TableConstructionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TableConstructionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIMConstructionDBDataSet = New BIM_Construction_Application.BIMConstructionDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_OrganisationTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_ProjectTextBox = New System.Windows.Forms.TextBox()
        Me.Assessor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Assessor_DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.Section_Score_FourTextBox = New System.Windows.Forms.TextBox()
        Me.Section_Score_ThreeTextBox = New System.Windows.Forms.TextBox()
        Me.Score_Achieved_FourTextBox = New System.Windows.Forms.TextBox()
        Me.Section_Score_TwoTextBox = New System.Windows.Forms.TextBox()
        Me.Score_Achieved_ThreeTextBox = New System.Windows.Forms.TextBox()
        Me.Score_Achieved_TwoTextBox = New System.Windows.Forms.TextBox()
        Me.Section_Score_OneTextBox = New System.Windows.Forms.TextBox()
        Me.Score_Achieved_OneTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ScoreChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableConstructionTableAdapter = New BIM_Construction_Application.BIMConstructionDBDataSetTableAdapters.TableConstructionTableAdapter()
        Me.TableAdapterManager = New BIM_Construction_Application.BIMConstructionDBDataSetTableAdapters.TableAdapterManager()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        Name_of_OrganisationLabel = New System.Windows.Forms.Label()
        Name_of_ProjectLabel = New System.Windows.Forms.Label()
        Assessor_NameLabel = New System.Windows.Forms.Label()
        Assessor_DesignationLabel = New System.Windows.Forms.Label()
        Total_ScoreLabel = New System.Windows.Forms.Label()
        CType(Me.TableConstructionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableConstructionBindingNavigator.SuspendLayout()
        CType(Me.TableConstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIMConstructionDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.ScoreChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(9, 35)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Name_of_OrganisationLabel
        '
        Name_of_OrganisationLabel.AutoSize = True
        Name_of_OrganisationLabel.Location = New System.Drawing.Point(9, 61)
        Name_of_OrganisationLabel.Name = "Name_of_OrganisationLabel"
        Name_of_OrganisationLabel.Size = New System.Drawing.Size(112, 13)
        Name_of_OrganisationLabel.TabIndex = 3
        Name_of_OrganisationLabel.Text = "Name of Organisation:"
        '
        'Name_of_ProjectLabel
        '
        Name_of_ProjectLabel.AutoSize = True
        Name_of_ProjectLabel.Location = New System.Drawing.Point(9, 87)
        Name_of_ProjectLabel.Name = "Name_of_ProjectLabel"
        Name_of_ProjectLabel.Size = New System.Drawing.Size(86, 13)
        Name_of_ProjectLabel.TabIndex = 5
        Name_of_ProjectLabel.Text = "Name of Project:"
        '
        'Assessor_NameLabel
        '
        Assessor_NameLabel.AutoSize = True
        Assessor_NameLabel.Location = New System.Drawing.Point(9, 113)
        Assessor_NameLabel.Name = "Assessor_NameLabel"
        Assessor_NameLabel.Size = New System.Drawing.Size(83, 13)
        Assessor_NameLabel.TabIndex = 7
        Assessor_NameLabel.Text = "Assessor Name:"
        '
        'Assessor_DesignationLabel
        '
        Assessor_DesignationLabel.AutoSize = True
        Assessor_DesignationLabel.Location = New System.Drawing.Point(9, 139)
        Assessor_DesignationLabel.Name = "Assessor_DesignationLabel"
        Assessor_DesignationLabel.Size = New System.Drawing.Size(111, 13)
        Assessor_DesignationLabel.TabIndex = 9
        Assessor_DesignationLabel.Text = "Assessor Designation:"
        '
        'Total_ScoreLabel
        '
        Total_ScoreLabel.AutoSize = True
        Total_ScoreLabel.Location = New System.Drawing.Point(987, 165)
        Total_ScoreLabel.Name = "Total_ScoreLabel"
        Total_ScoreLabel.Size = New System.Drawing.Size(65, 13)
        Total_ScoreLabel.TabIndex = 27
        Total_ScoreLabel.Text = "Total Score:"
        '
        'TableConstructionBindingNavigator
        '
        Me.TableConstructionBindingNavigator.AddNewItem = Nothing
        Me.TableConstructionBindingNavigator.BindingSource = Me.TableConstructionBindingSource
        Me.TableConstructionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableConstructionBindingNavigator.DeleteItem = Nothing
        Me.TableConstructionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.TableConstructionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TableConstructionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableConstructionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableConstructionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableConstructionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableConstructionBindingNavigator.Name = "TableConstructionBindingNavigator"
        Me.TableConstructionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableConstructionBindingNavigator.Size = New System.Drawing.Size(1184, 25)
        Me.TableConstructionBindingNavigator.TabIndex = 0
        Me.TableConstructionBindingNavigator.Text = "BindingNavigator1"
        '
        'TableConstructionBindingSource
        '
        Me.TableConstructionBindingSource.DataMember = "TableConstruction"
        Me.TableConstructionBindingSource.DataSource = Me.BIMConstructionDBDataSet
        '
        'BIMConstructionDBDataSet
        '
        Me.BIMConstructionDBDataSet.DataSetName = "BIMConstructionDBDataSet"
        Me.BIMConstructionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(132, 32)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(213, 20)
        Me.IDTextBox.TabIndex = 2
        Me.IDTextBox.TabStop = False
        '
        'Name_of_OrganisationTextBox
        '
        Me.Name_of_OrganisationTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Name_of_OrganisationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Name of Organisation", True))
        Me.Name_of_OrganisationTextBox.Location = New System.Drawing.Point(132, 58)
        Me.Name_of_OrganisationTextBox.Name = "Name_of_OrganisationTextBox"
        Me.Name_of_OrganisationTextBox.ReadOnly = True
        Me.Name_of_OrganisationTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Name_of_OrganisationTextBox.TabIndex = 4
        Me.Name_of_OrganisationTextBox.TabStop = False
        '
        'Name_of_ProjectTextBox
        '
        Me.Name_of_ProjectTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Name_of_ProjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Name of Project", True))
        Me.Name_of_ProjectTextBox.Location = New System.Drawing.Point(132, 84)
        Me.Name_of_ProjectTextBox.Name = "Name_of_ProjectTextBox"
        Me.Name_of_ProjectTextBox.ReadOnly = True
        Me.Name_of_ProjectTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Name_of_ProjectTextBox.TabIndex = 6
        Me.Name_of_ProjectTextBox.TabStop = False
        '
        'Assessor_NameTextBox
        '
        Me.Assessor_NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Assessor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Assessor Name", True))
        Me.Assessor_NameTextBox.Location = New System.Drawing.Point(132, 110)
        Me.Assessor_NameTextBox.Name = "Assessor_NameTextBox"
        Me.Assessor_NameTextBox.ReadOnly = True
        Me.Assessor_NameTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Assessor_NameTextBox.TabIndex = 8
        Me.Assessor_NameTextBox.TabStop = False
        '
        'Assessor_DesignationTextBox
        '
        Me.Assessor_DesignationTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Assessor_DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Assessor Designation", True))
        Me.Assessor_DesignationTextBox.Location = New System.Drawing.Point(132, 136)
        Me.Assessor_DesignationTextBox.Name = "Assessor_DesignationTextBox"
        Me.Assessor_DesignationTextBox.ReadOnly = True
        Me.Assessor_DesignationTextBox.Size = New System.Drawing.Size(213, 20)
        Me.Assessor_DesignationTextBox.TabIndex = 10
        Me.Assessor_DesignationTextBox.TabStop = False
        '
        'Section_Score_FourTextBox
        '
        Me.Section_Score_FourTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Section_Score_FourTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Section_Score_FourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Section Score Four", True))
        Me.Section_Score_FourTextBox.Location = New System.Drawing.Point(707, 123)
        Me.Section_Score_FourTextBox.Name = "Section_Score_FourTextBox"
        Me.Section_Score_FourTextBox.ReadOnly = True
        Me.Section_Score_FourTextBox.Size = New System.Drawing.Size(109, 20)
        Me.Section_Score_FourTextBox.TabIndex = 34
        Me.Section_Score_FourTextBox.TabStop = False
        Me.Section_Score_FourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Section_Score_ThreeTextBox
        '
        Me.Section_Score_ThreeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Section_Score_ThreeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Section_Score_ThreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Section Score Three", True))
        Me.Section_Score_ThreeTextBox.Location = New System.Drawing.Point(707, 92)
        Me.Section_Score_ThreeTextBox.Name = "Section_Score_ThreeTextBox"
        Me.Section_Score_ThreeTextBox.ReadOnly = True
        Me.Section_Score_ThreeTextBox.Size = New System.Drawing.Size(109, 20)
        Me.Section_Score_ThreeTextBox.TabIndex = 34
        Me.Section_Score_ThreeTextBox.TabStop = False
        Me.Section_Score_ThreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Score_Achieved_FourTextBox
        '
        Me.Score_Achieved_FourTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Score_Achieved_FourTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Score_Achieved_FourTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Score Achieved Four", True))
        Me.Score_Achieved_FourTextBox.Location = New System.Drawing.Point(251, 123)
        Me.Score_Achieved_FourTextBox.Name = "Score_Achieved_FourTextBox"
        Me.Score_Achieved_FourTextBox.ReadOnly = True
        Me.Score_Achieved_FourTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Score_Achieved_FourTextBox.TabIndex = 33
        Me.Score_Achieved_FourTextBox.TabStop = False
        Me.Score_Achieved_FourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Section_Score_TwoTextBox
        '
        Me.Section_Score_TwoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Section_Score_TwoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Section_Score_TwoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Section Score Two", True))
        Me.Section_Score_TwoTextBox.Location = New System.Drawing.Point(707, 63)
        Me.Section_Score_TwoTextBox.Name = "Section_Score_TwoTextBox"
        Me.Section_Score_TwoTextBox.ReadOnly = True
        Me.Section_Score_TwoTextBox.Size = New System.Drawing.Size(109, 20)
        Me.Section_Score_TwoTextBox.TabIndex = 34
        Me.Section_Score_TwoTextBox.TabStop = False
        Me.Section_Score_TwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Score_Achieved_ThreeTextBox
        '
        Me.Score_Achieved_ThreeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Score_Achieved_ThreeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Score_Achieved_ThreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Score Achieved Three", True))
        Me.Score_Achieved_ThreeTextBox.Location = New System.Drawing.Point(251, 92)
        Me.Score_Achieved_ThreeTextBox.Name = "Score_Achieved_ThreeTextBox"
        Me.Score_Achieved_ThreeTextBox.ReadOnly = True
        Me.Score_Achieved_ThreeTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Score_Achieved_ThreeTextBox.TabIndex = 33
        Me.Score_Achieved_ThreeTextBox.TabStop = False
        Me.Score_Achieved_ThreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Score_Achieved_TwoTextBox
        '
        Me.Score_Achieved_TwoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Score_Achieved_TwoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Score_Achieved_TwoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Score Achieved Two", True))
        Me.Score_Achieved_TwoTextBox.Location = New System.Drawing.Point(251, 63)
        Me.Score_Achieved_TwoTextBox.Name = "Score_Achieved_TwoTextBox"
        Me.Score_Achieved_TwoTextBox.ReadOnly = True
        Me.Score_Achieved_TwoTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Score_Achieved_TwoTextBox.TabIndex = 33
        Me.Score_Achieved_TwoTextBox.TabStop = False
        Me.Score_Achieved_TwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Section_Score_OneTextBox
        '
        Me.Section_Score_OneTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Section_Score_OneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Section_Score_OneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Section Score One", True))
        Me.Section_Score_OneTextBox.Location = New System.Drawing.Point(707, 34)
        Me.Section_Score_OneTextBox.Name = "Section_Score_OneTextBox"
        Me.Section_Score_OneTextBox.ReadOnly = True
        Me.Section_Score_OneTextBox.Size = New System.Drawing.Size(109, 20)
        Me.Section_Score_OneTextBox.TabIndex = 33
        Me.Section_Score_OneTextBox.TabStop = False
        Me.Section_Score_OneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Score_Achieved_OneTextBox
        '
        Me.Score_Achieved_OneTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Score_Achieved_OneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Score_Achieved_OneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Score Achieved One", True))
        Me.Score_Achieved_OneTextBox.Location = New System.Drawing.Point(251, 34)
        Me.Score_Achieved_OneTextBox.Name = "Score_Achieved_OneTextBox"
        Me.Score_Achieved_OneTextBox.ReadOnly = True
        Me.Score_Achieved_OneTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Score_Achieved_OneTextBox.TabIndex = 33
        Me.Score_Achieved_OneTextBox.TabStop = False
        Me.Score_Achieved_OneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Total_ScoreTextBox
        '
        Me.Total_ScoreTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Total_ScoreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableConstructionBindingSource, "Total Score", True))
        Me.Total_ScoreTextBox.Location = New System.Drawing.Point(1058, 162)
        Me.Total_ScoreTextBox.Name = "Total_ScoreTextBox"
        Me.Total_ScoreTextBox.ReadOnly = True
        Me.Total_ScoreTextBox.Size = New System.Drawing.Size(109, 20)
        Me.Total_ScoreTextBox.TabIndex = 28
        Me.Total_ScoreTextBox.TabStop = False
        Me.Total_ScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66677!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66719!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66719!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66552!))
        Me.TableLayoutPanel4.Controls.Add(Me.Section_Score_FourTextBox, 6, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Section_Score_ThreeTextBox, 6, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Score_Achieved_FourTextBox, 2, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Section_Score_TwoTextBox, 6, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Score_Achieved_ThreeTextBox, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Score_Achieved_TwoTextBox, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Section_Score_OneTextBox, 6, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Score_Achieved_OneTextBox, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label14, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 3, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 4, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 5, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label20, 3, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label21, 4, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label22, 5, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label23, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label24, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label25, 3, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 4, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label27, 5, 4)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(351, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(821, 150)
        Me.TableLayoutPanel4.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(479, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(593, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(707, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(479, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(593, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Label12"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Label14"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(365, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Label15"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(479, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(593, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Label17"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(119, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Label19"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(365, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Label20"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(479, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(106, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Label21"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(593, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 126)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Label23"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(119, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 13)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Label24"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(365, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 13)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Label25"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(479, 126)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 13)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Label26"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(593, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 13)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "Label27"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(1016, 9)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(1097, 9)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ScoreChart
        '
        Me.ScoreChart.BackColor = System.Drawing.Color.Transparent
        Me.ScoreChart.BorderlineColor = System.Drawing.SystemColors.ControlText
        Me.ScoreChart.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.Title = "Items"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Interval = 1.0R
        ChartArea1.AxisY.MajorGrid.Interval = 1.0R
        ChartArea1.AxisY.Maximum = 10.0R
        ChartArea1.AxisY.MinorGrid.Enabled = True
        ChartArea1.AxisY.MinorGrid.Interval = 0.2R
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.Title = "Score"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.Interval = 0.1R
        ChartArea1.Name = "ChartArea1"
        Me.ScoreChart.ChartAreas.Add(ChartArea1)
        Me.ScoreChart.DataSource = Me.TableConstructionBindingSource
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Legend1.Title = "Legend"
        Legend1.TitleBackColor = System.Drawing.Color.Transparent
        Me.ScoreChart.Legends.Add(Legend1)
        Me.ScoreChart.Location = New System.Drawing.Point(12, 188)
        Me.ScoreChart.Name = "ScoreChart"
        Me.ScoreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ScoreChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(110, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(104, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Legend = "Legend1"
        Series1.Name = "Score Achieved"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Legend = "Legend1"
        Series2.Name = "Section Score (%)"
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.ScoreChart.Series.Add(Series1)
        Me.ScoreChart.Series.Add(Series2)
        Me.ScoreChart.Size = New System.Drawing.Size(1160, 505)
        Me.ScoreChart.TabIndex = 32
        Me.ScoreChart.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "BIM Construction"
        Me.ScoreChart.Titles.Add(Title1)
        '
        'TableConstructionTableAdapter
        '
        Me.TableConstructionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableConstructionTableAdapter = Me.TableConstructionTableAdapter
        Me.TableAdapterManager.UpdateOrder = BIM_Construction_Application.BIMConstructionDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintDoc
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnPrint)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 721)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 40)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableConstructionBindingNavigator)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 22)
        Me.Panel2.TabIndex = 34
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.TableLayoutPanel4)
        Me.MainPanel.Controls.Add(Me.ScoreChart)
        Me.MainPanel.Controls.Add(IDLabel)
        Me.MainPanel.Controls.Add(Total_ScoreLabel)
        Me.MainPanel.Controls.Add(Me.IDTextBox)
        Me.MainPanel.Controls.Add(Name_of_OrganisationLabel)
        Me.MainPanel.Controls.Add(Me.Total_ScoreTextBox)
        Me.MainPanel.Controls.Add(Me.Name_of_OrganisationTextBox)
        Me.MainPanel.Controls.Add(Me.Assessor_DesignationTextBox)
        Me.MainPanel.Controls.Add(Name_of_ProjectLabel)
        Me.MainPanel.Controls.Add(Assessor_DesignationLabel)
        Me.MainPanel.Controls.Add(Me.Name_of_ProjectTextBox)
        Me.MainPanel.Controls.Add(Me.Assessor_NameTextBox)
        Me.MainPanel.Controls.Add(Assessor_NameLabel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 22)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1184, 699)
        Me.MainPanel.TabIndex = 35
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        CType(Me.TableConstructionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableConstructionBindingNavigator.ResumeLayout(False)
        Me.TableConstructionBindingNavigator.PerformLayout()
        CType(Me.TableConstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIMConstructionDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.ScoreChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BIMConstructionDBDataSet As BIMConstructionDBDataSet
    Friend WithEvents TableConstructionBindingSource As BindingSource
    Friend WithEvents TableConstructionTableAdapter As BIMConstructionDBDataSetTableAdapters.TableConstructionTableAdapter
    Friend WithEvents TableAdapterManager As BIMConstructionDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableConstructionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Name_of_OrganisationTextBox As TextBox
    Friend WithEvents Name_of_ProjectTextBox As TextBox
    Friend WithEvents Assessor_NameTextBox As TextBox
    Friend WithEvents Assessor_DesignationTextBox As TextBox
    Friend WithEvents Total_ScoreTextBox As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents ScoreChart As DataVisualization.Charting.Chart
    Friend WithEvents Section_Score_FourTextBox As TextBox
    Friend WithEvents Section_Score_ThreeTextBox As TextBox
    Friend WithEvents Score_Achieved_FourTextBox As TextBox
    Friend WithEvents Section_Score_TwoTextBox As TextBox
    Friend WithEvents Score_Achieved_ThreeTextBox As TextBox
    Friend WithEvents Score_Achieved_TwoTextBox As TextBox
    Friend WithEvents Section_Score_OneTextBox As TextBox
    Friend WithEvents Score_Achieved_OneTextBox As TextBox
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainPanel As Panel
End Class

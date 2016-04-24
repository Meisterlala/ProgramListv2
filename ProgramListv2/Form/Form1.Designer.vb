<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPrograms = New System.Windows.Forms.TabPage()
        Me.ListViewPrograms = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabGames = New System.Windows.Forms.TabPage()
        Me.ListViewGames = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabGameList = New System.Windows.Forms.TabPage()
        Me.ListViewGamelist = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LabelCount4 = New System.Windows.Forms.Label()
        Me.LabelNumber4 = New System.Windows.Forms.Label()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.LabelNumber3 = New System.Windows.Forms.Label()
        Me.LabelCount3 = New System.Windows.Forms.Label()
        Me.LabelNumber1 = New System.Windows.Forms.Label()
        Me.LabelCount1 = New System.Windows.Forms.Label()
        Me.LabelNumber2 = New System.Windows.Forms.Label()
        Me.LabelCount2 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPrograms.SuspendLayout()
        Me.TabGames.SuspendLayout()
        Me.TabGameList.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPrograms)
        Me.TabControl.Controls.Add(Me.TabGames)
        Me.TabControl.Controls.Add(Me.TabGameList)
        Me.TabControl.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TabControl, "TabControl")
        Me.TabControl.HotTrack = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        '
        'TabPrograms
        '
        Me.TabPrograms.Controls.Add(Me.ListViewPrograms)
        resources.ApplyResources(Me.TabPrograms, "TabPrograms")
        Me.TabPrograms.Name = "TabPrograms"
        Me.TabPrograms.UseVisualStyleBackColor = True
        '
        'ListViewPrograms
        '
        Me.ListViewPrograms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewPrograms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        resources.ApplyResources(Me.ListViewPrograms, "ListViewPrograms")
        Me.ListViewPrograms.FullRowSelect = True
        Me.ListViewPrograms.GridLines = True
        Me.ListViewPrograms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewPrograms.HideSelection = False
        Me.ListViewPrograms.Name = "ListViewPrograms"
        Me.ListViewPrograms.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewPrograms.UseCompatibleStateImageBehavior = False
        Me.ListViewPrograms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'TabGames
        '
        Me.TabGames.Controls.Add(Me.ListViewGames)
        resources.ApplyResources(Me.TabGames, "TabGames")
        Me.TabGames.Name = "TabGames"
        Me.TabGames.UseVisualStyleBackColor = True
        '
        'ListViewGames
        '
        Me.ListViewGames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewGames.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        resources.ApplyResources(Me.ListViewGames, "ListViewGames")
        Me.ListViewGames.FullRowSelect = True
        Me.ListViewGames.GridLines = True
        Me.ListViewGames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewGames.HideSelection = False
        Me.ListViewGames.Name = "ListViewGames"
        Me.ListViewGames.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewGames.UseCompatibleStateImageBehavior = False
        Me.ListViewGames.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'ColumnHeader4
        '
        resources.ApplyResources(Me.ColumnHeader4, "ColumnHeader4")
        '
        'TabGameList
        '
        Me.TabGameList.Controls.Add(Me.ListViewGamelist)
        resources.ApplyResources(Me.TabGameList, "TabGameList")
        Me.TabGameList.Name = "TabGameList"
        Me.TabGameList.UseVisualStyleBackColor = True
        '
        'ListViewGamelist
        '
        Me.ListViewGamelist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewGamelist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewGamelist.FullRowSelect = True
        Me.ListViewGamelist.GridLines = True
        Me.ListViewGamelist.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {CType(resources.GetObject("ListViewGamelist.Groups"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("ListViewGamelist.Groups1"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("ListViewGamelist.Groups2"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("ListViewGamelist.Groups3"), System.Windows.Forms.ListViewGroup)})
        Me.ListViewGamelist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewGamelist.HideSelection = False
        resources.ApplyResources(Me.ListViewGamelist, "ListViewGamelist")
        Me.ListViewGamelist.Name = "ListViewGamelist"
        Me.ListViewGamelist.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewGamelist.UseCompatibleStateImageBehavior = False
        Me.ListViewGamelist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        resources.ApplyResources(Me.ColumnHeader5, "ColumnHeader5")
        '
        'ColumnHeader6
        '
        resources.ApplyResources(Me.ColumnHeader6, "ColumnHeader6")
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LabelCount4
        '
        resources.ApplyResources(Me.LabelCount4, "LabelCount4")
        Me.LabelCount4.Name = "LabelCount4"
        '
        'LabelNumber4
        '
        Me.LabelNumber4.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.LabelNumber4, "LabelNumber4")
        Me.LabelNumber4.Name = "LabelNumber4"
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox, "ComboBox")
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {resources.GetString("ComboBox.Items"), resources.GetString("ComboBox.Items1"), resources.GetString("ComboBox.Items2"), resources.GetString("ComboBox.Items3")})
        Me.ComboBox.Name = "ComboBox"
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LabelNumber3
        '
        Me.LabelNumber3.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.LabelNumber3, "LabelNumber3")
        Me.LabelNumber3.Name = "LabelNumber3"
        '
        'LabelCount3
        '
        resources.ApplyResources(Me.LabelCount3, "LabelCount3")
        Me.LabelCount3.Name = "LabelCount3"
        '
        'LabelNumber1
        '
        Me.LabelNumber1.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.LabelNumber1, "LabelNumber1")
        Me.LabelNumber1.Name = "LabelNumber1"
        '
        'LabelCount1
        '
        resources.ApplyResources(Me.LabelCount1, "LabelCount1")
        Me.LabelCount1.Name = "LabelCount1"
        '
        'LabelNumber2
        '
        Me.LabelNumber2.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.LabelNumber2, "LabelNumber2")
        Me.LabelNumber2.Name = "LabelNumber2"
        '
        'LabelCount2
        '
        resources.ApplyResources(Me.LabelCount2, "LabelCount2")
        Me.LabelCount2.Name = "LabelCount2"
        '
        'FormMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.LabelNumber1)
        Me.Controls.Add(Me.LabelCount1)
        Me.Controls.Add(Me.LabelNumber2)
        Me.Controls.Add(Me.LabelCount2)
        Me.Controls.Add(Me.LabelNumber3)
        Me.Controls.Add(Me.LabelCount3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.LabelNumber4)
        Me.Controls.Add(Me.LabelCount4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.TabControl.ResumeLayout(False)
        Me.TabPrograms.ResumeLayout(False)
        Me.TabGames.ResumeLayout(False)
        Me.TabGameList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TabPrograms As TabPage
    Friend WithEvents TabGames As TabPage
    Friend WithEvents TabGameList As TabPage
    Friend WithEvents ListViewPrograms As ListView
    Friend WithEvents ListViewGames As ListView
    Friend WithEvents ListViewGamelist As ListView
    Friend WithEvents Button6 As Button
    Friend WithEvents LabelCount4 As Label
    Friend WithEvents LabelNumber4 As Label
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents LabelNumber3 As Label
    Friend WithEvents LabelCount3 As Label
    Friend WithEvents LabelNumber1 As Label
    Friend WithEvents LabelCount1 As Label
    Friend WithEvents LabelNumber2 As Label
    Friend WithEvents LabelCount2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class

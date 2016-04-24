<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddEdit))
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxCommands = New System.Windows.Forms.TextBox()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.ButtonChoose = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ListBoxStatus = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxName.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(660, 32)
        Me.TextBoxName.TabIndex = 0
        Me.TextBoxName.Text = "Displayed name"
        '
        'TextBoxCommands
        '
        Me.TextBoxCommands.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBoxCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCommands.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxCommands.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCommands.Location = New System.Drawing.Point(12, 97)
        Me.TextBoxCommands.Name = "TextBoxCommands"
        Me.TextBoxCommands.Size = New System.Drawing.Size(660, 29)
        Me.TextBoxCommands.TabIndex = 1
        Me.TextBoxCommands.Text = "Optional command line arguments"
        '
        'TextBoxPath
        '
        Me.TextBoxPath.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPath.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPath.Location = New System.Drawing.Point(12, 62)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(547, 29)
        Me.TextBoxPath.TabIndex = 2
        Me.TextBoxPath.Text = "Path to executable"
        '
        'ButtonChoose
        '
        Me.ButtonChoose.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonChoose.Location = New System.Drawing.Point(565, 62)
        Me.ButtonChoose.Name = "ButtonChoose"
        Me.ButtonChoose.Size = New System.Drawing.Size(107, 29)
        Me.ButtonChoose.TabIndex = 3
        Me.ButtonChoose.Text = "Choose"
        Me.ButtonChoose.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(565, 188)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(107, 29)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Location = New System.Drawing.Point(12, 188)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(107, 29)
        Me.ButtonBack.TabIndex = 5
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Execuable|*.exe|All files|*.*"
        Me.OpenFileDialog.Title = "Select the executable file"
        '
        'ListBoxStatus
        '
        Me.ListBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxStatus.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxStatus.FormattingEnabled = True
        Me.ListBoxStatus.ItemHeight = 25
        Me.ListBoxStatus.Items.AddRange(New Object() {"Playing", "Completed", "Backlog", "Dropped"})
        Me.ListBoxStatus.Location = New System.Drawing.Point(12, 62)
        Me.ListBoxStatus.Name = "ListBoxStatus"
        Me.ListBoxStatus.Size = New System.Drawing.Size(660, 102)
        Me.ListBoxStatus.TabIndex = 7
        '
        'FormAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(684, 229)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonChoose)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.TextBoxCommands)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ListBoxStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add / Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxCommands As TextBox
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents ButtonChoose As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ListBoxStatus As ListBox
End Class

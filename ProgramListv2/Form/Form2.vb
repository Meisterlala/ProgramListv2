Public Class FormAddEdit



    Dim TextBoxNameDefault As String
    Dim TextBoxPathDefault As String
    Dim TextBoxCommandsDefault As String
    Dim Status As Integer = FormMain.FormAddEditStatus
    Dim PassedStructure As Object = FormMain.PassedStructure

    '   Status
    '
    ' 0 Program Add
    ' 1 Program Edit
    ' 2 Game Add
    ' 3 Game Edit
    ' 4 Gamelist Add
    ' 5 Gamelist Edit



    ' Main
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True

        TextBoxDefault()
        InitializeFormAddEdit()


    End Sub



    ' Initialize the form and change displayed text
    Sub InitializeFormAddEdit()

        ' Disable textbox and button
        If Status = 0 Or Status = 1 Then
            Me.Height = 231
            Me.Width = 700
            ButtonAdd.Location = New Point(565, 151)
            ButtonBack.Location = New Point(12, 151)
            ListBoxStatus.Enabled = False
            ListBoxStatus.Visible = False
            TextBoxName.Enabled = True
            TextBoxName.Visible = True
            TextBoxPath.Enabled = True
            TextBoxPath.Visible = True
            TextBoxCommands.Enabled = True
            TextBoxCommands.Visible = True
            ButtonChoose.Enabled = True
            ButtonChoose.Visible = True

        ElseIf Status = 2 Or Status = 3 Then

            Me.Height = 231
            Me.Width = 700
            ButtonAdd.Location = New Point(565, 151)
            ButtonBack.Location = New Point(12, 151)
            ListBoxStatus.Enabled = False
            ListBoxStatus.Visible = False
            TextBoxName.Enabled = True
            TextBoxName.Visible = True
            TextBoxPath.Enabled = True
            TextBoxPath.Visible = True
            TextBoxCommands.Enabled = True
            TextBoxCommands.Visible = True
            ButtonChoose.Enabled = True
            ButtonChoose.Visible = True

        ElseIf Status = 4 Or Status = 5 Then

            Me.Height = 268
            Me.Width = 700
            ButtonAdd.Location = New Point(565, 188)
            ButtonBack.Location = New Point(12, 188)
            ListBoxStatus.Enabled = True
            ListBoxStatus.Visible = True
            TextBoxName.Enabled = True
            TextBoxName.Visible = True
            TextBoxPath.Enabled = False
            TextBoxPath.Visible = False
            TextBoxCommands.Enabled = False
            TextBoxCommands.Visible = False
            ButtonChoose.Enabled = False
            ButtonChoose.Visible = False
            TextBoxNameDefault = Convert.ToString("Game name")
        End If

        If Status = 4 Then
            TextBoxName.Text = Convert.ToString(TextBoxNameDefault)
            ListBoxStatus.SelectedIndex = 0
        End If



        ' Add or Edit
        If Status = 0 Or Status = 2 Or Status = 4 Then
            ButtonAdd.Text = "Add"
            Me.Text = "Add new entry"
        Else
            ButtonAdd.Text = "Edit"
            Me.Text = "Edit entry"

            If Status = 1 Then
                TextBoxName.Text = PassedStructure.Name
                TextBoxPath.Text = PassedStructure.Path
                TextBoxCommands.Text = PassedStructure.Command
                TextBoxPath_LostFocus()
                TextBoxCommands_LostFocus()
            ElseIf Status = 3 Then

                TextBoxName.Text = PassedStructure.Name
                TextBoxPath.Text = PassedStructure.Path
                TextBoxCommands.Text = PassedStructure.Command
                TextBoxPath_LostFocus()
                TextBoxCommands_LostFocus()
            ElseIf Status = 5 Then
                TextBoxName.Text = PassedStructure.Name
                ListBoxStatus.SelectedIndex = PassedStructure.status
            End If

        End If


    End Sub



    ' Choose Button open dialog and to line
    Private Sub ButtonChoose_Click(sender As Object, e As EventArgs) Handles ButtonChoose.Click

        Me.WindowState = FormWindowState.Minimized
        OpenFileDialog.ShowDialog()
        Me.WindowState = FormWindowState.Normal

        Dim fn As String

        fn = OpenFileDialog.SafeFileName

        If OpenFileDialog.FileName.Length > 0 Then
            TextBoxPath.Text = OpenFileDialog.FileName
        End If

        If TextBoxName.Text = "" Or TextBoxName.Text = TextBoxNameDefault And fn.Length > 0 Then

            TextBoxName.Text = fn.Substring(0, Convert.ToInt32(fn.LastIndexOf(".")))

        End If


    End Sub



    ' Back Button Close Form
    Private Sub ButtonBack_Click() Handles ButtonBack.Click
        Me.Close()
    End Sub



    ' Add / Edit Button 
    Private Sub ButtonAdd_Click() Handles ButtonAdd.Click

        If TextBoxName.Text = "" Or TextBoxName.Text = TextBoxNameDefault Then
            Return
        End If

        If TextBoxPath.Text = TextBoxPathDefault Then
            TextBoxPath.Text = ""
        End If

        If TextBoxCommands.Text = TextBoxCommandsDefault Then
            TextBoxCommands.Text = ""
        End If


        If Status = 0 Then

            Dim newProgram As New FormMain.SProgram
            newProgram.Name = TextBoxName.Text
            newProgram.Path = TextBoxPath.Text
            newProgram.Command = TextBoxCommands.Text
            newProgram.Id = FormMain.GetNewID()
            FormMain.LProgram.Add(newProgram)
            FormMain.addtoListViewPrograms(newProgram)
            FormMain.SaveToFile()

        ElseIf Status = 1 Then

            Dim editedProgram As New FormMain.SProgram
            editedProgram.Name = TextBoxName.Text
            editedProgram.Path = TextBoxPath.Text
            editedProgram.Command = TextBoxCommands.Text
            editedProgram.Id = PassedStructure.Id
            FormMain.RemoveFromLProgram(PassedStructure.Id)
            FormMain.LProgram.Add(editedProgram)
            FormMain.addtoListViewPrograms(editedProgram)
            FormMain.SaveToFile()

        ElseIf Status = 2 Then

            Dim newGame As New FormMain.SGame
            newGame.Name = TextBoxName.Text
            newGame.Path = TextBoxPath.Text
            newGame.Command = TextBoxCommands.Text
            newGame.Id = FormMain.GetNewID()
            FormMain.LGame.Add(newGame)
            FormMain.addtoListViewGames(newGame)
            FormMain.SaveToFile()

        ElseIf Status = 3 Then

            Dim editedGame As New FormMain.SGame
            editedGame.Name = TextBoxName.Text
            editedGame.Path = TextBoxPath.Text
            editedGame.Command = TextBoxCommands.Text
            editedGame.Id = PassedStructure.Id
            FormMain.RemoveFromLGame(PassedStructure.Id)
            FormMain.LGame.Add(editedGame)
            FormMain.addtoListViewGames(editedGame)
            FormMain.SaveToFile()

        ElseIf Status = 4 Then

            Dim newGamelist As New FormMain.SGamelist
            newGamelist.Name = TextBoxName.Text
            newGamelist.Id = FormMain.GetNewID()
            newGamelist.Status = Convert.ToInt16(ListBoxStatus.SelectedIndex)
            FormMain.LGamelist.Add(newGamelist)
            FormMain.addtoListViewGamelist(newGamelist)
            FormMain.SaveToFile()


        ElseIf Status = 5 Then

            Dim editedGamelist As New FormMain.SGamelist
            editedGamelist.Name = TextBoxName.Text
            editedGamelist.Status = Convert.ToInt16(ListBoxStatus.SelectedIndex)
            editedGamelist.Id = PassedStructure.Id
            FormMain.RemoveFromLGamelist(PassedStructure.Id)
            FormMain.LGamelist.Add(editedGamelist)
            FormMain.addtoListViewGamelist(editedGamelist)
            FormMain.SaveToFile()

        End If


        Me.Close()

    End Sub



    ' Sets Default Values for Text Box
    Public Sub TextBoxDefault()

        TextBoxNameDefault = Convert.ToString(TextBoxName.Text)
        TextBoxPathDefault = Convert.ToString(TextBoxPath.Text)
        TextBoxCommandsDefault = Convert.ToString(TextBoxCommands.Text)

    End Sub



    ' All the Text boxes Combined 
    Private Sub TextBoxName_GotFocus() Handles TextBoxName.GotFocus

        ' Diplay Name Box
        If TextBoxName.Text.ToString = TextBoxNameDefault Then
            TextBoxName.Text = ""
        End If

    End Sub
    Private Sub TextBoxName_LostFocus() Handles TextBoxName.LostFocus

        ' Diplay text Box
        If TextBoxName.Text.ToString = "" Then
            TextBoxName.Text = TextBoxNameDefault
        End If

    End Sub
    Private Sub TextBoxPath_TextChanged() Handles TextBoxPath.GotFocus

        ' Path text box
        If TextBoxPath.Text.ToString = TextBoxPathDefault Then
            TextBoxPath.Text = ""
        End If

    End Sub
    Private Sub TextBoxPath_LostFocus() Handles TextBoxPath.LostFocus

        ' Path text Box
        If TextBoxPath.Text.ToString = "" Then
            TextBoxPath.Text = TextBoxPathDefault
        End If

    End Sub
    Private Sub TextBoxCommands_TextChanged() Handles TextBoxCommands.GotFocus

        ' Commands text Box 
        If TextBoxCommands.Text.ToString = TextBoxCommandsDefault Then
            TextBoxCommands.Text = ""
        End If

    End Sub
    Private Sub TextBoxCommands_LostFocus() Handles TextBoxCommands.LostFocus

        ' Commands text Box
        If TextBoxCommands.Text.ToString = "" Then
            TextBoxCommands.Text = TextBoxCommandsDefault
        End If

    End Sub




    ' Esc to close
    Private Sub FormAddEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            ButtonBack_Click()
        End If
        If e.KeyCode = Keys.Enter Then
            ButtonAdd_Click()
        End If
    End Sub




End Class
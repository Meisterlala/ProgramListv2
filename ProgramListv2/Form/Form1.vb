Public Class FormMain

    Public Structure SProgram
        Dim Id As Integer
        Dim Name As String
        Dim Path As String
        Dim Command As String
    End Structure

    Public Structure SGame
        Dim Id As Integer
        Dim Name As String
        Dim Path As String
        Dim Command As String
    End Structure

    Public Structure SGamelist
        Dim Id As Integer
        Dim Name As String
        Dim Status As Short
    End Structure



    Public LProgram As New List(Of SProgram)
    Public LGame As New List(Of SGame)
    Public LGamelist As New List(Of SGamelist)
    Public ITabIndex As New Integer
    Public ImageListProgram As New ImageList()
    Public ImageListGame As New ImageList()
    Public ImageListGamelist As New ImageList()
    Public FormAddEditStatus As New Integer
    Public PassedStructure As Object


    '   SGamelist.Status
    '  
    ' 0 Playing
    ' 1 Completed
    ' 2 Backlog
    ' 3 Dropped


    '   FormAddEdit
    '   
    ' 0 Program Add
    ' 1 Program Edit
    ' 2 Game Add
    ' 3 Game Edit
    ' 4 Gamelist Add
    ' 5 Gamelist Edit



    ' the main() funtion
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.KeyPreview = True

        LoadFromFile()
        TabControl_SelectedIndexChanged()
        InitializeListView()


        SaveToFile()








    End Sub



    ' Save before closing the app
    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        SaveToFile()

    End Sub



    ' Save
    Public Sub SaveToFile()


        Dim FILE_NAME As String = "DB.txt"


        System.IO.File.Delete(FILE_NAME)



        Dim sw As System.IO.StreamWriter
        sw = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True)


        sw.WriteLine("Tabindex")
        sw.WriteLine(TabControl.SelectedIndex)
        sw.WriteLine("Program")
        For Each element In LProgram

            sw.WriteLine(element.Id & "<0>" & element.Name & "<0>" & element.Path & "<0>" & element.Command)

        Next


        sw.WriteLine("Game")
        For Each element In LGame

            sw.WriteLine(element.Id & "<0>" & element.Name & "<0>" & element.Path & "<0>" & element.Command)

        Next


        sw.WriteLine("Gamelist")
        For Each element In LGamelist

            sw.WriteLine(element.Id & "<0>" & element.Name & "<0>" & element.Status)

        Next


        sw.Close()



    End Sub



    ' Load 
    Public Sub LoadFromFile()


        Dim FILE_NAME As String = "DB.txt"



        If CheckIfExists(FILE_NAME) = False Then

            'Default values


        End If




        Dim stringReader As String


        Dim fr As System.IO.StreamReader
        fr = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)

        stringReader = fr.ReadLine()
        stringReader = fr.ReadLine()

        TabControl.SelectedIndex = Convert.ToInt32(stringReader)
        ITabIndex = Convert.ToInt32(stringReader)

        stringReader = fr.ReadLine()
        stringReader = fr.ReadLine()

        Dim tmpSProgram As New SProgram
        Dim tmpSGame As New SGame
        Dim tmpSGamelist As New SGamelist
        Dim index0 As Integer = 0
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0



        LProgram.Clear()
        LGame.Clear()
        LGamelist.Clear()



        Do While stringReader IsNot Nothing And stringReader IsNot "" And stringReader IsNot "Game"

            If stringReader = "Game" Then
                Exit Do
            End If
            index0 = stringReader.IndexOf("<0>")
            tmpSProgram.Id = Convert.ToInt32(stringReader.Substring(0, index0))


            index1 = stringReader.IndexOf("<0>", index0 + 2)
            tmpSProgram.Name = Convert.ToString(stringReader.Substring(index0 + 3, index1 - index0 - 3))


            index2 = stringReader.IndexOf("<0>", index1 + 2)
            tmpSProgram.Path = Convert.ToString(stringReader.Substring(index1 + 3, index2 - index1 - 3))


            tmpSProgram.Command = Convert.ToString(stringReader.Substring(index2 + 3))


            LProgram.Add(tmpSProgram)
            addtoListViewPrograms(tmpSProgram)

            ' AddtoList(tmpSProgram)

            '
            '        Dispaly Loaded Programs

            'MsgBox(tmpSProgram.Id _
            '         & vbCrLf & tmpSProgram.Name _
            '         & vbCrLf & tmpSProgram.Path _
            '         & vbCrLf & tmpSProgram.Command)

            stringReader = fr.ReadLine()

        Loop


        stringReader = fr.ReadLine()

        Do While stringReader IsNot Nothing And stringReader IsNot "" And stringReader IsNot "Gamelist"

            If stringReader = "Gamelist" Then
                Exit Do
            End If


            index0 = stringReader.IndexOf("<0>")
            tmpSGame.Id = Convert.ToInt32(stringReader.Substring(0, index0))


            index1 = stringReader.IndexOf("<0>", index0 + 2)
            tmpSGame.Name = Convert.ToString(stringReader.Substring(index0 + 3, index1 - index0 - 3))


            index2 = stringReader.IndexOf("<0>", index1 + 2)
            tmpSGame.Path = Convert.ToString(stringReader.Substring(index1 + 3, index2 - index1 - 3))


            tmpSGame.Command = Convert.ToString(stringReader.Substring(index2 + 3))

            LGame.Add(tmpSGame)
            addtoListViewGames(tmpSGame)


            '
            '        Dispaly Loaded Programs
            '
            'MsgBox(tmpSGame.Id _
            '         & vbCrLf & tmpSGame.Name _
            '         & vbCrLf & tmpSGame.Path _
            '         & vbCrLf & tmpSGame.Command)

            stringReader = fr.ReadLine()
        Loop



        stringReader = fr.ReadLine()

        Do While stringReader IsNot Nothing And stringReader IsNot ""



            index0 = stringReader.IndexOf("<0>")
            tmpSGamelist.Id = Convert.ToInt32(stringReader.Substring(0, index0))


            index1 = stringReader.IndexOf("<0>", index0 + 2)
            tmpSGamelist.Name = Convert.ToString(stringReader.Substring(index0 + 3, index1 - index0 - 3))


            ' index2 = stringReader.IndexOf("<0>", index1 + 2)
            tmpSGamelist.Status = Convert.ToInt16(stringReader.Substring(index1 + 3))


            LGamelist.Add(tmpSGamelist)
            addtoListViewGamelist(tmpSGamelist)





            ' Dispaly Loaded Programs

            'MsgBox(tmpSGamelist.Id _
            '         & vbCrLf & tmpSGamelist.Name _
            '         & vbCrLf & tmpSGamelist.Status)

            stringReader = fr.ReadLine()


        Loop




        fr.Close()



    End Sub



    ' Remove selected from program list
    Public Sub RemoveFromLProgram(id As Integer)

        ImageListProgram.Images.Clear()
        ListViewPrograms.BeginUpdate()
        ListViewPrograms.Items.Clear()

        Dim tmpLProgram As New List(Of SProgram)
        tmpLProgram = LProgram.ToList

        For Each entry In tmpLProgram
            If entry.Id <> id Then
                addtoListViewPrograms(entry)
            Else
                LProgram.Remove(entry)
            End If
        Next

        tmpLProgram.Clear()
        ListViewPrograms.EndUpdate()
        SaveToFile()

    End Sub



    ' Remove selected from Game list
    Public Sub RemoveFromLGame(id As Integer)

        ImageListGame.Images.Clear()
        ListViewGames.BeginUpdate()
        ListViewGames.Items.Clear()

        Dim tmpLGame As New List(Of SGame)
        tmpLGame = LGame.ToList

        For Each entry In tmpLGame
            If entry.Id <> id Then
                addtoListViewGames(entry)
            Else
                LGame.Remove(entry)
            End If
        Next

        tmpLGame.Clear()
        ListViewGames.EndUpdate()
        SaveToFile()

    End Sub



    ' Remove selected from Gamelist list :p
    Public Sub RemoveFromLGamelist(id As Integer)

        ImageListGamelist.Images.Clear()
        ListViewGamelist.BeginUpdate()
        ListViewGamelist.Items.Clear()

        Dim tmpLGamelist As New List(Of SGamelist)
        tmpLGamelist = LGamelist.ToList

        For Each entry In tmpLGamelist
            If entry.Id <> id Then
                addtoListViewGamelist(entry)
            Else
                LGamelist.Remove(entry)
            End If
        Next

        tmpLGamelist.Clear()
        ListViewGamelist.EndUpdate()
        SaveToFile()

    End Sub



    ' New ID for structures
    Public Function GetNewID()

        Dim int As Integer = 0

        For Each entry In LProgram
            If entry.Id >= int Then

                int = entry.Id
                int += 1

            End If
        Next
        For Each entry In LGame
            If entry.Id >= int Then

                int = entry.Id
                int += 1

            End If
        Next
        For Each entry In LGamelist
            If entry.Id >= int Then

                int = entry.Id
                int += 1

            End If
        Next

        Return int
    End Function



    ' Checks if File exists
    Public Function CheckIfExists(path As String)


        If System.IO.File.Exists(path) = True Then
            Return True

        Else
            Return False

        End If


    End Function



    ' Returns Ico or red X
    Public Function GetIcoFromPath(path As String)

        If CheckIfExists(path) = True Then
            Return Icon.ExtractAssociatedIcon(path)
        Else
            Return My.Resources.red

        End If



    End Function



    ' Changing of Tabs with redrawing
    Private Sub TabControl_SelectedIndexChanged() Handles TabControl.SelectedIndexChanged


        If TabControl.SelectedIndex = 0 Then
            ITabIndex = 0



            Me.Button1.Text = "Start"
            Me.Button2.Text = "Explore"
            Me.Button3.Text = "Add"
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = False
            Me.Button7.Visible = False
            Me.ComboBox.Visible = False
            Me.LabelCount1.Visible = False
            Me.LabelCount2.Visible = False
            Me.LabelCount3.Visible = False
            Me.LabelCount4.Visible = True
            Me.LabelCount4.Text = "Count:"
            Me.LabelNumber1.Visible = False
            Me.LabelNumber2.Visible = False
            Me.LabelNumber3.Visible = False
            Me.LabelNumber4.Visible = True
            Me.LabelNumber4.Text = LProgram.Count


            Return
        End If



        If TabControl.SelectedIndex = 1 Then
            ITabIndex = 1



            Me.Button1.Text = "Start"
            Me.Button2.Text = "Explore"
            Me.Button3.Text = "Add"
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = False
            Me.ComboBox.Visible = False
            Me.LabelCount1.Visible = False
            Me.LabelCount2.Visible = False
            Me.LabelCount3.Visible = False
            Me.LabelCount4.Visible = True
            Me.LabelCount4.Text = "Count:"
            Me.LabelNumber1.Visible = False
            Me.LabelNumber2.Visible = False
            Me.LabelNumber3.Visible = False
            Me.LabelNumber4.Visible = True
            Me.LabelNumber4.Text = LGame.Count

            Return
        End If



        If TabControl.SelectedIndex = 2 Then
            ITabIndex = 2


            Me.Button1.Text = "Add"
            Me.Button2.Text = "Edit"
            Me.Button3.Text = "Remove"
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = True
            Me.ComboBox.Visible = True
            Me.LabelCount1.Visible = True
            Me.LabelCount2.Visible = True
            Me.LabelCount3.Visible = True
            Me.LabelCount4.Visible = True
            Me.LabelCount4.Text = "Dropped:"
            Me.LabelNumber1.Visible = True
            Me.LabelNumber2.Visible = True
            Me.LabelNumber3.Visible = True
            Me.LabelNumber4.Visible = True
            Me.LabelNumber4.Text = LGamelist.Count



            If Me.ComboBox.SelectedIndex = -1 Then
                Me.ComboBox.SelectedIndex = 1
            End If


            Dim Number1 As Integer = 0
            Dim Number2 As Integer = 0
            Dim Number3 As Integer = 0
            Dim Number4 As Integer = 0


            For Each game In LGamelist

                If game.Status = 0 Then
                    Number1 += 1
                ElseIf game.Status = 1 Then
                    Number2 += 1
                ElseIf game.Status = 2 Then
                    Number3 += 1
                ElseIf game.Status = 3 Then
                    Number4 += 1
                End If

            Next

            Me.LabelNumber1.Text = Number1
            Me.LabelNumber2.Text = Number2
            Me.LabelNumber3.Text = Number3
            Me.LabelNumber4.Text = Number4



            Return
        End If



    End Sub



    ' Settings for the list views and Initialization
    Public Sub InitializeListView()

        Me.ListViewPrograms.SmallImageList = ImageListProgram
        Me.ListViewGames.SmallImageList = ImageListGame
        '  Me.ListViewGamelist.SmallImageList = ImageListGamelist


        Me.ListViewPrograms.LargeImageList = ImageListProgram
        Me.ListViewGames.LargeImageList = ImageListGame
        '    Me.ListViewGamelist.LargeImageList = ImageListGamelist

    End Sub



    'Add program to list View
    Public Sub addtoListViewPrograms(program As SProgram)

        Dim item As New ListViewItem
        ImageListProgram.Images.Add(program.Id.ToString, GetIcoFromPath(program.Path))
        item.ImageKey = program.Id.ToString
        item.Text = " " & program.Name.ToString
        item.SubItems.Add(program.Id.ToString)

        Me.ListViewPrograms.Items.Add(item)
        Me.ListViewPrograms.Sort()

        Me.LabelNumber4.Text = LProgram.Count

    End Sub



    'Add game to list View
    Public Sub addtoListViewGames(game As SGame)

        Dim item As New ListViewItem

        ImageListGame.Images.Add(game.Id.ToString, GetIcoFromPath(game.Path))
        item.ImageKey = game.Id.ToString
        item.Text = " " & game.Name.ToString
        item.SubItems.Add(game.Id.ToString)

        Me.ListViewGames.Items.Add(item)
        Me.ListViewGames.Sort()

        Me.LabelNumber4.Text = LGame.Count

    End Sub



    'Add gamelist To list View
    Public Sub addtoListViewGamelist(gamelist As SGamelist)

        Dim item As New ListViewItem

        If gamelist.Status = 0 Then
            ImageListGamelist.Images.Add(gamelist.Id.ToString, My.Resources.p)
            item.Group = Me.ListViewGamelist.Groups(0)
        End If

        If gamelist.Status = 1 Then
            ImageListGamelist.Images.Add(gamelist.Id.ToString, My.Resources.c)
            item.Group = Me.ListViewGamelist.Groups(1)
        End If

        If gamelist.Status = 2 Then
            ImageListGamelist.Images.Add(gamelist.Id.ToString, My.Resources.b)
            item.Group = Me.ListViewGamelist.Groups(2)
        End If

        If gamelist.Status = 3 Then
            ImageListGamelist.Images.Add(gamelist.Id.ToString, My.Resources.d)
            item.Group = Me.ListViewGamelist.Groups(3)
        End If

        item.ImageKey = gamelist.Id.ToString
        item.Text = " " & gamelist.Name.ToString
        item.SubItems.Add(gamelist.Id.ToString)





        Me.ListViewGamelist.Items.Add(item)
        Me.ListViewGamelist.Sort()


        Dim Number1 As Integer = 0
        Dim Number2 As Integer = 0
        Dim Number3 As Integer = 0
        Dim Number4 As Integer = 0


        For Each game In LGamelist

            If game.Status = 0 Then
                Number1 += 1
            ElseIf game.Status = 1 Then
                Number2 += 1
            ElseIf game.Status = 2 Then
                Number3 += 1
            ElseIf game.Status = 3 Then
                Number4 += 1
            End If

        Next

        Me.LabelNumber1.Text = Number1
        Me.LabelNumber2.Text = Number2
        Me.LabelNumber3.Text = Number3
        Me.LabelNumber4.Text = Number4



        Return

    End Sub



    ' Button 1   Start      Start       Add
    Private Sub Button1_Click() Handles Button1.Click

        If ITabIndex = 0 Then


            Dim myProcess As New Process
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewPrograms.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LProgram
                    If entry.Id = id Then
                        Try
                            myProcess.StartInfo.FileName = Convert.ToString(entry.Path)
                            If entry.Command <> "" Then
                                myProcess.StartInfo.Arguments = Convert.ToString(entry.Command)
                            End If
                            myProcess.StartInfo.UseShellExecute = True
                            myProcess.Start()

                        Catch e As Exception
                            MsgBox("Sorry, could not launch " & Convert.ToString(entry.Name) & vbCrLf & Convert.ToString(e.Message))
                        End Try
                        Exit For
                    End If
                Next

            End If

            Me.WindowState = FormWindowState.Minimized


        ElseIf ITabIndex = 1 Then


            Dim myProcess As New Process
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGames.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LGame
                    If entry.Id = id Then
                        Try
                            myProcess.StartInfo.FileName = Convert.ToString(entry.Path)
                            If entry.Command <> "" Then
                                myProcess.StartInfo.Arguments = Convert.ToString(entry.Command)
                            End If
                            myProcess.StartInfo.UseShellExecute = True
                            myProcess.Start()

                        Catch e As Exception
                            MsgBox("Sorry, could not launch " & Convert.ToString(entry.Name) & vbCrLf & Convert.ToString(e.Message))
                        End Try
                        Exit For
                    End If
                Next

            End If


            Me.WindowState = FormWindowState.Minimized


        ElseIf ITabIndex = 2 Then

            FormAddEditStatus = 4
            FormAddEdit.Show()

        End If







    End Sub



    ' Button 2   Explore    Explore     Edit
    Private Sub Button2_Click() Handles Button2.Click


        If ITabIndex = 0 Then

            Dim myProcess As New Process
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewPrograms.SelectedItems
            Dim Item As New ListViewItem
            Dim Directory As String = ""


            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LProgram
                    If entry.Id = id Then

                        Try
                            Directory = System.IO.Path.GetDirectoryName(entry.Path)
                            myProcess.StartInfo.FileName = Convert.ToString(Directory)
                            myProcess.StartInfo.UseShellExecute = True
                            myProcess.Start()

                        Catch e As Exception
                            MsgBox("Sorry, could not open " & Convert.ToString(Directory) & vbCrLf & Convert.ToString(e.Message))
                        End Try
                        Exit For
                    End If
                Next

            End If



        ElseIf ITabIndex = 1 Then

            Dim myProcess As New Process
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGames.SelectedItems
            Dim Item As New ListViewItem
            Dim Directory As String = ""


            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LGame
                    If entry.Id = id Then

                        Try
                            Directory = System.IO.Path.GetDirectoryName(entry.Path)
                            myProcess.StartInfo.FileName = Convert.ToString(Directory)
                            myProcess.StartInfo.UseShellExecute = True
                            myProcess.Start()

                        Catch e As Exception
                            MsgBox("Sorry, could not open " & Convert.ToString(Directory) & vbCrLf & Convert.ToString(e.Message))
                        End Try
                        Exit For
                    End If
                Next

            End If


        ElseIf ITabIndex = 2 Then


            Dim selected As New SGamelist
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGamelist.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LGamelist
                    If entry.Id = id Then
                        PassedStructure = entry
                        FormAddEditStatus = 5
                        FormAddEdit.Show()
                        Exit For
                    End If
                Next

            End If



        End If



    End Sub



    ' Button 3   Add        Add         Remove
    Private Sub Button3_Click() Handles Button3.Click


        If ITabIndex = 0 Then

            FormAddEditStatus = 0
            FormAddEdit.Show()

        ElseIf ITabIndex = 1 Then

            FormAddEditStatus = 2
            FormAddEdit.Show()

        Else

            Dim selected As New SGamelist
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGamelist.SelectedItems
            Dim Item As New ListViewItem

            For Each Item In AllItems
                id = Convert.ToInt32(Item.SubItems(1).Text)
                RemoveFromLGamelist(id)
            Next

        End If

    End Sub



    ' Button 4   Edit       Edit        ----
    Private Sub Button4_Click() Handles Button4.Click


        If ITabIndex = 0 Then

            Dim selected As New SProgram
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewPrograms.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LProgram
                    If entry.Id = id Then
                        PassedStructure = entry
                        FormAddEditStatus = 1
                        FormAddEdit.Show()
                        Exit For
                    End If
                Next

            End If


        ElseIf ITabIndex = 1 Then

            Dim selected As New SGame
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGames.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count > 0 Then

                id = Convert.ToInt32(AllItems.Item(0).SubItems(1).Text)
                For Each entry In LGame
                    If entry.Id = id Then
                        PassedStructure = entry
                        FormAddEditStatus = 3
                        FormAddEdit.Show()
                        Exit For
                    End If
                Next

            End If


        ElseIf ITabIndex = 2 Then

        End If


    End Sub



    ' Button 5   Remove     Remove      ----
    Private Sub Button5_Click() Handles Button5.Click


        If ITabIndex = 0 Then

            Dim selected As New SProgram
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewPrograms.SelectedItems
            Dim Item As New ListViewItem

            For Each Item In AllItems
                id = Convert.ToInt32(Item.SubItems(1).Text)
                RemoveFromLProgram(id)
            Next


        ElseIf ITabIndex = 1 Then
            Dim selected As New SGame
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGames.SelectedItems
            Dim Item As New ListViewItem

            For Each Item In AllItems
                id = Convert.ToInt32(Item.SubItems(1).Text)
                RemoveFromLGame(id)
            Next


        End If



    End Sub



    ' Button 6   ----       ToGamelist  ----
    Private Sub Button6_Click() Handles Button6.Click

        If ITabIndex = 0 Then

        ElseIf ITabIndex = 1 Then

            Dim newGamelist As New SGamelist
            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGames.SelectedItems
            Dim Item As New ListViewItem
            Dim AlreadyExists As Boolean = False

            If AllItems.Count > 0 Then
                For Each Item In AllItems

                    id = Convert.ToInt32(Item.SubItems(1).Text)
                    For Each entry In LGame

                        If entry.Id = id Then


                            AlreadyExists = False

                            newGamelist.Id = entry.Id
                            newGamelist.Status = Convert.ToInt16(0)
                            newGamelist.Name = entry.Name



                            For Each entry2 In LGamelist
                                If newGamelist.Id = entry2.Id Then
                                    AlreadyExists = True
                                    Exit For
                                End If
                            Next

                            If AlreadyExists = False Then
                                LGamelist.Add(newGamelist)
                                addtoListViewGamelist(newGamelist)
                                TabControl.SelectedIndex = 2
                            End If


                            Exit For
                        End If
                    Next

                Next
            End If


        ElseIf ITabIndex = 2 Then

        End If


    End Sub



    ' Button 7   ----       ----        Set status      
    Private Sub Button7_Click() Handles Button7.Click

        If ITabIndex = 0 Then

        ElseIf ITabIndex = 1 Then

        ElseIf ITabIndex = 2 Then



            Dim id As New Integer
            Dim AllItems As ListView.SelectedListViewItemCollection = ListViewGamelist.SelectedItems
            Dim Item As New ListViewItem

            If AllItems.Count = 0 Then
            Else

                For Each Item In AllItems
                    Dim tmpGamelist As New SGamelist
                    id = Convert.ToInt32(Item.SubItems(1).Text)



                    For Each entry In LGamelist
                        If entry.Id = id Then
                            tmpGamelist.Name = Convert.ToString(entry.Name)
                            tmpGamelist.Id = entry.Id
                            tmpGamelist.Status = Convert.ToInt16(ComboBox.SelectedIndex)
                        End If
                    Next

                    RemoveFromLGamelist(id)
                    LGamelist.Add(tmpGamelist)
                    addtoListViewGamelist(tmpGamelist)

                    SaveToFile()


                Next

            End If


        End If

    End Sub



    ' Esc to minimize
    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub



    ' Dubble click the list view
    Private Sub ListViewPrograms_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewPrograms.MouseDoubleClick
        Button4_Click()
    End Sub
    Private Sub ListViewGames_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewGames.MouseDoubleClick
        Button4_Click()
    End Sub
    Private Sub ListViewgamelist_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewGamelist.MouseDoubleClick
        Button2_Click()
    End Sub




End Class
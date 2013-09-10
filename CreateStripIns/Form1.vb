'''''''''''''''''''''''''''''''''''''''''''
'' Known issues:
'' need check box to disable font code
'''''''''''''''''''''''''''''''''''''''''''



Imports System.IO

Public Class MainForm

    Dim Settings As New Settings

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' read in the configuration file to find where to save the strip-ins text file

        If Not File.Exists("settings.cfg") Then
            MessageBox.Show("Settings file is missing!", "Please seek help!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If

        Dim R As New StreamReader("settings.cfg")
        Dim line As String = ""

        While Not IsNothing(line)

            line = R.ReadLine()
            If Not IsNothing(line) Then

                If line = "[OUTFILE]" Then
                    '' load config setting for outfile
                    Settings.outFile = R.ReadLine()

                    '' if outfile exists, delete it
                    deleteOutFile()


                ElseIf line = "[FILENAME]" Then
                    '' load config settings for filename delineation string
                    Settings.filenameString = R.ReadLine()

                ElseIf line = "[COMMENT]" Then
                    '' load config settings for comment delineation string
                    Settings.commentString = R.ReadLine() & " ------------"

                ElseIf line = "[LITHO]" Then
                    '' load config settings for litho delineation string
                    Settings.lithoString = R.ReadLine()

                ElseIf line = "[DOLLAR]" Then
                    '' load config settings for dollar delineation string
                    Settings.dollarString = R.ReadLine

                ElseIf line = "[PREMIER]" Then
                    '' load config settings for premier delineation string
                    Settings.premierString = R.ReadLine

                ElseIf line = "[MONTHLY]" Then
                    '' load config settings for monthly delineation string
                    Settings.monthlyString = R.ReadLine

                ElseIf line = "[DEFAULTJOBTYPE]" Then
                    Select Case line
                        Case "DOLLAR"
                            Settings.defaultJobType = JobType.Dollar
                        Case "MONTHLY"
                            Settings.defaultJobType = JobType.Monthly
                        Case "PREMIER"
                            Settings.defaultJobType = JobType.Premier
                    End Select

                    '' load other config settings here

                End If

            End If

        End While

        '' populate job type combobox
        Me.JobTypeSelect.DataSource = System.Enum.GetValues(GetType(JobType))
        Me.JobTypeSelect.SelectedIndex = Settings.defaultJobType

    End Sub

    Public Sub deleteOutFile()
        If File.Exists(Settings.outFile) Then
            File.Delete(Settings.outFile)
        End If
    End Sub

    Public Sub clearForm()
        EnvelopeName.Text = ""
        FontCode.Text = ""
        TextLine1.Text = ""
        TextLine2.Text = ""
        TextLine3.Text = ""
    End Sub

    Public Function testEmptiness() As Emptiness

        If EnvelopeName.Text = String.Empty And
            FontCode.Text = String.Empty And
            TextLine1.Text = String.Empty And
            TextLine2.Text = String.Empty And
            TextLine3.Text = String.Empty Then
            Return Emptiness.EnvelopeCodeIsEmpty
        ElseIf EnvelopeName.Text = String.Empty Then
            Return Emptiness.EnvelopeCodeIsEmpty
        ElseIf TextLine1.Text = String.Empty And
            TextLine2.Text = String.Empty And
            TextLine3.Text = String.Empty Then
            Return Emptiness.TextLinesAreEmpty
        Else
            Return Emptiness.NotEmpty
        End If

    End Function

    Public Function getJobType() As String
        Dim type As JobType = CType(Me.JobTypeSelect.SelectedValue, JobType)
        Select Case type
            Case JobType.Dollar
                Return Settings.dollarString
            Case JobType.Monthly
                Return Settings.monthlyString
            Case JobType.Premier
                Return Settings.premierString
        End Select
    End Function


    Public Sub appendToFile()

        '' open the out file for writing
        Dim W As StreamWriter

        '' if the file doesn't yet exist, create it and add the job type code (dollar, premier, monthly)
        If Not File.Exists(Settings.outFile) Then
            '' create a new outfile
            W = File.CreateText(Settings.outFile)
            W.WriteLine(getJobType())
            W.Flush()
            W.Close()
        End If





        '' set W to append text
        W = File.AppendText(Settings.outFile)

        '' write out the filename
        Dim filename As String = EnvelopeName.Text.Replace(" ", "").ToUpper
        W.WriteLine(Settings.filenameString & filename)


        '' write out the litho code, if it exists, in all upper case
        If Not FontCode.Text = String.Empty Then
            W.WriteLine(Settings.lithoString & FontCode.Text.ToUpper)
        End If

        '' write each text line, even if it's empty
        W.WriteLine(TextLine1.Text)
        W.WriteLine(TextLine2.Text)
        W.WriteLine(TextLine3.Text)

        '' for readability of text file, write out a comment line
        W.WriteLine(Settings.commentString)



        '' append the data to the CurrentOutput text box

        '' create a new stringbuilder to append (save RAM)
        Dim output As New System.Text.StringBuilder
        output.AppendLine(CurrentOutput.Text)

        output.AppendLine(Settings.filenameString & filename)

        '' litho code is optional
        If Not FontCode.Text = String.Empty Then
            output.AppendLine(Settings.lithoString & FontCode.Text.ToUpper)
        End If

        output.AppendLine(TextLine1.Text)
        output.AppendLine(TextLine2.Text)
        output.AppendLine(TextLine3.Text)
        output.AppendLine(Settings.commentString)

        CurrentOutput.Text = output.ToString

        W.Flush()
        W.Close()

    End Sub

    Private Sub FinishedButton_Click(sender As Object, e As EventArgs) Handles FinishedButton.Click

        'Dim didAppend As Boolean = False

        Dim empty As Emptiness = testEmptiness()

        '' append current data to out file if the form is not empty
        If empty = Emptiness.NotEmpty Or
            empty = Emptiness.EnvelopeCodeIsEmpty Then
            appendToFile()
            'exit
            Me.Dispose()

        ElseIf empty = Emptiness.EnvelopeCodeIsEmpty Then
            MessageBox.Show("You can't leave the envelope name empty!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf empty = Emptiness.TextLinesAreEmpty Then
            MessageBox.Show("You can't leave all three text lines empty!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub



    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        deleteOutFile()
        clearForm()
        CurrentOutput.Text = ""
        EnvelopeName.Focus()
    End Sub



    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        Dim empty As Emptiness = testEmptiness()

        '' append current data to out file if the form is not empty
        If empty = Emptiness.NotEmpty Then
            appendToFile()
            clearForm()
            EnvelopeName.Focus()

        ElseIf empty = Emptiness.EnvelopeCodeIsEmpty Then
            MessageBox.Show("You can't leave the envelope name empty!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf empty = Emptiness.TextLinesAreEmpty Then
            MessageBox.Show("You can't leave all three text lines empty!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub



End Class

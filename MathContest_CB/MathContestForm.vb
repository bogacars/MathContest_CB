'Carson Bogart
'RCET 0265
'Spring 22
'Math Contest
'https://github.com/bogacars/MathContest_CB.git

Option Explicit On
Option Strict On
Public Class MathContestForm
    Dim CorrectAnswer As Integer = 0
    Dim WrongAnswer As Integer = 0
    Sub Startup() Handles Me.Activated
        'sets max and min for numeric up downs
        AgeNumericUpDown.Minimum = 4
        GradeNumericUpDown.Minimum = 1
        AgeNumericUpDown.Maximum = 11
        GradeNumericUpDown.Maximum = 7
        'add radio button will always be checked on startup
        AddRadioButton.Checked = True
        'restricts the user from acsessing these text boxes
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Function Validation() As Boolean
        Dim Status As Boolean = False
        'This looks to see if there is any empty fields and promts the user
        If NameTextBox.Text = "" Then
            Status = False
        Else
            Status = True
        End If
        Return Status
    End Function
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If

    End Sub
    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If

    End Sub
    Private Sub StrudentAnswerTextBox_Leave(sender As Object, e As EventArgs)
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim StudentAnswer As Integer
        FirstNumber = CInt(FirstNumberTextBox.Text)
        SecondNumber = CInt(SecondNumberTextBox.Text)
        StudentAnswer = CInt(StudentAnswerTextBox.Text)

        'all below check if the answer submitted is actually the correct answer
        'based on the selected operation
        If AddRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber + SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber + SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber + SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber + SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If

        End If
        If SubtractRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber - SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber - SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber - SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber - SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
        If MultiplyRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber * SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber * SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber * SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber * SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
        If DivideRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber / SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber / SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                SubmitButton.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber / SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber / SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                SubmitButton.Enabled = True
            Else
                MsgBox("I think you broke the program")
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'resets all entered fields to default, empty
        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'displays to the user the number of questions answered correct or incorrect
        MsgBox($"You got {CorrectAnswer} correct and {WrongAnswer} Wrong.")
    End Sub
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
    End Sub
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((12 * Rnd() * +1))))
    End Sub
    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
    End Sub
    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(CInt(Int((20 * Rnd() * +1))))
        SecondNumberTextBox.Text = CStr(CInt(Int((12 * Rnd() * +1))))
    End Sub
End Class


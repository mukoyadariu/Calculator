Public Class Form1

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 4 ' = /
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Operator_Selector = True Then
            Secondnum = TextBox1.Text
            Select Case Operations
                Case 1 ' +
                    TextBox1.Text = Firstnum + Secondnum
                Case 2 ' -
                    TextBox1.Text = Firstnum - Secondnum
                Case 3 ' *
                    TextBox1.Text = Firstnum * Secondnum
                Case 4 ' /
                    If Secondnum <> 0 Then
                        TextBox1.Text = Firstnum / Secondnum
                    Else
                        MessageBox.Show("Cannot divide by zero!")
                        TextBox1.Text = "0"
                    End If
            End Select
            Operator_Selector = False

        End If
    End Sub
End Class

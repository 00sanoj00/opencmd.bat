Public Class Form1
    Dim codes As String = "color 7"
    Private Sub ViButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton1.Click
        Process.Start("https://www.widane.com/")
        End
    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text.Equals("නිල් පාට") Then
            TextBox1.ForeColor = Color.Blue
        ElseIf ComboBox1.Text.Equals("කොළ පාට") Then
            TextBox1.ForeColor = Color.Green
        ElseIf ComboBox1.Text.Equals("ලා නිල් පාට") Then
            TextBox1.ForeColor = Color.Cyan
        ElseIf ComboBox1.Text.Equals("රතු පාට") Then
            TextBox1.ForeColor = Color.Red
        ElseIf ComboBox1.Text.Equals("දම් පාට") Then
            TextBox1.ForeColor = Color.Purple
        ElseIf ComboBox1.Text.Equals("කහ පාට") Then
            TextBox1.ForeColor = Color.Yellow
        ElseIf ComboBox1.Text.Equals("සුදු පාට") Then
            TextBox1.ForeColor = Color.Wheat
        ElseIf ComboBox1.Text.Equals("අළු පාට") Then
            TextBox1.ForeColor = Color.Gray
        ElseIf ComboBox1.Text.Equals("තද නිල් පාට") Then
            TextBox1.ForeColor = Color.Navy
        End If

    End Sub

    Private Sub ViButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton2.Click
        If ComboBox1.Text.Equals("") Then
            MessageBox.Show("උඩ ටික හරියට පුරවලා ඉදන් බන්")
        Else
            If ComboBox1.Text.Equals("නිල් පාට") Then
                codes = "color 1"
            ElseIf ComboBox1.Text.Equals("කොළ පාට") Then
                codes = "color 2"
            ElseIf ComboBox1.Text.Equals("ලා නිල් පාට") Then
                codes = "color 3"
            ElseIf ComboBox1.Text.Equals("රතු පාට") Then
                codes = "color 4"
            ElseIf ComboBox1.Text.Equals("දම් පාට") Then
                codes = "color 5"
            ElseIf ComboBox1.Text.Equals("කහ පාට") Then
                codes = "color 6"
            ElseIf ComboBox1.Text.Equals("සුදු පාට") Then
                codes = "color 7"
            ElseIf ComboBox1.Text.Equals("අළු පාට") Then
                codes = "color 8"
            ElseIf ComboBox1.Text.Equals("තද නිල් පාට") Then
                codes = "color 9"
            End If
            MyUtilities.RunCommandCom(codes, "", True)
        End If

    End Sub
    Public Class MyUtilities
        Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        End Sub
    End Class

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.facebook.com/sanoj.jayathilaka1")
    End Sub
End Class

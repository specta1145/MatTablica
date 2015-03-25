Public Class podkrecha

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox2.AppendText(Environment.NewLine & "---------------------- +" & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        TextBox2.AppendText(Environment.NewLine & "---------------------- -" & Environment.NewLine)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox2.AppendText(Environment.NewLine & "---------------------- •" & Environment.NewLine)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button6.Visible = False

        Button9.Visible = False
        Button10.Visible = True
        Panel1.Visible = False

        Button7.Visible = True

        Button4.Visible = False
        Button8.Visible = True


        TextBox2.Visible = False
        TextBox18.Visible = True
        TextBox18.Focus()

        'FlowLayoutPanel1.SetFlowBreak()
        'TextBox2.AppendText(Environment.NewLine & "---------------------- :" & Environment.NewLine)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim nazwa As String

        nazwa = InputBox("Nazwij zapis:", "Zapis rachunków", "Podkreska-" & TimeOfDay.Minute)
        Dim bmp As New Bitmap(TextBox2.Width, TextBox2.Height)
        TextBox2.DrawToBitmap(bmp, New Rectangle(New Point(0, 0), TextBox2.Size))
        PictureBox2.Image = bmp
        PictureBox2.Image.Save(nazwa + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
       


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Clear()

    End Sub

    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox18.Clear()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button6.Visible = True

        Button9.Visible = True
        Button10.Visible = False

        Button7.Visible = False

        Button4.Visible = True
        Button8.Visible = False
        Panel1.Visible = True


        TextBox2.Visible = True
        TextBox18.Visible = False


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim nazwa As String

        nazwa = InputBox("Nazwij zapis:", "Zapis rachunków", "Podkreska-" & TimeOfDay.Minute)
        Dim bmp As New Bitmap(TextBox18.Width, TextBox2.Height)
        TextBox18.DrawToBitmap(bmp, New Rectangle(New Point(0, 0), TextBox2.Size))
        PictureBox2.Image = bmp
        PictureBox2.Image.Save(nazwa + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox18.AppendText(Environment.NewLine & "----------------------" & Environment.NewLine)
    End Sub

    Public Sub New()

        ' To wywołanie jest wymagane przez projektanta.
        InitializeComponent()
        TextBox2.Focus()

        ' Dodaj inicjację po wywołaniu funkcji InitializeComponent().

    End Sub

   
    Private Sub TextBox2_VisibleChanged(sender As Object, e As EventArgs) Handles TextBox2.VisibleChanged
        If TextBox2.Visible = True Then
            TextBox2.Focus()

        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

    End Sub

    Private Sub podkrecha_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox2.Focus()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form1.TextBox1.Focus()


        Me.Close()

    End Sub
End Class
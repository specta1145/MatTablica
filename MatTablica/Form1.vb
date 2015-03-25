Public Class Form1
    Public nr1, nr2, n3 As Integer
    Public aktnr, licznik, mianownik As String
    Public czcionka As Font = New System.Drawing.Font("Tachoma", 72, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Public czaspocz, czaskon As Integer
    Public aktwybel As Integer
    Public nrobiektu(1000), nazwaobiektu(1000), typobieku(1000), szerokoscob(1000), wysokoscob(1000), zawob(1000), kolorob(1000), dekob(1000), fontob(1000), liczob(1000), kresob(1000), mianob(1000) As String
    Public liczbaklawiszy As Integer


    Public Sub czysczapis()

        Dim i As Integer

        For i = 0 To liczbaelemetow()

            nrobiektu(i) = ""
            nazwaobiektu(i) = ""
            typobieku(i) = ""
            szerokoscob(i) = ""
            wysokoscob(i) = ""
            zawob(i) = ""
            kolorob(i) = ""
            dekob(i) = ""
            fontob(i) = ""

        Next
    End Sub





    Public Function kreska(ByVal znaki As String) As String
        For y = 1 To znaki.Length * 1.5
            kreska = kreska + "-"
        Next

    End Function

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        liczbaklawiszy = liczbaklawiszy + 1


        If e.KeyValue = Keys.Enter Then
            
            e.SuppressKeyPress = True

            aktnr = TextBox1.Text
            nr1 = Len(aktnr)

            TextBox1.Clear()


            Dim Label2 = New System.Windows.Forms.TextBox
            Dim g As Graphics = Label2.CreateGraphics
            Label2.Font = New System.Drawing.Font("Tachoma", 72, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))

            Label2.Width = g.MeasureString(aktnr, Label2.Font).Width - 35

            If aktnr = "(" Or aktnr = ")" Then
                Label2.Width = g.MeasureString("1", Label2.Font).Width - 60
            End If
            g.Dispose()



            Label2.Name = "Element" & nr2
            Label2.Tag = "calkowita"
            Label2.WordWrap = True


            'Label2.Width = nr1 * 60

            Label2.BorderStyle = BorderStyle.None


            Label2.Text = aktnr.Replace("*", "•")
            If CheckBox1.Checked = True Then
                FlowLayoutPanel1.SetFlowBreak(Label2, True)
                CheckBox1.Checked = False

            Else
                FlowLayoutPanel1.SetFlowBreak(Label2, False)


            End If

            Me.FlowLayoutPanel1.Controls.Add(Label2)
            ComboBox1.Items.Add(Label2.Name)
            nrobiektu(nr2) = nr2.ToString
            nazwaobiektu(nr2) = Label2.Name
            typobieku(nr2) = Label2.Tag

            szerokoscob(nr2) = Label2.Width
            wysokoscob(nr2) = Label2.Height
            zawob(nr2) = Label2.Text
            liczob(nr2) = "0"
            kresob(nr2) = "-"
            mianob(nr2) = "0"

            kolorob(nr2) = Label2.ForeColor.ToString
            dekob(nr2) = Label2.Font.Style.ToString


            fontob(nr2) = Label2.Font.Name

            nr2 = nr2 + 1
            liczbaklawiszy = 0


        End If
        If e.KeyValue = Keys.ControlKey Then
            aktnr = TextBox1.Text
            nr1 = Len(aktnr)

            TextBox1.Clear()


            Dim Label2 = New System.Windows.Forms.TextBox
            Dim g As Graphics = Label2.CreateGraphics
            Label2.Font = czcionka

            Label2.Width = g.MeasureString(aktnr, Label2.Font).Width - 50

            g.Dispose()
            Label2.BorderStyle = BorderStyle.None



            Label2.Name = "Element" & nr2
            Label2.Tag = "Ulamek"

            'Label2.Width = nr1 * 60




            Label2.Text = aktnr

            Me.FlowLayoutPanel1.Controls.Add(Label2)
            ComboBox1.Items.Add(Label2.Name)


            ulamki.ShowDialog()
            nrobiektu(nr2) = nrobiektu(nr2)
            nazwaobiektu(nr2) = nazwaobiektu(nr2)
            typobieku(nr2) = typobieku(nr2)

            szerokoscob(nr2) = szerokoscob(nr2)
            wysokoscob(nr2) = wysokoscob(nr2)
            zawob(nr2) = zawob(nr2)
            liczob(nr2) = liczob(nr2)
            kresob(nr2) = kresob(nr2)
            mianob(nr2) = mianob(nr2)

            kolorob(nr2) = Label2.ForeColor.ToString
            dekob(nr2) = Label2.Font.Style.ToString


            fontob(nr2) = Label2.Font.Name
            nr2 = nr2 + 1

        End If
        If TextBox1.Text.Length >= 20 Then
            e.SuppressKeyPress = True
            aktnr = TextBox1.Text
            nr1 = Len(aktnr)

            TextBox1.Clear()


            Dim Label2 = New System.Windows.Forms.TextBox
            Dim g As Graphics = Label2.CreateGraphics
            Label2.Font = New System.Drawing.Font("Tachoma", 72, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))

            Label2.Width = g.MeasureString(aktnr, Label2.Font).Width - 35

            If aktnr = "(" Or aktnr = ")" Then
                Label2.Width = g.MeasureString("1", Label2.Font).Width - 60
            End If
            g.Dispose()



            Label2.Name = "Element" & nr2
            Label2.Tag = "calkowita"
            Label2.WordWrap = True


            'Label2.Width = nr1 * 60

            Label2.BorderStyle = BorderStyle.None


            Label2.Text = aktnr

            Me.FlowLayoutPanel1.Controls.Add(Label2)
            ComboBox1.Items.Add(Label2.Name)
            nrobiektu(nr2) = nr2.ToString
            nazwaobiektu(nr2) = Label2.Name
            typobieku(nr2) = Label2.Tag

            szerokoscob(nr2) = Label2.Width
            wysokoscob(nr2) = Label2.Height
            zawob(nr2) = Label2.Text
            liczob(nr2) = "0"
            kresob(nr2) = "-"
            mianob(nr2) = "0"

            kolorob(nr2) = Label2.ForeColor.ToString
            dekob(nr2) = Label2.Font.Style.ToString


            fontob(nr2) = Label2.Font.Name

            nr2 = nr2 + 1
            liczbaklawiszy = 0

        End If












    End Sub


    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usu = New System.Windows.Forms.TextBox
        usu.Name = ComboBox1.Text
        Dim nazwa As String
        nazwa = ComboBox1.Text

        ComboBox1.Controls.RemoveByKey(nazwa)

        ComboBox1.Items.Remove(nazwa)
        ComboBox1.Update()




        Me.FlowLayoutPanel1.Controls.RemoveByKey(nazwa)


    End Sub


    Private Sub czysczaznaczenie()
        For i = 0 To FlowLayoutPanel1.Controls.Count - 1
            Me.FlowLayoutPanel1.Controls.Item(i).BackColor = Color.White

        Next
    End Sub






    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        For i = 0 To FlowLayoutPanel1.Controls.Count - 1
            Me.FlowLayoutPanel1.Controls.Item(i).BackColor = Color.White

        Next


        Me.FlowLayoutPanel1.Controls.Item(ComboBox1.SelectedIndex).BackColor = Color.BlanchedAlmond

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 0 To FlowLayoutPanel1.Controls.Count - 1
            Me.FlowLayoutPanel1.Controls.Item(i).BackColor = Color.White

        Next
    End Sub

    


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()



        ' Timer1.Start()














    End Sub



    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox1.Focus()

    End Sub

    

   



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a, c As Integer
        Dim b As Integer = FlowLayoutPanel1.Controls.Count

        a = MsgBox("Czy napewno chcesz wyczyścić tablicę ?", MsgBoxStyle.YesNo, "Czyszczenie tablicy")
        c = 0


        If a = vbYes Then

            FlowLayoutPanel1.Controls.Clear()
            ComboBox1.Items.Clear()
            nr2 = 0

        Else
        Exit Sub

        End If
    End Sub
    Public Function liczbaelemetow() As Integer
        liczbaelemetow = FlowLayoutPanel1.Controls.Count

    End Function


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        czysczaznaczenie()

        aktwybel = aktwybel - 1


        If liczbaelemetow() <> 0 Then
            If aktwybel = -1 Then aktwybel = liczbaelemetow() - 1

            Me.FlowLayoutPanel1.Controls.Item(aktwybel).BackColor = Color.BlanchedAlmond
            ComboBox1.Text = ComboBox1.Items.Item(aktwybel)







        End If



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ColorDialog1.ShowDialog()
        Dim kolor As Color
        kolor = ColorDialog1.Color
        If ComboBox1.Text <> "" Then
            FlowLayoutPanel1.Controls.Item(ComboBox1.Text).ForeColor = kolor


        End If
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim nazwa As String
        If liczbaelemetow() > 0 Then
            nazwa = InputBox("Nazwij zapis:", "Zapis rachunków", "Ulamki-" & TimeOfDay.Minute)
            Dim tekst(), nazwaob(), szerob() As String
            If nazwa <> "" Then
                FileOpen(1, nazwa, OpenMode.Output, OpenAccess.Write)
                Write(1, liczbaelemetow)
                For zapis = 0 To liczbaelemetow()


                    Write(1, nrobiektu(zapis))
                    Write(1, nazwaobiektu(zapis))
                    Write(1, typobieku(zapis))

                    Write(1, szerokoscob(zapis))

                    Write(1, wysokoscob(zapis))

                    Write(1, zawob(zapis))
                    Write(1, liczob(zapis))
                    Write(1, kresob(zapis))
                    Write(1, mianob(zapis))


                    Write(1, kolorob(zapis))
                    Write(1, dekob(zapis))


                    Write(1, fontob(zapis))



                Next



                FileClose(1)
            End If
        End If




    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim nazwa As String
        Dim zapis, wczyt As Integer

        nazwa = OpenFileDialog1.ShowDialog
        nazwa = OpenFileDialog1.FileName

        Dim x As String = MsgBox("Czy chcesz wyczyścić okno przed wczytaniem pliku ?", MsgBoxStyle.YesNoCancel, "Wczytanie pliku")
        If x = vbYes Then
            czysczapis()
            Dim a, c As Integer
            Dim b As Integer = FlowLayoutPanel1.Controls.Count

            a = MsgBox("Czy napewno chcesz wyczyścić tablicę ?", MsgBoxStyle.YesNo, "Czyszczenie tablicy")
           FlowLayoutPanel1.Controls.Clear()
            ComboBox1.Items.Clear()
            nr2 = 0

        Else
            Exit Sub

        End If




        If x = vbAbort Then Exit Sub




        FileOpen(1, nazwa, OpenMode.Input, OpenAccess.Read)
        Input(1, wczyt)

        For zapis = 0 To wczyt

            Input(1, nrobiektu(zapis))
            Input(1, nazwaobiektu(zapis))
            Input(1, typobieku(zapis))

            Input(1, szerokoscob(zapis))

            Input(1, wysokoscob(zapis))

            Input(1, zawob(zapis))
            Input(1, liczob(zapis))
            Input(1, kresob(zapis))
            Input(1, mianob(zapis))

            Input(1, kolorob(zapis))
            Input(1, dekob(zapis))


            Input(1, fontob(zapis))
            If typobieku(zapis) = "calkowita" Then
                Dim Label2 = New System.Windows.Forms.TextBox
                Dim g As Graphics = Label2.CreateGraphics
                Label2.Font = New System.Drawing.Font("Tachoma", 72, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))

                Label2.Width = szerokoscob(zapis)
                Label2.Height = wysokoscob(zapis)




                Label2.Name = nazwaobiektu(zapis)
                Label2.ForeColor = Color.FromName(kolorob(zapis))



                'Label2.Width = nr1 * 60

                Label2.BorderStyle = BorderStyle.None


                Label2.Text = zawob(zapis)
                g.Dispose()
                Me.FlowLayoutPanel1.Controls.Add(Label2)
                ComboBox1.Items.Add(Label2.Name)
                nrobiektu(nr2) = nr2.ToString
                nazwaobiektu(nr2) = Label2.Name
                typobieku(nr2) = Label2.Tag

                szerokoscob(nr2) = Label2.Width
                wysokoscob(nr2) = Label2.Height
                zawob(nr2) = Label2.Text
                liczob(nr2) = "0"
                kresob(nr2) = "-"
                mianob(nr2) = "0"
                kolorob(nr2) = Label2.ForeColor.ToString
                dekob(nr2) = Label2.Font.Style.ToString


                fontob(nr2) = Label2.Font.Name

                nr2 = nr2 + 1
            End If
            If typobieku(zapis) = "Ulamek" Then
                Dim Label2 = New System.Windows.Forms.TextBox
                Dim g As Graphics = Label2.CreateGraphics
                Label2.Font = czcionka

                Label2.Width = szerokoscob(zapis)
                Label2.Height = wysokoscob(zapis)



                Label2.BorderStyle = BorderStyle.None



                Label2.Name = nazwaobiektu(zapis)
                Label2.Tag = typobieku(zapis)

                'Label2.Width = nr1 * 60




                Label2.Text = mianob(nr2) + Environment.NewLine + kresob(nr2) + Environment.NewLine + liczob(nr2)


                Me.FlowLayoutPanel1.Controls.Add(Label2)
                ComboBox1.Items.Add(Label2.Name)
                nrobiektu(nr2) = nr2
                nazwaobiektu(nr2) = Label2.Name
                typobieku(nr2) = Label2.Tag

                szerokoscob(nr2) = Label2.Width
                wysokoscob(nr2) = Label2.Height
                zawob(nr2) = Label2.Text

                kolorob(nr2) = Label2.ForeColor.ToString
                dekob(nr2) = Label2.Font.Style.ToString


                fontob(nr2) = Label2.Font.Name
                nr2 = nr2 + 1
            End If

        Next



        FileClose(1)
        



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim nazwa As String
        If liczbaelemetow() > 0 Then
            nazwa = InputBox("Nazwij zapis:", "Zapis rachunków", "Ulamki-" & TimeOfDay.Minute)
            Dim bmp As New Bitmap(FlowLayoutPanel1.Width, FlowLayoutPanel1.Height)
            FlowLayoutPanel1.DrawToBitmap(bmp, New Rectangle(New Point(0, 0), FlowLayoutPanel1.Size))
            PictureBox1.Image = bmp
            PictureBox1.Image.Save(nazwa + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        Else
            Exit Sub

        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        podkrecha.ShowDialog()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

   
   
    
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        aktnr = TextBox1.Text
        nr1 = Len(aktnr)

        TextBox1.Clear()


        Dim Label2 = New System.Windows.Forms.TextBox
       
        Label2.WordWrap = True




        Label2.BorderStyle = BorderStyle.None


        Label2.Text = " "
        FlowLayoutPanel1.SetFlowBreak(Label2, True)
        Me.FlowLayoutPanel1.Controls.Add(Label2)
        CheckBox1.Checked = False


    End Sub
End Class

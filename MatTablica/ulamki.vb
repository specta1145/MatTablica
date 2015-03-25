Public Class ulamki

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Dim dluzszy, dl2 As String
            Dim licznik, mianownik As String


            mianownik = TextBox1.Text
            licznik = TextBox2.Text
            If mianownik.Length > licznik.Length Then
                dluzszy = mianownik
            End If
            If mianownik.Length < licznik.Length Then
                dluzszy = licznik
            End If
            If mianownik.Length = licznik.Length Then
                dluzszy = mianownik
            End If






            Dim Label3 = New System.Windows.Forms.TextBox
            Label3.Multiline = True

            'Label3.Height = 125

            Dim g As Graphics = Label3.CreateGraphics
            Label3.Font = New System.Drawing.Font("Tachoma", 20, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Label3.Width = g.MeasureString(dluzszy, Label3.Font).Width + 40


            g.Dispose()
            Dim o As System.Drawing.Graphics = Me.CreateGraphics
            Dim oSizeF As System.Drawing.SizeF
            oSizeF = o.MeasureString(TextBox2.Text, Label3.Font)
            Label3.Height = 125

            Label3.TextAlign = HorizontalAlignment.Center
            Label3.BorderStyle = BorderStyle.None

            'Label2.Width = nr1 * 60
            Label3.Name = "Element" & Form1.nr2

            Label3.Text = mianownik + Environment.NewLine + Form1.kreska(dluzszy) + Environment.NewLine + licznik












            Form1.FlowLayoutPanel1.Controls.Add(Label3)
            Form1.ComboBox1.Items.Add(Label3.Name)

            Form1.nr2 = Form1.nr2 + 1
            TextBox1.Clear()
            TextBox2.Clear()
            Form1.nrobiektu(Form1.nr2) = Form1.nr2

            Form1.nazwaobiektu(Form1.nr2) = Label3.Name
            Form1.typobieku(Form1.nr2) = Label3.Tag

            Form1.szerokoscob(Form1.nr2) = Label3.Width
            Form1.wysokoscob(Form1.nr2) = Label3.Height
            Form1.liczob(Form1.nr2) = TextBox1.Text
            Form1.kresob(Form1.nr2) = Form1.kreska(dluzszy)
            Form1.mianob(Form1.nr2) = TextBox2.Text

            Form1.kolorob(Form1.nr2) = Label3.ForeColor.ToString
            Form1.dekob(Form1.nr2) = Label3.Font.Style.ToString


            Form1.fontob(Form1.nr2) = Label3.Font.Name


            Me.Close()
        Else
            Me.Close()

        End If


    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyValue = Keys.Enter Then


            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                Dim dluzszy, dl2 As String
                Dim licznik, mianownik As String


                mianownik = TextBox1.Text
                licznik = TextBox2.Text
                If mianownik.Length > licznik.Length Then
                    dluzszy = mianownik
                End If
                If mianownik.Length < licznik.Length Then
                    dluzszy = licznik
                End If
                If mianownik.Length = licznik.Length Then
                    dluzszy = mianownik
                End If






                Dim Label3 = New System.Windows.Forms.TextBox
                Label3.Multiline = True

                'Label3.Height = 125

                Dim g As Graphics = Label3.CreateGraphics
                Label3.Font = New System.Drawing.Font("Tachoma", 20, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
                Label3.Width = g.MeasureString(dluzszy, Label3.Font).Width + 40


                g.Dispose()
                Dim o As System.Drawing.Graphics = Me.CreateGraphics
                Dim oSizeF As System.Drawing.SizeF
                oSizeF = o.MeasureString(TextBox2.Text, Label3.Font)
                Label3.Height = 125
                Label3.TextAlign = HorizontalAlignment.Center
                Label3.BorderStyle = BorderStyle.None
                Label3.Tag = "Ulamek"

                'Label2.Width = nr1 * 60
                Label3.Name = "Element" & Form1.nr2

                Label3.Text = mianownik + Environment.NewLine + Form1.kreska(dluzszy) + Environment.NewLine + licznik












                Form1.FlowLayoutPanel1.Controls.Add(Label3)
                Form1.ComboBox1.Items.Add(Label3.Name)


                TextBox1.Clear()
                TextBox2.Clear()
                Form1.nrobiektu(Form1.nr2) = Form1.nr2

                Form1.nazwaobiektu(Form1.nr2) = Label3.Name
                Form1.typobieku(Form1.nr2) = Label3.Tag

                Form1.szerokoscob(Form1.nr2) = Label3.Width
                Form1.wysokoscob(Form1.nr2) = Label3.Height
                Form1.liczob(Form1.nr2) = TextBox1.Text
                Form1.kresob(Form1.nr2) = Form1.kreska(dluzszy)
                Form1.mianob(Form1.nr2) = TextBox2.Text

                Form1.kolorob(Form1.nr2) = Label3.ForeColor.ToString
                Form1.dekob(Form1.nr2) = Label3.Font.Style.ToString


                Form1.fontob(Form1.nr2) = Label3.Font.Name
                Form1.nr2 = Form1.nr2 + 1

                Me.Close()
            Else
                Me.Close()

            End If
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "-" Or e.KeyChar = "+" Or e.KeyChar = "*" Or e.KeyChar = "=" Or e.KeyChar = ":" Or e.KeyChar = "/" Or e.KeyChar = "x" Or e.KeyChar = "y" Or e.KeyChar = "z" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = Chr(8) Then


            MyBase.OnKeyPress(e)
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub ulamki_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox1.Focus()





    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "-" Or e.KeyChar = "+" Or e.KeyChar = "*" Or e.KeyChar = "=" Or e.KeyChar = ":" Or e.KeyChar = "/" Or e.KeyChar = "x" Or e.KeyChar = "y" Or e.KeyChar = "z" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = Chr(8) Then


            MyBase.OnKeyPress(e)
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ulamki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
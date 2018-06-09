Public Class Form1

    Dim oldIndex As Integer
    Dim totAmt As Double
    Dim totPaid As Double
    Dim change As Double
    Dim subTot As Double
    Dim FILE_NAME As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Saving Reciept"
    Dim oExcel As Object
    Dim oBook As Object
    Dim oSheet As Object
    Dim temp As Integer

#Region "Add Item and Price"
    Private Sub AddStuff(ByVal Item, ByVal Price)
        ListBox1.Items.Add(Item)
        ListBox2.Items.Add(Price)
    End Sub
#End Region

#Region "Number Pad Code"
    Private Sub NumberPad(ByVal number)
        TextBox4.Text = TextBox4.Text & number
    End Sub
#End Region

#Region "Final Total Function "
    Private Sub FinalTotal()
        totAmt = Nothing
        For i = 0 To ListBox2.Items.Count - 1
            totAmt = totAmt + ListBox2.Items.Item(i)
        Next
        TextBox1.Text = FormatCurrency(totAmt)
    End Sub
#End Region

#Region "Main course"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddStuff("Soup Cup", "1.50")
        FinalTotal()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddStuff("Soup Bowl", "2.00")
        FinalTotal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddStuff("Special of the Day", "4.00")
        FinalTotal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AddStuff("Special of the Day With Beverage", "5.00")
        FinalTotal()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AddStuff("Skins-on Fries", "1.50")
        FinalTotal()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AddStuff("Side Salad", "2.50")
        FinalTotal()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AddStuff("Sandwiches", "2.75")
        FinalTotal()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AddStuff("Large Salad", "3.50")
        FinalTotal()
    End Sub
#End Region

#Region "Sides"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AddStuff("Fresh Fruit", "0.60")
        FinalTotal()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AddStuff("Coleslaw, Applesauce, ect ", "1.00")
        FinalTotal()
    End Sub
#End Region

#Region "Snacks"
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        AddStuff("Chips, Pretzels, Doritos", "0.75")
        FinalTotal()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AddStuff("Cookies(2)", "0.50")
        FinalTotal()
    End Sub
#End Region

#Region "Drinks"
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        AddStuff("Bottled Water", "1.00")
        FinalTotal()

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AddStuff("Milk, Iced Tea, pts.", "1.00")
        FinalTotal()
    End Sub
#End Region

#Region "Make listboxes have same selected index"
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex

    End Sub
#End Region

#Region "Remove Item"
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1 Then
            oldIndex = ListBox1.SelectedIndex
            If ListBox1.SelectedIndex <> 0 Then
                ListBox1.SelectedIndex = oldIndex - 1
                ListBox2.SelectedIndex = oldIndex - 1

            Else
                ListBox1.SelectedIndex = 0
                ListBox2.SelectedIndex = 0

            End If
            ListBox1.Items.RemoveAt(oldIndex)
            ListBox2.Items.RemoveAt(oldIndex)
            FinalTotal()


        Else
            If ListBox1.SelectedIndex = -1 And ListBox1.Items.Count > 0 Then
                ListBox1.SelectedIndex = 0
                ListBox2.SelectedIndex = 0
                oldIndex = ListBox1.SelectedIndex
                ListBox1.Items.RemoveAt(oldIndex)
                ListBox2.Items.RemoveAt(oldIndex)
                FinalTotal()
            Else
                MessageBox.Show("Nothing left to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
#End Region

#Region "Esc Button"
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Me.Close()
    End Sub
#End Region

#Region "Number Pad"
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        NumberPad("1")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        NumberPad("2")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        NumberPad("3")
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        NumberPad("4")
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        NumberPad("5")
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        NumberPad("6")
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        NumberPad("7")
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        NumberPad("8")
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        NumberPad("9")
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        NumberPad(".")
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        NumberPad("0")
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If TextBox4.Text.Length > 0 Then
            TextBox4.Text = TextBox4.Text.Remove(TextBox4.Text.Length - 1)
        End If
    End Sub
#End Region

#Region "Send Total Paid Button"
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        totPaid = TextBox4.Text
        TextBox2.Text = FormatCurrency(totPaid)
        If TextBox4.Text = "" Then
            MessageBox.Show("Enter an Amount to be Paid", "Error")
        End If
        TextBox4.Text = ""

    End Sub
#End Region

#Region "Form Load"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimeDate()
        Timer1.Start()
        TextBox1.Text = FormatCurrency(TextBox2.Text)
        TextBox2.Text = FormatCurrency(TextBox2.Text)
        TextBox3.Text = FormatCurrency(TextBox2.Text)
        Call CreateFiles()
    End Sub
#End Region

#Region "Save Reciept"
    Private Sub SaveReciept()
        Me.Refresh()
        If My.Computer.FileSystem.FileExists(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\itemsPurch.txt") Then
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\itemsPurch.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\itemsPrice.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\time.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\death.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\finalTotal.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\totalPaid.txt")
            IO.File.Delete(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\change.txt")
        Else
            If My.Computer.FileSystem.FileExists(FILE_NAME & "\Receipts" & "\directoryMade.txt") Then
                MkDir(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum))
            Else
                MkDir(FILE_NAME & "\Receipts")
                IO.File.Create(FILE_NAME & "\Receipts" & "\directoryMade.txt")
                MkDir(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum))
            End If
        End If

        Dim Img As New Bitmap(Panel6.Width, Panel6.Height)
        Dim g As Graphics = Graphics.FromImage(Img)
        g.CopyFromScreen(Panel6.Bounds.Left + Me.Bounds.Left + 4, Panel6.Bounds.Top + Me.Bounds.Top + 30, 0, 0, Img.Size)
        Img.Save(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\RecieptImage.jpg", Imaging.ImageFormat.Bmp)
        g.Dispose()

        'IO.File.CreateText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\time.txt")
        'IO.File.CreateText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\date.txt")
        'IO.File.CreateText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\finalTotal.txt")
        'IO.File.CreateText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\totalPaid.txt")
        'IO.File.CreateText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\change.txt")

        'Items Purchased
        Dim fileTransfer(50) As String
        If ListBox1.Items.Count = 1 Then
            fileTransfer(0) = ListBox1.Items.Item(0)
        Else
            For i = 0 To ListBox1.Items.Count - 1
                fileTransfer(i) = ListBox1.Items.Item(i)
            Next
        End If
        IO.File.WriteAllLines(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\itemsPurch.txt", fileTransfer)
        'Items Price
        ReDim fileTransfer(50)
        If ListBox1.Items.Count = 1 Then
            fileTransfer(0) = ListBox2.Items.Item(0)
        Else
            For i = 0 To ListBox2.Items.Count - 1
                fileTransfer(i) = ListBox2.Items.Item(i)
            Next
        End If
        IO.File.WriteAllLines(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\itemsPrice.txt", fileTransfer)
        'Items
        IO.File.WriteAllText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\time.txt", Label8.Text)
        'Date
        IO.File.WriteAllText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\date.txt", Label7.Text)
        'Final Total
        IO.File.WriteAllText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\finalTotal.txt", TextBox1.Text)
        'Total Paid
        IO.File.WriteAllText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\totalPaid.txt", TextBox2.Text)
        'Change Due
        IO.File.WriteAllText(FILE_NAME & "\Receipts\Receipt" & (My.Settings.RecNum) & "\change.txt", TextBox3.Text)
    End Sub
#End Region

#Region "Form2 Instructions"
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        Form2.Show()
        Me.Hide()
    End Sub
#End Region

#Region "Sub Total Button"
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        change = TextBox2.Text - TextBox1.Text
        If change >= 0 Then
            TextBox3.Text = FormatCurrency(change)
            Call saveReciept()
            'Me.Refresh()
            'Dim Img As New Bitmap(Panel6.Width, Panel6.Height)
            'Dim g As Graphics = Graphics.FromImage(Img)
            'g.CopyFromScreen(Panel6.Bounds.Left + Me.Bounds.Left + 4, Panel6.Bounds.Top + Me.Bounds.Top + 30, 0, 0, Img.Size)
            'Img.Save(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Saving Menu File\Saving Reciept File" & My.Settings.RecNum, Imaging.ImageFormat.Bmp)
            'g.Dispose()
            My.Settings.RecNum = My.Settings.RecNum + 1

        Else
            MessageBox.Show("You do not have enough money to pay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Text = "$0.00"
        End If

    End Sub
#End Region

#Region "Clear Button"
    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = "$0.00"
        TextBox2.Text = "$0.00"
        TextBox3.Text = "$0.00"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        subTot = 0
        totAmt = 0
        totPaid = 0
        change = 0


    End Sub
#End Region

#Region "Next Customer"
    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        TextBox1.Text = "$0.00"
        TextBox2.Text = "$0.00"
        TextBox3.Text = "$0.00"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
#End Region

#Region "insta money click"
    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        subTot = subTot + 20
        TextBox2.Text = FormatCurrency(subTot)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        subTot = subTot + 10
        TextBox2.Text = FormatCurrency(subTot)
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        subTot = subTot + 5
        TextBox2.Text = FormatCurrency(subTot)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        subTot = subTot + 1
        TextBox2.Text = FormatCurrency(subTot)
    End Sub
#End Region

#Region "Number pad visible?"
    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Panel2.Visible = True
        Else
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub
#End Region

#Region "Time and Date"
    Private Sub TimeDate()
        Label8.Text = Now.ToLongTimeString
        Label14.Text = Now.ToLongTimeString

        Label7.Text = DateTime.Now.ToString("MM/dd/yyyy")
        Label10.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeDate()
    End Sub
#End Region

#Region "Creating Files"
    Private Sub CreateFiles()
        If IO.File.Exists(FILE_NAME & "\all files created.txt") = False Then
            MkDir(FILE_NAME)
            IO.File.CreateText(FILE_NAME & "\all files created.txt")
        End If
    End Sub
#End Region

End Class

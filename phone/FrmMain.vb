Public Class FrmMain

    Dim PubSqlCom As New SqlClient.SqlCommand
    Dim PubSqlCon As New SqlClient.SqlConnection
    Dim PubSqlDR As SqlClient.SqlDataReader
    Public Shared PubStrConString As String = ("Data Source=" & My.Computer.Name & ";Initial Catalog=PhoneBook;Integrated Security=True")

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim Lst As ListViewItem
        PubSqlCon.ConnectionString = PubStrConString

        'تبدیل زبان صفحه کلید به فارسی در هنگام فراخوانی برنامه
        Dim locInputType As New System.Globalization.CultureInfo("FA-IR")
        Application.CurrentInputLanguage = InputLanguage.FromCulture(locInputType)

        'پر کردن لیست ویو
        PubSqlCom.CommandText = "SELECT * FROM  TblPhoneBook "
        PubSqlCom.Connection = PubSqlCon
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlDR = PubSqlCom.ExecuteReader()
        If PubSqlDR.HasRows Then
            While PubSqlDR.Read()
                Lst = ListView1.Items.Add(PubSqlDR("Id"))
                Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
            End While
        End If
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
        CmbSearch.SelectedItem = "نام خانوادگی"
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim Lst As ListViewItem

        If Len(TxtFName.Text) = 0 Then
            MessageBox.Show("در وارد کردن نام مخاطب دقت کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtFName.Focus()
            Exit Sub
        End If

        If Len(TxtLName.Text) = 0 Then
            MessageBox.Show("در وارد کردن نام خانوادگی  مخاطب دقت کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtLName.Focus()
            Exit Sub
        End If
        If Len(TxtPhone.Text) = 0 And Len(TxtMobile.Text) = 0 Then
            MessageBox.Show("لطفا شماره تلفن یا موبایل را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtPhone.Focus()
            Exit Sub
        Else
            If Len(TxtPhone.Text) <> 0 Then
                If IsNumeric(TxtPhone.Text) = False Then
                    MessageBox.Show("لطفا برای شماره تلفن فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtPhone.Clear()
                    TxtPhone.Focus()
                    Exit Sub
                End If
            End If

            If Len(TxtCodPhon.Text) <> 0 Then
                If IsNumeric(TxtCodPhon.Text) = False Then
                    MessageBox.Show("لطفا برای کد تلفن فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtCodPhon.Clear()
                    TxtCodPhon.Focus()
                    Exit Sub
                End If
            End If

            If Len(TxtMobile.Text) <> 0 Then
                If IsNumeric(TxtMobile.Text) = False Then
                    MessageBox.Show("لطفا برای شماره موبایل فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtMobile.Clear()
                    TxtMobile.Focus()
                    Exit Sub
                End If
            End If

        End If

        'اضافه کردن مخاطب جدید
        PubSqlCom.CommandText = "INSERT INTO TblPhoneBook   ( FName,LName,CodePhone ,PhoneNum, MobileNum)  VALUES  (N'" & TxtFName.Text & "',N'" & TxtLName.Text & "',N'" & TxtCodPhon.Text & "',N'" & TxtPhone.Text & "',N'" & TxtMobile.Text & "')"
        PubSqlCom.Connection = PubSqlCon
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlCom.ExecuteReader()
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()

        'بدست آوردن آخرین کد ذخیره شده(کد ذخیره شده برای مخاطب
        PubSqlCom.CommandText = "select max(Id) From  TblPhoneBook "
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlDR = PubSqlCom.ExecuteReader()
        PubSqlDR.Read()
        TxtId.Text = PubSqlDR(0)
        MessageBox.Show("کد ثبت شده برای مخاطب = " & PubSqlDR(0), "ثبت شد", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
        BtnNew.Focus()
        RadioBtn1.Checked = True
        'پر کردن لیست ویو
        ListView1.Items.Clear()
        PubSqlCom.CommandText = "SELECT * FROM  TblPhoneBook "
        PubSqlCom.Connection = PubSqlCon
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlDR = PubSqlCom.ExecuteReader()
        If PubSqlDR.HasRows Then
            While PubSqlDR.Read()
                Lst = ListView1.Items.Add(PubSqlDR("Id"))
                Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
            End While
        End If
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        Dim MsgResult As New MsgBoxResult
        Dim Lst As ListViewItem

        'ویرایش اطلاعات
        If Len(TxtFName.Text) = 0 Then
            MessageBox.Show("در وارد کردن نام مخاطب دقت کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtFName.Focus()
            Exit Sub
        End If

        If Len(TxtLName.Text) = 0 Then
            MessageBox.Show("در وارد کردن نام خانوادگی  مخاطب دقت کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtLName.Focus()
            Exit Sub
        End If
        If Len(TxtPhone.Text) = 0 And Len(TxtMobile.Text) = 0 Then
            MessageBox.Show("لطفا شماره تلفن یا موبایل را وارد نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtPhone.Focus()
            Exit Sub
        Else
            If Len(TxtPhone.Text) <> 0 Then
                If IsNumeric(TxtPhone.Text) = False Then
                    MessageBox.Show("لطفا برای شماره تلفن فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtPhone.Clear()
                    TxtPhone.Focus()
                    Exit Sub
                End If
            End If

            If Len(TxtCodPhon.Text) <> 0 Then
                If IsNumeric(TxtCodPhon.Text) = False Then
                    MessageBox.Show("لطفا برای کد تلفن فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtCodPhon.Clear()
                    TxtCodPhon.Focus()
                    Exit Sub
                End If
            End If

            If Len(TxtMobile.Text) <> 0 Then
                If IsNumeric(TxtMobile.Text) = False Then
                    MessageBox.Show("لطفا برای شماره موبایل فقط از اعداد استفاده نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtMobile.Clear()
                    TxtMobile.Focus()
                    Exit Sub
                End If
            End If

        End If

        MsgResult = MessageBox.Show("برای ویرایش اطلاعات مطمئن هستید", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        If MsgResult = MsgBoxResult.Yes Then

            PubSqlCom.CommandText = "UPDATE  TblPhoneBook   SET      FName =N'" & TxtFName.Text & "', LName ='" & TxtLName.Text & "', CodePhone =N'" & TxtCodPhon.Text & "',PhoneNum =N'" & TxtPhone.Text & "',  MobileNum =N'" & TxtMobile.Text & "' where id=" & TxtId.Text
            PubSqlCom.Connection = PubSqlCon
            If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
            PubSqlCom.ExecuteReader()
            If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
            MessageBox.Show("تغییرات در بانک اطلاعاتی به ثبت رسید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            BtnNew.Focus()
            RadioBtn1.Checked = True
        Else
            Exit Sub
        End If
        'پر کردن لیست ویو
        ListView1.Items.Clear()
        PubSqlCom.CommandText = "SELECT * FROM  TblPhoneBook "
        PubSqlCom.Connection = PubSqlCon
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlDR = PubSqlCom.ExecuteReader()
        If PubSqlDR.HasRows Then
            While PubSqlDR.Read()
                Lst = ListView1.Items.Add(PubSqlDR("Id"))
                Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
            End While
        End If
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()

    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        Dim MsgResult As New MsgBoxResult
        Dim Lst As ListViewItem

        'حذف اطلاعات
        If Len(TxtId.Text) <> 0 Then

            MsgResult = MessageBox.Show("برای حذف اطلاعات مطمئن هستید", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            If MsgResult = MsgBoxResult.Yes Then

                PubSqlCom.CommandText = "DELETE  FROM  TblPhoneBook  where  id =" & TxtId.Text
                PubSqlCom.Connection = PubSqlCon
                If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
                PubSqlCom.ExecuteReader()
                If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
                BtnNew_Click(sender, e)
                MessageBox.Show("اطلاعات از بانک اطلاعاتی حذف شد", "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                BtnNew.Focus()
                RadioBtn1.Checked = True
            Else
                Exit Sub
            End If

        Else
            Exit Sub
        End If

        'پر کردن لیست ویو
        ListView1.Items.Clear()
        PubSqlCom.CommandText = "SELECT * FROM  TblPhoneBook "
        PubSqlCom.Connection = PubSqlCon
        If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
        PubSqlDR = PubSqlCom.ExecuteReader()
        If PubSqlDR.HasRows Then
            While PubSqlDR.Read()
                Lst = ListView1.Items.Add(PubSqlDR("Id"))
                Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
            End While
        End If
        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()

    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        'عملیات مربوط به دکمه جدید
        TxtId.Clear()
        TxtFName.Clear()
        TxtLName.Clear()
        TxtCodPhon.Clear()
        TxtPhone.Clear()
        TxtMobile.Clear()
        If RadioBtnSave.Checked = True Then
            BtnSave.Enabled = True
        ElseIf RadioBtnEdit.Checked = True Then
            BtnEdit.Enabled = True
        ElseIf RadioBtnDel.Checked = True Then
            BtnDel.Enabled = True
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'بستن برنامه
        Me.Close()

    End Sub

    Private Sub BtnPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPhone.Click

        'نمایش فرم مربوط به تماس
        Dim Frm As New FrmNumber
        Me.Hide()
        Frm.ShowDialog()

    End Sub

    Private Sub RadioBtnSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnSave.CheckedChanged

        'اعمال تغییرات با انتخاب رادیو باتن ذخیره
        If RadioBtnSave.Checked = True Then
            BtnSave.Enabled = True
            BtnEdit.Enabled = False
            BtnDel.Enabled = False
            Me.AcceptButton = BtnSave
            BtnNew_Click(sender, e)
            TxtId.ReadOnly = True
            TxtFName.ReadOnly = False
            TxtLName.ReadOnly = False
            TxtCodPhon.ReadOnly = False
            TxtPhone.ReadOnly = False
            TxtMobile.ReadOnly = False
            TxtFName.Focus()
        Else
            BtnSave.Enabled = False
        End If

    End Sub

    Private Sub RadioBtnEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnEdit.CheckedChanged

        'اعمال تغییرات با انتخاب رادیو باتن ویرایش
        If RadioBtnEdit.Checked = True Then
            BtnEdit.Enabled = True
            BtnSave.Enabled = False
            BtnDel.Enabled = False
            Me.AcceptButton = BtnEdit
            BtnNew_Click(sender, e)
            TxtId.ReadOnly = False
            TxtFName.ReadOnly = True
            TxtLName.ReadOnly = True
            TxtCodPhon.ReadOnly = True
            TxtPhone.ReadOnly = True
            TxtMobile.ReadOnly = True
            TxtId.Focus()
        Else
            BtnEdit.Enabled = False
        End If

    End Sub

    Private Sub RadioBtnDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnDel.CheckedChanged

        'اعمال تغییرات با انتخاب رادیو باتن حذف
        If RadioBtnDel.Checked = True Then
            BtnDel.Enabled = True
            BtnSave.Enabled = False
            BtnEdit.Enabled = False
            Me.AcceptButton = BtnDel
            BtnNew_Click(sender, e)
            TxtId.ReadOnly = False
            TxtFName.ReadOnly = True
            TxtLName.ReadOnly = True
            TxtCodPhon.ReadOnly = True
            TxtPhone.ReadOnly = True
            TxtMobile.ReadOnly = True
            TxtId.Focus()
        Else
            BtnDel.Enabled = False
        End If

    End Sub

    Private Sub TxtId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtId.Leave

        'پر کردن اطلاعات مربوط به ایدی وارد شده در تکست باکس ایدی در تکست باکس های دیگر
        If IsNumeric(TxtId.Text) Then

            PubSqlCom.CommandText = "SELECT  *  FROM    TblPhoneBook    WHERE Id=" & TxtId.Text
            PubSqlCom.Connection = PubSqlCon
            If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
            If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
            PubSqlDR = PubSqlCom.ExecuteReader()
            PubSqlDR.Read()

            If PubSqlDR.HasRows Then
                TxtFName.Text = PubSqlDR("FName")
                TxtLName.Text = PubSqlDR("LName")
                TxtCodPhon.Text = PubSqlDR("CodePhone")
                TxtPhone.Text = PubSqlDR("PhoneNum")
                TxtMobile.Text = PubSqlDR("MobileNum")

                TxtFName.Focus()
                TxtFName.ReadOnly = False
                TxtLName.ReadOnly = False
                TxtCodPhon.ReadOnly = False
                TxtPhone.ReadOnly = False
                TxtMobile.ReadOnly = False
            Else
                MessageBox.Show("کد وارد شده فاقد اطلاعات می باشد.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                TxtId.Text = ""
                TxtId.Focus()
                BtnNew_Click(sender, e)
            End If
            If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()

        ElseIf Len(TxtId.Text) <> 0 Then
            MessageBox.Show("لطفا عدد وارد نمایید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
            TxtId.Text = ""
            TxtId.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub ListView1_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        'کد بایند اطلاعات از لیست ویو
        RadioBtn1.Checked = True
        BtnPhone.Focus()
        TxtId.Text = e.Item.SubItems(1).Text
        TxtFName.Text = e.Item.SubItems(2).Text
        TxtLName.Text = e.Item.SubItems(3).Text
        TxtCodPhon.Text = e.Item.SubItems(4).Text
        TxtPhone.Text = e.Item.SubItems(5).Text
        TxtMobile.Text = e.Item.SubItems(6).Text

    End Sub

    Private Sub ChbSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChbSearch.CheckedChanged
        'کدهای مریوط به چک باکس جستجو
        If ChbSearch.Checked = False Then
            ListView1.Items.Clear()
            Panel5.Enabled = False
            FrmMain_Load(sender, e)
            TxtSearch.Clear()
        Else
            Panel5.Enabled = True
            TxtSearch.Focus()
            ListView1.Items.Clear()
        End If

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        'کد های مربوط به جستجو
        ListView1.Items.Clear()
        Dim Lst As ListViewItem
        Dim WHERE As String

        If TxtSearch.Text <> "" Then


            If CmbSearch.Text = "نام" Then
                WHERE = "Fname Like N'" & TxtSearch.Text & "%'"
                PubSqlCom.CommandText = "SELECT  *  FROM    TblPhoneBook    WHERE " & WHERE
                PubSqlCom.Connection = PubSqlCon
                If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
                PubSqlDR = PubSqlCom.ExecuteReader()
                If PubSqlDR.HasRows Then
                    While PubSqlDR.Read()
                        Lst = ListView1.Items.Add(PubSqlDR("Id"))
                        Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                        Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                        Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                        Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                        Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                        Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
                    End While
                Else
                    MessageBox.Show("موردی برای جستجو یافت نشد", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtSearch.Clear()
                End If

            ElseIf CmbSearch.Text = "نام خانوادگی" Then
                WHERE = "Lname like N'" & TxtSearch.Text & "%'"
                PubSqlCom.CommandText = "SELECT  *  FROM    TblPhoneBook    WHERE " & WHERE
                PubSqlCom.Connection = PubSqlCon
                If PubSqlCon.State = ConnectionState.Closed Then PubSqlCon.Open()
                PubSqlDR = PubSqlCom.ExecuteReader

                If PubSqlDR.HasRows Then
                    While PubSqlDR.Read()
                        Lst = ListView1.Items.Add(PubSqlDR("Id"))
                        Lst.SubItems.Add(1).Text = (PubSqlDR("Id"))
                        Lst.SubItems.Add(2).Text = (PubSqlDR("FName"))
                        Lst.SubItems.Add(3).Text = (PubSqlDR("LName"))
                        Lst.SubItems.Add(4).Text = (PubSqlDR("CodePhone"))
                        Lst.SubItems.Add(5).Text = (PubSqlDR("PhoneNum"))
                        Lst.SubItems.Add(6).Text = (PubSqlDR("MobileNum"))
                    End While
                Else
                    MessageBox.Show("موردی برای جستجو یافت نشد", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign)
                    TxtSearch.Clear()
                End If
            End If
        End If

        If PubSqlCon.State = ConnectionState.Open Then PubSqlCon.Close()
        TxtSearch.Clear()
        TxtSearch.Focus()

    End Sub

    Private Sub TxtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSearch.KeyPress

        If (AscW(e.KeyChar) = 13) Then 'Enter Key Pressed
            BtnSearch_Click(sender, e)
        End If

    End Sub

End Class

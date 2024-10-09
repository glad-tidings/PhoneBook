Public Class FrmNumber

    Private Sub FrmNumber_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        FrmMain.Show()

    End Sub

    Private Sub FrmNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        TxtPhoneNumber.Text = FrmMain.TxtCodPhon.Text & FrmMain.TxtPhone.Text
        TxtMobile.Text = FrmMain.TxtMobile.Text

        If TxtPhoneNumber.Text = "" And TxtMobile.Text = "" Then
            BtnCall.Enabled = False
        ElseIf TxtPhoneNumber.Text = "" Then
            RBtnPhone.Enabled = False
            RBtnMobile.Checked = True
        ElseIf TxtMobile.Text = "" Then
            RBtnMobile.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCall.Click

        Dim C As New TAPI3Lib.RequestMakeCall

        If RBtnPhone.Checked = True Then
            C.MakeCall(TxtPhoneNumber.Text, "home", "0", "none")
        Else
            C.MakeCall(TxtMobile.Text, "home", "0", "none")
        End If

    End Sub
End Class
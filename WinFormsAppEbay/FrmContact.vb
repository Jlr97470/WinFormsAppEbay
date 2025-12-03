Public Class FrmContact

	Private Sub FrmContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Try

			Me.CONTACTTableAdapter.Fill(Me.DstEbay.CONTACT)

		Catch ex As Exception

			MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmContact.FrmContact_Load()")

		End Try

	End Sub

	Private Sub FrmContact_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

		Try

			FrmListe.Show()

		Catch ex As Exception

			MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmContact.FrmContact_Closing()")

		End Try

	End Sub

End Class
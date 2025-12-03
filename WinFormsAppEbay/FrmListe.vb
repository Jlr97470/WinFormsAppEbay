Public Class FrmListe

    Private Sub InitialiseListeContact()
        Dim RowContact As Data.DataRow
        Dim ItemContact As ListViewItem

        Try

            Me.LsvContact.Items.Clear()

            For Each RowContact In Me.DstEbay.CONTACT.Rows

                ItemContact = New ListViewItem(RowContact("ConPseudo").ToString)

                ItemContact.SubItems.Add(RowContact("ConNom").ToString)

                ItemContact.SubItems.Add(RowContact("ConPrenom").ToString)

                ItemContact.SubItems.Add(RowContact("ConNum").ToString)

                Me.LsvContact.Items.Add(ItemContact)

            Next

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmListe.InitialiseListeContact()")

        End Try

    End Sub

    Private Sub FrmListe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            CreerBase()

            Me.CONTACTTableAdapter.Fill(Me.DstEbay.CONTACT)

            InitialiseListeContact()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmListe.FrmListe_Load()")

        End Try


    End Sub

    Private Sub MnuQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuQuitter.Click

        Try

            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmListe.MnuQuitter_Click()")

        End Try


    End Sub

    Private Sub MnuApropos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuApropos.Click

        Try

            MsgBox(CstPrgNom & " V" & CstPrgVersion & vbCrLf & "Auteur : " & vbCrLf & CstPrgAuteur, MsgBoxStyle.Information, "Apropos")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmListe.MnuApropos_Click()")

        End Try

    End Sub

    Private Sub CmdModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModifier.Click

        Try

            FrmContact.Show()

            FrmContact.CONTACTBindingSource.Filter = "ConNum=" & CStr(Me.LsvContact.Items(Me.LsvContact.SelectedIndices.Item(0)).SubItems(3).Text)

            Me.Hide()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "FrmListe.CmdModifier_Click()")

        End Try


    End Sub

    Private Sub CmdAjouter_Click(sender As Object, e As EventArgs) Handles CmdAjouter.Click

    End Sub
End Class

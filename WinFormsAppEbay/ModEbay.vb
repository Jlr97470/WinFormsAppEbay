Imports System.Data.SqlServerCe

Module ModEbay

	Public Const CstPrgNom As String = "Ebay Vente"

	Public Const CstPrgVersion As String = "1.0.0"

	Public Const CstPrgAuteur As String = "ROYER Jean-Laurent"

	Private StrCheminBase As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

	Private StrCheminNomBase As String = StrCheminBase & "\Ebay.sdf"

	Private Conn As SqlCeConnection

	Private Cmd As SqlCeCommand

	Public Function ExecuteSQL(ByVal StrSQL As String) As Boolean

		Try

			Cmd.CommandText = StrSQL

			Cmd.ExecuteNonQuery()

			Return True

		Catch ex As Exception

			MsgBox(ex.Message, MsgBoxStyle.Critical, "ModEbay.ExecuteSQL()")

			Return False

		End Try

	End Function

	Public Sub CreerBase()

		Try

			If Not System.IO.File.Exists(StrCheminNomBase) Then

				Dim SCE As New SqlCeEngine("Data Source=" & StrCheminNomBase)

				SCE.CreateDatabase()

				SCE.Dispose()

				Connexion(True)

				ExecuteSQL("CREATE TABLE CONTACT (ConNum INTEGER IDENTITY, ConPseudo NVARCHAR(255), ConNom NVARCHAR(255), ConPrenom NVARCHAR(255), ConAdresse NVARCHAR(255), ConCP NVARCHAR(5), ConVille NVARCHAR(255), ConTel NVARCHAR(15), ConEmail NVARCHAR(255))")

				ExecuteSQL("INSERT INTO CONTACT (ConPseudo, ConNom, ConPrenom, ConAdresse, ConCP, ConVille, ConTel, ConEmail) VALUES ('ZEUS97470', 'ROYER', 'Jean-Laurent', '8 Bis Rue Souville', '60950', 'ERMENONVILLE', '0344218641', 'jlr97470@hotmail.com')")

				ExecuteSQL("INSERT INTO CONTACT (ConPseudo, ConNom, ConPrenom, ConAdresse, ConCP, ConVille, ConTel, ConEmail) VALUES ('ASI', 'SINGA', 'ALAIN', '', '', '', '', '')")

				Connexion(False)

			End If

		Catch ex As Exception

			MsgBox(ex.Message, MsgBoxStyle.Critical, "ModEbay.CreerBase()")

		End Try

	End Sub

	Public Function Connexion(ByVal BolConnecte As Boolean) As Boolean

		Try

			If BolConnecte Then

				Conn = New SqlCeConnection("Data Source=" & StrCheminNomBase)

				Conn.Open()

				Cmd = Conn.CreateCommand

			Else

				Conn.Close()

				Conn.Dispose()

			End If

			Return True

		Catch ex As Exception

			MsgBox(ex.Message, MsgBoxStyle.Critical, "ModEbay.Connexion()")

			Return False

		End Try

	End Function

End Module

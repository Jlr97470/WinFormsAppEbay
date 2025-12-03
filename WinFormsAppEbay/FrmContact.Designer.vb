<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmContact
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MainMenu = New MainMenu(components)
        MnuMenu = New MenuItem()
        MnuApropos = New MenuItem()
        MnuQuitter = New MenuItem()
        TxtConPseudo = New TextBox()
        DstEbay = New DstEbay()
        CONTACTBindingSource = New BindingSource(components)
        LblConPseudo = New Label()
        LblConNom = New Label()
        TxtConNom = New TextBox()
        LblConPrenom = New Label()
        TxtConPrenom = New TextBox()
        LblConAdresse = New Label()
        TxtConAdresse = New TextBox()
        TxtConCP = New TextBox()
        LblConCP = New Label()
        LblConVille = New Label()
        TxtConVille = New TextBox()
        LblConTel = New Label()
        TxtConTel = New TextBox()
        LblConEmail = New Label()
        TxtConEmail = New TextBox()
        CONTACTTableAdapter = New DstEbayTableAdapters.CONTACTTableAdapter()
        CType(DstEbay, ComponentModel.ISupportInitialize).BeginInit()
        CType(CONTACTBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MnuMenu
        ' 
        MnuMenu.Index = 0
        MnuMenu.MenuItems.AddRange(New MenuItem() {MnuApropos})
        MnuMenu.Text = "Menu"
        ' 
        ' MnuApropos
        ' 
        MnuApropos.Index = 0
        MnuApropos.Text = "Apropos"
        ' 
        ' MnuQuitter
        ' 
        MnuQuitter.Index = 1
        MnuQuitter.Text = "Quitter"
        ' 
        ' MainMenu
        ' 
        MainMenu.MenuItems.AddRange(New MenuItem() {MnuMenu, MnuQuitter})
        ' 
        ' DstEbay
        ' 
        DstEbay.DataSetName = "DstEbay"
        DstEbay.Namespace = "http://tempuri.org/DstEbay.xsd"
        ' 
        ' CONTACTBindingSource
        ' 
        CONTACTBindingSource.DataMember = "CONTACT"
        CONTACTBindingSource.DataSource = DstEbay
        ' 
        ' LblConPseudo
        ' 
        LblConPseudo.Font = New Font("Tahoma", 8.0F)
        LblConPseudo.Location = New Point(13, 71)
        LblConPseudo.Name = "LblConPseudo"
        LblConPseudo.Size = New Size(197, 20)
        LblConPseudo.TabIndex = 30
        LblConPseudo.Text = "Pseudonyme"
        ' 
        ' TxtConPseudo
        ' 
        TxtConPseudo.BorderStyle = BorderStyle.None
        TxtConPseudo.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConPseudo", True))
        TxtConPseudo.Font = New Font("Tahoma", 8.0F)
        TxtConPseudo.Location = New Point(216, 71)
        TxtConPseudo.Name = "TxtConPseudo"
        TxtConPseudo.Size = New Size(223, 13)
        TxtConPseudo.TabIndex = 0
        ' 
        ' LblConNom
        ' 
        LblConNom.Font = New Font("Tahoma", 8.0F)
        LblConNom.Location = New Point(13, 91)
        LblConNom.Name = "LblConNom"
        LblConNom.Size = New Size(197, 20)
        LblConNom.TabIndex = 29
        LblConNom.Text = "Nom"
        ' 
        ' TxtConNom
        ' 
        TxtConNom.BorderStyle = BorderStyle.None
        TxtConNom.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConNom", True))
        TxtConNom.Font = New Font("Tahoma", 8.0F)
        TxtConNom.Location = New Point(216, 91)
        TxtConNom.Name = "TxtConNom"
        TxtConNom.Size = New Size(223, 13)
        TxtConNom.TabIndex = 2
        ' 
        ' LblConPrenom
        ' 
        LblConPrenom.Font = New Font("Tahoma", 8.0F)
        LblConPrenom.Location = New Point(13, 111)
        LblConPrenom.Name = "LblConPrenom"
        LblConPrenom.Size = New Size(197, 20)
        LblConPrenom.TabIndex = 28
        LblConPrenom.Text = "Prenom"
        ' 
        ' TxtConPrenom
        ' 
        TxtConPrenom.BorderStyle = BorderStyle.None
        TxtConPrenom.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConPrenom", True))
        TxtConPrenom.Font = New Font("Tahoma", 8.0F)
        TxtConPrenom.Location = New Point(216, 111)
        TxtConPrenom.Name = "TxtConPrenom"
        TxtConPrenom.Size = New Size(223, 13)
        TxtConPrenom.TabIndex = 5
        ' 
        ' LblConAdresse
        ' 
        LblConAdresse.Font = New Font("Tahoma", 8.0F)
        LblConAdresse.Location = New Point(13, 131)
        LblConAdresse.Name = "LblConAdresse"
        LblConAdresse.Size = New Size(197, 20)
        LblConAdresse.TabIndex = 27
        LblConAdresse.Text = "Adresse"
        ' 
        ' TxtConAdresse
        ' 
        TxtConAdresse.BorderStyle = BorderStyle.None
        TxtConAdresse.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConAdresse", True))
        TxtConAdresse.Font = New Font("Tahoma", 8.0F)
        TxtConAdresse.Location = New Point(216, 131)
        TxtConAdresse.Multiline = True
        TxtConAdresse.Name = "TxtConAdresse"
        TxtConAdresse.Size = New Size(223, 38)
        TxtConAdresse.TabIndex = 8
        ' 
        ' TxtConCP
        ' 
        TxtConCP.BorderStyle = BorderStyle.None
        TxtConCP.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConCP", True))
        TxtConCP.Font = New Font("Tahoma", 8.0F)
        TxtConCP.Location = New Point(216, 175)
        TxtConCP.Name = "TxtConCP"
        TxtConCP.Size = New Size(223, 13)
        TxtConCP.TabIndex = 11
        ' 
        ' LblConCP
        ' 
        LblConCP.Font = New Font("Tahoma", 8.0F)
        LblConCP.Location = New Point(13, 175)
        LblConCP.Name = "LblConCP"
        LblConCP.Size = New Size(197, 20)
        LblConCP.TabIndex = 26
        LblConCP.Text = "Code Postal"
        ' 
        ' LblConVille
        ' 
        LblConVille.Font = New Font("Tahoma", 8.0F)
        LblConVille.Location = New Point(13, 200)
        LblConVille.Name = "LblConVille"
        LblConVille.Size = New Size(197, 20)
        LblConVille.TabIndex = 25
        LblConVille.Text = "Ville"
        ' 
        ' TxtConVille
        ' 
        TxtConVille.BorderStyle = BorderStyle.None
        TxtConVille.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConVille", True))
        TxtConVille.Font = New Font("Tahoma", 8.0F)
        TxtConVille.Location = New Point(216, 200)
        TxtConVille.Name = "TxtConVille"
        TxtConVille.Size = New Size(223, 13)
        TxtConVille.TabIndex = 17
        ' 
        ' LblConTel
        ' 
        LblConTel.Font = New Font("Tahoma", 8.0F)
        LblConTel.Location = New Point(13, 225)
        LblConTel.Name = "LblConTel"
        LblConTel.Size = New Size(197, 20)
        LblConTel.TabIndex = 24
        LblConTel.Text = "Telephone"
        ' 
        ' TxtConTel
        ' 
        TxtConTel.BorderStyle = BorderStyle.None
        TxtConTel.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConTel", True))
        TxtConTel.Font = New Font("Tahoma", 8.0F)
        TxtConTel.Location = New Point(216, 225)
        TxtConTel.Name = "TxtConTel"
        TxtConTel.Size = New Size(223, 13)
        TxtConTel.TabIndex = 20
        ' 
        ' LblConEmail
        ' 
        LblConEmail.Font = New Font("Tahoma", 8.0F)
        LblConEmail.Location = New Point(13, 250)
        LblConEmail.Name = "LblConEmail"
        LblConEmail.Size = New Size(197, 20)
        LblConEmail.TabIndex = 0
        LblConEmail.Text = "Email"
        ' 
        ' TxtConEmail
        ' 
        TxtConEmail.BorderStyle = BorderStyle.None
        TxtConEmail.DataBindings.Add(New Binding("Text", CONTACTBindingSource, "ConEmail", True))
        TxtConEmail.Font = New Font("Tahoma", 8.0F)
        TxtConEmail.Location = New Point(216, 250)
        TxtConEmail.Name = "TxtConEmail"
        TxtConEmail.Size = New Size(223, 13)
        TxtConEmail.TabIndex = 23
        ' 
        ' CONTACTTableAdapter
        ' 
        CONTACTTableAdapter.ClearBeforeFill = True
        ' 
        ' FrmContact
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(461, 438)
        Controls.Add(LblConEmail)
        Controls.Add(TxtConEmail)
        Controls.Add(LblConTel)
        Controls.Add(TxtConTel)
        Controls.Add(LblConVille)
        Controls.Add(TxtConVille)
        Controls.Add(LblConCP)
        Controls.Add(TxtConCP)
        Controls.Add(LblConAdresse)
        Controls.Add(TxtConAdresse)
        Controls.Add(LblConPrenom)
        Controls.Add(TxtConPrenom)
        Controls.Add(LblConNom)
        Controls.Add(TxtConNom)
        Controls.Add(LblConPseudo)
        Controls.Add(TxtConPseudo)
        Font = New Font("Tahoma", 8.0F)
        MinimizeBox = False
        Name = "FrmContact"
        Text = "                            "
        CType(DstEbay, ComponentModel.ISupportInitialize).EndInit()
        CType(CONTACTBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents MnuMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MnuApropos As System.Windows.Forms.MenuItem
    Friend WithEvents MnuQuitter As System.Windows.Forms.MenuItem
    Friend WithEvents TxtConPseudo As System.Windows.Forms.TextBox
    Friend WithEvents DstEbay As WinFormsAppEbay.DstEbay
    Friend WithEvents CONTACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTACTTableAdapter As WinFormsAppEbay.DstEbayTableAdapters.CONTACTTableAdapter
    Friend WithEvents LblConPseudo As System.Windows.Forms.Label
    Friend WithEvents LblConNom As System.Windows.Forms.Label
    Friend WithEvents TxtConNom As System.Windows.Forms.TextBox
    Friend WithEvents LblConPrenom As System.Windows.Forms.Label
    Friend WithEvents TxtConPrenom As System.Windows.Forms.TextBox
    Friend WithEvents LblConAdresse As System.Windows.Forms.Label
    Friend WithEvents TxtConAdresse As System.Windows.Forms.TextBox
    Friend WithEvents TxtConCP As System.Windows.Forms.TextBox
    Friend WithEvents LblConCP As System.Windows.Forms.Label
    Friend WithEvents LblConVille As System.Windows.Forms.Label
    Friend WithEvents TxtConVille As System.Windows.Forms.TextBox
    Friend WithEvents LblConTel As System.Windows.Forms.Label
    Friend WithEvents TxtConTel As System.Windows.Forms.TextBox
    Friend WithEvents LblConEmail As System.Windows.Forms.Label
    Friend WithEvents TxtConEmail As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmListe
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MainMenu = New MainMenu(components)
        MnuMenu = New MenuItem()
        MnuApropos = New MenuItem()
        MnuQuitter = New MenuItem()
        TbcListe = New TabControl()
        TbpListeContact = New TabPage()
        LsvContact = New ListView()
        ColConPseudo = New ColumnHeader()
        ColConNom = New ColumnHeader()
        ColConPrenom = New ColumnHeader()
        ColConNum = New ColumnHeader()
        TbpListeProduit = New TabPage()
        CmdAjouter = New Button()
        CmdModifier = New Button()
        CmdSupprimer = New Button()
        DstEbay = New WinFormsAppEbay.DstEbay
        CONTACTBindingSource = New BindingSource(components)
        CONTACTTableAdapter = New DstEbayTableAdapters.CONTACTTableAdapter()
        TbcListe.SuspendLayout()
        TbpListeContact.SuspendLayout()
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
        ' CONTACTTableAdapter
        ' 
        CONTACTTableAdapter.ClearBeforeFill = True
        ' 
        ' TbcListe
        ' 
        TbcListe.Controls.Add(TbpListeContact)
        TbcListe.Controls.Add(TbpListeProduit)
        TbcListe.Location = New Point(0, 39)
        TbcListe.Name = "TbcListe"
        TbcListe.SelectedIndex = 0
        TbcListe.Size = New Size(464, 336)
        TbcListe.TabIndex = 0
        ' 
        ' TbpListeContact
        ' 
        TbpListeContact.Controls.Add(LsvContact)
        TbpListeContact.Location = New Point(4, 22)
        TbpListeContact.Name = "TbpListeContact"
        TbpListeContact.Size = New Size(456, 310)
        TbpListeContact.TabIndex = 0
        TbpListeContact.Text = "Contact"
        ' 
        ' LsvContact
        ' 
        LsvContact.Activation = ItemActivation.OneClick
        LsvContact.Columns.AddRange(New ColumnHeader() {ColConPseudo, ColConNom, ColConPrenom, ColConNum})
        LsvContact.Font = New Font("Tahoma", 8.0F)
        LsvContact.FullRowSelect = True
        LsvContact.Location = New Point(0, 3)
        LsvContact.Name = "LsvContact"
        LsvContact.Size = New Size(456, 311)
        LsvContact.TabIndex = 0
        LsvContact.UseCompatibleStateImageBehavior = False
        LsvContact.View = View.Details
        ' 
        ' ColConPseudo
        ' 
        ColConPseudo.Text = "Pseudo"
        ColConPseudo.Width = 75
        ' 
        ' ColConNom
        ' 
        ColConNom.Text = "Nom"
        ColConNom.Width = 75
        ' 
        ' ColConPrenom
        ' 
        ColConPrenom.Text = "Prenom"
        ColConPrenom.Width = 85
        ' 
        ' ColConNum
        ' 
        ColConNum.Text = "ColumnHeader"
        ColConNum.Width = 0
        ' 
        ' TbpListeProduit
        ' 
        TbpListeProduit.Location = New Point(4, 24)
        TbpListeProduit.Name = "TbpListeProduit"
        TbpListeProduit.Size = New Size(456, 308)
        TbpListeProduit.TabIndex = 1
        TbpListeProduit.Text = "Produit"
        ' 
        ' CmdAjouter
        ' 
        CmdAjouter.Font = New Font("Tahoma", 8.0F, FontStyle.Bold)
        CmdAjouter.Location = New Point(38, 381)
        CmdAjouter.Name = "CmdAjouter"
        CmdAjouter.Size = New Size(72, 20)
        CmdAjouter.TabIndex = 4
        CmdAjouter.Text = "Ajouter"
        ' 
        ' CmdModifier
        ' 
        CmdModifier.Font = New Font("Tahoma", 8.0F, FontStyle.Bold)
        CmdModifier.Location = New Point(172, 381)
        CmdModifier.Name = "CmdModifier"
        CmdModifier.Size = New Size(72, 20)
        CmdModifier.TabIndex = 3
        CmdModifier.Text = "Modifier"
        ' 
        ' CmdSupprimer
        ' 
        CmdSupprimer.Font = New Font("Tahoma", 8.0F, FontStyle.Bold)
        CmdSupprimer.Location = New Point(322, 381)
        CmdSupprimer.Name = "CmdSupprimer"
        CmdSupprimer.Size = New Size(72, 20)
        CmdSupprimer.TabIndex = 5
        CmdSupprimer.Text = "Supprimer"
        ' 
        ' FrmListe
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        ClientSize = New Size(461, 438)
        Controls.Add(CmdSupprimer)
        Controls.Add(CmdAjouter)
        Controls.Add(CmdModifier)
        Controls.Add(TbcListe)
        Font = New Font("Tahoma", 8F)
        Name = "FrmListe"
        Text = "eBay Vente"
        TbcListe.ResumeLayout(False)
        TbpListeContact.ResumeLayout(False)
        CType(CONTACTBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents MnuMenu As System.Windows.Forms.MenuItem
	Friend WithEvents MnuQuitter As System.Windows.Forms.MenuItem
	Friend WithEvents MnuApropos As System.Windows.Forms.MenuItem
	Friend WithEvents TbcListe As System.Windows.Forms.TabControl
	Friend WithEvents TbpListeContact As System.Windows.Forms.TabPage
	Friend WithEvents TbpListeProduit As System.Windows.Forms.TabPage
    Friend WithEvents DstEbay As WinFormsAppEbay.DstEbay
    Friend WithEvents CONTACTBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents CONTACTTableAdapter As WinFormsAppEbay.DstEbayTableAdapters.CONTACTTableAdapter
	Friend WithEvents CmdAjouter As System.Windows.Forms.Button
	Friend WithEvents CmdModifier As System.Windows.Forms.Button
	Friend WithEvents CmdSupprimer As System.Windows.Forms.Button
	Friend WithEvents LsvContact As System.Windows.Forms.ListView
	Friend WithEvents ColConPseudo As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColConNom As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColConPrenom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColConNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
End Class

Imports System.IO
Public Class frmLaunchScr
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Me.Hide() ' Hides launch screen
        creation.Show() ' Shows character creation screen
    End Sub

    Private Sub frmLaunchScr_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'lblDEBUG.Text = resPath ' Debug label
        'lblDEBUG.Visible = True
        picLogo.Parent = picBackground ' Allows transparency for title
        ' Sets all the information for items
        ' Empty
        items(0).ID = 0
        items(0).name = "Empty"
        items(0).image = eInvSlot
        ' Basic Dagger
        items(1).ID = 1
        items(1).name = "Basic Dagger"
        items(1).dmg = 5
        items(1).agility = 2
        items(1).strength = 1
        items(1).intelligence = 0
        items(1).armor = 0
        items(1).image = rogBasDagL
        ' Basic Axe
        items(2).ID = 2
        items(2).name = "Basic Axe"
        items(2).dmg = 7
        items(2).agility = 0
        items(2).strength = 3
        items(2).intelligence = 0
        items(2).armor = 1
        'items(2).image = warBasAxe
        ' Old Wand
        items(3).ID = 3
        items(3).name = "Old Wand"
        items(3).dmg = 2
        items(3).agility = 2
        items(3).strength = 0
        items(3).intelligence = 2
        items(3).armor = 0
        'items(3).image = magBasWand
        ' Worn Helm
        items(4).ID = 4
        items(4).name = "Worn Helm"
        items(4).dmg = 0
        items(4).agility = 1
        items(4).strength = 2
        items(4).intelligence = 0
        items(4).armor = 2
        items(4).image = rogBasHelm
        'items(4).imageVar = warBasHelm
        ' Worn Hat
        items(5).ID = 5
        items(5).name = "Worn Hat"
        items(5).dmg = 0
        items(5).agility = 1
        items(5).strength = 0
        items(5).intelligence = 2
        items(5).armor = 1
        'items(5).image = wornHat
        ' Worn Gloves
        items(6).ID = 6
        items(6).name = "Worn Gloves"
        items(6).dmg = 0
        items(6).agility = 1
        items(6).strength = 2
        items(6).intelligence = 0
        items(6).armor = 1
        'items(6).image = wornGloves
        ' Worn Leg Plate
        items(7).ID = 7
        items(7).name = "Worn Leg Plate"
        items(7).dmg = 0
        items(7).agility = 0
        items(7).strength = 2
        items(7).intelligence = 0
        items(7).armor = 2
        'items(7).image = wornLegPlate
        ' Worn Pants
        items(8).ID = 8
        items(8).name = "Worn Pants"
        items(8).dmg = 0
        items(8).agility = 1
        items(8).strength = 0
        items(8).intelligence = 2
        items(8).armor = 1
        'items(8).image = wornPants
        ' Worn Leg Armor
        items(9).ID = 9
        items(9).name = "Worn Leg Armor"
        items(9).dmg = 0
        items(9).agility = 2
        items(9).strength = 1
        items(9).intelligence = 0
        items(9).armor = 1
        'items(9).image = wornLegArmor
        ' Worn Dress
        items(10).ID = 10
        items(10).name = "Worn Dress"
        items(10).dmg = 0
        items(10).agility = 0
        items(10).strength = 1
        items(10).intelligence = 2
        items(10).armor = 1
        ' items(10).image = wornDress
        ' Worn Chestplate
        items(11).ID = 11
        items(11).name = "Worn Chestplate"
        items(11).dmg = 0
        items(11).agility = 0
        items(11).strength = 2
        items(11).intelligence = 0
        items(11).armor = 2
        'items(11).image = wornChesplate
        ' Worn Leather Coat
        items(12).ID = 12
        items(12).name = "Worn Leather Coat"
        items(12).dmg = 0
        items(12).agility = 2
        items(12).strength = 1
        items(12).intelligence = 0
        items(12).armor = 1
        'items(12).image = wornLeathCoat
        ' Worn Bracers
        items(13).ID = 13
        items(13).name = "Worn Bracers"
        items(13).dmg = 0
        items(13).agility = 2
        items(13).strength = 1
        items(13).intelligence = 1
        items(13).armor = 1
        'items(13).image = wornBracers
        ' Debug Item
        items(20).ID = 20
        items(20).name = "Debug"
        items(20).dmg = 500
        items(20).agility = 500
        items(20).strength = 500
        items(20).intelligence = 500
        items(20).armor = 500
        items(20).image = debugImg
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        ' Switches to the load saves screen
        Dim dir As DirectoryInfo = New DirectoryInfo(resPath & "\Saves\")
        If (dir.EnumerateFiles().Any()) Then ' Checks for save files
            ' Loads screen appears
            loadScr.Show()
            Me.Hide()
        Else
            ' Gives the user an error stating there are no save files
            MsgBox("No save files found, please create a new character.")
        End If
    End Sub
End Class
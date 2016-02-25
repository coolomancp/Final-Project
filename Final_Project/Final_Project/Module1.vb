Module Module1
    Public loadScr As New frmLoadScr ' Loading screen
    Public mainScr As New frmMainScr ' Main Screen player used
    Public inventoryScr As New frmInventory ' Inventory screen is loaded
    Public charInfoScr As New frmCharScreen ' Character Info screen is loaded
    Public exitWarning As New frmExitWarning ' Warns player to save before exiting
    Public creation As New frmCharCreate ' Character creation screen
    Public Structure playerInfo ' Stores all of the player's information
        Public HP As Integer ' Player's current health
        Public HPM As Integer ' Player's max health
        Public MP As Integer ' Player's current mana pool
        Public MPM As Integer ' Player's max mana
        Public name As String ' Player's current name
        Public level As Integer ' Player's current level
        Public strength As Integer ' Player's strength stat
        Public intelligence As Integer ' Player's intelligence stat
        Public agility As Integer ' Player's agility stat
        Public activeHelm As String ' Player's currently equipped helmet
        Public activeChest As String ' Player's currently equipped chestpiece
        Public activeLegs As String ' Player's currently equipped pants / leg armour
        Public activeGloves As String ' Player's currently equipped gloves
        Public activeBracers As String ' Player's currently equipped bracers
        Public activeWepL As String ' Player's currently equipped left weapon / shield
        Public activeWepR As String ' Player's currently equipped right weapon
        Public charClass As String ' Player's class
        Public moneyAmount As Integer ' PLayer's amount of money
        Public charX As Integer ' Player's X coord
        Public charY As Integer ' Player's Y coord
        Public dungeonID As Integer ' What dungeon the player is in
        Public dungeonRM As Integer ' What room in the dungeon the player is in
    End Structure
    Public playerInf As playerInfo
    Public Structure playerInv ' Stores all of the player's inventory information
        Dim invS1 As String ' Player's first inventory slot
    End Structure
    ' Warrior
    Public warIdleR As Image = My.Resources.warIdleR ' Character idle facing the right (warrior)
    Public warIdleL As Image = My.Resources.warIdleL ' Character idle facing the left (warrior)
    Public warWalkL1 As Image = My.Resources.warWalkL1 ' First frame of warrior class walking left
    Public warWalkL2 As Image = My.Resources.warWalkL2 ' Second frame of warrior class walking left
    Public warWalkL3 As Image = My.Resources.warWalkL3 ' Third frame of warrior class walking left
    Public warWalkL4 As Image = My.Resources.warWalkL4 ' Fourth frame of warrior class walking left
    Public warWalkR1 As Image = My.Resources.warWalkR1 ' First frame of warrior class walking right
    Public warWalkR2 As Image = My.Resources.warWalkR2 ' Second frame of warrior class walking right
    Public warWalkR3 As Image = My.Resources.warWalkR3 ' Third frame of warrior class walking right
    Public warWalkR4 As Image = My.Resources.warWalkR4 ' Fourth frame of warrior class walking right
    Public warAttL1 As Image = My.Resources.warAttL1 ' First frame of warrior class attacking to the left
    Public warAttL2 As Image = My.Resources.warAttL2 ' Second frame of warrior class attacking to the left
    Public warAttL3 As Image = My.Resources.warAttL3 ' Third frame of warrior class attacking to the left
    Public warAttL4 As Image = My.Resources.warAttL4 ' Fourth frame of warrior class attacking to the left
    Public warAttR1 As Image = My.Resources.warAttR1 ' First frame of warrior class attacking to the right
    Public warAttR2 As Image = My.Resources.warAttR2 ' Second frame of warrior class attacking to the right
    Public warAttR3 As Image = My.Resources.warAttR3 ' Third frame of warrior class attacking to the right
    Public warAttR4 As Image = My.Resources.warAttR4 ' Fourth frame of warrior class attacking to the right
    ' Rogue
    Public rogIdleR As Image = My.Resources.rogIdleR ' Character idle facing the left (rogue)
    Public rogIdleL As Image = My.Resources.rogIdleL ' Character idle facing the left (rogue)
    Public rogWalkL1 As Image = My.Resources.rogWalkL1 ' First frame of rogue class walking left
    Public rogWalkL2 As Image = My.Resources.rogWalkL2 ' Second frame of rogue class walking left
    Public rogWalkL3 As Image = My.Resources.rogWalkL3 ' Third frame of rogue class walking left
    Public rogWalkL4 As Image = My.Resources.rogWalkL4 ' Fourth frame of rogue class walking left
    Public rogWalkR1 As Image = My.Resources.rogWalkR1 ' First frame of rogue class walking right
    Public rogWalkR2 As Image = My.Resources.rogWalkR2 ' Second frame of rogue class walking right
    Public rogWalkR3 As Image = My.Resources.rogWalkR3 ' Third frame of rogue class walking right
    Public rogWalkR4 As Image = My.Resources.rogWalkR4 ' Fourth frame of rogue class walking right
    Public rogAttR1 As Image = My.Resources.rogAttR1 ' Character attacks to the right (rogue)
    Public rogAttR2 As Image = My.Resources.rogAttR2 ' Character attacks to the right (rogue)
    Public rogAttR3 As Image = My.Resources.rogAttR3 ' Character attacks to the right (rogue)
    Public rogAttR4 As Image = My.Resources.rogAttR4 ' Character attacks to the right (rogue)
    Public rogAttL1 As Image = My.Resources.rogAttL1 ' Character attacks to the left (rogue)
    Public rogAttL2 As Image = My.Resources.rogAttL2 ' Character attacks to the left (rogue)
    Public rogAttL3 As Image = My.Resources.rogAttL3 ' Character attacks to the left (rogue)
    Public rogAttL4 As Image = My.Resources.rogAttL4 ' Character attacks to the left (rogue)
    ' Mage
    Public magIdleR As Image = My.Resources.magIdleR ' Character idle facing the left (mage)
    Public magIdleL As Image = My.Resources.magIdleL ' Character idle facing the left (mage)
    Public magFlyL1 As Image = My.Resources.magFlyL1 ' First frame of mage class walking left
    Public magFlyL2 As Image = My.Resources.magFlyL2 ' Second frame of mage class walking left
    Public magFlyL3 As Image = My.Resources.magFlyL3 ' Third frame of mage class walking left
    Public magFlyL4 As Image = My.Resources.magFlyL4 ' Fourth frame of mage class walking left
    Public magFlyR1 As Image = My.Resources.magFlyR1 ' First frame of mage class walking right
    Public magFlyR2 As Image = My.Resources.magFlyR2 ' Second frame of mage class walking right
    Public magFlyR3 As Image = My.Resources.magFlyR3 ' Third frame of mage class walking right
    Public magFlyR4 As Image = My.Resources.magFlyR4 ' Fourth frame of mage class walking right
    Public magAttR1 As Image = My.Resources.magAttR1 ' First frame of mage class attacking to the right
    Public magAttR2 As Image = My.Resources.magAttR2 ' Second frame of mage class attacking to the right
    Public magAttR3 As Image = My.Resources.magAttR3 ' Third frame of mage class attacking to the right
    Public magAttR4 As Image = My.Resources.magAttR4 ' Fourth frame of mage class attacking to the right
    Public magAttL1 As Image = My.Resources.magAttL1 ' First frame of mage class attacking to the left
    Public magAttL2 As Image = My.Resources.magAttL2 ' Second frame of mage class attacking to the left
    Public magAttL3 As Image = My.Resources.magAttL3 ' Third frame of mage class attacking to the left
    Public magAttL4 As Image = My.Resources.magAttL4 ' Fourth frame of mage class attacking to the left
    ' Path to the resource files to allow use in any directory
    Public resPath As String = Replace(My.Application.Info.DirectoryPath, "\bin\Debug", "\Resources\")
End Module

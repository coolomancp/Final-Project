Module Module1
    Public Structure playerInfo ' Stores all of the player's information
        Dim HP As Integer ' Player's current health
        Dim MP As Integer ' Player's current mana pool
        Dim name As String ' Player's current name
        Dim strength As Integer ' Player's strength stat
        Dim intelligence As Integer ' Player's intelligence stat
        Dim agility As Integer ' Player's agility stat
        Dim activeHelm As String ' Player's currently equipped helmet
        Dim activeChest As String ' Player's currently equipped chestpiece
        Dim activeLegs As String ' Player's currently equipped pants / leg armour
        Dim activeGloves As String ' Player's currently equipped gloves
        Dim activeBracers As String ' Player's currently equipped bracers
        Dim activeWepL As String ' Player's currently equipped left weapon / shield
        Dim activeWepR As String ' Player's currently equipped right weapon
        Dim charClass As Integer ' Player's class
    End Structure
    Public Structure playerInv ' Stores all of the player's inventory information
        Dim invS1 As String ' Player's first inventory slot
    End Structure
    Public warIdleR As Image = My.Resources.warIdleR ' Character idle facing the right
    Public warIdleL As Image = My.Resources.warIdleL ' Character idle facing the left
    Public warWalkL1 As Image = My.Resources.warWalkL1 ' First frame of warrior class walking left
    Public warWalkL2 As Image = My.Resources.warWalkL2 ' Second frame of warrior class walking left
    Public warWalkL3 As Image = My.Resources.warWalkL3 ' Third frame of warrior class walking left
    Public warWalkL4 As Image = My.Resources.warWalkL4 ' Fourth frame of warrior class walking left
End Module

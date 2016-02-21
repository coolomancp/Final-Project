Module Module1
    Public Structure playerInfo ' Stores all of the player's information
        Public HP As Integer ' Player's current health
        Public HPM As Integer ' Player's max health
        Public MP As Integer ' Player's current mana pool
        Public MPM As Integer ' Player's max mana
        Public name As String ' Player's current name
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
    Public warWalkR1 As Image = My.Resources.warWalkR1 ' First frame of warrior class walking right
    Public warWalkR2 As Image = My.Resources.warWalkR2 ' Second frame of warrior class walking right
    Public warWalkR3 As Image = My.Resources.warWalkR3 ' Third frame of warrior class walking right
    Public warWalkR4 As Image = My.Resources.warWalkR4 ' Fourth frame of warrior class walking right
    Public resPath As String = Replace(My.Application.Info.DirectoryPath, "\bin\Debug", "\Resources\") ' Path to the resource files to allow use in any directory
End Module

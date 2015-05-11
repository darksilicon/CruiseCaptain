
Public Class MainForm
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.




    End Sub



    Private Sub NewCruiseButton_Click(sender As Object, e As EventArgs)
        'This Button Should Create A new Cruise INstance


        InputCruiseData.Show()

    End Sub

    'NEW -> CRUISE MENU ITEM
    Private Sub CruiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CruiseToolStripMenuItem.Click
        InputCruiseData.Show()
    End Sub
End Class









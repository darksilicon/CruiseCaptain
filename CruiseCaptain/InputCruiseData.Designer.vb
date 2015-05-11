<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputCruiseData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim ReservationNumLabel As System.Windows.Forms.Label
        Dim DepartureDateLabel As System.Windows.Forms.Label
        Dim ArrivalDateLabel As System.Windows.Forms.Label
        Dim DeparturePortLabel As System.Windows.Forms.Label
        Dim ArrivalPortLabel As System.Windows.Forms.Label
        Dim BaseFareLabel As System.Windows.Forms.Label
        Dim TaxesFeesLabel As System.Windows.Forms.Label
        Dim PPGratuitiesLabel As System.Windows.Forms.Label
        Dim PaymentsLabel As System.Windows.Forms.Label
        Dim StateRoomNoLabel As System.Windows.Forms.Label
        Dim ShipLabel As System.Windows.Forms.Label
        Dim IteneraryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputCruiseData))
        Me.CruiseData = New CruiseCaptain.CruiseData()
        Me.ActualCruiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActualCruiseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActualCruiseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationNumTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureDateTextBox = New System.Windows.Forms.TextBox()
        Me.ArrivalDateTextBox = New System.Windows.Forms.TextBox()
        Me.DeparturePortTextBox = New System.Windows.Forms.TextBox()
        Me.ArrivalPortTextBox = New System.Windows.Forms.TextBox()
        Me.BaseFareTextBox = New System.Windows.Forms.TextBox()
        Me.TaxesFeesTextBox = New System.Windows.Forms.TextBox()
        Me.PPGratuitiesTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentsTextBox = New System.Windows.Forms.TextBox()
        Me.StateRoomNoTextBox = New System.Windows.Forms.TextBox()
        Me.ShipTextBox = New System.Windows.Forms.TextBox()
        Me.IteneraryTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        ReservationNumLabel = New System.Windows.Forms.Label()
        DepartureDateLabel = New System.Windows.Forms.Label()
        ArrivalDateLabel = New System.Windows.Forms.Label()
        DeparturePortLabel = New System.Windows.Forms.Label()
        ArrivalPortLabel = New System.Windows.Forms.Label()
        BaseFareLabel = New System.Windows.Forms.Label()
        TaxesFeesLabel = New System.Windows.Forms.Label()
        PPGratuitiesLabel = New System.Windows.Forms.Label()
        PaymentsLabel = New System.Windows.Forms.Label()
        StateRoomNoLabel = New System.Windows.Forms.Label()
        ShipLabel = New System.Windows.Forms.Label()
        IteneraryLabel = New System.Windows.Forms.Label()
        CType(Me.CruiseData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualCruiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualCruiseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActualCruiseBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(54, 78)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 25)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'ReservationNumLabel
        '
        ReservationNumLabel.AutoSize = True
        ReservationNumLabel.Location = New System.Drawing.Point(54, 115)
        ReservationNumLabel.Name = "ReservationNumLabel"
        ReservationNumLabel.Size = New System.Drawing.Size(183, 25)
        ReservationNumLabel.TabIndex = 3
        ReservationNumLabel.Text = "Reservation Num:"
        '
        'DepartureDateLabel
        '
        DepartureDateLabel.AutoSize = True
        DepartureDateLabel.Location = New System.Drawing.Point(54, 152)
        DepartureDateLabel.Name = "DepartureDateLabel"
        DepartureDateLabel.Size = New System.Drawing.Size(164, 25)
        DepartureDateLabel.TabIndex = 5
        DepartureDateLabel.Text = "Departure Date:"
        '
        'ArrivalDateLabel
        '
        ArrivalDateLabel.AutoSize = True
        ArrivalDateLabel.Location = New System.Drawing.Point(54, 189)
        ArrivalDateLabel.Name = "ArrivalDateLabel"
        ArrivalDateLabel.Size = New System.Drawing.Size(130, 25)
        ArrivalDateLabel.TabIndex = 7
        ArrivalDateLabel.Text = "Arrival Date:"
        '
        'DeparturePortLabel
        '
        DeparturePortLabel.AutoSize = True
        DeparturePortLabel.Location = New System.Drawing.Point(54, 226)
        DeparturePortLabel.Name = "DeparturePortLabel"
        DeparturePortLabel.Size = New System.Drawing.Size(158, 25)
        DeparturePortLabel.TabIndex = 9
        DeparturePortLabel.Text = "Departure Port:"
        '
        'ArrivalPortLabel
        '
        ArrivalPortLabel.AutoSize = True
        ArrivalPortLabel.Location = New System.Drawing.Point(54, 263)
        ArrivalPortLabel.Name = "ArrivalPortLabel"
        ArrivalPortLabel.Size = New System.Drawing.Size(124, 25)
        ArrivalPortLabel.TabIndex = 11
        ArrivalPortLabel.Text = "Arrival Port:"
        '
        'BaseFareLabel
        '
        BaseFareLabel.AutoSize = True
        BaseFareLabel.Location = New System.Drawing.Point(54, 300)
        BaseFareLabel.Name = "BaseFareLabel"
        BaseFareLabel.Size = New System.Drawing.Size(117, 25)
        BaseFareLabel.TabIndex = 13
        BaseFareLabel.Text = "Base Fare:"
        '
        'TaxesFeesLabel
        '
        TaxesFeesLabel.AutoSize = True
        TaxesFeesLabel.Location = New System.Drawing.Point(54, 337)
        TaxesFeesLabel.Name = "TaxesFeesLabel"
        TaxesFeesLabel.Size = New System.Drawing.Size(131, 25)
        TaxesFeesLabel.TabIndex = 15
        TaxesFeesLabel.Text = "Taxes Fees:"
        '
        'PPGratuitiesLabel
        '
        PPGratuitiesLabel.AutoSize = True
        PPGratuitiesLabel.Location = New System.Drawing.Point(54, 374)
        PPGratuitiesLabel.Name = "PPGratuitiesLabel"
        PPGratuitiesLabel.Size = New System.Drawing.Size(138, 25)
        PPGratuitiesLabel.TabIndex = 17
        PPGratuitiesLabel.Text = "PPGratuities:"
        '
        'PaymentsLabel
        '
        PaymentsLabel.AutoSize = True
        PaymentsLabel.Location = New System.Drawing.Point(54, 411)
        PaymentsLabel.Name = "PaymentsLabel"
        PaymentsLabel.Size = New System.Drawing.Size(113, 25)
        PaymentsLabel.TabIndex = 19
        PaymentsLabel.Text = "Payments:"
        '
        'StateRoomNoLabel
        '
        StateRoomNoLabel.AutoSize = True
        StateRoomNoLabel.Location = New System.Drawing.Point(54, 448)
        StateRoomNoLabel.Name = "StateRoomNoLabel"
        StateRoomNoLabel.Size = New System.Drawing.Size(163, 25)
        StateRoomNoLabel.TabIndex = 21
        StateRoomNoLabel.Text = "State Room No:"
        '
        'ShipLabel
        '
        ShipLabel.AutoSize = True
        ShipLabel.Location = New System.Drawing.Point(54, 485)
        ShipLabel.Name = "ShipLabel"
        ShipLabel.Size = New System.Drawing.Size(61, 25)
        ShipLabel.TabIndex = 23
        ShipLabel.Text = "Ship:"
        '
        'IteneraryLabel
        '
        IteneraryLabel.AutoSize = True
        IteneraryLabel.Location = New System.Drawing.Point(54, 522)
        IteneraryLabel.Name = "IteneraryLabel"
        IteneraryLabel.Size = New System.Drawing.Size(102, 25)
        IteneraryLabel.TabIndex = 25
        IteneraryLabel.Text = "Itenerary:"
        '
        'CruiseData
        '
        Me.CruiseData.DataSetName = "CruiseData"
        Me.CruiseData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActualCruiseBindingSource
        '
        Me.ActualCruiseBindingSource.DataMember = "ActualCruise"
        Me.ActualCruiseBindingSource.DataSource = Me.CruiseData
        '
        'ActualCruiseBindingNavigator
        '
        Me.ActualCruiseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActualCruiseBindingNavigator.BindingSource = Me.ActualCruiseBindingSource
        Me.ActualCruiseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActualCruiseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActualCruiseBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ActualCruiseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActualCruiseBindingNavigatorSaveItem})
        Me.ActualCruiseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActualCruiseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActualCruiseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActualCruiseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActualCruiseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActualCruiseBindingNavigator.Name = "ActualCruiseBindingNavigator"
        Me.ActualCruiseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActualCruiseBindingNavigator.Size = New System.Drawing.Size(1108, 71)
        Me.ActualCruiseBindingNavigator.TabIndex = 0
        Me.ActualCruiseBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(71, 68)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 71)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 39)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 71)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(68, 68)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 71)
        '
        'ActualCruiseBindingNavigatorSaveItem
        '
        Me.ActualCruiseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActualCruiseBindingNavigatorSaveItem.Enabled = False
        Me.ActualCruiseBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActualCruiseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActualCruiseBindingNavigatorSaveItem.Name = "ActualCruiseBindingNavigatorSaveItem"
        Me.ActualCruiseBindingNavigatorSaveItem.Size = New System.Drawing.Size(68, 68)
        Me.ActualCruiseBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(243, 75)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(333, 31)
        Me.IDTextBox.TabIndex = 2
        '
        'ReservationNumTextBox
        '
        Me.ReservationNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "ReservationNum", True))
        Me.ReservationNumTextBox.Location = New System.Drawing.Point(243, 112)
        Me.ReservationNumTextBox.Name = "ReservationNumTextBox"
        Me.ReservationNumTextBox.Size = New System.Drawing.Size(333, 31)
        Me.ReservationNumTextBox.TabIndex = 4
        '
        'DepartureDateTextBox
        '
        Me.DepartureDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "DepartureDate", True))
        Me.DepartureDateTextBox.Location = New System.Drawing.Point(243, 149)
        Me.DepartureDateTextBox.Name = "DepartureDateTextBox"
        Me.DepartureDateTextBox.Size = New System.Drawing.Size(333, 31)
        Me.DepartureDateTextBox.TabIndex = 6
        '
        'ArrivalDateTextBox
        '
        Me.ArrivalDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "ArrivalDate", True))
        Me.ArrivalDateTextBox.Location = New System.Drawing.Point(243, 186)
        Me.ArrivalDateTextBox.Name = "ArrivalDateTextBox"
        Me.ArrivalDateTextBox.Size = New System.Drawing.Size(333, 31)
        Me.ArrivalDateTextBox.TabIndex = 8
        '
        'DeparturePortTextBox
        '
        Me.DeparturePortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "DeparturePort", True))
        Me.DeparturePortTextBox.Location = New System.Drawing.Point(243, 223)
        Me.DeparturePortTextBox.Name = "DeparturePortTextBox"
        Me.DeparturePortTextBox.Size = New System.Drawing.Size(333, 31)
        Me.DeparturePortTextBox.TabIndex = 10
        '
        'ArrivalPortTextBox
        '
        Me.ArrivalPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "ArrivalPort", True))
        Me.ArrivalPortTextBox.Location = New System.Drawing.Point(243, 260)
        Me.ArrivalPortTextBox.Name = "ArrivalPortTextBox"
        Me.ArrivalPortTextBox.Size = New System.Drawing.Size(333, 31)
        Me.ArrivalPortTextBox.TabIndex = 12
        '
        'BaseFareTextBox
        '
        Me.BaseFareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "BaseFare", True))
        Me.BaseFareTextBox.Location = New System.Drawing.Point(243, 297)
        Me.BaseFareTextBox.Name = "BaseFareTextBox"
        Me.BaseFareTextBox.Size = New System.Drawing.Size(333, 31)
        Me.BaseFareTextBox.TabIndex = 14
        '
        'TaxesFeesTextBox
        '
        Me.TaxesFeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "TaxesFees", True))
        Me.TaxesFeesTextBox.Location = New System.Drawing.Point(243, 334)
        Me.TaxesFeesTextBox.Name = "TaxesFeesTextBox"
        Me.TaxesFeesTextBox.Size = New System.Drawing.Size(333, 31)
        Me.TaxesFeesTextBox.TabIndex = 16
        '
        'PPGratuitiesTextBox
        '
        Me.PPGratuitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "PPGratuities", True))
        Me.PPGratuitiesTextBox.Location = New System.Drawing.Point(243, 371)
        Me.PPGratuitiesTextBox.Name = "PPGratuitiesTextBox"
        Me.PPGratuitiesTextBox.Size = New System.Drawing.Size(333, 31)
        Me.PPGratuitiesTextBox.TabIndex = 18
        '
        'PaymentsTextBox
        '
        Me.PaymentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "Payments", True))
        Me.PaymentsTextBox.Location = New System.Drawing.Point(243, 408)
        Me.PaymentsTextBox.Name = "PaymentsTextBox"
        Me.PaymentsTextBox.Size = New System.Drawing.Size(333, 31)
        Me.PaymentsTextBox.TabIndex = 20
        '
        'StateRoomNoTextBox
        '
        Me.StateRoomNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "StateRoomNo", True))
        Me.StateRoomNoTextBox.Location = New System.Drawing.Point(243, 445)
        Me.StateRoomNoTextBox.Name = "StateRoomNoTextBox"
        Me.StateRoomNoTextBox.Size = New System.Drawing.Size(333, 31)
        Me.StateRoomNoTextBox.TabIndex = 22
        '
        'ShipTextBox
        '
        Me.ShipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "Ship", True))
        Me.ShipTextBox.Location = New System.Drawing.Point(243, 482)
        Me.ShipTextBox.Name = "ShipTextBox"
        Me.ShipTextBox.Size = New System.Drawing.Size(333, 31)
        Me.ShipTextBox.TabIndex = 24
        '
        'IteneraryTextBox
        '
        Me.IteneraryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActualCruiseBindingSource, "Itenerary", True))
        Me.IteneraryTextBox.Location = New System.Drawing.Point(243, 519)
        Me.IteneraryTextBox.Name = "IteneraryTextBox"
        Me.IteneraryTextBox.Size = New System.Drawing.Size(333, 31)
        Me.IteneraryTextBox.TabIndex = 26
        '
        'InputCruiseData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 1025)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ReservationNumLabel)
        Me.Controls.Add(Me.ReservationNumTextBox)
        Me.Controls.Add(DepartureDateLabel)
        Me.Controls.Add(Me.DepartureDateTextBox)
        Me.Controls.Add(ArrivalDateLabel)
        Me.Controls.Add(Me.ArrivalDateTextBox)
        Me.Controls.Add(DeparturePortLabel)
        Me.Controls.Add(Me.DeparturePortTextBox)
        Me.Controls.Add(ArrivalPortLabel)
        Me.Controls.Add(Me.ArrivalPortTextBox)
        Me.Controls.Add(BaseFareLabel)
        Me.Controls.Add(Me.BaseFareTextBox)
        Me.Controls.Add(TaxesFeesLabel)
        Me.Controls.Add(Me.TaxesFeesTextBox)
        Me.Controls.Add(PPGratuitiesLabel)
        Me.Controls.Add(Me.PPGratuitiesTextBox)
        Me.Controls.Add(PaymentsLabel)
        Me.Controls.Add(Me.PaymentsTextBox)
        Me.Controls.Add(StateRoomNoLabel)
        Me.Controls.Add(Me.StateRoomNoTextBox)
        Me.Controls.Add(ShipLabel)
        Me.Controls.Add(Me.ShipTextBox)
        Me.Controls.Add(IteneraryLabel)
        Me.Controls.Add(Me.IteneraryTextBox)
        Me.Controls.Add(Me.ActualCruiseBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InputCruiseData"
        Me.Text = "InputCruiseData"
        CType(Me.CruiseData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualCruiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualCruiseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActualCruiseBindingNavigator.ResumeLayout(False)
        Me.ActualCruiseBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CruiseData As CruiseData
    Friend WithEvents ActualCruiseBindingSource As BindingSource
    Friend WithEvents ActualCruiseBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ActualCruiseBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ReservationNumTextBox As TextBox
    Friend WithEvents DepartureDateTextBox As TextBox
    Friend WithEvents ArrivalDateTextBox As TextBox
    Friend WithEvents DeparturePortTextBox As TextBox
    Friend WithEvents ArrivalPortTextBox As TextBox
    Friend WithEvents BaseFareTextBox As TextBox
    Friend WithEvents TaxesFeesTextBox As TextBox
    Friend WithEvents PPGratuitiesTextBox As TextBox
    Friend WithEvents PaymentsTextBox As TextBox
    Friend WithEvents StateRoomNoTextBox As TextBox
    Friend WithEvents ShipTextBox As TextBox
    Friend WithEvents IteneraryTextBox As TextBox
End Class

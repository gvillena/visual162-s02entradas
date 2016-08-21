<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblComprarTickets = New System.Windows.Forms.Label()
        Me.lblGooglIO = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnDev = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.lblPrecioTitulo = New System.Windows.Forms.Label()
        Me.lblPrecioTituloP = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblImpTitulo = New System.Windows.Forms.Label()
        Me.lblImp = New System.Windows.Forms.Label()
        Me.lblTotalTitulo = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnComprar = New System.Windows.Forms.Button()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(52, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(147, 127)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lblComprarTickets
        '
        Me.lblComprarTickets.AutoSize = True
        Me.lblComprarTickets.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprarTickets.ForeColor = System.Drawing.Color.Black
        Me.lblComprarTickets.Location = New System.Drawing.Point(56, 168)
        Me.lblComprarTickets.Name = "lblComprarTickets"
        Me.lblComprarTickets.Size = New System.Drawing.Size(141, 25)
        Me.lblComprarTickets.TabIndex = 2
        Me.lblComprarTickets.Text = "Comprar Tickets"
        '
        'lblGooglIO
        '
        Me.lblGooglIO.AutoSize = True
        Me.lblGooglIO.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGooglIO.ForeColor = System.Drawing.Color.DimGray
        Me.lblGooglIO.Location = New System.Drawing.Point(73, 149)
        Me.lblGooglIO.Name = "lblGooglIO"
        Me.lblGooglIO.Size = New System.Drawing.Size(102, 19)
        Me.lblGooglIO.TabIndex = 3
        Me.lblGooglIO.Text = "Google IO 2016"
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Indigo
        Me.btnCerrar.Location = New System.Drawing.Point(226, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(31, 44)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGeneral
        '
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.Location = New System.Drawing.Point(24, 212)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(65, 30)
        Me.btnGeneral.TabIndex = 5
        Me.btnGeneral.Text = "General"
        Me.btnGeneral.UseVisualStyleBackColor = True
        '
        'btnDev
        '
        Me.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDev.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDev.Location = New System.Drawing.Point(95, 212)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(65, 30)
        Me.btnDev.TabIndex = 5
        Me.btnDev.Text = "Dev"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFull.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFull.Location = New System.Drawing.Point(166, 212)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(65, 30)
        Me.btnFull.TabIndex = 5
        Me.btnFull.Text = "Full"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'lblPrecioTitulo
        '
        Me.lblPrecioTitulo.AutoSize = True
        Me.lblPrecioTitulo.Font = New System.Drawing.Font("Segoe UI Light", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTitulo.Location = New System.Drawing.Point(54, 254)
        Me.lblPrecioTitulo.Name = "lblPrecioTitulo"
        Me.lblPrecioTitulo.Size = New System.Drawing.Size(148, 54)
        Me.lblPrecioTitulo.TabIndex = 6
        Me.lblPrecioTitulo.Text = "$ 1,500"
        Me.lblPrecioTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecioTituloP
        '
        Me.lblPrecioTituloP.AutoSize = True
        Me.lblPrecioTituloP.Location = New System.Drawing.Point(24, 325)
        Me.lblPrecioTituloP.Name = "lblPrecioTituloP"
        Me.lblPrecioTituloP.Size = New System.Drawing.Size(51, 21)
        Me.lblPrecioTituloP.TabIndex = 7
        Me.lblPrecioTituloP.Text = "Precio"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(185, 325)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(46, 21)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "1,500"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpTitulo
        '
        Me.lblImpTitulo.AutoSize = True
        Me.lblImpTitulo.Location = New System.Drawing.Point(24, 357)
        Me.lblImpTitulo.Name = "lblImpTitulo"
        Me.lblImpTitulo.Size = New System.Drawing.Size(40, 21)
        Me.lblImpTitulo.TabIndex = 7
        Me.lblImpTitulo.Text = "Imp."
        '
        'lblImp
        '
        Me.lblImp.AutoSize = True
        Me.lblImp.Location = New System.Drawing.Point(197, 357)
        Me.lblImp.Name = "lblImp"
        Me.lblImp.Size = New System.Drawing.Size(34, 21)
        Me.lblImp.TabIndex = 8
        Me.lblImp.Text = "150"
        Me.lblImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalTitulo
        '
        Me.lblTotalTitulo.AutoSize = True
        Me.lblTotalTitulo.Location = New System.Drawing.Point(24, 391)
        Me.lblTotalTitulo.Name = "lblTotalTitulo"
        Me.lblTotalTitulo.Size = New System.Drawing.Size(43, 21)
        Me.lblTotalTitulo.TabIndex = 7
        Me.lblTotalTitulo.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(189, 391)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 21)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "1650"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnComprar
        '
        Me.btnComprar.BackColor = System.Drawing.Color.Indigo
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(-2, 441)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(266, 43)
        Me.btnComprar.TabIndex = 9
        Me.btnComprar.Text = "COMPRAR ENTRADAS"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(263, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalTitulo)
        Me.Controls.Add(Me.lblImp)
        Me.Controls.Add(Me.lblImpTitulo)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblPrecioTituloP)
        Me.Controls.Add(Me.lblPrecioTitulo)
        Me.Controls.Add(Me.btnFull)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblGooglIO)
        Me.Controls.Add(Me.lblComprarTickets)
        Me.Controls.Add(Me.pbLogo)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblComprarTickets As Label
    Friend WithEvents lblGooglIO As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnDev As Button
    Friend WithEvents btnFull As Button
    Friend WithEvents lblPrecioTitulo As Label
    Friend WithEvents lblPrecioTituloP As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblImpTitulo As Label
    Friend WithEvents lblImp As Label
    Friend WithEvents lblTotalTitulo As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnComprar As Button
End Class

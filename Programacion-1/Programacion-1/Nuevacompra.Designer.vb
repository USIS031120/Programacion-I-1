﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nuevacompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim NfacturaLabel As System.Windows.Forms.Label
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cobpagod = New System.Windows.Forms.ComboBox()
        Me.txtfacturad = New System.Windows.Forms.TextBox()
        Me.cobsucursald = New System.Windows.Forms.ComboBox()
        Me.calendariod = New System.Windows.Forms.DateTimePicker()
        Me.cobproveedord = New System.Windows.Forms.ComboBox()
        Me.cobid = New System.Windows.Forms.ComboBox()
        Me.cobpagolist = New System.Windows.Forms.ComboBox()
        Me.cobproveedorlist = New System.Windows.Forms.ComboBox()
        Me.cobsucursallist = New System.Windows.Forms.ComboBox()
        Me.cobfecha = New System.Windows.Forms.ComboBox()
        Me.cobfacturad = New System.Windows.Forms.ComboBox()
        Me.cobfacturaslist = New System.Windows.Forms.ComboBox()
        Me.cobfacturalist = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        NfacturaLabel = New System.Windows.Forms.Label()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(555, 16)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(69, 13)
        NfacturaLabel.TabIndex = 16
        NfacturaLabel.Text = "Factura: No.:"
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(15, 48)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(40, 13)
        Fecha_vtaLabel.TabIndex = 18
        Fecha_vtaLabel.Text = "Fecha:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(304, 48)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 20
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(555, 49)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(66, 13)
        IdPagoLabel.TabIndex = 22
        IdPagoLabel.Text = "Forma pago:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(15, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 24
        Label1.Text = "Proveedor"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(304, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 13)
        Label2.TabIndex = 28
        Label2.Text = "Sucursal"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblRespuestaIva)
        Me.Panel1.Controls.Add(Me.lbliva)
        Me.Panel1.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel1.Controls.Add(Me.lblsuma)
        Me.Panel1.Location = New System.Drawing.Point(719, 478)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 104)
        Me.Panel1.TabIndex = 27
        '
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(97, 76)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00.00"
        Me.lblRespuestaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(16, 76)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(65, 16)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblRespuestaIva
        '
        Me.lblRespuestaIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaIva.Location = New System.Drawing.Point(97, 44)
        Me.lblRespuestaIva.Name = "lblRespuestaIva"
        Me.lblRespuestaIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaIva.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaIva.TabIndex = 3
        Me.lblRespuestaIva.Text = "00.00"
        Me.lblRespuestaIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbliva
        '
        Me.lbliva.AutoSize = True
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.Location = New System.Drawing.Point(16, 44)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(40, 16)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "IVA:"
        '
        'lblRespuestaSuma
        '
        Me.lblRespuestaSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaSuma.Location = New System.Drawing.Point(97, 9)
        Me.lblRespuestaSuma.Name = "lblRespuestaSuma"
        Me.lblRespuestaSuma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaSuma.Size = New System.Drawing.Size(100, 16)
        Me.lblRespuestaSuma.TabIndex = 1
        Me.lblRespuestaSuma.Text = "00.00"
        Me.lblRespuestaSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuma.Location = New System.Drawing.Point(16, 9)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(60, 16)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'subtotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 150
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subtotal})
        Me.grid.Location = New System.Drawing.Point(7, 96)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(912, 371)
        Me.grid.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 478)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Factura"
        '
        'btnnuevoyaceptar
        '
        Me.btnnuevoyaceptar.Location = New System.Drawing.Point(6, 28)
        Me.btnnuevoyaceptar.Name = "btnnuevoyaceptar"
        Me.btnnuevoyaceptar.Size = New System.Drawing.Size(84, 45)
        Me.btnnuevoyaceptar.TabIndex = 19
        Me.btnnuevoyaceptar.Text = "Nuevo"
        Me.btnnuevoyaceptar.UseVisualStyleBackColor = True
        '
        'btnmodificarycancelar
        '
        Me.btnmodificarycancelar.Location = New System.Drawing.Point(95, 28)
        Me.btnmodificarycancelar.Name = "btnmodificarycancelar"
        Me.btnmodificarycancelar.Size = New System.Drawing.Size(87, 45)
        Me.btnmodificarycancelar.TabIndex = 18
        Me.btnmodificarycancelar.Text = "Modificar"
        Me.btnmodificarycancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(187, 29)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(84, 44)
        Me.btneliminar.TabIndex = 17
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(862, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Editar detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(781, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cobpagod
        '
        Me.cobpagod.FormattingEnabled = True
        Me.cobpagod.Location = New System.Drawing.Point(624, 45)
        Me.cobpagod.Name = "cobpagod"
        Me.cobpagod.Size = New System.Drawing.Size(147, 21)
        Me.cobpagod.TabIndex = 36
        '
        'txtfacturad
        '
        Me.txtfacturad.Location = New System.Drawing.Point(624, 11)
        Me.txtfacturad.Name = "txtfacturad"
        Me.txtfacturad.Size = New System.Drawing.Size(147, 20)
        Me.txtfacturad.TabIndex = 41
        '
        'cobsucursald
        '
        Me.cobsucursald.FormattingEnabled = True
        Me.cobsucursald.Location = New System.Drawing.Point(372, 11)
        Me.cobsucursald.Name = "cobsucursald"
        Me.cobsucursald.Size = New System.Drawing.Size(147, 21)
        Me.cobsucursald.TabIndex = 34
        '
        'calendariod
        '
        Me.calendariod.Location = New System.Drawing.Point(74, 44)
        Me.calendariod.Name = "calendariod"
        Me.calendariod.Size = New System.Drawing.Size(222, 20)
        Me.calendariod.TabIndex = 19
        '
        'cobproveedord
        '
        Me.cobproveedord.FormattingEnabled = True
        Me.cobproveedord.Location = New System.Drawing.Point(74, 13)
        Me.cobproveedord.Name = "cobproveedord"
        Me.cobproveedord.Size = New System.Drawing.Size(147, 21)
        Me.cobproveedord.TabIndex = 33
        '
        'cobid
        '
        Me.cobid.FormattingEnabled = True
        Me.cobid.Location = New System.Drawing.Point(508, 530)
        Me.cobid.Name = "cobid"
        Me.cobid.Size = New System.Drawing.Size(147, 21)
        Me.cobid.TabIndex = 35
        '
        'cobpagolist
        '
        Me.cobpagolist.FormattingEnabled = True
        Me.cobpagolist.Location = New System.Drawing.Point(624, 45)
        Me.cobpagolist.Name = "cobpagolist"
        Me.cobpagolist.Size = New System.Drawing.Size(147, 21)
        Me.cobpagolist.TabIndex = 43
        '
        'cobproveedorlist
        '
        Me.cobproveedorlist.FormattingEnabled = True
        Me.cobproveedorlist.Location = New System.Drawing.Point(74, 12)
        Me.cobproveedorlist.Name = "cobproveedorlist"
        Me.cobproveedorlist.Size = New System.Drawing.Size(147, 21)
        Me.cobproveedorlist.TabIndex = 42
        '
        'cobsucursallist
        '
        Me.cobsucursallist.FormattingEnabled = True
        Me.cobsucursallist.Location = New System.Drawing.Point(372, 10)
        Me.cobsucursallist.Name = "cobsucursallist"
        Me.cobsucursallist.Size = New System.Drawing.Size(147, 21)
        Me.cobsucursallist.TabIndex = 45
        '
        'cobfecha
        '
        Me.cobfecha.FormattingEnabled = True
        Me.cobfecha.Location = New System.Drawing.Point(74, 44)
        Me.cobfecha.Name = "cobfecha"
        Me.cobfecha.Size = New System.Drawing.Size(222, 21)
        Me.cobfecha.TabIndex = 40
        '
        'cobfacturad
        '
        Me.cobfacturad.FormattingEnabled = True
        Me.cobfacturad.Location = New System.Drawing.Point(372, 44)
        Me.cobfacturad.Name = "cobfacturad"
        Me.cobfacturad.Size = New System.Drawing.Size(147, 21)
        Me.cobfacturad.TabIndex = 35
        '
        'cobfacturaslist
        '
        Me.cobfacturaslist.FormattingEnabled = True
        Me.cobfacturaslist.Location = New System.Drawing.Point(624, 10)
        Me.cobfacturaslist.Name = "cobfacturaslist"
        Me.cobfacturaslist.Size = New System.Drawing.Size(147, 21)
        Me.cobfacturaslist.TabIndex = 44
        '
        'cobfacturalist
        '
        Me.cobfacturalist.FormattingEnabled = True
        Me.cobfacturalist.Location = New System.Drawing.Point(372, 44)
        Me.cobfacturalist.Name = "cobfacturalist"
        Me.cobfacturalist.Size = New System.Drawing.Size(147, 21)
        Me.cobfacturalist.TabIndex = 46
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(307, 506)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 45)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Nuevacompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 582)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cobfacturalist)
        Me.Controls.Add(Me.cobsucursallist)
        Me.Controls.Add(Me.cobfacturaslist)
        Me.Controls.Add(Me.cobpagolist)
        Me.Controls.Add(Me.cobproveedorlist)
        Me.Controls.Add(Me.txtfacturad)
        Me.Controls.Add(Me.calendariod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cobpagod)
        Me.Controls.Add(Me.cobfacturad)
        Me.Controls.Add(Me.cobsucursald)
        Me.Controls.Add(Me.cobproveedord)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(NfacturaLabel)
        Me.Controls.Add(Fecha_vtaLabel)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cobid)
        Me.Controls.Add(Me.cobfecha)
        Me.Name = "Nuevacompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nueva Compra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents grid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cobpagod As ComboBox
    Friend WithEvents txtfacturad As TextBox
    Friend WithEvents cobsucursald As ComboBox
    Friend WithEvents calendariod As DateTimePicker
    Friend WithEvents cobproveedord As ComboBox
    Friend WithEvents cobid As ComboBox
    Friend WithEvents cobpagolist As ComboBox
    Friend WithEvents cobproveedorlist As ComboBox
    Friend WithEvents cobsucursallist As ComboBox
    Friend WithEvents cobfecha As ComboBox
    Friend WithEvents cobfacturad As ComboBox
    Friend WithEvents cobfacturaslist As ComboBox
    Friend WithEvents cobfacturalist As ComboBox
    Friend WithEvents Button3 As Button
End Class

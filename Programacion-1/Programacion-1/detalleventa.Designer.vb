﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalleventa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnnuevoyaceptar = New System.Windows.Forms.Button()
        Me.btnmodificarycancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cobcliente = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cobpre = New System.Windows.Forms.ComboBox()
        Me.coblab = New System.Windows.Forms.ComboBox()
        Me.cobmedicamento = New System.Windows.Forms.ComboBox()
        Me.lblcoste = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtotrosvalores = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtfactura = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtiddetalle = New System.Windows.Forms.TextBox()
        Me.cobdescuento = New System.Windows.Forms.ComboBox()
        Me.cobganancia = New System.Windows.Forms.ComboBox()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(876, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Terminar detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(306, 56)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(673, 471)
        Me.grid.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Filtro:"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(372, 23)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(346, 20)
        Me.txtfiltro.TabIndex = 46
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnnuevoyaceptar)
        Me.GroupBox2.Controls.Add(Me.btnmodificarycancelar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 475)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 84)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edicion"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cobcliente)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cobpre)
        Me.GroupBox1.Controls.Add(Me.coblab)
        Me.GroupBox1.Controls.Add(Me.cobmedicamento)
        Me.GroupBox1.Controls.Add(Me.lblcoste)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtotrosvalores)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtfactura)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 459)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Venta"
        '
        'cobcliente
        '
        Me.cobcliente.FormattingEnabled = True
        Me.cobcliente.Location = New System.Drawing.Point(6, 32)
        Me.cobcliente.Name = "cobcliente"
        Me.cobcliente.Size = New System.Drawing.Size(149, 21)
        Me.cobcliente.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Nombre Cliente"
        '
        'cobpre
        '
        Me.cobpre.FormattingEnabled = True
        Me.cobpre.Location = New System.Drawing.Point(4, 190)
        Me.cobpre.Name = "cobpre"
        Me.cobpre.Size = New System.Drawing.Size(149, 21)
        Me.cobpre.TabIndex = 41
        '
        'coblab
        '
        Me.coblab.FormattingEnabled = True
        Me.coblab.Location = New System.Drawing.Point(4, 150)
        Me.coblab.Name = "coblab"
        Me.coblab.Size = New System.Drawing.Size(149, 21)
        Me.coblab.TabIndex = 41
        '
        'cobmedicamento
        '
        Me.cobmedicamento.FormattingEnabled = True
        Me.cobmedicamento.Location = New System.Drawing.Point(4, 110)
        Me.cobmedicamento.Name = "cobmedicamento"
        Me.cobmedicamento.Size = New System.Drawing.Size(149, 21)
        Me.cobmedicamento.TabIndex = 41
        '
        'lblcoste
        '
        Me.lblcoste.AutoSize = True
        Me.lblcoste.Location = New System.Drawing.Point(70, 349)
        Me.lblcoste.Name = "lblcoste"
        Me.lblcoste.Size = New System.Drawing.Size(33, 13)
        Me.lblcoste.TabIndex = 5
        Me.lblcoste.Text = "coste"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 349)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Costo Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Agregar otros gastos (Transporte)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Precio Total de Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad comprada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Presentacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Laboratorio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion Medicamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero de factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IdMedicamento"
        '
        'txtotrosvalores
        '
        Me.txtotrosvalores.Location = New System.Drawing.Point(4, 308)
        Me.txtotrosvalores.Name = "txtotrosvalores"
        Me.txtotrosvalores.Size = New System.Drawing.Size(149, 20)
        Me.txtotrosvalores.TabIndex = 0
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(4, 269)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(149, 20)
        Me.txtprecio.TabIndex = 0
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(4, 230)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(149, 20)
        Me.txtcantidad.TabIndex = 0
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(4, 71)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(149, 20)
        Me.txtfactura.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(773, 10)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(149, 20)
        Me.txtid.TabIndex = 41
        '
        'txtiddetalle
        '
        Me.txtiddetalle.Location = New System.Drawing.Point(773, 30)
        Me.txtiddetalle.Name = "txtiddetalle"
        Me.txtiddetalle.Size = New System.Drawing.Size(149, 20)
        Me.txtiddetalle.TabIndex = 42
        '
        'cobdescuento
        '
        Me.cobdescuento.FormattingEnabled = True
        Me.cobdescuento.Location = New System.Drawing.Point(461, 533)
        Me.cobdescuento.Name = "cobdescuento"
        Me.cobdescuento.Size = New System.Drawing.Size(149, 21)
        Me.cobdescuento.TabIndex = 44
        '
        'cobganancia
        '
        Me.cobganancia.FormattingEnabled = True
        Me.cobganancia.Location = New System.Drawing.Point(306, 533)
        Me.cobganancia.Name = "cobganancia"
        Me.cobganancia.Size = New System.Drawing.Size(149, 21)
        Me.cobganancia.TabIndex = 45
        '
        'detalleventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 571)
        Me.Controls.Add(Me.cobdescuento)
        Me.Controls.Add(Me.cobganancia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtiddetalle)
        Me.Name = "detalleventa"
        Me.Text = "Detalle de Venta"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnnuevoyaceptar As Button
    Friend WithEvents btnmodificarycancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cobpre As ComboBox
    Friend WithEvents coblab As ComboBox
    Friend WithEvents cobmedicamento As ComboBox
    Friend WithEvents lblcoste As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtotrosvalores As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtfactura As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtiddetalle As TextBox
    Friend WithEvents cobcliente As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cobdescuento As ComboBox
    Friend WithEvents cobganancia As ComboBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscador
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
        Me.dwItems = New ControlesPersonalizados.GridFiltrado.GridMultiGruposFiltros()
        Me.fddFiltros = New ControlesPersonalizados.Filtro_DragDrop.FiltroDragDrop()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tlpbotones = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dwItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpbotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dwItems
        '
        Me.dwItems.AllowUserToAddRows = False
        Me.dwItems.AllowUserToDeleteRows = False
        Me.dwItems.AllowUserToResizeColumns = False
        Me.dwItems.AllowUserToResizeRows = False
        Me.dwItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dwItems.BackgroundColor = System.Drawing.Color.White
        Me.dwItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dwItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dwItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dwItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dwItems.ImageList = Nothing
        Me.dwItems.Location = New System.Drawing.Point(8, 97)
        Me.dwItems.MostrarFiltros = True
        Me.dwItems.MultiSelect = False
        Me.dwItems.Name = "dwItems"
        Me.dwItems.ReadOnly = True
        Me.dwItems.RowHeadersWidth = 25
        Me.dwItems.Size = New System.Drawing.Size(574, 332)
        Me.dwItems.TabIndex = 3
        Me.dwItems.TablaDatos = Nothing
        Me.dwItems.Total = ControlesPersonalizados.GridFiltrado.Elementos_Grid.TOTAL.NINGUNA
        '
        'fddFiltros
        '
        Me.fddFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.fddFiltros.Grid = Me.dwItems
        Me.fddFiltros.Location = New System.Drawing.Point(8, 8)
        Me.fddFiltros.Name = "fddFiltros"
        Me.fddFiltros.Size = New System.Drawing.Size(574, 89)
        Me.fddFiltros.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(497, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(74, 22)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(417, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(74, 22)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'tlpbotones
        '
        Me.tlpbotones.ColumnCount = 3
        Me.tlpbotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpbotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpbotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpbotones.Controls.Add(Me.btnCancelar, 2, 0)
        Me.tlpbotones.Controls.Add(Me.btnAceptar, 1, 0)
        Me.tlpbotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpbotones.Location = New System.Drawing.Point(8, 401)
        Me.tlpbotones.Name = "tlpbotones"
        Me.tlpbotones.RowCount = 1
        Me.tlpbotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpbotones.Size = New System.Drawing.Size(574, 28)
        Me.tlpbotones.TabIndex = 4
        '
        'FrmBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 437)
        Me.Controls.Add(Me.tlpbotones)
        Me.Controls.Add(Me.dwItems)
        Me.Controls.Add(Me.fddFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscador"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        CType(Me.dwItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpbotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fddFiltros As ControlesPersonalizados.Filtro_DragDrop.FiltroDragDrop
    Friend WithEvents dwItems As ControlesPersonalizados.GridFiltrado.GridMultiGruposFiltros
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents tlpbotones As TableLayoutPanel
End Class
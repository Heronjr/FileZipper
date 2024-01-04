<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPastaEntrada = New System.Windows.Forms.Button()
        Me.btnPastaSaida = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaida = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtdeArquivos = New System.Windows.Forms.TextBox()
        Me.btnZip = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomeArq = New System.Windows.Forms.TextBox()
        Me.txtMensagens = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumInicial = New System.Windows.Forms.TextBox()
        Me.btnFecha = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(99, 12)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(627, 20)
        Me.txtEntrada.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entrada:"
        '
        'btnPastaEntrada
        '
        Me.btnPastaEntrada.Location = New System.Drawing.Point(732, 12)
        Me.btnPastaEntrada.Name = "btnPastaEntrada"
        Me.btnPastaEntrada.Size = New System.Drawing.Size(27, 20)
        Me.btnPastaEntrada.TabIndex = 2
        Me.btnPastaEntrada.Text = "..."
        Me.btnPastaEntrada.UseVisualStyleBackColor = True
        '
        'btnPastaSaida
        '
        Me.btnPastaSaida.Location = New System.Drawing.Point(732, 50)
        Me.btnPastaSaida.Name = "btnPastaSaida"
        Me.btnPastaSaida.Size = New System.Drawing.Size(27, 20)
        Me.btnPastaSaida.TabIndex = 5
        Me.btnPastaSaida.Text = "..."
        Me.btnPastaSaida.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Saída:"
        '
        'txtSaida
        '
        Me.txtSaida.Location = New System.Drawing.Point(99, 50)
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(627, 20)
        Me.txtSaida.TabIndex = 3
        Me.txtSaida.Text = "h:\Graphics\_CLASS\_CRIPTOGRAFADOS\_CLASSIFICAR\"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(786, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusLabel1.Text = "Nostromo C 2022-2023"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel2.Text = "| Arq lidos: 0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(70, 17)
        Me.ToolStripStatusLabel3.Text = "| Arq grav: 0"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(400, 16)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Qtde de arquivos:"
        '
        'txtQtdeArquivos
        '
        Me.txtQtdeArquivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdeArquivos.Location = New System.Drawing.Point(99, 88)
        Me.txtQtdeArquivos.Name = "txtQtdeArquivos"
        Me.txtQtdeArquivos.Size = New System.Drawing.Size(48, 20)
        Me.txtQtdeArquivos.TabIndex = 7
        Me.txtQtdeArquivos.Text = "50"
        Me.txtQtdeArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnZip
        '
        Me.btnZip.BackColor = System.Drawing.SystemColors.Control
        Me.btnZip.Enabled = False
        Me.btnZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZip.Location = New System.Drawing.Point(99, 114)
        Me.btnZip.Name = "btnZip"
        Me.btnZip.Size = New System.Drawing.Size(76, 52)
        Me.btnZip.TabIndex = 9
        Me.btnZip.Text = "ZIP"
        Me.btnZip.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(565, 88)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(194, 20)
        Me.txtSenha.TabIndex = 10
        Me.txtSenha.Text = "LesRoulettes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nome ZIP:"
        '
        'txtNomeArq
        '
        Me.txtNomeArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeArq.Location = New System.Drawing.Point(217, 88)
        Me.txtNomeArq.Name = "txtNomeArq"
        Me.txtNomeArq.Size = New System.Drawing.Size(194, 20)
        Me.txtNomeArq.TabIndex = 12
        '
        'txtMensagens
        '
        Me.txtMensagens.BackColor = System.Drawing.SystemColors.Info
        Me.txtMensagens.Location = New System.Drawing.Point(99, 172)
        Me.txtMensagens.Multiline = True
        Me.txtMensagens.Name = "txtMensagens"
        Me.txtMensagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagens.Size = New System.Drawing.Size(660, 237)
        Me.txtMensagens.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mensagens:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(422, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nº inicial"
        '
        'txtNumInicial
        '
        Me.txtNumInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumInicial.Location = New System.Drawing.Point(478, 88)
        Me.txtNumInicial.Name = "txtNumInicial"
        Me.txtNumInicial.Size = New System.Drawing.Size(37, 20)
        Me.txtNumInicial.TabIndex = 16
        Me.txtNumInicial.Text = "1"
        Me.txtNumInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFecha
        '
        Me.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFecha.Location = New System.Drawing.Point(684, 114)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(75, 52)
        Me.btnFecha.TabIndex = 18
        Me.btnFecha.Text = "Fecha"
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 450)
        Me.Controls.Add(Me.btnFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumInicial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMensagens)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomeArq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnZip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQtdeArquivos)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnPastaSaida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaida)
        Me.Controls.Add(Me.btnPastaEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEntrada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "FileZipper"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPastaEntrada As Button
    Friend WithEvents btnPastaSaida As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaida As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQtdeArquivos As TextBox
    Friend WithEvents btnZip As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeArq As TextBox
    Friend WithEvents txtMensagens As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNumInicial As TextBox
    Friend WithEvents btnFecha As Button
End Class

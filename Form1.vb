Imports System.IO
Imports System.Threading
Imports Ionic.Zip
Imports Microsoft.VisualBasic.Devices

Public Class Form1

    Private fd As New FolderBrowserDialog
    Private _strEntrada As New String("")
    Private _strSaida As New String("")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga do form
        '26/12/22
        '=============
        Me.Text = "Nostromo " & Proj.VersaoAuto
        ToolStripStatusLabel1.Text = My.Application.Info.Copyright & IIf(Year(Today) > 2022, "-" & Year(Now.Date), "")

    End Sub

    Private Sub btnZip_Click(sender As Object, e As EventArgs) Handles btnZip.Click
        'Botão Zip
        '23/12/22
        '=========
        If btnZip.Text = "Outro?" Then
            txtEntrada.Text = ""
            txtQtdeArquivos.Text = 50
            txtNomeArq.Text = ""
            txtNumInicial.Text = 1
            btnZip.BackColor = SystemColors.Control
            btnZip.Text = "Zip"
            ToolStripStatusLabel2.Text = "| Arq lidos: 0"
            ToolStripStatusLabel3.Text = "| Arq grav: 0"
            Zipando(False)
        Else
            btnZip.BackColor = Color.OrangeRed
            btnZip.Text = "Zipando..."
            ZipFiles()
        End If

    End Sub

    Private Sub ZipFiles()
        'Zip dos arquivos com senha
        '23/12/22
        '==========================
        UseWaitCursor = True
        Thread.Sleep(500)
        Me.Refresh()
        txtSenha.PasswordChar = "*"
        Zipando(True)

        Dim strArqZip As New String(txtSaida.Text & "/" & txtNomeArq.Text & txtNumInicial.Text & ".zip")
        Dim intLimPorZip As Integer = 0
        Dim intTotArqs As Integer = 0
        Dim intGravados As Integer = 0
        Dim intNome As Integer = txtNumInicial.Text
        Dim oDir As New IO.DirectoryInfo(txtEntrada.Text)
        Dim aArquivos As IO.FileInfo() = oDir.GetFiles("*.*")
        Dim oArq As IO.FileInfo
        Dim zip As New ZipFile
        Dim strZerosEsquerda As New String("D2")

        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = 100
        strZerosEsquerda = If(Math.Ceiling(Directory.GetFiles(txtEntrada.Text, "*.*").Count / Convert.ToUInt16(txtQtdeArquivos.Text)) < 100, "D2",
                           If(Math.Ceiling(Directory.GetFiles(txtEntrada.Text, "*.*").Count / Convert.ToUInt16(txtQtdeArquivos.Text)) < 1000, "D3", "D4"))

        Try

            For Each oArq In aArquivos
                intLimPorZip += 1
                intTotArqs += 1
                ToolStripProgressBar1.Value = (intTotArqs / Directory.GetFiles(txtEntrada.Text, "*.*").Count) * 100
                Application.DoEvents()

                zip.Password = txtSenha.Text
                zip.Encryption = EncryptionAlgorithm.WinZipAes256
                zip.AddFile(txtEntrada.Text & "\" & oArq.Name)

                'Atingiu o limite?
                If intLimPorZip = txtQtdeArquivos.Text Then
                    intGravados += 1
                    zip.Save(txtSaida.Text & "\" & txtNomeArq.Text & intNome.ToString(strZerosEsquerda) & ".zip")
                    ToolStripStatusLabel3.Text = "| Arq grav: " & intGravados & " / " & Directory.GetFiles(txtSaida.Text, "*.*").Count
                    intLimPorZip = 0
                    intNome += 1
                    zip = New ZipFile
                End If

            Next

            If intLimPorZip > 0 Then
                zip.Password = txtSenha.Text
                zip.Save(txtSaida.Text & "\" & txtNomeArq.Text & intNome.ToString(strZerosEsquerda) & ".zip")
            End If

        Catch ex As Exception
            MessageBox.Show("exception: {0}", ex.ToString)
        End Try

        txtMensagens.Text &= "Fim do processo: gravados " & Directory.GetFiles(txtSaida.Text, "*.*").Count & " Arqs ZIP *****************************" & vbCrLf
        ToolStripStatusLabel3.Text = "| Arq grav: " & Directory.GetFiles(txtSaida.Text, "*.*").Count
        'Cursor = Cursors.Default
        UseWaitCursor = False
        btnZip.Text = "Outro?"
        btnZip.BackColor = Color.Orange
        Beep()

    End Sub

    Private Sub Zipando(blnZipando As Boolean)
        'Controle de campos de edição durante o processo de zip
        '26/12/22
        '======================================================
        For Each oCnt As Control In Me.Controls
            oCnt.Enabled = If(TypeOf (oCnt) Is TextBox, Not blnZipando, blnZipando)
        Next

        btnPastaEntrada.Enabled = txtEntrada.Enabled
        btnPastaSaida.Enabled = txtSaida.Enabled

    End Sub

    Private Sub btnPastaEntrada_Click(sender As Object, e As EventArgs) Handles btnPastaEntrada.Click
        'Botão pasta de entrada
        '23/12/22-10/01/23
        '======================
        If _strEntrada <> "" Then
            fd.SelectedPath = StrReverse(Split(StrReverse(_strEntrada), "\", 2)(1)) & "\"
            SendKeys.Send("{TAB}{TAB}{RIGHT}")  'Workaround para tornar o controle de busca com EnsureVisiblem
        End If
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtEntrada.Text = fd.SelectedPath
            _strEntrada = fd.SelectedPath
            ToolStripStatusLabel2.Text = "| Arq lidos: " & Directory.GetFiles(txtEntrada.Text, "*.*").Count
            txtNomeArq.Text = txtEntrada.Text.Split(Path.DirectorySeparatorChar).Last()
            txtMensagens.Text &= txtNomeArq.Text & ": Serão gerados " & Math.Ceiling(Directory.GetFiles(txtEntrada.Text, "*.*").Count / Convert.ToUInt16(txtQtdeArquivos.Text)) &
                " arquivos zip" & vbCrLf
        End If

    End Sub

    Private Sub btnPastaSaida_Click(sender As Object, e As EventArgs) Handles btnPastaSaida.Click
        'Botão pasta de saída
        '23/12/22-10/01/23
        '======================
        If _strSaida <> "" Then
            fd.SelectedPath = StrReverse(Split(StrReverse(_strSaida), "\", 2)(1))
        End If
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSaida.Text = fd.SelectedPath
            _strSaida = fd.SelectedPath
            ToolStripStatusLabel3.Text = "| Arq grav: " & Directory.GetFiles(txtSaida.Text, "*.*").Count
        End If

    End Sub

    Private Function TextosPreenchidos() As Boolean
        '23/12/22
        '========
        Dim blnOK As Boolean = Len(Trim(txtEntrada.Text)) > 0 And Len(Trim(txtSaida.Text)) > 0 And Len(Trim(txtSenha.Text)) > 0 And IsNumeric(txtQtdeArquivos.Text)

        btnZip.BackColor = If(blnOK, Color.Lime, SystemColors.Control)
        Return blnOK

    End Function
    Private Sub txtEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtEntrada.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub txtSaida_TextChanged(sender As Object, e As EventArgs) Handles txtSaida.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub txtQtdeArquivos_TextChanged(sender As Object, e As EventArgs) Handles txtQtdeArquivos.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub txtNomeArq_TextChanged(sender As Object, e As EventArgs) Handles txtNomeArq.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub txtNumInicial_TextChanged(sender As Object, e As EventArgs) Handles txtNumInicial.TextChanged
        'Alteração de texto
        '23/12/22
        '==================
        btnZip.Enabled = TextosPreenchidos()

    End Sub

    Private Sub btnZip_MouseHover(sender As Object, e As EventArgs) Handles btnZip.MouseHover
        'Mouse passa por cima
        '25/12/22
        '====================
        Cursor = Cursors.Hand

    End Sub

    Private Sub btnZip_MouseLeave(sender As Object, e As EventArgs) Handles btnZip.MouseLeave
        'Mouse sai de cima
        '25/12/22
        '=================
        Cursor = Cursors.Default

    End Sub

    Private Sub btnFecha_Click(sender As Object, e As EventArgs) Handles btnFecha.Click
        'Botão fecha
        '26/12/22
        '===========
        Me.Close()

    End Sub

End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnvironment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEnvironment))
        Me.CmdOkay = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.TlpPlaceholder = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.lnkIssue = New System.Windows.Forms.LinkLabel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdOkay
        '
        Me.CmdOkay.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOkay.FlatAppearance.BorderSize = 0
        Me.CmdOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOkay.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOkay.Location = New System.Drawing.Point(345, 8)
        Me.CmdOkay.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.CmdOkay.Name = "CmdOkay"
        Me.CmdOkay.Size = New System.Drawing.Size(75, 35)
        Me.CmdOkay.TabIndex = 1
        Me.CmdOkay.Text = "OK"
        Me.CmdOkay.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(0, 2)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(9)
        Me.lblMessage.Size = New System.Drawing.Size(428, 115)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "..."
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.TlpPlaceholder)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(428, 40)
        Me.PanHead.TabIndex = 1
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(348, 40)
        Me.LabHead.TabIndex = 1
        Me.LabHead.Text = "WinXI Application Support"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TlpPlaceholder
        '
        Me.TlpPlaceholder.BackColor = System.Drawing.Color.Transparent
        Me.TlpPlaceholder.ColumnCount = 1
        Me.TlpPlaceholder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlaceholder.Dock = System.Windows.Forms.DockStyle.Right
        Me.TlpPlaceholder.Location = New System.Drawing.Point(388, 0)
        Me.TlpPlaceholder.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpPlaceholder.Name = "TlpPlaceholder"
        Me.TlpPlaceholder.RowCount = 1
        Me.TlpPlaceholder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlaceholder.Size = New System.Drawing.Size(40, 40)
        Me.TlpPlaceholder.TabIndex = 11
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TlpHeadImage.Controls.Add(Me.icnMain, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(40, 40)
        Me.TlpHeadImage.TabIndex = 10
        '
        'icnMain
        '
        Me.icnMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.icnMain.BackColor = System.Drawing.Color.Transparent
        Me.icnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icnMain.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.icnMain.Location = New System.Drawing.Point(9, 8)
        Me.icnMain.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.icnMain.Name = "icnMain"
        Me.icnMain.Size = New System.Drawing.Size(24, 24)
        Me.icnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icnMain.TabIndex = 1
        Me.icnMain.TabStop = False
        '
        'lnkIssue
        '
        Me.lnkIssue.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkIssue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lnkIssue.AutoSize = True
        Me.lnkIssue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkIssue.ForeColor = System.Drawing.Color.White
        Me.lnkIssue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkIssue.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkIssue.Location = New System.Drawing.Point(8, 14)
        Me.lnkIssue.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lnkIssue.Name = "lnkIssue"
        Me.lnkIssue.Size = New System.Drawing.Size(119, 23)
        Me.lnkIssue.TabIndex = 0
        Me.lnkIssue.TabStop = True
        Me.lnkIssue.Text = "Open an Issue"
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.lblMessage)
        Me.PanMain.Controls.Add(Me.TableLayoutPanel1)
        Me.PanMain.Controls.Add(Me.PanSplit)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 41)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(428, 168)
        Me.PanMain.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CmdOkay, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lnkIssue, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 117)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(428, 51)
        Me.TableLayoutPanel1.TabIndex = 74
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(0, 0)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(428, 2)
        Me.PanSplit.TabIndex = 73
        '
        'FormEnvironment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 210)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(430, 210)
        Me.MinimumSize = New System.Drawing.Size(430, 210)
        Me.Name = "FormEnvironment"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Support (Unsupported OS)"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents CmdOkay As System.Windows.Forms.Button
    Friend WithEvents lnkIssue As System.Windows.Forms.LinkLabel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TlpPlaceholder As TableLayoutPanel
End Class

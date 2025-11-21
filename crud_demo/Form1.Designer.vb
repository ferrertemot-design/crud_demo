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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(335, 3)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(135, 58)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(298, 168)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxName.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(243, 168)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Name:"
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(298, 194)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxAge.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(298, 220)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxEmail.TabIndex = 6
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(129, 58)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(270, 48)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "CREATE (Insert Data)"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(774, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(131, 114)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(270, 48)
        Me.ButtonRead.TabIndex = 9
        Me.ButtonRead.Text = "READ (Retrieve Data)"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 48)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Remove (Delete Data)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(407, 114)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(270, 48)
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Update (Update Data)"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonRead As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonUpdate As Button
End Class

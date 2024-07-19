<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.searchtext = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.mobtext = New System.Windows.Forms.TextBox()
        Me.citytext = New System.Windows.Forms.TextBox()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.codingbtn = New System.Windows.Forms.Button()
        Me.noncodingbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchtext
        '
        Me.searchtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtext.Location = New System.Drawing.Point(350, 418)
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(174, 38)
        Me.searchtext.TabIndex = 49
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(162, 540)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton3.TabIndex = 48
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(162, 441)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton2.TabIndex = 47
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(162, 351)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton1.TabIndex = 46
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(755, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(417, 298)
        Me.DataGridView1.TabIndex = 45
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(347, 188)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 16)
        Me.label3.TabIndex = 44
        Me.label3.Text = "mobile"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(348, 133)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(27, 16)
        Me.label2.TabIndex = 43
        Me.label2.Text = "city"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(348, 89)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 16)
        Me.label1.TabIndex = 42
        Me.label1.Text = "name"
        '
        'mobtext
        '
        Me.mobtext.Location = New System.Drawing.Point(162, 183)
        Me.mobtext.Name = "mobtext"
        Me.mobtext.Size = New System.Drawing.Size(100, 22)
        Me.mobtext.TabIndex = 41
        '
        'citytext
        '
        Me.citytext.Location = New System.Drawing.Point(162, 133)
        Me.citytext.Name = "citytext"
        Me.citytext.Size = New System.Drawing.Size(100, 22)
        Me.citytext.TabIndex = 40
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(161, 89)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(100, 22)
        Me.nametext.TabIndex = 39
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(390, 500)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 38
        Me.searchbtn.Text = "search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(517, 253)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 23)
        Me.Editbtn.TabIndex = 37
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Location = New System.Drawing.Point(348, 253)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(75, 23)
        Me.delbtn.TabIndex = 36
        Me.delbtn.Text = "delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(187, 253)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(75, 23)
        Me.addbtn.TabIndex = 35
        Me.addbtn.Text = "add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'codingbtn
        '
        Me.codingbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.codingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codingbtn.Location = New System.Drawing.Point(672, 380)
        Me.codingbtn.Name = "codingbtn"
        Me.codingbtn.Size = New System.Drawing.Size(507, 43)
        Me.codingbtn.TabIndex = 50
        Me.codingbtn.Text = "Show Crystall report in coding"
        Me.codingbtn.UseVisualStyleBackColor = False
        '
        'noncodingbtn
        '
        Me.noncodingbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.noncodingbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noncodingbtn.Location = New System.Drawing.Point(672, 452)
        Me.noncodingbtn.Name = "noncodingbtn"
        Me.noncodingbtn.Size = New System.Drawing.Size(507, 43)
        Me.noncodingbtn.TabIndex = 51
        Me.noncodingbtn.Text = "Show Crystall report without coding"
        Me.noncodingbtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 608)
        Me.Controls.Add(Me.noncodingbtn)
        Me.Controls.Add(Me.codingbtn)
        Me.Controls.Add(Me.searchtext)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.mobtext)
        Me.Controls.Add(Me.citytext)
        Me.Controls.Add(Me.nametext)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchtext As Windows.Forms.TextBox
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Private WithEvents label3 As Windows.Forms.Label
    Private WithEvents label2 As Windows.Forms.Label
    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents mobtext As Windows.Forms.TextBox
    Private WithEvents citytext As Windows.Forms.TextBox
    Private WithEvents nametext As Windows.Forms.TextBox
    Private WithEvents searchbtn As Windows.Forms.Button
    Private WithEvents Editbtn As Windows.Forms.Button
    Private WithEvents delbtn As Windows.Forms.Button
    Private WithEvents addbtn As Windows.Forms.Button
    Friend WithEvents codingbtn As Windows.Forms.Button
    Friend WithEvents noncodingbtn As Windows.Forms.Button
End Class

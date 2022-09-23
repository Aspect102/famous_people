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
        Me.btn_Turing = New System.Windows.Forms.Button()
        Me.btn_Berners = New System.Windows.Forms.Button()
        Me.btn_Hopper = New System.Windows.Forms.Button()
        Me.btn_Babbage = New System.Windows.Forms.Button()
        Me.btn_Shannon = New System.Windows.Forms.Button()
        Me.lbl_Photo = New System.Windows.Forms.Label()
        Me.pbx_Photo = New System.Windows.Forms.PictureBox()
        Me.lbl_Facts = New System.Windows.Forms.Label()
        Me.txt_Facts = New System.Windows.Forms.TextBox()
        Me.lbl_Born = New System.Windows.Forms.Label()
        Me.lbl_Died = New System.Windows.Forms.Label()
        Me.txt_Born = New System.Windows.Forms.TextBox()
        Me.txt_Died = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        CType(Me.pbx_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Turing
        '
        Me.btn_Turing.Location = New System.Drawing.Point(46, 102)
        Me.btn_Turing.Name = "btn_Turing"
        Me.btn_Turing.Size = New System.Drawing.Size(112, 49)
        Me.btn_Turing.TabIndex = 0
        Me.btn_Turing.Text = "Alan Turing"
        Me.btn_Turing.UseVisualStyleBackColor = True
        '
        'btn_Berners
        '
        Me.btn_Berners.Location = New System.Drawing.Point(46, 170)
        Me.btn_Berners.Name = "btn_Berners"
        Me.btn_Berners.Size = New System.Drawing.Size(112, 49)
        Me.btn_Berners.TabIndex = 1
        Me.btn_Berners.Text = "Tim Berners-Lee"
        Me.btn_Berners.UseVisualStyleBackColor = True
        '
        'btn_Hopper
        '
        Me.btn_Hopper.Location = New System.Drawing.Point(46, 232)
        Me.btn_Hopper.Name = "btn_Hopper"
        Me.btn_Hopper.Size = New System.Drawing.Size(112, 49)
        Me.btn_Hopper.TabIndex = 2
        Me.btn_Hopper.Text = "Grace Hopper"
        Me.btn_Hopper.UseVisualStyleBackColor = True
        '
        'btn_Babbage
        '
        Me.btn_Babbage.Location = New System.Drawing.Point(46, 297)
        Me.btn_Babbage.Name = "btn_Babbage"
        Me.btn_Babbage.Size = New System.Drawing.Size(112, 49)
        Me.btn_Babbage.TabIndex = 3
        Me.btn_Babbage.Text = "Charles Babbage"
        Me.btn_Babbage.UseVisualStyleBackColor = True
        '
        'btn_Shannon
        '
        Me.btn_Shannon.Location = New System.Drawing.Point(46, 364)
        Me.btn_Shannon.Name = "btn_Shannon"
        Me.btn_Shannon.Size = New System.Drawing.Size(112, 49)
        Me.btn_Shannon.TabIndex = 4
        Me.btn_Shannon.Text = "Claude Shannon"
        Me.btn_Shannon.UseVisualStyleBackColor = True
        '
        'lbl_Photo
        '
        Me.lbl_Photo.AutoSize = True
        Me.lbl_Photo.Location = New System.Drawing.Point(209, 72)
        Me.lbl_Photo.Name = "lbl_Photo"
        Me.lbl_Photo.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Photo.TabIndex = 5
        Me.lbl_Photo.Text = "Photo"
        '
        'pbx_Photo
        '
        Me.pbx_Photo.Location = New System.Drawing.Point(209, 102)
        Me.pbx_Photo.Name = "pbx_Photo"
        Me.pbx_Photo.Size = New System.Drawing.Size(245, 194)
        Me.pbx_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_Photo.TabIndex = 6
        Me.pbx_Photo.TabStop = False
        '
        'lbl_Facts
        '
        Me.lbl_Facts.AutoSize = True
        Me.lbl_Facts.Location = New System.Drawing.Point(488, 72)
        Me.lbl_Facts.Name = "lbl_Facts"
        Me.lbl_Facts.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Facts.TabIndex = 7
        Me.lbl_Facts.Text = "Facts/Info"
        '
        'txt_Facts
        '
        Me.txt_Facts.Location = New System.Drawing.Point(488, 98)
        Me.txt_Facts.Multiline = True
        Me.txt_Facts.Name = "txt_Facts"
        Me.txt_Facts.Size = New System.Drawing.Size(275, 248)
        Me.txt_Facts.TabIndex = 8
        '
        'lbl_Born
        '
        Me.lbl_Born.AutoSize = True
        Me.lbl_Born.Location = New System.Drawing.Point(209, 331)
        Me.lbl_Born.Name = "lbl_Born"
        Me.lbl_Born.Size = New System.Drawing.Size(32, 15)
        Me.lbl_Born.TabIndex = 9
        Me.lbl_Born.Text = "Born"
        '
        'lbl_Died
        '
        Me.lbl_Died.AutoSize = True
        Me.lbl_Died.Location = New System.Drawing.Point(350, 331)
        Me.lbl_Died.Name = "lbl_Died"
        Me.lbl_Died.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Died.TabIndex = 10
        Me.lbl_Died.Text = "Died"
        '
        'txt_Born
        '
        Me.txt_Born.Location = New System.Drawing.Point(209, 364)
        Me.txt_Born.Name = "txt_Born"
        Me.txt_Born.Size = New System.Drawing.Size(115, 23)
        Me.txt_Born.TabIndex = 11
        '
        'txt_Died
        '
        Me.txt_Died.Location = New System.Drawing.Point(350, 364)
        Me.txt_Died.Name = "txt_Died"
        Me.txt_Died.Size = New System.Drawing.Size(115, 23)
        Me.txt_Died.TabIndex = 12
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(768, 30)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 13
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Title.Location = New System.Drawing.Point(46, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(617, 47)
        Me.lbl_Title.TabIndex = 14
        Me.lbl_Title.Text = "Famous People In Computer Science"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 450)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.txt_Died)
        Me.Controls.Add(Me.txt_Born)
        Me.Controls.Add(Me.lbl_Died)
        Me.Controls.Add(Me.lbl_Born)
        Me.Controls.Add(Me.txt_Facts)
        Me.Controls.Add(Me.lbl_Facts)
        Me.Controls.Add(Me.pbx_Photo)
        Me.Controls.Add(Me.lbl_Photo)
        Me.Controls.Add(Me.btn_Shannon)
        Me.Controls.Add(Me.btn_Babbage)
        Me.Controls.Add(Me.btn_Hopper)
        Me.Controls.Add(Me.btn_Berners)
        Me.Controls.Add(Me.btn_Turing)
        Me.Name = "Form1"
        Me.Text = "Famous People In Computer Science"
        CType(Me.pbx_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Turing As Button
    Friend WithEvents btn_Berners As Button
    Friend WithEvents btn_Hopper As Button
    Friend WithEvents btn_Babbage As Button
    Friend WithEvents btn_Shannon As Button
    Friend WithEvents lbl_Photo As Label
    Friend WithEvents pbx_Photo As PictureBox
    Friend WithEvents lbl_Facts As Label
    Friend WithEvents txt_Facts As TextBox
    Friend WithEvents lbl_Born As Label
    Friend WithEvents lbl_Died As Label
    Friend WithEvents txt_Born As TextBox
    Friend WithEvents txt_Died As TextBox
    Friend WithEvents btn_Clear As Button
    Friend WithEvents lbl_Title As Label
End Class

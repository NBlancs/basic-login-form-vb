<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        usernametxt = New TextBox()
        loginbtn = New Button()
        passwordtxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(301, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 30)
        Label1.TabIndex = 0
        Label1.Text = "Basic Login Form"
        ' 
        ' usernametxt
        ' 
        usernametxt.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernametxt.Location = New Point(236, 150)
        usernametxt.Name = "usernametxt"
        usernametxt.PlaceholderText = "username"
        usernametxt.Size = New Size(300, 35)
        usernametxt.TabIndex = 1
        ' 
        ' loginbtn
        ' 
        loginbtn.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginbtn.Location = New Point(326, 299)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(128, 50)
        loginbtn.TabIndex = 3
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = True
        ' 
        ' passwordtxt
        ' 
        passwordtxt.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwordtxt.Location = New Point(236, 224)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.PasswordChar = "*"c
        passwordtxt.PlaceholderText = "password"
        passwordtxt.Size = New Size(300, 35)
        passwordtxt.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(passwordtxt)
        Controls.Add(loginbtn)
        Controls.Add(usernametxt)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents passwordtxt As TextBox

End Class

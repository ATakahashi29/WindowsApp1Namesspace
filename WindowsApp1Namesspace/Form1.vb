'imports宣言する時に、別名命名
Imports Nihonkai = WindowsApp1Namesspace.Akita
Imports Taiheiyo = WindowsApp1Namesspace.Iwate

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '↓このままではダブっていて名前空間追記必要
        'Dim Space As New Space()

        'どちらか必須↓
        Dim Space As New Nihonkai.Space()
        'Dim Space As New Taiheiyo.Space()
        Space.ShowName()
    End Sub
End Class

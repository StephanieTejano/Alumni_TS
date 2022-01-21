

Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ControlAlumni1.BringToFront()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ControlProfessors1.BringToFront()
    End Sub

    Private Sub AcadYear_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AcadYear.ItemClick
        Academic_Year.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        ControlMembership1.BringToFront()
    End Sub

    Private Sub studentbtn(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ControlStudent1.BringToFront()
    End Sub

    Private Sub BarButtonItem6_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick

    End Sub
End Class

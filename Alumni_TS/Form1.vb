﻿

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

    Private Sub studentbtn(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ControlStudent1.BringToFront()
    End Sub

    Private Sub Blank1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub MembershipButton_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        ControlMembership1.BringToFront()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        AddUser.ShowDialog()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        ControlGuardian1.BringToFront()
    End Sub
End Class

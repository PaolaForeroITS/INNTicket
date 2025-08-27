Imports System.Configuration

Public Class frmMain

    Dim bSyncAttachStarted As Boolean

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim sync As New clsSyncAttach
        sync.Log("SESTicketSyncAttached: Closed")
        sync.Dispose()
        sync = Nothing
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sync As New clsSyncAttach
        sync.Log("SESTicketSyncAttached: Started")
        sync.Dispose()
        sync = Nothing
        StartSyncAttach()
    End Sub

    Private Sub StartSyncAttach()
        Dim Timer1 As New Timer()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        Timer1.Interval = 60000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If bSyncAttachStarted = False Then
            Timer1.Stop()
            bSyncAttachStarted = True

            Dim sync As New clsSyncAttach
            sync.SyncTable()
            sync.SyncFile()
            sync.Dispose()
            sync = Nothing

            bSyncAttachStarted = False
            Timer1.Start()
        End If

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sHide As String = ConfigurationManager.AppSettings("hide").ToString.ToUpper
        If sHide = "TRUE" Then
            Me.Visible = False
        End If
    End Sub
End Class
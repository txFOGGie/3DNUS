﻿Public Class dev_express
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("I'm Sorry, but you cant close while we are Setting up your Settings!", "3DNUS: First time Setup | Express Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'Save Configurations and Continue

        dev_custom_finish.Show()
        Me.Close()
    End Sub

    Private Sub dev_express_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes express"
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes express"
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label1.Text = "3DNUS : Configuración por primera vez | Ajustes express"
        End If
        If My.Settings.lang_selected = "Spanish, MX (Español)" Then
            Label2.Text = "Por favor espera..."
        End If
        If My.Settings.lang_selected = "Spanish, US (Español)" Then
            Label2.Text = "Por favor espera..."
        End If
        If My.Settings.lang_selected = "Spanish, UK (Español)" Then
            Label2.Text = "Por favor espera..."
        End If
    End Sub
End Class
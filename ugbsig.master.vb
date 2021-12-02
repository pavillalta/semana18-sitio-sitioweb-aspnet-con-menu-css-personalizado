
Partial Class ugbsig
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim tipousuario As String

        If Session("aliasusuario") = "" Then

            Me.lblnomusuario.Text = "No se ha iniciado ninguna sesion."
            Me.btnsesion.Text = "Iniciar Sesión"

        Else

            If Session("nivel") = 1 Then

                tipousuario = " (Administrador)"

            ElseIf Session("nivel") = 2 Then
                tipousuario = " (Docente)"

            ElseIf Session("nivel") = 3 Then
                tipousuario = " (Estudiante)"

            Else
                tipousuario = " (Visitante)"

            End If

            Me.lblnomusuario.Text = "Bienvenido " & Session("nomusuario") & tipousuario
            Me.btnsesion.Text = "Cerrar Sesión"

            End If

    End Sub

    Protected Sub btnsesion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsesion.Click

        If Session("aliasusuario") = "" Then

            Me.Response.Redirect("f_acceso.aspx")

        Else

            Me.Response.Redirect("f_cerrarsesion.aspx")

        End If


    End Sub
End Class


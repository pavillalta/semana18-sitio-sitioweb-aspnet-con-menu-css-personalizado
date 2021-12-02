
Partial Class f_cerrarsesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("aliasusuario") = "" Then

            'Me.Response.Redirect("f_acceso.aspx")

            Me.lblsesionmensaje.Text = "No se ha iniciado ninguna sesion de usuario."
            Me.lblsesionname.Text = ""
            SESION.Visible = False


        Else

            Me.lblsesionmensaje.Text = "Esta seguro que desea cerrar la sesion iniciada como:"
            Me.lblsesionname.Text = Session("aliasusuario") & " (" & (Session("nomusuario")) & ")"
            SESION.Visible = True

        End If

    End Sub

    Protected Sub SESION_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles SESION.Click

        Session("nomusuario") = ""
        Session("aliasusuario") = ""
        Session("nivel") = ""
        Me.Response.Redirect("default.aspx")

    End Sub

End Class

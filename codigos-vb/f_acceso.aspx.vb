
'DECLARACION DE CLASES
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration.ConfigurationManager
Imports System.Data.Odbc

Partial Class f_acceso
    Inherits System.Web.UI.Page

    Dim conexion As New SqlConnection(ConnectionStrings("UGBSIGConnectionString").ConnectionString)

    Protected Sub ENTRAR_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ENTRAR.Click

        'DECLARACION DE VARIABLES
        Dim usuario As String = Me.Txtusuario.Text.Trim
        Dim clave As String = Me.Txtclave.Text.Trim

        Dim ds_acceso As New Data.DataSet("acceso")
        Dim cm_acceso As New SqlDataAdapter("SELECT * FROM t_usuario WHERE aliasusuario = '" & usuario & "' AND pasword = '" & clave & "' ", conexion)
        cm_acceso.Fill(ds_acceso, "acceso")

        If ds_acceso.Tables("acceso").Rows.Count > 0 Then

            'DETERMINAR EL TIPO DE USUARIO
            Dim ds_tipo As New DataSet("tipo_usuario")
            Dim cm_tipo As New SqlDataAdapter("SELECT nomusuario, aliasusuario, nivel FROM t_usuario WHERE aliasusuario = '" & usuario & "' ", conexion)
            cm_tipo.Fill(ds_tipo, "tipo_usuario")

            Dim nivel_usuario As String


            Try

                Session("nomusuario") = ds_tipo.Tables("tipo_usuario").Rows(0).Item(0).ToString
                Session("aliasusuario") = ds_tipo.Tables("tipo_usuario").Rows(0).Item(1).ToString
                Session("nivel") = ds_tipo.Tables("tipo_usuario").Rows(0).Item(2).ToString


                nivel_usuario = ds_tipo.Tables("tipo_usuario").Rows(0).Item(2).ToString

            Catch ex As Exception

                nivel_usuario = "0"

            End Try

            If nivel_usuario = "1" Then
                'Session("Nivel") = "1"
                'Me.pnl_acceso.Visible = False
                'Me.pnl_entrar.Visible = True
                'Me.imgbienvenido.ImageUrl = "~/Imagenes/administrador.jpg

                'Dim alerta1 As String = "<script language='JavaScript'> alert('Bienvenido...administrador');</script>"
                'ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta1)
                'Return

                Response.Redirect("~/f_acceso_index.aspx")


            ElseIf nivel_usuario = "2" Then
                'Session("Nivel") = "2"
                'Me.pnl_acceso.Visible = False
                'Me.pnl_entrar.Visible = True
                'Me.imgbienvenido.ImageUrl = "~/Imagenes/docente.jpg"

                'Dim alerta2 As String = "<script language='JavaScript'> alert('Bienvenido...docente');</script>"
                'ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta2)
                'Return

                Response.Redirect("~/f_acceso_index.aspx")

            ElseIf nivel_usuario = "3" Then
                'Session("Nivel") = "3"
                'Me.pnl_acceso.Visible = False
                'Me.pnl_entrar.Visible = True
                'Me.imgbienvenido.ImageUrl = "~/Imagenes/estudiante.jpg"

                'Dim alerta3 As String = "<script language='JavaScript'> alert('Bienvenido...estudiante');</script>"
                'ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta3)
                'Return

                Response.Redirect("~/f_acceso_index.aspx")

            ElseIf nivel_usuario = "4" Then
                'Session("Nivel") = "4"
                'Session("name") = usuario
                'Me.pnl_acceso.Visible = False
                'Me.pnl_entrar.Visible = True
                'Me.imgbienvenido.ImageUrl = "~/Imagenes/visitante.jpg"

                'Dim alerta4 As String = "<script language='JavaScript'> alert('Bienvenido...visitante');</script>"
                'ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta4)
                'Return

                Response.Redirect("~/f_acceso_index.aspx")

            Else
                Dim alerta5 As String = "<script language='JavaScript'> alert('Parece que sus datos estan dañados, contacte al administrador');</script>"
                ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta5)
                Return
            End If

            'DETERMINAR EL TIPO DE USUARIO
        Else
            Dim alerta6 As String = "<script language='JavaScript'> alert('Lon datos ingresados no están registrados');</script>"
            ClientScript.RegisterStartupScript(GetType(String), "AlertScript", alerta6)
            Return
        End If
    End Sub

End Class

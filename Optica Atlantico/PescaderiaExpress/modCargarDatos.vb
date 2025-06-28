Imports System.Data.SqlClient

Module modCargarDatos
    Public NomOptica As String
    Private ReadOnly cadenaConexion As String = "TU_CADENA_CONEXION_AQUÍ"

    ''' <summary>
    ''' Carga los detalles de una compra desde el procedimiento almacenado.
    ''' </summary>
    ''' <param name="idOrdan">El ID de la compra a consultar</param>
    ''' <param name="dtResultado">DataTable donde se devolverán los datos</param>
    ''' <param name="mensajeError">Mensaje de error en caso de excepción</param>
    ''' <returns>True si se cargaron datos correctamente, False si ocurrió algún error</returns>
    Public Function ObtenerDatosCompraPorID(idOrdan As Integer, ByRef dtResultado As DataTable, ByRef mensajeError As String) As Boolean
        mensajeError = ""
        dtResultado = New DataTable()
        If Conectar() Then
            Try
                Using cmd As New SqlCommand("PObtenerDetalleCompra", CNN)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@idOrden", SqlDbType.Int).Value = idOrdan

                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dtResultado)
                    End Using
                End Using

                Return dtResultado.Rows.Count > 0

            Catch ex As Exception
                mensajeError = "Error al obtener los datos: " & ex.Message
                Return False
            End Try
        End If
        Return dtResultado.Rows.Count > 0
    End Function

    Public Sub CargarDatos(NumOptica As Integer)
        Try
            If Conectar() Then
                Using cmd As New SqlCommand("dbo.RefrescarPagosConConcepto", CNN)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Modo", SqlDbType.Int).Value = NumOptica
                    cmd.ExecuteNonQuery()
                    Desconectar()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ObtenerNombreOptica(ByVal idOptica) As Integer
        Dim valor As Integer
        Try
            If Conectar() Then
                Using cmd As New SqlCommand("SELECT Sucursal FROM TEmpresa WHERE idEmpresa = @idOptica", CNN)
                    cmd.Parameters.AddWithValue("@idOptica", idOptica)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        valor = CInt(OptenerNumeroOptica(reader("Sucursal").ToString()))
                        NomOptica = reader("Sucursal").ToString()
                        Desconectar()
                        Return valor
                    End If
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return valor
        End Try
        Return valor
    End Function

    Private Function OptenerNumeroOptica(nombre As String) As Integer
        Select Case nombre.Trim().ToUpper()
            Case "ATLANTICO I" : OptenerNumeroOptica = 1
            Case "ATLANTICO II" : OptenerNumeroOptica = 1
            Case "ATLANTICO III" : OptenerNumeroOptica = 1
            Case "ATLANTICO IV" : OptenerNumeroOptica = 1
            Case "ATLANTICO V" : OptenerNumeroOptica = 1
            Case "ATLANTICO VI" : OptenerNumeroOptica = 1
            Case "ATLANTICO III." : OptenerNumeroOptica = 0
        End Select
        Return OptenerNumeroOptica
    End Function

End Module

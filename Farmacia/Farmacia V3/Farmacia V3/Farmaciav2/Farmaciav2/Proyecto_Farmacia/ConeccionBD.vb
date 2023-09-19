Imports System.Data.SqlClient
Module ConeccionBD

    Public CONECCION As New SqlConnection
    Public Sub Abrir_BaseDato()
        CONECCION.ConnectionString = "Server=DESKTOP-I3PK5B7;Database=Facturacion_Farmacia;User=sa;Password=123"
        CONECCION.Open()
    End Sub

    Public Sub Cerrar_BaseDato()
        CONECCION.Close()
    End Sub



End Module
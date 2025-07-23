# Script: CargarPagosDia.ps1
# Ejecuta spInicializarPagosDia cada vez que Windows inicia

$server   = ".\SQLEXPRESS"           # ← nombre del servidor (ej. localhost\SQLEXPRESS)
$database = "BDOptica2"          # ← nombre de la base donde está el procedimiento

$connectionString = "Server=$server;Database=$database;Trusted_Connection=True;"
$conexion = New-Object System.Data.SqlClient.SqlConnection
$conexion.ConnectionString = $connectionString
$conexion.Open()

$comando = $conexion.CreateCommand()
$comando.CommandText = "EXEC dbo.spInicializarPagosDia;"
$comando.ExecuteNonQuery()

$conexion.Close()
Write-Host "✅ Carga ejecutada correctamente desde PowerShell"

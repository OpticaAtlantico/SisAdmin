# CargarPagosDia.ps1
# Ejecuta spInicializarPagosDia y muestra confirmación visual

$server   = ".\SQLEXPRESS"                   # ← ajusta tu instancia
$database = "BDOptica2"                  # ← nombre de la base

$connectionString = "Server=$server;Database=$database;Trusted_Connection=True;"
$conexion = New-Object System.Data.SqlClient.SqlConnection
$conexion.ConnectionString = $connectionString

Try {
    $conexion.Open()
    $comando = $conexion.CreateCommand()
    $comando.CommandText = "EXEC dbo.spInicializarPagosDiaInteligente;"
    $comando.CommandTimeout = 300
    $comando.ExecuteNonQuery()
    $conexion.Close()

    $hora = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    Write-Host "Carga de pagos completada exitosamente."
    Write-Host "Fecha y hora de ejecución: $hora"
} 
Catch {
    Write-Host "Error al ejecutar la carga:"
    Write-Host $_.Exception.Message
}

Write-Host "Presiona ENTER para cerrar esta ventana..."
Read-Host


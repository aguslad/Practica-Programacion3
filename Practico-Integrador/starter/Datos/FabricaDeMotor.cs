namespace starter.Datos;

public static class FabricaDeMotor
{
    public static IAccesoDatos Crear(Motor motor)
    {
        switch (motor)
        {
            case Motor.PostgreSql:
                return new AccesoPostgres();
            case Motor.SqlServer:
                return new AccesoSqlServer();
            case Motor.MySql:
                return new AccesoMySql();
            default:
                throw new ArgumentException("Motor no soportado");
        }
    }
}
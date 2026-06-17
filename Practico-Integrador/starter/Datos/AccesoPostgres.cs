using Npgsql;
using Spectre.Console;
using starter.Dominio;

public class AccesoPostgres : IAccesoDatos
{
    private const string cadenaConexion =
    "Host=localhost;Port=5432;Database=practico;Username=postgres;Password=postgres";

    public void CrearEstructura()
    {
        Console.WriteLine("\n===== MOTOR: PostgreSQL =====\n");

        Console.WriteLine("\nRF2 — Crear estructura");

        const string cadenaAdmin =
        "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres";

        using (var connBD = new NpgsqlConnection(cadenaAdmin))
        {
            connBD.Open();

            var cmdBD = connBD.CreateCommand();

            cmdBD.CommandText = """
            SELECT COUNT(*)
            FROM pg_database
            WHERE datname = 'practico';
            """;

            int existe = Convert.ToInt32(cmdBD.ExecuteScalar());

            if (existe == 0)
            {
                cmdBD.CommandText = "CREATE DATABASE practico;";
                cmdBD.ExecuteNonQuery();

                Console.WriteLine("Base de datos 'practico' creada.");
            }
        }

        using var conn = new NpgsqlConnection(cadenaConexion);

        conn.Open();

        var cmd = conn.CreateCommand();

        cmd.CommandText = """
        DROP TABLE IF EXISTS Detalle_pedido;
        DROP TABLE IF EXISTS Pedidos;
        DROP TABLE IF EXISTS Productos;
        DROP TABLE IF EXISTS Clientes;
        DROP TABLE IF EXISTS Categorias;

        CREATE TABLE Categorias (
            Id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
            Nombre VARCHAR(100)
        );

        CREATE TABLE Productos (
            Id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
            Nombre VARCHAR(100),
            Precio DECIMAL(10,2),
            Stock INTEGER,
            Categoria_id INTEGER REFERENCES Categorias(Id)
        );

        CREATE TABLE Clientes (
            Id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
            Nombre VARCHAR(100),
            Email VARCHAR(100)
        );

        CREATE TABLE Pedidos (
            Id INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
            Cliente_id INTEGER REFERENCES Clientes(Id),
            Fecha DATE
        );

        CREATE TABLE Detalle_pedido (
            Pedido_id INTEGER REFERENCES Pedidos(Id),
            Producto_id INTEGER REFERENCES Productos(Id),
            Cantidad INTEGER,
            Precio_unitario DECIMAL(10,2),
            PRIMARY KEY (Pedido_id, Producto_id)
        );
        """;

        cmd.ExecuteNonQuery();

        Console.WriteLine("\nBase 'practico' creada.\n");
        Console.WriteLine("Estructura (5 tablas) creada correctamente.\n");
    }


    public void InsertarDatosPrueba()
    {
        Console.WriteLine("RF3 — Insertar datos de prueba\n");

        using var conn = new NpgsqlConnection(cadenaConexion);

        conn.Open();

        using var tx = conn.BeginTransaction();

        var cmd = conn.CreateCommand();
        cmd.Transaction = tx;

        try
        {

            cmd.CommandText = """
               INSERT INTO Categorias(nombre)
               VALUES(@nombreCat)
               RETURNING id;
         """;

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreCat", "Electrónica");

        int categoriaElectronica = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreCat", "Ropa");

        int categoriaRopa = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreCat", "Hogar");

        int categoriaHogar = Convert.ToInt32(cmd.ExecuteScalar());


        cmd.CommandText = """
               INSERT INTO Productos
               (nombre, precio, stock, categoria_id)
               VALUES
               (@nombreProd, @precio, @stock, @categoriaId)
               RETURNING id;
         """;

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreProd", "Laptop");
        cmd.Parameters.AddWithValue("@precio", 1500000.00m);
        cmd.Parameters.AddWithValue("@stock", 10);
        cmd.Parameters.AddWithValue("@categoriaId", categoriaElectronica);

        int idLaptop = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreProd", "Remera");
        cmd.Parameters.AddWithValue("@precio", 30000.00m);
        cmd.Parameters.AddWithValue("@stock", 50);
        cmd.Parameters.AddWithValue("@categoriaId", categoriaRopa);

        int idRemera = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear(); 
        cmd.Parameters.AddWithValue("@nombreProd", "Sillón");
        cmd.Parameters.AddWithValue("@precio", 500000.00m);
        cmd.Parameters.AddWithValue("@stock", 5);
        cmd.Parameters.AddWithValue("@categoriaId", categoriaHogar);

        int idSillon = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreProd", "Smartphone");
        cmd.Parameters.AddWithValue("@precio", 800000.00m);
        cmd.Parameters.AddWithValue("@stock", 20);
        cmd.Parameters.AddWithValue("@categoriaId", categoriaElectronica);

        int idSmartphone = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreProd", "Pantalón");
        cmd.Parameters.AddWithValue("@precio", 40000.00m);
        cmd.Parameters.AddWithValue("@stock", 30);
        cmd.Parameters.AddWithValue("@categoriaId", categoriaRopa);

        int idPantalon = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.CommandText = """
               INSERT INTO Clientes(nombre, email)
               VALUES(@nombreCliente, @email)
               RETURNING id;
         """;
        
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreCliente", "Juan Pérez");
        cmd.Parameters.AddWithValue("@email", "juan.perez@outlook.com");

        int idCliente = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@nombreCliente", "María Gómez");
        cmd.Parameters.AddWithValue("@email", "maria.gomez@outlook.com");

        int idCliente2 = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.CommandText = """
               INSERT INTO Pedidos(cliente_id, fecha)
               VALUES(@clienteId, @fecha)
               RETURNING id;
         """;
        
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@clienteId", idCliente);
        cmd.Parameters.AddWithValue("@fecha", DateTime.Today);

        int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@clienteId", idCliente2);
        cmd.Parameters.AddWithValue("@fecha", DateTime.Today);

        int idPedido2 = Convert.ToInt32(cmd.ExecuteScalar());

        cmd.CommandText = """
               INSERT INTO Detalle_pedido(pedido_id, producto_id, cantidad, precio_unitario)
               VALUES(@pedidoId, @productoId, @cantidad, @precioUnitario)
         """;

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@pedidoId", idPedido);
        cmd.Parameters.AddWithValue("@productoId", idLaptop);
        cmd.Parameters.AddWithValue("@cantidad", 1);
        cmd.Parameters.AddWithValue("@precioUnitario", 1500000.00m);

        cmd.ExecuteNonQuery();

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@pedidoId", idPedido);
        cmd.Parameters.AddWithValue("@productoId", idSillon);
        cmd.Parameters.AddWithValue("@cantidad", 1);
        cmd.Parameters.AddWithValue("@precioUnitario", 500000.00m);

        cmd.ExecuteNonQuery();

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@pedidoId", idPedido2);
        cmd.Parameters.AddWithValue("@productoId", idRemera);
        cmd.Parameters.AddWithValue("@cantidad", 5);
        cmd.Parameters.AddWithValue("@precioUnitario", 30000.00m);

        cmd.ExecuteNonQuery();

        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@pedidoId", idPedido2);
        cmd.Parameters.AddWithValue("@productoId", idPantalon);
        cmd.Parameters.AddWithValue("@cantidad", 3);
        cmd.Parameters.AddWithValue("@precioUnitario", 40000.00m);

        cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@pedidoId", idPedido2);
            cmd.Parameters.AddWithValue("@productoId", idSmartphone);
            cmd.Parameters.AddWithValue("@cantidad", 1);
            cmd.Parameters.AddWithValue("@precioUnitario", 800000.00m);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Datos de prueba insertados correctamente.\n");

            tx.Commit();
        }
        catch
        {
            tx.Rollback();
            throw;
        }


    }

    public void EjecutarOperaciones()
    {
        Console.WriteLine("RF4 — Ejecutar operaciones (C1, C2, U1, D1)");
        using var conn = new NpgsqlConnection(cadenaConexion);

        conn.Open();

        using var tx = conn.BeginTransaction();

        var cmd = conn.CreateCommand();
        cmd.Transaction = tx;

        try
        {
            // C1
            cmd.CommandText = """
            SELECT p.id, p.nombre, p.precio, p.stock, p.categoria_id, c.nombre
            FROM Productos p
            INNER JOIN Categorias c ON p.categoria_id = c.id
            """;

            using var reader = cmd.ExecuteReader();
            var tablaC1 = new Table();
            Console.WriteLine("\n[C1] Productos con su categoría: \n");
            tablaC1.AddColumn("Producto");
            tablaC1.AddColumn("Categoría");

            while (reader.Read())
            {
                Producto prod = new Producto
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Precio = reader.GetDecimal(2),
                    Stock = reader.GetInt32(3),
                    CategoriaId = reader.GetInt32(4)
                };

                string nombreCategoria = reader.GetString(5);

                tablaC1.AddRow(prod.Nombre, nombreCategoria);
            }
            reader.Close();

            AnsiConsole.Write(tablaC1);
            Console.WriteLine();

            // C2
            cmd.CommandText = """
            SELECT 
                p.id, 
                p.fecha, 
                pr.id AS producto_id,
                pr.nombre AS producto_nombre, 
                dp.cantidad, 
                dp.precio_unitario, 
                (dp.cantidad * dp.precio_unitario) AS subtotal
            FROM Pedidos p
            INNER JOIN Detalle_pedido dp ON p.id = dp.pedido_id
            INNER JOIN Productos pr ON dp.producto_id = pr.id
            ORDER BY p.id, pr.nombre;
            """;

            using var reader2 = cmd.ExecuteReader();

            int? pedidoActualId = null;
            Table tablaPedido = null;
            decimal totalPedido = 0;

            while (reader2.Read())
            {
                // 1. MAPEO MANUAL: Cargamos la entidad intermedia de Dominio
                DetallePedido detalle = new DetallePedido
                {
                    PedidoId = reader2.GetInt32(0),
                    ProductoId = reader2.GetInt32(2),
                    Cantidad = reader2.GetInt32(4),
                    PrecioUnitario = reader2.GetDecimal(5)
                };

                // Variables auxiliares que no pertenecen a la tabla intermedia
                string fecha = reader2.GetDateTime(1).ToString("dd/MM/yyyy");
                string nombreProducto = reader2.GetString(3) ?? "";
                decimal subtotal = reader2.GetDecimal(6);

                if (pedidoActualId != detalle.PedidoId)
                {
                    if (tablaPedido != null)
                    {
                        tablaPedido!.AddRow("", "TOTAL DEL PEDIDO", "", "", totalPedido.ToString("C2"));
                        AnsiConsole.Write(tablaPedido);
                        Console.WriteLine();
                    }

                    totalPedido = 0;
                    pedidoActualId = detalle.PedidoId;

                    tablaPedido = new Table();
                    tablaPedido.Title($"=== COMPROBANTE DE PEDIDO #{detalle.PedidoId} ({fecha}) ===\n");
                    tablaPedido.AddColumn("Nº Pedido");
                    tablaPedido.AddColumn("Producto");
                    tablaPedido.AddColumn(new TableColumn("Cantidad").RightAligned());
                    tablaPedido.AddColumn(new TableColumn("Precio Unit.").RightAligned());
                    tablaPedido.AddColumn(new TableColumn("Subtotal").RightAligned());
                }

                totalPedido += subtotal;

                // 2. Cargamos la fila usando las propiedades del objeto mapeado
                tablaPedido.AddRow(
                    $"#{detalle.PedidoId}",
                    nombreProducto,
                    detalle.Cantidad.ToString(),
                    detalle.PrecioUnitario.ToString("C2"),
                    subtotal.ToString("C2")
                );
            }

            if (tablaPedido != null)
            {
                tablaPedido.AddRow("", "TOTAL DEL PEDIDO", "", "", totalPedido.ToString("C2"));
                AnsiConsole.Write(tablaPedido);
                Console.WriteLine();
            }

            reader2.Close();

            // U1
            cmd.CommandText = """
             UPDATE Productos
             SET precio = precio * @porcentaje
             WHERE categoria_id = @categoria
             """;

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@porcentaje", 1.10m);
            cmd.Parameters.AddWithValue("@categoria", 1);

            int filas = cmd.ExecuteNonQuery();

            Console.WriteLine($"[U1] Se subió un 10% precios de categoría #1 ->  {filas} cambio(s) realizado(s)");

            // D1
            cmd.Parameters.Clear();
            cmd.CommandText = """
            DELETE FROM Detalle_pedido
            WHERE pedido_id = 1
            AND producto_id = 1
            """;

            int filasEliminadas = cmd.ExecuteNonQuery();

            Console.WriteLine($"\n[D1] Se eliminó el producto 1 del pedido 1 -> {filasEliminadas} fila(s) eliminada(s).");

            Console.WriteLine("\nOperaciones ejecutadas (Commit).\n");

            tx.Commit();
        }
        catch
        {
            tx.Rollback();
            throw;
        }
    }

    public void DemostrarRollback()
    {
        using var conn = new NpgsqlConnection(cadenaConexion);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = """
                  SELECT precio
                  FROM Productos
                  WHERE id = 1
                 """;

        decimal precioOriginal = Convert.ToDecimal(cmd.ExecuteScalar());

        // Modificado según la imagen (se fuerza el formato con dos decimales F2)
        Console.WriteLine($"\nRF5 – Demostrar rollback");
        Console.WriteLine($"  Precio del producto #1 ANTES: ${precioOriginal:F2}");

        using var tx = conn.BeginTransaction();

        cmd.Transaction = tx;

        try
        {
            cmd.CommandText = """
                  UPDATE Productos
                  SET precio = precio + 1000
                  WHERE id = 1
                 """;

            cmd.ExecuteNonQuery();

            Console.WriteLine("  UPDATE aplicado (precio -> 1) dentro de la transacción.");

            throw new Exception("Algo salió mal.");

            tx.Commit();
        }
        catch (Exception ex)
        {
            tx.Rollback();
            Console.WriteLine($"  Excepción capturada -> ROLLBACK. ({ex.Message})");
        }

        cmd.Transaction = null;

        cmd.CommandText = """
                  SELECT precio
                  FROM Productos
                  WHERE id = 1
                  """;

        decimal precioFinal = Convert.ToDecimal(cmd.ExecuteScalar());

        Console.WriteLine($"  Precio del producto #1 DESPUÉS: ${precioFinal:F2}");

        if (precioOriginal == precioFinal)
        {
            Console.WriteLine("  El rollback funcionó, el dato NO cambió.");
        }
        else
        {
            Console.WriteLine("  Error: el dato cambió. El rollback falló.");
        }

        Console.WriteLine("\n===== FIN (PostgreSQL) =====\n");
    }
}
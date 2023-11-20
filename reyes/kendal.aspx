<!DOCTYPE html>
<html>
<head>
    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>
</head>
<body>

<h2>Reparaciones</h2>
<table>
    <tr>
        <th>ReparacionID</th>
        <th>EquipolD</th>
        <th>Fecha Solicitud</th>
        <th>Estado</th>
        <th>Fecha Inicic</th>
        <th>Fecha Fin</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

<h2>Detalles de Reparaciones</h2>
<table>
    <tr>
        <th>Detalle D</th>
        <th>ReparacionID</th>
        <th>Descripcion</th>
        <th>Fecha y hora</th>
        <th>Texto 15, Unico</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

<h2>Asignaciones</h2>
<table>
    <tr>
        <th>acionit</th>
        <th>ReparacionID</th>
        <th>TecnicolD</th>
        <th>FechaAsignacic</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

<h2>Equipos</h2>
<table>
    <tr>
        <th>EquipolD</th>
        <th>Tipo Equipo</th>
        <th>Modelo</th>
        <th>Usuario ID</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

<h2>Usuarios</h2>
<table>
    <tr>
        <th>Entero, identitdad</th>
        <th>Fecha y hora</th>
        <th>Char 1</th>
        <th>Usuario ID</th>
        <th>Nombre</th>
        <th>Correo Electronico</th>
        <th>Telefono</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

<h2>Tecnicos</h2>
<table>
    <tr>
        <th>TecnicolD</th>
        <th>Nombre</th>
        <th>Especialidad</th>
    </tr>
    <!-- Rellenar con registros -->
</table>

</body>
</html>
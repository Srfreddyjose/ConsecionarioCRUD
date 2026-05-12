# 🚀 Configuración de Entity Framework Core

## 📦 Instalación de paquetes NuGet

Para que el proyecto funcione correctamente con **Entity Framework Core** y SQL Server, **es obligatorio** instalar los siguientes paquetes en tu proyecto de Visual Studio.

### Pasos en Visual Studio:

1. Abre el **Administrador de paquetes NuGet**:
   - `Herramientas` → `Administrador de paquetes NuGet` → `Administrar paquetes NuGet para la solución`

2. Busca e **instala** los siguientes paquetes (versión estable más reciente):

| Paquete                                      | Descripción                          |
|----------------------------------------------|--------------------------------------|
| `Microsoft.EntityFrameworkCore`              | Núcleo de EF Core                    |
| `Microsoft.EntityFrameworkCore.SqlServer`    | Proveedor de SQL Server              |
| `Microsoft.EntityFrameworkCore.Tools`        | Herramientas de migraciones (PMC)    |
| `Microsoft.EntityFrameworkCore.Design`       | Soporte de diseño y scaffolding      |

> **Importante**: Instala todos los paquetes en el mismo proyecto donde está tu `DbContext`.

---

## 🛠️ Ejecución de Migraciones

Una vez instalados los paquetes, abre la **Consola del Administrador de Paquetes** de Visual Studio y ejecuta los siguientes comandos **en orden**:

### 1. Crear la migración inicial
`Add-Migration Initial`

### 2. Aplica la migracion de la base de datos
`Update-Database`

## ✅ Verificación
Después de ejecutar Update-Database:

Deberías ver la base de datos creada en SQL Server.
En tu proyecto aparecerá la carpeta Migrations con los archivos de migración.

¿Problemas comunes?

Si te sale el error "No se puede encontrar el comando Add-Migration", asegúrate de haber instalado Microsoft.EntityFrameworkCore.Tools.
Asegúrate de que el proyecto de inicio esté seleccionado en la Consola del Administrador de Paquetes.

¡Listo! Ya tienes Entity Framework Core configurado correctamente en tu proyecto. 🔥

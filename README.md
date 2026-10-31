# Empresa – Sistema de Gestión de Empleados por Departamento
 
Aplicación web ASP.NET Core MVC (.NET 10) con Entity Framework Core y SQL Server para registrar departamentos y los empleados que pertenecen a cada uno (relación uno a muchos).
 
**Grupo 5** · Entidad principal: `Departamento` · Entidad dependiente: `Empleado`.

**Video demostrativo** · https://www.youtube.com/watch?v=SZbq4NpX14Y.
 
## Integrantes
 
| Integrante | Usuario GitHub | Entidad desarrollada |
|---|---|---|
| Santiago Ortega | SantiOrtega125 | Empleado: creación del proyecto y CRUD inicial (Fase 1) |
| Brayan Mendoza | skyshoto | Empleado: validaciones con DataAnnotations (Fase 2) y corrección del formulario de edición |
| Claudio Villalba | cdvillalba2 | Departamento: entidad, relación con Empleado y CRUD (Fase 3) |
| Milton Yuxi | MiltonYuxi | Departamento–Empleado: corrección de las vistas de la relación |
| Nicolás Neira | Niclik05 | Menú principal: diseño y pruebas de funcionamiento |
 
## Entidades
 
- **Departamento**: `Id`, `Nombre` (obligatorio), `Ubicacion` (opcional) y la colección `Empleados`.
- **Empleado**: `Id`, `Nombre`, `Cargo`, `Edad` y la clave foránea `DepartamentoId`.
## Requisitos
 
- Visual Studio con el SDK de .NET 10
- SQL Server Express con la instancia `SQLEXPRESS`
- SQL Server Management Studio (opcional, para revisar la base de datos)
## Pasos para ejecutar el proyecto
 
### 1. Clonar el repositorio
 
```
git clone https://github.com/SantiOrtega125/Empresa_Grupo5.git
```
 
Abrir la solución `Empresa.slnx` en Visual Studio.
 
### 2. Revisar la cadena de conexión
 
En `Empresa/appsettings.json`:
 
```json
"ConnectionStrings": {
  "EmpresaContext": "Server=localhost\\SQLEXPRESS;Database=EmpresaABD;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
}
```
 
Si el nombre de la instancia de SQL Server es distinto, cambiar el valor de `Server`.
 
### 3. Crear la base de datos
 
Abrir **Herramientas → Administrador de paquetes NuGet → Consola del Administrador de paquetes** y ejecutar:
 
```
Update-Database
```
 
Esto crea la base `EmpresaABD` y aplica las migraciones `CreacionInicial`, `ValidacionesEmpleado` y `AgregarDepartamento`.
 
### 4. Ejecutar
 
Presionar **F5**. Desde el menú principal se accede a **Departamentos** y **Empleados**.
 
Primero se debe crear al menos un departamento, porque cada empleado tiene que pertenecer a uno.

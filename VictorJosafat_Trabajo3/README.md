# APP Grafica de Empleados y Departamentos

## Descripción del Proyecto
Este proyecto es una aplicación gráfica desarrollada en C# utilizando Windows Forms. La aplicación permite gestionar empleados y departamentos, proporcionando una interfaz intuitiva para agregar, editar y eliminar registros. Además, se implementan funcionalidades para visualizar la relación entre empleados y departamentos, facilitando la administración de recursos humanos.

Fue utilizado XAMPP para la gestión de la base de datos MySQL, lo que permitió una integración eficiente entre la aplicación y la base de datos. La aplicación se estructura en varias carpetas para organizar el código de manera clara y modular.

## Características Principales
- Gestión de Empleados: Permite agregar, editar y eliminar empleados, incluyendo detalles como nombre, apellido, departamento asignado y fecha de contratación.
- Gestión de Departamentos: Permite crear, modificar y eliminar departamentos, así como asignar empleados a cada departamento.
- Visualización de Relaciones: Proporciona una vista clara de la relación entre empleados y departamentos, facilitando la toma de decisiones.

## Carpetas y Archivos
- Data: Método de acceso a datos, incluyendo la conexión a la base de datos y las operaciones CRUD para empleados y departamentos.
- Forms: Contiene los formularios de la aplicación, incluyendo el formulario principal y los formularios para agregar/editar empleados y departamentos.
- Models: Contiene las clases que representan las entidades de la aplicación, como Empleado y Departamento.

## Para Ejecutar el Proyecto
1. Asegúrate de tener instalado XAMPP y MySQL.
2. Crea la base de datos y las tablas necesarias utilizando el script SQL proporcionado - 
   Tambien puedes hacer uso del archivo dept_emp_db.sql en la carpeta principal.

### Creación de la Base de Datos
Para crear la base de datos, se puede utilizar el siguiente script SQL:
```
CREATE TABLE Departamento (
    codigo INT PRIMARY KEY,
    nombre_depto VARCHAR(100)
);

CREATE TABLE Empleado (
    rut VARCHAR(12) PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    sueldo DECIMAL(10,2),
    codigo_depto INT,
    FOREIGN KEY (codigo_depto) REFERENCES Departamento(codigo)
);
```
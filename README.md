# 🛠️ Proyecto: Login para Usuarios - Maquinarias GAQ

## 📋 Descripción
Este proyecto consiste en la implementación de un sistema de autenticación de usuarios para la Pyme Maquinarias GAQ, utilizando Windows Forms en .NET Framework con base de datos SQL Server. Su objetivo es permitir un acceso seguro mediante validación de credenciales, control de intentos fallidos y bloqueo temporal de cuentas.

## 🧱 Arquitectura
El sistema está estructurado en **cuatro capas**:

- **CapaPresentacion**: Interfaz gráfica (formulario de login)
- **CapaNegocio**: Lógica de negocio (`UsuarioBO.cs`)
- **CapaDatos**: Acceso a datos (`UsuarioDAO.cs`, `Conexion.cs`)
- **CapaEntidades**: Modelo de datos (`Usuario.cs`)

## 🧩 Funcionalidades
- Inicio de sesión con validación de campos vacíos y formato RUT.
- Verificación de credenciales contra base de datos SQL Server.
- Control de intentos fallidos: máximo 4 intentos antes de bloquear.
- Bloqueo temporal de 1 hora en caso de intentos fallidos excesivos.
- Mensajes personalizados según el resultado de la autenticación.
- Validaciones de contraseña con fuerza mínima.

## 🛡️ Seguridad
- Contraseñas almacenadas con **SHA-256** (HASHBYTES).
- Validaciones en front-end y control en procedimientos almacenados.

## 💽 Base de Datos
Ubicada en el archivo `maquinarias_gaq.sql`, contiene:
- Tablas: `USUARIO`, `PERFIL`, `HISTORIAL_REGISTRO`
- Procedimientos:
  - `registrar_usuario`
  - `cambiar_rol_a_admin`
  - `autenticar_usuario`
  - `desbloquear_cuenta`

## 🖥️ Requisitos del sistema
- Visual Studio 2019 o superior
- SQL Server Express
- .NET Framework 4.7.2

## ▶️ Cómo ejecutar
1. Restaurar la base de datos ejecutando `maquinarias_gaq.sql` en SSMS.
2. Abrir la solución `LoginMaquinariasGAQ.sln` en Visual Studio.
3. Establecer `CapaPresentacion` como proyecto de inicio.
4. Ejecutar el formulario y probar el login.

## 📂 Estructura del repositorio
```
LoginMaquinariasGAQ/
├── CapaPresentacion/
│   └── frmLogin.cs
├── CapaNegocio/
│   └── UsuarioBO.cs
├── CapaDatos/
│   ├── UsuarioDAO.cs
│   └── Conexion.cs
├── CapaEntidades/
│   └── Usuario.cs
├── maquinarias_gaq.sql
└── LoginMaquinariasGAQ.sln
```



## 📄 Licencia
Este proyecto fue desarrollado como actividad académica para Taller de Programación - Semana 8, AIEP 2024.

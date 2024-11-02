<h1 align="left">Presstank</h1>
 <p align="left">
   <img src="https://img.shields.io/badge/STATUS-EN%20DESAROLLO-green">
   <img src="https://img.shields.io/github/stars/iamjuaness/Presstank?color=orange">
	  <img src="https://img.shields.io/github/last-commit/iamjuaness/Presstank?style=default&logo=git&logoColor=white&color=orange" alt="last-commit">
  	<img src="https://img.shields.io/github/languages/top/iamjuaness/Presstank?style=default&color=orange" alt="repo-top-language">
	  <img src="https://img.shields.io/github/languages/count/iamjuaness/Presstank?style=default&color=orange" alt="repo-language-count">
 </p>

 <h1 align="left">
  🚧 Proyecto en construcción 🚧</h1>
   <p></p>

## 📝 Descripción del proyecto
<p>
El proyecto consiste en el desarrollo de un sistema de préstamos de dinero para empleados de una empresa con múltiples sucursales. Este sistema está diseñado para facilitar la gestión de solicitudes de préstamo, aprobación, desembolso y pago de cuotas, proporcionando una solución eficiente y accesible para los empleados que deseen acceder a financiamiento.
</p>

## 🏁 Objetivos del Proyecto
- **Facilitar el Proceso de Préstamos:**
  - Permitir a los empleados solicitar préstamos de manera simple y rápida a través de una interfaz amigable.
- **Gestión Eficiente de Solicitudes:**
  - Proporcionar a los empleados de tesorería las herramientas necesarias para evaluar y gestionar las solicitudes de manera efectiva.
- **Control de Pagos:**
  - Implementar un sistema que registre y controle los pagos de cuotas, incluyendo notificaciones para morosidad.
- **Generación de Reportes:**
  - Ofrecer reportes detallados que ayuden a la administración a analizar los préstamos otorgados, los montos pendientes y la situación financiera de los empleados.

## 🔨 Funcionalidades del proyecto
### Rol Principal:
- **Gestionar usuarios (CRUD):**
  - Crear, leer, actualizar y eliminar usuarios en el sistema.
  - Asignar niveles de acceso (Rol Principal, Tesorería, Empleado).
- **Auditar accesos:**
  - Ver el historial de entrada y salida de todos los usuarios del sistema a través de la bitácora de auditoría.
- **Gestionar sucursales y empleados (CRUD):**
  - Crear, leer, actualizar y eliminar sucursales.
  - Administrar empleados asignados a las sucursales.
- **Gestión total de solicitudes y préstamos:**
  - Ver todas las solicitudes y préstamos realizados por los empleados.
  - Aprobar o rechazar cualquier solicitud de préstamo.
- **Generar reportes globales:**
  - *Generar reportes como:*
    - Total prestado por municipio.
    - Total prestado por sucursal.
    - Listado de empleados morosos y cuánto deben.

### Rol Tesorería:
- **Gestionar solicitudes de préstamos:**
  - Visualizar todas las solicitudes de préstamo pendientes de aprobación.
  - Evaluar las solicitudes basadas en el cargo del empleado y los montos solicitados.
  - Aprobar o rechazar solicitudes de préstamo según las reglas establecidas (límites de monto según cargo).
- **Gestionar préstamos (CRUD):**
  - Una vez aprobada una solicitud, generar el préstamo correspondiente.
  - Desembolsar el préstamo directamente en la cuenta del empleado el día 3 del mes siguiente.
- **Generar reportes de tesorería:**
  - *Generar reportes relacionados con:*
    - Total prestado por sucursal.
    - Total prestado por municipio.
- **Ver estado de cuentas de los empleados:**
  - Consultar el estado de los préstamos de los empleados (cuotas pendientes, pagos realizados).

### Rol Empleado:
- **Realizar solicitudes de préstamo:**
  - Crear solicitudes de préstamo desde su puesto de trabajo.
  - Definir el monto solicitado y el periodo (24, 36, 48, 60, 72 meses).
  - Consultar el estado de sus solicitudes (pendiente, en estudio, aprobada, reprobada).
- **Consultar el estado de sus préstamos:**
  - Ver el estado actual de sus préstamos: fechas de pago, número de cuotas, valor de la cuota.
- **Registrar pagos:**
  - *Una vez realizado el pago de la cuota en el banco, ingresar al sistema para registrar el pago, proporcionando:*
   - Número de préstamo.
   - Número de cuota pagada.
   - Fecha del pago.
   - Valor pagado.
- **Consultar reportes personales:**
  - Generar reportes sobre su estado de cuenta y pagos realizados.


## 🛠️ Arquitectura en Capas
- **BusinessLayer**
  - Esta capa contiene toda la lógica de negocio de la aplicación. Se encarga de procesar las reglas y operaciones necesarias para la gestión de préstamos, solicitudes, pagos y la validación de datos. Se asegura de que las reglas de negocio se apliquen correctamente al procesar las solicitudes de los usuarios y al interactuar con los datos. Esta capa actúa como intermediaria entre la capa de presentación y la capa de datos, proporcionando los servicios necesarios para la aplicación.
- **DataLayer**
  - También conocida como la capa de acceso a datos, esta capa es responsable de interactuar directamente con la base de datos. Se encarga de realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre las tablas de la base de datos. Esta capa abstrae la lógica de acceso a datos y proporciona métodos para que la capa de negocio interactúe con la base de datos de manera eficiente, asegurando que los datos se almacenen y recuperen correctamente.
- **EntityLayer**
  - La capa de entidades representa las clases que corresponden a las tablas de la base de datos. Cada entidad refleja un objeto del mundo real y encapsula los datos y comportamientos relacionados. En el contexto del sistema de préstamos, las entidades pueden incluir clases como **Empleado, Solicitud, Prestamo, Pago, y Usuario**. Esta capa define la estructura de los datos que se manejarán en la aplicación y puede incluir métodos para manipular estos datos.
- **PresentationLayer**
  - La capa de presentación es la interfaz de usuario de la aplicación. Su función es facilitar la interacción entre el usuario y el sistema. Aquí se diseñan las pantallas, formularios y menús que los usuarios utilizarán para realizar acciones como solicitar préstamos, consultar el estado de sus cuentas o generar reportes. Esta capa es responsable de capturar la entrada del usuario y mostrar la salida, actuando como un puente entre la lógica de negocio y el usuario final.

## ✔️ Tecnologías utilizadas en el Backend
- `Microsoft Visual Studio 2022`:  Microsoft Visual Studio 2022 es un entorno de desarrollo integrado avanzado y versátil.
- `C#`: C# es un lenguaje de programación orientado a objetos, desarrollado por Microsoft.
- `SQL Server`: SQL Server es un sistema de gestión de bases de datos relacional desarrollado por Microsoft.

## ✔️ Tecnologías utilizadas en el Frontend
- `.NET Framework`: .NET Framework es una plataforma de desarrollo para crear y ejecutar aplicaciones Windows.
- `FontAwesome.Sharp`: FontAwesome.Sharp es una biblioteca de iconos para aplicaciones .NET, que permite utilizar iconos de Font Awesome en aplicaciones de escritorio y web.

## 💻 Autores

| [<img src="https://avatars.githubusercontent.com/u/104481229?v=4" width=115><br><sub>Juan E. Cardona</sub>](https://github.com/iamjuaness)
| :---: |


## Contributors

<a href="https://github.com/iamjuaness/Mi-Boleta/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=iamjuaness/Presstank" />
</a>

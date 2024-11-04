Funcionalidad del Proyecto
Este proyecto consiste en una aplicación web estática que permite a los usuarios enviar consultas a través de un formulario. Los datos ingresados son almacenados en una base de datos MySQL, y se gestiona visualmente mediante phpMyAdmin. La aplicación está contenida en un entorno Docker para facilitar su despliegue y ejecución.


Instrucciones para subir un proyecto local a github
Creamos un nuevo repositorio en https://github.com. Le damos nombre, descripción, seleccionamos si va a ser un proyecto publico o privado si es el caso. Le damos a crear repositorio y con esto ya tenemos el repositorio donde alojaremos nuestro proyecto.

Desde la terminal del equipo donde esta el proyecto que queremos subir a github
Nos vamos a la carpeta del proyecto y ejecutamos estos comandos.
1- git init
2- git add .
3- git commit -m "first commit"
4- git remote add origin https://github.com/NOMBRE_USUARIO/NOMBRE_PROYECTO.git //tu url lo obtenes de la pagina GitHub del repo que creaste copiando el url
5- git push -u origin master

Instrucciones para Clonar el Repositorio
1. Abre una terminal en directorio que quieres copiar el repositorio
2. Clona el repositorio usando el siguiente comando:
git clone https://github.com/NOMBRE_USUARIO/NOMBRE_PROYECTO.git


Pasos para Levantar el Entorno con Docker
Tener docker instalado
En la terminal, dentro del directorio del proyecto, ejecuta: docker-compose up --build
 docker-compose up: Inicia contenedores existentes sin recompilar imágenes Docker.
 docker-compose up --build: Inicia contenedores y recompila imágenes Docker desde cero si no existen o han cambiado.

Accede a la pagina web en http://localhost:5000.
Accede a phpMyAdmin en http://localhost:8081 para gestionar la base de datos (credenciales: usuario root, contraseña 12345678).
Si se quiere probar la api por aparte http://localhost:5024/swagger

Descripción de las Tecnologías Utilizadas
Frontend: HTML y CSS para la interfaz de usuario.
Backend: ASP.NET Core Web Api para manejar las solicitudes y almacenar datos en MySQL.
Base de Datos: MySQL para almacenar los datos ingresados.
phpMyAdmin: Herramienta para gestionar la base de datos de forma visual.
Docker: Para contenerizar la aplicación y facilitar su despliegue.


Ejemplos de las Rutas del Backend:
POST /submit-client-data:
Descripción: Recibe los datos del formulario y los almacena en la base de datos.
Cuerpo de la Solicitud (es un json):
{
  "name": "Nombre del cliente",
  "email": "correo@ejemplo.com",
  "phone": "123456789",
  "message": "Consulta del cliente"
}

Respuesta Esperada:
Código 200: "Datos almacenados con éxito"
Código 400: "Datos inválidos" si los datos no son válidos.

PROYECTO REALIZADO POR MAXIMO OLGUIN MUÑOZ

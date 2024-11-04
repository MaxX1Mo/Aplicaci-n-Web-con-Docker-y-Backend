Antes de levantar los contenedores se debe verificar que los puertos asignados
no esten en uso.
Ademas se debe verificar que mysql no este en ejecucion localmente,
ya que el puerto que se le asigna al crear la base de datos es el puerto por defecto,
y si ya estaba en ejecucion mysql, dara error,

docker ps - Esto mostrará todos los contenedores en ejecución y sus puertos asignados

para levantar contenedores de debe abrir un terminal en el mismo nivel del docker-compose:  docker-compose up --build


docker-compose up: Inicia contenedores existentes sin recompilar imágenes Docker.
docker-compose up --build: Inicia contenedores y recompila imágenes Docker desde cero si no existen o han cambiado. Por eso lo utilizo para evitar menos problemas

esto es para reiniciar y reconstruir para cuando se haga cambios, cuando por ejemplo se cambia un puerto
docker-compose down --remove-orphans
docker-compose up --build
 docker ps -a para borrar contenedores por si da error de que ya existe

Links para verificar por separado si esta en funcion: 
http://localhost:8081   para ver el phpadmin
http://localhost:5024/swagger Acceso backend, para ver en swagger la api
http://localhost:5000 Acceso frontend, para ver la pagina
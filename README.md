#hada-p1
P1 ¿Qué rama se ha subido exactamente?
  Se sube la rama master ya que es en la que estabamos anteriormente despues de realizar el rebase.
  
P2 ¿Qué pasa al utilizar la opción Comparar con la versión no modificada?
  Muestra en verde lo añadido en la nueva version y en rojo lo que no estaba en la version anterior
  
P3 ¿Y ahora ves algún cambio en el repositorio remoto? ¿Por qué?
  No nos ha dejado insertar los cambios en remoto ya que existe un conflicto, debido a que estamos manipulando este archivo en remoto y haciendo cambios en local lo que produce un conflicto, habria que hacer un pull
  para tener lo de remoto en local y ya luego realizar el correspondiente push para subir todo
  
P4 ¿Qué significa "Confirmar todo" y cuál sería el comando git equivalente?
  El comando equivalente es 'git commit -a' y lo que hace es confirmar todos los archivos sin tener que hacer el git add
  
P5 ¿Qué significa "Confirmar todo e insertar" y cuál sería el comando git equivalente?
  El comando equivalente es 'git push' y permite insertar todo en remoto que este pendientes de actualizar en local

P6 ¿Qué significa "Confirmar todo y sincronizar" cuál sería el comando git equivalente?
  el comando equivalente es 'git pull' y permite traer de remoto los archivos que faltaban por sincronizar

P7 ¿Cuál es la diferencia entre pulsar Sincronizar o Extraer? ¿Cuáles serían los comandos git equivalentes?
  La diferencia es que sincronizar es solo con el contenido que no este actualizado en ambos sitios y extraer es bajar todo el contenido de remoto al loca
  Sincronizar->git pull
  Extraer->git fetch

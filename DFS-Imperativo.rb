#Se comienza creando una matriz que luego será la evaluada por el método
#de búsqueda de profundidad
#La matriz de adyacencia está representada de la sgte manera: 
#Cada nodo tiene un número asignado y si existe un borde entre ambos
#nodos se indica mediante un 1 y si no, con un 0

                 #Nodo 1          #Nodo 2          #Nodo 3
MatrizAdy = [0,1,1,0,0,1,1], [1,0,0,0,0,0,0], [1,0,0,0,0,0,0], 
    	      [0,0,0,0,1,1,0], [0,0,0,1,0,1,1], [1,0,0,1,1,0,0], [1,0,0,0,1,0,0]  
                 #Nodo 4          #Nodo 5          #Nodo 6         #Nodo 7

#Se le asigna el número indicado de cada uno de los nodos
Nodos = %w(0 1 2 3 4 5 6)

#Para el método de Búsqueda por profundidad lo que se debe realizar
#es iniciar la búsqueda en en nodo indicado y seguir con el nodo más cercano 
#a este en la definición del grafo o árbol, esto se hace de manera constante
#entre todos los nodos siempre tomando en cuenta que no se puede usar un
#nodo ya antes visitado durante la búsqueda

def BusquedaProfunda(nodo)
  print "#{Nodos[nodo]} "
  #Marcamos el nodo como visitado anulando la fila 
  #hasta que nos quedemos sin filas(nodos) que anular 
  borde = 0
  while MatrizAdy.size > borde
    MatrizAdy[nodo][borde] = 0
    borde = borde + 1 
  end
  # Encontramos bordes sin analizar
  borde = 0
  while borde < MatrizAdy.size
  	#identificamos si el nodo no es uno ya visitado
    if ( MatrizAdy[borde][nodo] != 0 && borde != nodo)
      BusquedaProfunda(borde)
    end
    borde = borde + 1
  end
end

#Analizamos los nodos del grafo
print "Recorrido para el nodo seleccionado"
print "\n"
#Dentro del () se pone el nodo a evaluar
BusquedaProfunda(2)
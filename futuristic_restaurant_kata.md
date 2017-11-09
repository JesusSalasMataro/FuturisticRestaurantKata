# Futuristic Restaurant Kata

## Introducci�n

El restaurante "Futuristic" prev� su inaguraci�n para mediados del a�o pr�ximo. Para entonces nos ha solicitado tener 
listo un programa de gesti�n de los clientes que acceden al local. Las mesas cuentan con un sofisticado sistema que 
detecta cuando son ocupadas por nuevos comensales. 

Cuando unos clientes ocupan una mesa el nuevo sistema debe activar el servicio de camarero: un camarero se acerca a 
la mesa, recibe a los comensales y verifica que la mesa tenga todo lo necesario: platos, copas, cuberter�a, etc. 
As�mismo debe activarse tambi�n el servicio de carta: las cartas electr�nicas ancladas a la mesa se activan 
autom�ticamente para permitir a los comensales pedir los platos y bebidas que deseen. Existen unas mesas "vip" en las 
que adem�s debe activarse el servicio de metre: un metre se acerca a la mesa y proporciona informaci�n adicional a 
los comensales sobre las diferentes opciones de la carta grastron�mica as� como de la carta de vinos.


## Lo que debemos implementar:

El objetivo de la kata es practicar el patr�n "Observer".
Pod�is encontrar m�s info en 
https://www.codeproject.com/Articles/328361/Understanding-and-Implementing-Observer-Pattern-in

Tendremos un conjunto (array, lista, cola, ...) de comensales que ir�n accediendo a las mesas en orden. Cuando un grupo
de comensales ocupe una mesa se debe disparar un evento que debe activar los diferentes servicios o "observadores":
servicios de camarero, carta electr�nica y metre (este �ltimo �nicamente para las mesas "vip").


## Opcional:

- Desarrollar el sistema utizando TDD.
- Permitir gestionar diversos conjuntos (o colas) de comensales de forma concurrente utilizando para ello t�cnicas 
de paralelismo.


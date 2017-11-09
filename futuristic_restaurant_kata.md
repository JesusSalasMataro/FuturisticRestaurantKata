# Futuristic Restaurant Kata

## Introducción

El restaurante "Futuristic" prevé su inaguración para mediados del año próximo. Para entonces nos ha solicitado tener 
listo un programa de gestión de los clientes que acceden al local. Las mesas cuentan con un sofisticado sistema que 
detecta cuando son ocupadas por nuevos comensales. 

Cuando unos clientes ocupan una mesa el nuevo sistema debe activar el servicio de camarero: un camarero se acerca a 
la mesa, recibe a los comensales y verifica que la mesa tenga todo lo necesario: platos, copas, cubertería, etc. 
Asímismo debe activarse también el servicio de carta: las cartas electrónicas ancladas a la mesa se activan 
automáticamente para permitir a los comensales pedir los platos y bebidas que deseen. Existen unas mesas "vip" en las 
que además debe activarse el servicio de metre: un metre se acerca a la mesa y proporciona información adicional a 
los comensales sobre las diferentes opciones de la carta grastronómica así como de la carta de vinos.


## Lo que debemos implementar:

El objetivo de la kata es practicar el patrón "Observer".
Podéis encontrar más info en 
https://www.codeproject.com/Articles/328361/Understanding-and-Implementing-Observer-Pattern-in

Tendremos un conjunto (array, lista, cola, ...) de comensales que irán accediendo a las mesas en orden. Cuando un grupo
de comensales ocupe una mesa se debe disparar un evento que debe activar los diferentes servicios o "observadores":
servicios de camarero, carta electrónica y metre (este último únicamente para las mesas "vip").


## Opcional:

- Desarrollar el sistema utizando TDD.
- Permitir gestionar diversos conjuntos (o colas) de comensales de forma concurrente utilizando para ello técnicas 
de paralelismo.


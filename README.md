# CsvReaderTest: Proyecto de lectura de un csv
Pequeño ejemplo de lectura de un archivo csv. Este archivo csv simula una lista de entidades jurídicas, cada una de ellas con la siguiente estructura:
* Id
* Tipo
* Fecha de alta

Los puntos funcionales del ejemplo son:
* Lectura de un .csv (llamado "Ejemplo.csv"), a través de la clase CsvManager.cs.
* Filtrado de las entidades que sean de Tipo "TipoA" o "TipoB", y que además, su alta sea superior a 1 año.
* Mostrar en pantalla las entidades filtradas

Los puntos técnicos del ejemplo son:
* Uso de NET6
* Uso de interfaces

### Pre-requisitos 📋

Como herramientas de desarrollo necesitarás:
* Visual Studio 2022 (con la versión para .NET 6)

```
Nota: Visual Studio Code también valdría
```

## Ejecutando la aplicación ⚙️

* Una vez descargado el código, con ejecutarlo es suficiente (es una aplicación de consola)

### ¿Qué falta? 🔩

Muchísimas cosas. Sólo es un acercamiento. Desde meter las clases en un contenedor de dependencias, a controlar si el fichero no existe, o bien no tiene un formato correcto. También se pueden realizar test unitarios, mediante MSTest, XUnit...

## Construido con 🛠️

* [Microsoft Visual Studio Community 2022](https://visualstudio.microsoft.com/es/vs/) - IDE  de desarrollo

## Autores ✒️

* **David Santesteban** - *Trabajo Inicial* - [davidsantes](https://github.com/davidsantes)

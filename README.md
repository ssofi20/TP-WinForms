🛒 Catálogo de Artículos – Proyecto Programación 3

Este proyecto es una aplicación de escritorio desarrollada en C# .NET Framework (WinForms) que permite la gestión de artículos de un catálogo de un comercio.
El sistema fue pensado de forma genérica, de manera que pueda adaptarse a distintos rubros (electrónica, indumentaria, alimentos, etc.), y que los datos cargados puedan luego ser consumidos por otros servicios (web, mobile, e-commerce, revistas digitales, etc.).

✨ Funcionalidades principales

📋 Listado de artículos con visualización en grilla.

🔍 Búsqueda por múltiples criterios (código, nombre, marca, categoría).

➕ Alta de artículos con soporte para múltiples imágenes.

✏️ Modificación de artículos existentes.

🗑️ Eliminación de artículos.

👁️ Vista detallada de un artículo con toda su información.

🏷️ Gestión de Marcas y Categorías (ABM completo).

🗂️ Modelo de datos

La base de datos utilizada es SQL Server, y cuenta con las siguientes tablas:

MARCAS → Almacena las marcas disponibles.

CATEGORIAS → Define las categorías de los productos.

ARTICULOS → Contiene los productos con código, nombre, descripción, marca, categoría y precio.

IMAGENES → Permite asociar múltiples imágenes a cada artículo.

Relaciones:

Un artículo pertenece a una marca y a una categoría.

Un artículo puede tener múltiples imágenes.

# Conversion_Imagenes 🖼️🔄

Este repositorio contiene el motor de **procesamiento y transformación de mapas de bits**, desarrollado en Visual Basic 6.0 para la manipulación avanzada de archivos gráficos.

## 🚀 Descripción

`Conversion_Imagenes` es una utilidad técnica diseñada para el tratamiento de datos de imagen a nivel de píxel. El sistema permite la conversión entre diferentes formatos de color, la aplicación de filtros de procesamiento (escala de grises, inversión, brillo) y la transformación de estructuras de archivos (BMP, JPG, etc.). 

Este componente es fundamental para la suite de herramientas del autor, permitiendo que las visualizaciones matemáticas generadas en otros módulos sean procesadas, optimizadas y exportadas con precisión técnica.

## 🛠️ Especificaciones Técnicas

- **Lenguaje:** Visual Basic 6.0.
- **Arquitectura:** Manipulación de memoria mediante la API de Windows (GDI/GDI+) para acceso rápido a `BITMAP`.
- **Funcionalidades Clave:**
  - **Conversión de Formatos:** Algoritmos de codificación y decodificación de datos de imagen.
  - **Procesamiento de Color:** Transformaciones entre espacios de color (RGB, CMYK, Blanco y Negro).
  - **Redimensionamiento:** Algoritmos de escalado de imágenes manteniendo la relación de aspecto.
  - **Optimización de Memoria:** Manejo eficiente de *Device Contexts* (DC) para evitar fugas de recursos en el sistema.

## 📂 Estructura del Repositorio

Tras la reestructuración profesional:
- `/src`: Código fuente del motor de conversión (.vbp, .frm, .bas, .cls).
- `/filters`: Módulos especializados en algoritmos de procesamiento visual.
- `/docs`: Documentación sobre la estructura de archivos BMP y cabeceras de imagen.
- `/samples`: Ejemplos de imágenes originales y sus versiones transformadas.

## ⚙️ Instalación y Uso

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/MiguelQuinteiro/Conversion_Imagenes.git](https://github.com/MiguelQuinteiro/Conversion_Imagenes.git)
   

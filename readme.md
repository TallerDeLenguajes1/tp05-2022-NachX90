## Trabajo Práctico N° 5 | Nacchio, Javier
### ¿String es un tipo por valor o un tipo por referencia?
Es un tipo por referencia.
### ¿Qué secuencias de escape tiene el tipo string?
Tiene las siguientes secuencias de escape:
|Secuencia de escape |Caracter|
|---|---|
|\' | Single quote |
|\" | Double quote |
|\\ | Backslash |  
|\0 | Null |
|\a | Alert |
|\b | Backspace |
|\f | Form feed |
|\n | New line |
|\r | Carriage return |
|\t | Horizontal tab |
|\v | Vertical tab |
|\u | Unicode escape sequence (UTF-16) |
|\U | Unicode escape sequence (UTF-32) |
|\x | Unicode escape sequence similar to "\u" except with variable length |

### ¿Qué sucede cuando utiliza el caracter @ y $ antes de una cadena de texto?
Cuando una cadena tiene un **@** antes de las comillas de apertura, se interpreta textualmente, es decir, sin tener en cuenta las secuencia de escape.

Cuando una cadena tiene un **$** antes de las comillas de apertura, se realiza una interpolación de cadenas y variables, es decir, pueden concatenarse cadenas y variables.

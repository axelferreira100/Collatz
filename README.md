Basado en https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG

# Consigna

Considere la siguiente secuencia sobre un número entero positivo arbitrario:

Si n es par, el siguiente es n/2
Si n es impar, el siguiente es n * 3 + 1

Cree una función para evaluar repetidamente esta secuencia, hasta llegar a 1. Devuelva el número de pasos que tomó.

Vea el siguiente ejemplo, usando 10 como entrada, con 6 pasos:

10 es par - 10/2 = 5
5 es impar - 5 * 3 + 1 = 16
16 es par - 16/2 = 8
8 es par - 8/2 = 4
4 es par - 4/2 = 2
2 es par - 2/2 = 1 -> Llegó a 1, así que devuelve 6

# Ejemplos

Colatz(2) ➞ 1

Colatz(3) ➞ 7

Colatz(10) ➞ 6
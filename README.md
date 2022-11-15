# Итоговая проверочная работа #
## Задача ##
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, лиюо задать на старте алгоритма.*

## Функция получения массива строк длиной до 3 символов включительно ##
* Функция возвращает массив с ответами, для этого нужно создать новый массив из строк с длиной равной числу коротких строк
* Так как заранее мы не знаем число  таких строк, создадим массив с 1 строкой
* Запускаем цикл и внутри цикла сравневаем длину каждой строки в заданном изначально массиве с нашим условием (до 3х символов)
* Если такой элемент находится, то мы записываем его в массив с ответами, и увеличчиваем длину массива с ответами на 1
* Если таких элементов не будет, то мы возвращаем пустой массив (с одним элементом равным пустой строке).
* Если есть хотя бы одна подходящая строка, то мы уменьшаем длину массива с ответами на 1 (так как ранее мы в предыдущем цикле увеличивали данный массив, но выделеной памятью под элемент не воспользовались) и возвращаем массив с ответами

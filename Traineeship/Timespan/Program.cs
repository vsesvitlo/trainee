﻿//На закріплення циклів і DateTime/TimeSpan: 
//Дано два масива int[] masA = { 1, 2, 5, 1, 3, 4, 1, 14}; int[] masB = { 4, 3, 4, 4, 1, 8, 2, 9 };
//1.Візьмемо masA.Уявимо що його цифри це секунд.
//Зробити так щоб програма писала hello рівно через стільки секунд які є в масиві.
//Тобто перший раз через секунду, другий раз через 2 секунди після першого. Третій раз через 5 секунд після другого. 
//2. Візьмемо masA i masB. Створити третій масив в який покласти найбільші елементи
//із відповідних елементах першого і другого масива.
//3. Візьмемо masA i masB. Створити новий масив в який буде вкладено кожне третє значення
//із першого масиву і кожне друге значення і з другого масиву.
//4. Створити два часові проміжки по: 9 секунд і 7 секунд. Запустити безкінечний цикл так щоб
//через кожні ці 9 і 7 секунд писало в новому рядку число секунд цього проміжку який тригернувся
//(тобто 9 або 7), пробіл і поточна дата і години:

//(запущено програму о 10:12:10 05.08.23, (години, хвилини, секунди, день, місяць, рік))

//7 10:12:17 05.08.23
//9 10:12:19 05.08.23
//7 10:12:24 05.08.23
//9 10:12:28 05.08.23....В цьому завданні можете формат виводу дати переставити місцями.
//Наприклад спочатку день місяць рік, а потім година, хвилина, секунда. Тут головне щоб було число
//проміжку часу яке тригернуло вивід на екран і години, хвилини, секунди
//(порядок в одному рядочку не настільки важливий)
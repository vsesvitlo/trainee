﻿/*Напишіть клас Car, який надає для створених екземплярів такі атрибути даних автомобіля:
 * марку виготовлення автомобіля, модель автомобіля, рік автомобіля, 
 * швидкість (початкове значення 0). Клас також повинен мати наступні методи: 
 * accelerate (метод повинен щоразу додавати 5 до значення атрибуту даних про швидкість), 
 * brake (метод повинен віднімати 5 від значення атрибута даних швидкості кожного разу, 
 * коли він викликається), get_speed (метод повинен повернути поточну швидкість). 
 * Створіть екземпляр класу Car і викличте метод accelerate п’ять разів. 
 * Після кожного виклику методу accelerate отримайте поточну швидкість автомобіля і 
 * надрукуйте її значення. Потім викличте метод brake п’ять разів.
 * Після кожного виклику методу brake отримайте поточну швидкість автомобіля та надрукуйте її значення.
Вихідні дані:

Characteristics of the car:
Citroen c3 2018
Car accelerates:
Current speed: 5
Current speed: 10
Current speed: 15
Current speed: 20
Current speed: 25
Car slows down:
Current speed: 20
Current speed: 15
Current speed: 10
Current speed: 5
Current speed: 0
Car stopped
*/

namespace _05._11._2024___817
{
    public class CarBase
    {
        public string model;
        public double speed;
        public string type_brand;
        public int year;
    }
}
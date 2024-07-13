﻿//Приведем такой пример

//У нас есть переменная.И мы с помощью метода хотим изменить ее знаечение.
int number = 3;

//Вызывем метод и входным параметром будет наша переменная 
AddWithOutRef(number);

//Выведем на консоль значение нашей переменной которое вернул метод
Console.WriteLine("Метод который работает без ref");
Console.WriteLine(number);

//Метод вернул 3.А в чем проблема мы ведь увеличивали значение на 1.
//Когда мы работаем с переменными значимого типа и хотим изменить их значение
//с помощью какого-либо метода то мы в метод передаем копию это переменной
//и наш метод работает с копией и никак не может повлиять на исходную пременную.
//Для того чтобы мы могли изменить значение этой переменной нам нужно ключевое слово ref

//Пример работы с ref
//Вызовем метод с ref,но важно помнить что привызове метода с ref нужно перед параметром
//который мы передаем написать ключевое слово ref,а так же при работе
//с ref пременная должна быть проинициализированна 
AddWithRef(ref number);

//Метод вернул 4 так как мы и хотели 
Console.WriteLine("Метод который работает с ref");
Console.WriteLine(number);


//Метод без использования ref
int AddWithOutRef(int number)
{
   number++;
   return number;
}

//Метод с ref
//В методе мы так же должны перед переменной написать ключевое слово ref
int AddWithRef(ref int number)
{
   number++;
   return number;
}

Console.WriteLine();

//Но это была раьота с входными параметрами
//Так же мы можем работь с выходными парамаетрами с помощью ключевого слово out
//Для того чтобы параметр стал выходным нам нужно при вызове метода перед параметром написать
//ключевое слово out,а так же в входных параметрах метода нужео перед этим параметром написать
//ключевое слово out 

//Пример 

//Перемннная которая будет выходным параметром
int result;

//Метод который будет устанвливать значение выходной перемнной
void Multiplication(int x, int y, out int result)
{
   result = x * y;
}

//Вызов метода
Multiplication(5,5,out result);

//Вывод значения
Console.WriteLine(result);
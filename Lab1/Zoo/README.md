# Lab 1
### Програму цієї лабораторної роботи було створено з дотриманням принципів програмування :

**<ins>Принцип DRY (Don't Repeat Yourself)</ins>\
Суть: Не дублюйте одну й ту ж логіку в коді.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L36-L37)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L56-L57)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L71-L72)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L80-L81)\
У коді уникається дублювання: наприклад, валідація параметрів у конструкторах Animal, 
Employee, Enclosure повторюється, але використовується однаковий підхід (throw new ArgumentException)
— це консистентно і підтримується єдиним стилем. Клас Food виконує валідацію 
лише раз, і її не дублюють у методах годування.\
<ins>Принцип KISS (Keep It Simple, Stupid)</ins>\
Суть: Легкість у розумінні й мінімальна складність.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L87-L95)\
Простий, зрозумілий метод без зайвої логіки — чітко дотримується KISS.\
<ins>Принцип YAGNI (You Ain’t Gonna Need It)</ins>\
Суть: Не реалізовувати того, чого ще не потребуємо.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L9-L27)\
<ins>Принцип Composition Over Inheritance</ins>\
Суть: Краще включення об'єктів, ніж спадкування.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L64-L85)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L97-L106)\
Клас Enclosure має список тварин (List<IAnimal> Animals), 
а не наслідується від якогось базового класу зі списком. Тварини і працівники не успадковуються 
від загальних класів, а об'єднуються через поля і інтерфейси, що підвищує гнучкість.\
<ins>Принцип Program to Interfaces, not Implementations</ins>\
Суть: Працювати через інтерфейси, а не конкретні класи.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L135-L136)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L138)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L142)\

<ins>Принцип Fail Fast</ins>\
Суть: Помилки мають з'являтися якомога раніше.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L36-L37)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L56-L57)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L71-L72)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L80-L81)\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L93)\
<ins>Принцип SOLID</ins>\
<ins>Single Responsibility Principle (Принцип єдиної відповідальності)</ins>\
Суть:Кожен клас повинен мати одну відповідальність.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L9-L95)\
<ins>Open/Closed Principle (Принцип відкритості/закритості)</ins>\
Суть: Клас повинен бути відкритий для розширення, але закритий для змін.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L9-L85)\
Можна створювати нові типи, які реалізують IPrice, не змінюючи існуючий код.\
<ins>Interface Segregation Principle (Принцип розділення інтерфейсів)</ins>\
Суть:Інтерфейси повинні бути простими та конкретними.\
[Приклад в коді](https://github.com/Olia-Kuznetsova/kpz/blob/main/Lab1/Zoo/Program.cs#L9-L27)\..**

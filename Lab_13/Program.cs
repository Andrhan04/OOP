/*
 Универсальный химический обогатитель вопреки всем законам физики и химии способен создавать стабильные вещества из молекул различных элементов. 
Суть его работы крайне проста, 
        на вход подаётся базовое вещество, которое представляет собой некоторое число молекул 
        (например, H2O – две молекулы водорода и одна молекула кислорода). 
        Далее вещество проходит через различные фильтры и на выходе вы получаете новое вещество. 

Вы разрабатываете приложение для обогатителя (на основе паттерна Декоратор). 
    Для описания исходного вещества вы используете не химическую формулу, а строку, которая представляет собой набор латинских символов с описанием элементов. 
        Например: H2O будет записано как «H H O», а C2H5OH как  «C C H H H H H O H».

При этом каждое исходное вещество является отдельным классом, например для воды и перекиси водорода нужно будет создавать отдельные классы.


Нужно разработать несколько фильтров:
        1) «Кислородный фильтр», который будет добавлять молекулу кислорода, то есть строка «H H O» после этого фильтра примет вид «H H O O».
        2) «Водородный фильтр», который будет добавлять молекулу водорода, то есть строка «H H O» после этого фильтра примет вид «H H O H».

Решение должно позволять добавлять новые фильтры, кроме того должно позволять различные виды исходного вещества и комбинации фильтров.

Дополнительная задача №1
    Разработать специальный фильтр, который «убирает» весь кислород из вещества.
 
 */
using Lab_13.Substances;
using Lab_13.Filters;

Substance substance = new Water();
Console.WriteLine(substance);
substance = new Oxygen(substance);
Console.WriteLine(substance);
substance = new Hydrogen(substance);
Console.WriteLine(substance);
substance = new MyFilter(substance);
Console.WriteLine(substance);

substance = new Alcohol();
Console.WriteLine(substance);
substance = new Oxygen(substance);
Console.WriteLine(substance);
substance = new Hydrogen(substance);
Console.WriteLine(substance);
substance = new MyFilter(substance);
Console.WriteLine(substance);

substance = new HydrogenPeroxide();
Console.WriteLine(substance);
substance = new Oxygen(substance);
Console.WriteLine(substance);
substance = new Hydrogen(substance);
Console.WriteLine(substance);
substance = new MyFilter(substance);
Console.WriteLine(substance);
# Аналіз роботи напарника по Команді №4 - по списку №8 Mykhailo Rospopchuk
### https://github.com/MykhailoRospopchuk/SSWU_MykhailoRospopchuk_NET_CAMP/tree/main/Home_task_8

## Загальний огляд 

На мою думку, завдання виконано на дуже високому рівні. Реалізовано схему Клієнт – Сервер.

## По критеріям

1.	Алгоритм реалізовано на основі патерну Observer разом із використанням багатопотоковості, що надає змогу регулювати світлофорами на перехресті знаючи тільки схему роботи світлофорів, та сповіщаючи кожний світлофор в момент часу на який колір йому потрібно перемикатись. З недоліків даної реалізації можу відмітити перевищуючу необхідність звернення в кожний умовний «тік» програми до кожного світлофора, щоб він перевірив чи є необхідність змінювати свій колір. З переваг хочу відмітити гнучкість задання алгоритму переключення для будь якого типу перехрестя без потреби переписування метода проходу та оповіщення світлофорів, а також, в перспективі, умовно простої реалізації надання можливості користувачу самому задавати алгоритм переключення.

2.	Програма в достатній мірі реалізує критерії описані в завданні Домашньої роботи №7 та 8.

3.	Реалізація виконана на високому рівні. Єдині недоліки якиі я можу зазначити, це реалізація методу InitializerCrossroads.InitializeTraffic(), який одночасно ініціалізує всі необхідні для роботи програми об’єкти, запускає та контролює необхідний час виконання програми. Попри це хочу зазначити що в рамках наданого завдання програма реалізована дуже добре.

4.	Всі необхідні данні валідуються на тип але на мою думку не вистачає валідації на вхідні данні в алгоритмі задання схеми переключення(наприклад якщо стан буде передан 0>n або n>4).

5.	В порівнянні з попередньою реалізацією, найзначнішої необхідної перебудови зазнав метод TrafficLight.Update, оскільки було необхідно додати алгоритм переключення світла для світлофорів за поворотами.

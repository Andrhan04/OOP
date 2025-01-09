using Lab_15;

Cat cat = new Cat("Барсик", 7);
Cat cat1 = new Cat("Леопольд", 30);
CatAdapter adapter = new CatAdapter(cat);

Fraction fraction = new Fraction(1, 3, "Периодичная");
Fraction fraction1 = new Fraction(5, 10, "Хорошая");
FractionAdapter adapter1 = new FractionAdapter(fraction);

JsonCollector collector = new JsonCollector();

collector.GetInfo(adapter);
adapter = new CatAdapter(cat1);
collector.GetInfo(adapter);


collector.GetInfo(adapter1);
adapter1 = new FractionAdapter(fraction1);
collector.GetInfo(adapter1);


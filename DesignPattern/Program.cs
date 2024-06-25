using DesignPattern.CreationalDesignPatterns.FactoryMethod;

Car.InitializeFactories()
    .ExecuteCreation(CarType.SUV, 120)
    .Drive();
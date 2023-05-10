using Decorator;

namespace DecoratorTests
{
    public class Tests
    {

        [Test]
        public void CoffeeCreateTest()
        {
            var cut = new Coffee();
            Assert.IsTrue(cut.GetName() == "Coffee" && cut.GetCost() == 30);
        }
        [Test]
        public void CoffeeWithCreamTest() 
        {
            var cut = new Coffee();
            var cream = new Ñream(cut);
            Assert.IsTrue(cream.GetName() == "Coffee, cream" && cream.GetCost() == 35);
        }
        [Test]
        public void CoffeeWithCaramelTest()
        {
            var cut = new Coffee();
            var caramel = new Caramel(cut);
            Assert.IsTrue(caramel.GetName() == "Coffee, caramel" && caramel.GetCost() == 37.50);
        }
        [Test]
        public void CoffeeWithAnythingTest()
        {
            
            var cut = new Coffee();
            var caramel = new Caramel(cut);
            var cream = new Ñream(caramel);
            var sugar = new Sugar(cream);

            Assert.That(sugar.GetName() == "Coffee, caramel, cream, sugar" && sugar.GetCost() == 42.50);
        }
        [Test]
        public void DecoratorOnlySugarTest()
        {
            var cut = new Sugar(null);
            Assert.That(cut.GetName() == ", sugar" && cut.GetCost() == 0);
        }
    }
}
namespace h_5
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange 
            int age1 = 100;
            int age2 = 100;
            int age3 = 100;

            //act
            int Result = age1 + age2 + age3;

            //assert
            Assert.AreEqual(300, Result);
        }

        [Test]
        public void Test2()
        {
            //arrange 
            float age1 = 56;
            float age2 = 400;
            float age3 = 800;

            //act
            float Result = age1 + age2 + age3;

            //assert
            Assert.AreEqual(1256, Result);
        }

        [Test]
        public void Test3()
        {
            //arrange 
            double age1 = 700;
            double age2 = 600;
            double age3 = 10;

            //act
            double Result = age1 + age2 + age3;

            //assert
            Assert.AreEqual(1310, Result);
        }

        [Test]
        public void Test4()
        {
            //arrange 
            decimal age1 = 800;
            decimal age2 = 98;
            decimal age3 = 1;

            //act
            decimal Result = age1 + age2 + age3;

            //assert
            Assert.AreEqual(899, Result);
        }

        [Test]
        public void Test5()
        {
            //arrange 
            string name1 = "My name is";
            string name2 = " howzy";
            string name3 = " Ala ma kota";

            //act
            string Result = name1 + name2 + name3;

            //assert
            Assert.AreEqual("My name is howzy Ala ma kota", Result);
        }
    }
}
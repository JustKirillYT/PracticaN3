using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3
{
    [TestFixture]
    class UnitTestCalc
    {
        [Test]
        public void Test_adder()
        {
            Calculator calc = new Calculator();
            var a = calc.Adder(1,2);
            Assert.That(a, Is.EqualTo(3));
        }
        [Test]
        public void Test_minus()
        {
            Calculator calc = new Calculator();
            var a = calc.Minus(1, 2);
            Assert.That(a, Is.EqualTo(-1));
        }

        [Test]
        public void Test_Multiplie()
        {
            Calculator calc = new Calculator();
            var a = calc.Multiplie(2, 3);
            Assert.That(a, Is.EqualTo(6));
        }

        [Test]
        public void Test_Delenie()
        {
            Calculator calc = new Calculator();
            var a = calc.Delenie(6, 3);
            Assert.That(a, Is.EqualTo(2));
        }

        [Test]
        public void Test_ChetnostChet()
        {
            Zadanie1 z = new Zadanie1();
            var a = z.Chetnost(2);
            Assert.That(a, Is.EqualTo(true));
        }
        [Test]
        public void Test_ChetnostNeChet()
        {
            Zadanie1 z = new Zadanie1();
            var a = z.Chetnost(1);
            Assert.That(a, Is.EqualTo(false));
        }
        [Test]
        public void Test_ChetnostNull()
        {
            Zadanie1 z = new Zadanie1();
            var a = z.Chetnost(0);
            Assert.That(a, Is.EqualTo(true));
        }

        [Test]
        public void NeskolkoSlov()
        {
            string stroka = "Eto testovaya stroka";
           int rez = Chetchik.SchitatSlova(stroka);
            Assert.That(3, Is.EqualTo(rez));
        }

        [Test]
        public void ProbeliVStroke()
        {
            string stroka = "   Eto   test ";
            int rez = Chetchik.SchitatSlova(stroka);
            Assert.That(2, Is.EqualTo(rez));
        }

        [Test]
        public void PustayaStroka()
        {
            string stroka = "";
            int rez = Chetchik.SchitatSlova(stroka);
            Assert.That(0, Is.EqualTo(rez));
        }

        [Test]
        public void OdnoSlovo()
        {
            string stroka = "Slovo";
            int rez = Chetchik.SchitatSlova(stroka);
            Assert.That(1, Is.EqualTo(rez));
        }

        [Test]
        public void TolkoProbeli()
        { 
            string stroka = "     ";
            int rez = Chetchik.SchitatSlova(stroka);
            Assert.That(0, Is.EqualTo(rez));
        }
    }
}


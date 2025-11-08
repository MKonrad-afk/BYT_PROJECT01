using NUnit.Framework;
using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    internal class Tests_Sphere
    {
        //Sphare
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape sphere0 = new Sphere(0);
        
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        //todo : Complete the remaning tests here

        [Test]
        public void TestSphereCalculateVolume_ZeroRadius_ReturnsZero()
        {
            Assert.That(sphere0.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestSphereCalculateArea_ZeroRadius_ReturnsZero()
        {
            Assert.That(sphere0.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestSphereCreation_NegativeRadius_PopError()
        {
        Assert.That(() => new Sphere(-1), Throws.TypeOf<ArgumentException>());
        }
        
    }

    internal class Tests_Cylinder
    {
        //Cylinder
        private readonly IShape cyl = new Cylinder(3, 7);
        private readonly IShape cyl0R = new Cylinder(0, 10);
        private readonly IShape cyl0H = new Cylinder(5, 0);

        [Test]
        public void TestCylinder_Area()
        {
            Assert.That(cyl.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
        }

        [Test]
        public void TestCylinder_Volume()
        {
            Assert.That(cyl.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }

        [Test]
        public void TestCylinder_Volume_ZeroRadius_ReturnsZero()
        {
            Assert.That(cyl0R.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinder_Volume_ZeroHeight_ReturnsZero()
        {
            Assert.That(cyl0H.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinder_Area__ZeroRadious_ReturnsZero()
        {
            Assert.That(cyl0R.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinder_Area_ZeroHeight_ReturnsZero()
        {
            Assert.That(cyl0H.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinder_Creation_NegativeHeight_PopError()
        {
            Assert.That(() => new Cylinder(-1, 0), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void TestCylinder_Creation_NegativeRadius_PopError()
        {
            Assert.That(() => new Cylinder(0, -1), Throws.TypeOf<ArgumentException>());
        }
    }

    internal class Tests_Recatngle
    {
        private readonly IShape rec = new Rectangle(4, 8);
        private readonly IShape rec0L = new Rectangle(0, 8);
        private readonly IShape rec0W = new Rectangle(4, 0);

        [Test]
        public void TestRecatngle_Area()
        {
            Assert.That(rec.CalculateArea(), Is.EqualTo(32));
        }

        [Test]
        public void TestRecatngle_Volume_Zero()
        {
            Assert.That(rec.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRecatngle_Area_ZeroLength_ReturnsZero()
        {
            Assert.That(rec0L.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangle_Area_ZeroWidth_ReturnsZero()
        {
            Assert.That(rec0W.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestRecatangle_Creation_NegativeWidth_PopError()
        {
            Assert.That(()=> new Rectangle(0, -1), Throws.TypeOf<ArgumentException>() );
        } 
        [Test]
        public void TestRecatangle_Creation_NegativeLength_PopError()
        {
            Assert.That(()=> new Rectangle(-1, 0), Throws.TypeOf<ArgumentException>() );
        }
    }

    internal class Tests_Cube
    {
        private readonly IShape cube = new Cube(4);
        private readonly IShape cube0 = new Cube(0);

        [Test]
        public void TestCube_Area()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }

        [Test]
        public void TestCube_Volume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }

        [Test]
        public void TestCube_Volume_ZeroSide_ReturnsZero()
        {
            Assert.That(cube0.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCube_Area_ZeroSide_ReturnsZero()
        {
            Assert.That(cube0.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestCube_Creation_NegativeSide_PopError()
        {
            Assert.That(()=> new Cube(-1), Throws.TypeOf<ArgumentException>());
        }
    }
}
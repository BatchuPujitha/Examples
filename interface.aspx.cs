using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotnetProject
{
    public partial class _interface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IArea rectangleobj = new Rectangle();
            rectangleobj.area(5, 6);
            IArea circleobj = new Circle();
            circleobj.area(7, 0);
        }
    }
    public interface IArea
    {
        void area(double a, double b);
    }
    class Rectangle : IArea
    {
        public void area(double a, double b)
        {
            double areaRectangle;
            areaRectangle = a * b;
            Console.WriteLine("the area of rectangle is :" + areaRectangle);
        }
    }
    class Circle : IArea
    {
        static double pivalue = 3.14;
        public void area(double a, double b)
        {
            double areaCircle;
            areaCircle = pivalue * a * a;
            Console.WriteLine("the area of Circle is :" + areaCircle);
        }
    }
}
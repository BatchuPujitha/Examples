using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotnetProject
{
    public partial class abstractclass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hyundai carsobj = new Hyundai();
            carsobj.Wheel();
            carsobj.CheckingAC();
            carsobj.Price();
            carsobj.Color();
            carsobj.Price();
        }
    }

    public abstract class Cars
    {

        //abstract method.  
        public abstract double Price();
        public abstract string Color();

        //methods  
        public string Wheel()
        {
            return "4 wheeler";

        }
        public string CheckingAC()
        {
            return "AC is available";
        }
    }
    public class Hyundai : Cars
    {

        public int TotalSeats()
        {
            return 5;
        }
        public override double Price()
        {
            return 1000000.00;
        }
        public override string Color()
        {
            return "Blue";
        }
    }
}
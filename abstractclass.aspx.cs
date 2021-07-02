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
            Volkswagen volkcarsobj = new Volkswagen();
            volkcarsobj.CheckingAC();
            volkcarsobj.Price();
            volkcarsobj.Color();
            volkcarsobj.Price();
            volkcarsobj.ManufactureCountry();
            volkcarsobj.IsAvailableInShowroom();
            Tata tatacarsobj = new Tata();
            tatacarsobj.Price();
            tatacarsobj.ManufactureCountry();
            tatacarsobj.IsAvailableInShowroom();
        }
    }

    public abstract class CarsDetails
    {

        //abstract method.  
        public abstract double Price();
        public abstract string Color();
        public abstract string ManufactureCountry();
        public abstract bool IsAvailableInShowroom();

        //methods  
        public bool CheckingAC()
        {
            return true;
        }
    }
    public class Volkswagen : CarsDetails
    {

        public int TotalSeats()
        {
            return 2;
        }
        public override double Price()
        {
            return 10000000.00;
        }
        public override string Color()
        {
            return "Blue";
        }
        public override string ManufactureCountry()
        {
            return "Germany";
        }
        public override bool IsAvailableInShowroom()
        {
            return false;
        }
    }
    public class Tata : CarsDetails
    {

        public int TotalSeats()
        {
            return 7;
        }
        public override double Price()
        {
            return 7000000.00;
        }
        public override string Color()
        {
            return "Grey";
        }
        public override string ManufactureCountry()
        {
            return "India";
        }
        public override bool IsAvailableInShowroom()
        {
            return true;
        }
    }

}
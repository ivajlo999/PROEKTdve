using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AvtoKushta
{
    internal class Avtokushta
    {
        private int ownerNumber;
        private int carNumber;
        private int engineNumber;
        private int kupeNumber;
        private string carBrand;
        private int price;
        private int carYear;
        public int OwnerNumber
        {
            get { return ownerNumber; }
            set { ownerNumber = value; }
        }
        public int CarNumber
        {
            get { return carNumber; }
            set { carNumber = value; }
        }
        public int EngineNumber
        {
            get { return engineNumber; }
            set { engineNumber = value; }
        }
        public int KupeNumber
        {
            get { return kupeNumber; }
            set { kupeNumber = value; }
        }
        public string CarBrand
        {
            get { return carBrand; }
            set { carBrand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int CarYear
        {
            get { return carYear; }
            set { carYear = value; }
        }
        public Avtokushta(int ownerNumber, int carNumber, int engineNumber, int kupeNumber, string carBrand, int price, int carYear)
        {
            this.ownerNumber = ownerNumber;
            this.carNumber = carNumber;
            this.engineNumber = engineNumber;
            this.kupeNumber = kupeNumber;
            this.carBrand = carBrand;
            this.price = price;
            this.carYear = carYear;
        }
        public void Print()
        {
            Console.WriteLine($"OwnerNumber: {OwnerNumber}, CarNumber: {CarNumber}, EngineNumber: {EngineNumber},KupeNumber: {kupeNumber} Car: {CarBrand}, Price: {Price}, Year: {CarYear}");
        }
    }
}

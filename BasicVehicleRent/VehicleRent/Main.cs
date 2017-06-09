using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//a good base of software by Timothy Stewart and modified by Shermayne Lee 

namespace VehicleRent
{

    public partial class Main : Form
    {
        //Array size for different classes
        Vehicle[] vehicles = new Vehicle[100];
        Journey[] journeys = new Journey[100];
        FuelPurchase[] fuel = new FuelPurchase[100];
        Service[] services = new Service[100];
        Rental[] rentals = new Rental[100];


        //Determines maximum position in array
        int count = 0;
       
        public Main()
        {
           InitializeComponent();
        }

     

        private void btnVehicle_Click(object sender, EventArgs e)
        {   //Array to store vehicles information

            //Count to make sure the data does not exceed array size

            if (count < 99)
            {
                vehicles[count] = new Vehicle();
                vehicles[count].getManufacturer = txtManufacturer.Text;
                vehicles[count].getModel = txtModel.Text;
                vehicles[count].getMakeYear = Convert.ToInt32(txtMakeYear.Text);
                vehicles[count].getRegistration = txtRegistration.Text;
                vehicles[count].getId = count;
                listOutput.Items.Add(vehicles[count]);
                count++;               
            }
            
        }

        //Declare private variable for different methods        
        private double speedo;
        private double fuelEconomy;
        private double totalfuelpurchased;
        private double requiredService;
        private int TotalServiceCarriedOut;
        private int checkValue;
        private int RevenueperDay;
        private int RevenueperKm;
        private int TotalRevenue;
        private double KilometerSinceLastService;

        private void btnTotalDistance_Click(object sender, EventArgs e)
        {
            //For loop to make sure finite loop in accordance to the size of data avalaible 
            for (int i = 0; i < count; i++)
            {
                //To find vehicle according to the Vehicle Id
                if (txtId.Text == Convert.ToString(vehicles[i].getId))
                {
                    //Deckare new class for journey
                    journeys[i] = new Journey();
                    journeys[i].gettravelled = Convert.ToInt32(txtTravelled.Text);
                    //To calculate total distance travelled by the vehicle
                    speedo += journeys[i].gettravelled;

                    //Declare new class for FuelPurchased
                    fuel[i] = new FuelPurchase();
                    fuel[i].getfuelAmount = Convert.ToInt32(txtFuel.Text);
                    fuel[i].getfuelCost = Convert.ToInt32(txtFuelcost.Text);
                    //To calculate fuel purchased in order to get fuel economyu of the vehicle
                    totalfuelpurchased += fuel[i].getfuelAmount;
                    fuelEconomy = (totalfuelpurchased * 100) / speedo;                                    
                    

                    //Declare new class for Rental
                    rentals[i] = new Rental();
                    rentals[i].getnumberofDays = Convert.ToInt32(txtDaysofRental.Text);
                    rentals[i].getKmperRental = Convert.ToInt32(txtKMperRental.Text);
                    //To get reveunue per km
                    RevenueperKm += rentals[i].getperKm * rentals[i].getKmperRental;
                    //To get revenue per day 
                    RevenueperDay += rentals[i].getperDay * rentals[i].getnumberofDays;
                    TotalRevenue = 0;
                    TotalRevenue += RevenueperDay + RevenueperKm;

                    //Service class to determine when the class require service
                    services[i] = new Service();
                    requiredService = services[i].getrequiredService(speedo);
                    {
                        if (requiredService >= 1 && services[i].getServiceDone == checkBoxyes.Checked)
                        {
                            requiredService = 0;
                            checkValue = 1;
                            TotalServiceCarriedOut += checkValue;
                            KilometerSinceLastService = 0;
                        }

                        else if (requiredService >= 1 && services[i].getServiceDone == checkBoxNo.Checked)
                        {
                            KilometerSinceLastService = speedo;
                            MessageBox.Show("Pleases service your vehicle!");
                        }
                        else
                        {
                            KilometerSinceLastService = speedo;
                        }
                    }
                    
                }
                listOutput.Items.Clear();
                listOutput.Items.Add("Id       : " + vehicles[i].getId);
                listOutput.Items.Add("Manufacturer       : " + vehicles[i].getManufacturer);
                listOutput.Items.Add("Model: " + vehicles[i].getModel);
                listOutput.Items.Add("Make Year: " + vehicles[i].getMakeYear);
                listOutput.Items.Add("Registration Number: " + vehicles[i].getRegistration);
                listOutput.Items.Add("Total Kilometres Travelled : " + speedo);
                listOutput.Items.Add("Total Service Carried out: " + TotalServiceCarriedOut);
                listOutput.Items.Add("Total Revenue $: " + TotalRevenue);
                listOutput.Items.Add("Kilometer Since Last Service: " + KilometerSinceLastService);                             
                listOutput.Items.Add("Fuel Economy of the Vehicles L/KM: " + fuelEconomy);
               
                if (requiredService >= 1)
                {
                    listOutput.Items.Add("Required Service = yes " );
                }
                else
                {
                    listOutput.Items.Add("Required Service = no");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

       
    }
    



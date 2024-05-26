using System;
using Gtk;
using DogRace;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    Random random = new Random();
    int point;
    int point1;
    int point2;
    int point3;
    int point4;
    int point5;
    Dog dog;
    Golden golden;
    Beagle beagle;
    BullDog bullDog;
    Doberman doberman;
    Huskey huskey;

    protected void createObject(object sender, EventArgs e)
    {
        dog = new Dog(1, "Rex", "Terrier", point);

    }

    protected void startTraining(object sender, EventArgs e)
    {
        int randomNumber = random.Next(0, 100);
        point = randomNumber;
    }

    protected void displayObject(object sender, EventArgs e)
    {
        entry4.Text = dog.dogName + " " + dog.dogType + " " + dog.dogPoint;
    }

    protected void createFiveDog(object sender, EventArgs e)
    {
        golden = new Golden(1,"Marshall","Golden",point1);
        beagle = new Beagle(2,"Ares", "Beagle", point2);
        bullDog = new BullDog(3, "Nico", "BullDog", point3);
        doberman = new Doberman(4, "Taz", "Doberman", point4);
        huskey = new Huskey(5, "Haçiko", "Huskey",point5);
    }

    protected void startRacing(object sender, EventArgs e)
    {
        int randomNumber1 = random.Next(0,100);
        int randomNumber2 = random.Next(0, 100);
        int randomNumber3 = random.Next(0, 100);
        int randomNumber4 = random.Next(0, 100);
        int randomNumber5 = random.Next(0, 100);

        point1 = randomNumber1;
        point2 = randomNumber2;
        point3 = randomNumber3;
        point4 = randomNumber4;
        point5 = randomNumber5;
    }

    protected void displayResult(object sender, EventArgs e)
    {
        int maxPoint = point1;

        if (point2 > maxPoint)
        {
            entry4.Text = beagle.dogName + " " + beagle.dogType;
        }
        if (point3 > maxPoint)
        {
            entry4.Text = bullDog.dogName + " " + bullDog.dogType;
        }
        if (point4 > maxPoint)
        {
            entry4.Text = doberman.dogName + " " + doberman.dogType;
        }
        if (point5 > maxPoint)
        {
            entry4.Text = huskey.dogName + " " + huskey.dogType;
        }
        else
        {
            entry4.Text = golden.dogName + " " + golden.dogType;
        }
    }
}

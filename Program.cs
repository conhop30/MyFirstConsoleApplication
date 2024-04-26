/******************************************************************************
* File: MyFirstConsoleApplication
* Author: Connor Hopkins
******************************************************************************/
class Program
{
    /**************************************************************************
     * INTRODUCTION
     * Outputs information about a person and the current date.
     *************************************************************************/
    static void introduction(DateTime currentDateAndTime)
    {
        // Introduce an individual.
        string name        = "Connor Hopkins";
        string location    = "ID";
        Console.WriteLine($"My name is {name}, I am from {location}.");

        // Current Date.
        string currentDate = currentDateAndTime.ToShortDateString();
        Console.WriteLine($"Here is the current date: {currentDate}.");
    }

    /**************************************************************************
    * DAYS UNTIL CHRISTMAS
    * Outputs how many days there are until Christmas.
    **************************************************************************/
    static void daysUntilChristmas(DateTime currentDateAndTime)
    {
        // Processing
        DateTime christmas = new DateTime(currentDateAndTime.Year, 12, 25);
        TimeSpan daysBeforeChristmas = christmas.Date
                                       - currentDateAndTime.Date;
        int daysLeft = daysBeforeChristmas.Days;

        // Output
        Console.WriteLine($"There are {daysLeft} days before Christmas.");
    }

    /**************************************************************************
    * GET WIDTH
    * Gets input for a width.
    **************************************************************************/
    static double getWidth(double width, string widthString)
    {
        Console.Write("Width: ");
        widthString = Console.ReadLine() ?? "";
        width       = double.Parse(widthString);

        return width;
    }

    /**************************************************************************
    * GET HEIGHT
    * Gets input for a height.
    **************************************************************************/
    static double getHeight(double height, string heightString)
    {
        Console.Write("Height: ");
        heightString = Console.ReadLine() ?? "";
        height       = double.Parse(heightString);

        return height;
    }

    /**************************************************************************
    * CALCULATE WOOD LENGTH
    * Returns wood length based on given measurements.
    **************************************************************************/
    static double calculateWoodLength(double width, double height, double woodLength)
    {
        woodLength = 2 * (width + height) * 3.25;

        return woodLength;
    }

    /**************************************************************************
    * CALCULATE GLASS AREA
    * Returns glass amount based on the area of the wood length.
    **************************************************************************/
    static double calculateGlassArea(double width, double height, double glassArea)
    {
        glassArea = 2 * (width * height);

        return glassArea;
    }

    /**************************************************************************
    * DISPLAY
    * Outputs wood length and glass area based on given measurements.
    **************************************************************************/
    static void display(double woodLength, double glassArea)
    {
        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
                          glassArea + " square metres");
    }

    /**************************************************************************
    * MAIN
    * Driver of the program.
    **************************************************************************/
    static void Main()
    {
        // Introduction.
        DateTime currentDateAndTime = DateTime.Now;
        introduction(currentDateAndTime);

        // Christmas section.
        daysUntilChristmas(currentDateAndTime);

        // Glazer section.
        double width = 0.0, height = 0.0, woodLength = 0.0, glassArea = 0.0;
        string widthString = "", heightString = "";

        width      = getWidth(width, widthString);
        height     = getHeight(height, heightString);
        woodLength = calculateWoodLength(width, height, woodLength);
        glassArea  = calculateGlassArea(width, height, glassArea);
        display(woodLength, glassArea);

        // Stop the program from closing on its own.
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }
}

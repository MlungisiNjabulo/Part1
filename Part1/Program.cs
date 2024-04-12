using System; 

namespace Part1
{
   // this is for the Ingrediants class
   class Ingrediants
    {
        public string Name
        {  get; set; }
        public double Quantity 
        { get; set; }

        public string Units 
        {  get; set; }
    }

    //The class for steps
    class Steps
    {
        public string Descriptions 
        {  get; set; }
    }

    // recipe class 
    class Recipe
    {
        private Ingrediants[] ingrediant;
        private Steps[] step;
        public void RecipeDetails()
        {
            Console.WriteLine("Enter Number Of Ingrediants:");
            int ingrediantCount = Convert.ToInt32(Console.ReadLine());
            ingrediant = new Ingrediants[ingrediantCount];

            for (int i = 0; i < ingrediantCount; i++)
            { //inputting details about the recipe , steps taken on the recipe 
                Console.WriteLine("Ingrediants detaials #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.Write("Units: ");
                string unit = Console.ReadLine();


                ingrediant[i] = new Ingrediants { Name = name, Quantity = quantity, Units = unit };
            }
            //displays a message to promt the user for number of steps in recipe
            Console.WriteLine("The Number of steps: ");
            int stepCount = Convert.ToInt32(Console.ReadLine());
            step = new Steps[stepCount];

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine("Input Step # {i + 1} : ");

                string description = Console.ReadLine();

                step[i] = new Steps
                {
                    Descriptions = description
                };
            }
        }


        //how we will display the details given for the recipe 
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingrediants: ");

            foreach (Ingrediants ingrediant in ingrediant)
            {
                Console.WriteLine($"{ingrediant.Quantity} {ingrediant.Units} of {ingrediant.Name}");
            }
            Console.WriteLine("Steps: ");


            for (int i = 0; i < step.Length; i++)
            { Console.WriteLine($"{i + 1}. {step[i].Descriptions}");
            }
        }
        public void ScaleRecipe(double factor)
        {
            foreach (Ingrediants ingrediant in ingrediant)
            {
                ingrediant.Quantity *= factor;
            }
        }

        // for resetting quantities  to their original values
        public void ResetQuantities()
        {

        }
        public void ClearData()
        {
            ingrediant = null;
            step = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                Console.WriteLine("1 enter the recipe details");
                Console.WriteLine("2 Display Recipe");
                Console.WriteLine("3 Scale the Recipe");
                Console.WriteLine("4 Reset the Quantitys");
                Console.WriteLine("5 Clear the data ");
                Console.WriteLine("6 exit");
                Console.WriteLine(" Choose an Option: ");

                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 0:
                        recipe.RecipeDetails();
                        break;

                    case 1:
                        recipe.DisplayRecipe();
                        break;

                    case 2:
                        Console.Write("Enter the Scaling factor : ");
                        double factor = Convert.ToDouble(Console.ReadLine());

                        recipe.ScaleRecipe(factor);
                        break;
                        case 3:

                        recipe.ResetQuantities();
                        break;
                        case 4:

                        recipe.ClearData();
                        break;
                        case 5:

                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine("Invalid opt. Try again");
                        break; 


                }
            }
        }
    }


}
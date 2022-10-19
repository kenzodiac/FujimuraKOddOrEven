//Kenneth Fujimura
//09-12-2022 @1:45pm
//Mini Challenge # 6 - Odd Or Even
//Console program that takes in an input and tells you if the number entered is odd or even.
//Peer Review by: Jovann
//Comment works checks if numbers are odd or even has data validation, flow chart makes sense able to read it

Console.Clear();

//Greet user, explain program
Console.WriteLine("Hello! Welcome to my 'Odd or Even' program. Here, we'll be determining whether any number you input is an odd or even number. \n\n");

bool repeatProgram = true;
//while loop containing core program
while (repeatProgram == true) {

    //Take user input and run through while loop to evalute if it's a real number

    //declaring variables
    string userInput;
    bool isConverted = false;
    bool isNumber;
    int validNum = 0;

    while (!isConverted) {
        //Ask user to input a number
        Console.WriteLine("Please input an interger. (An integer is a whole number, not a fraction.)");
        userInput = Console.ReadLine();

        //Turn the string user input into an integer
        isNumber = Int32.TryParse(userInput, out validNum);
        
        //if else to evaluate 
        if (isNumber == true) {
            isConverted = true;
        }else{
            Console.WriteLine("Invalid input, please try that again.");
        }
    }

    //Calculate whether it's an odd or an even number
    int remainder = validNum % 2;
    string oddOrEven;
    if (remainder == 0) {
        oddOrEven = "even";
    } else {
        oddOrEven = "odd";
    }
    //Output checks for troubleshooting
    //Console.WriteLine(oddOrEven);
    //Console.WriteLine(remainder);
    
    //Report if it's an even or odd number to user
    Console.WriteLine("The number you inputed: '" + validNum + "' is an '" + oddOrEven + "' number.");

    //while loop asking the user if they want to try this again. 2nd Loop checks whether or not the user inputed a valid input
    bool validInput = false;
    while (validInput == false) {
        Console.WriteLine("Would you like to try that again? Y/N");
        string repeatInput = Console.ReadLine();
        if (repeatInput == "Y" || repeatInput == "y") {
            validInput = true;
            continue;
        } else if (repeatInput == "N" || repeatInput == "n") {
            validInput = true;
            repeatProgram = false;
        } else {
            Console.WriteLine("I did not understand that input.");
        }
    }
}
//Say good bye to the user
Console.WriteLine("Thank you, have a nice day!");
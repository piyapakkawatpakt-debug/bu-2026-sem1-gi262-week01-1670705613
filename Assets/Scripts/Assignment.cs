using UnityEngine;
public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         As01_CheckNumberSign();
         As02_GetDayName();
         As03_ValidatePassword();
         As04_GetGrade();
         As05_IsLeapYear();
         As06_Calculate();
         As07_GetSeason();
         As08_PurchasingSystemExample();
         As09_RockPaperScissorsExample();
         As10_CalculateWeaponDamage();
         As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        if (as01Number > 0) 
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0) 
        {
            Debug.Log("Negative");
        }
        else if (as01Number == 0) 
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        if Debug.Log(as03CorrectPassword == as03InputPassword)
        {
            Debug.Log("True");
        }
        else 
        {
            Debug.Log("false");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        if (as04Score >= 90)
        {
            Debug.Log(" A ");
        }
        else if (as04Score >= 80)
        {
            Debug.Log(" B ");
        }
        else if (as04Score >= 70)
        {
            Debug.Log(" C ");
        }
        else if (as04Score >= 60)
        {
            Debug.Log(" D ");
        }
        else
        {
            Debug.Log(" F ");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        if (as05Year % 400 == 0)
        {
            Debug.Log("True");
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else 
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        switch (as06Op)
        {
            case '+':
                Debug.Log(as06Num1 + as06Num2);
                break;
            case '-':
                Debug.Log(as06Num1 - as06Num2);
                break;
            case '*':
                Debug.Log(as06Num1 * as06Num2);
                break;
            case '/':
                if (as06Num2 != 0)
                {
                    Debug.Log($"Result : {as06Num1 / as06Num2}");
                }
                else 
                { 
                    Debug.Log($"Error: Cannot divide by zero !"); 
                }
                break;
            default:
                Debug.Log($"Error. Please use +, -, *, or /.");
                break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        if (as07Month >= 1 && as07Month <= 12)
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2) 
            {
                Debug.Log("Winter");
            }
            else if (as07Month >= 3 && as07Month <= 5)
            {
                Debug.Log("Spring");
            }
            else if (as07Month >= 6 && as07Month <= 8)
            {
                Debug.Log("Summer");
            }
            else if (as07Month >= 9 && as07Month <= 11)
            {
                Debug.Log("Fall");
            }
        }
        else
        {
            Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
      {
        if (as08Quantity != 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log("You got this item");
                if (as08Payment > as08Price)
                {
                    Debug.Log($"here your change {as08Payment - as08Price} $");
                }
            }
            else 
            {
                Debug.Log("You don't have enough money");
            }
        }
        else 
        {
            Debug.Log("This item is out of stock");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if (as09UserChoice == 1 && as09ComputerChoice == 2)
        {
            Debug.Log("You wins");
        }
        else if (as09UserChoice == 2 && as09ComputerChoice == 3)
        {
            Debug.Log("You wins");
        }
        else if (as09UserChoice == 3 && as09ComputerChoice == 1)
        {
            Debug.Log("You wins");
        }
        else
        {
            Debug.Log("You lose");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        switch (as10WeaponType)
        {
            case "sword":
                Debug.Log($"You deal : {as10BaseDamage * 1.3} DMG"); break;
            case "axe":
                Debug.Log($"You deal : {as10BaseDamage * 1.5} DMG"); break;
            case "bow":
                Debug.Log($"You deal : {as10BaseDamage * 1.5} DMG"); break;
            case "staff":
                Debug.Log($"You deal : {as10BaseDamage * 1.3} DMG"); break;
            case "dagger":
                Debug.Log($"You deal : {as10BaseDamage * 1.1} DMG"); break;
            default:
                Debug.Log($"You deal : {as10BaseDamage * 1.0} DMG"); break;
        }
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        int baseCoins = 0;
        int timeBonus = 0;
        string rank = "";
        if (as11Score < 0 || as11CompletionTime < 0) 
        {
            Debug.Log($"Invalid score or time");
        }
        else 
        {
            if (as11Score >= 8000) 
            {
                baseCoins = 100;
                rank = "Gold";
            }
            else if (as11Score >= 6000 && as11Score <= 7999)
            {
                baseCoins = 75;
                rank = "Silver";
            }
            else if (as11Score >= 4000 && as11Score <= 5999)
            {
                baseCoins = 50;
                rank = "Bronze";
            }
            else if (as11Score >= 0 && as11Score <= 3999)
            {
                baseCoins = 25;
                rank = "Participation";
            }

            if (as11CompletionTime >= 0 && as11CompletionTime <= 30) 
            {
                timeBonus = 25;
            }
            else if (as11CompletionTime >= 31 && as11CompletionTime <= 60)
            {
                timeBonus = 10;
            }
            if (as11CompletionTime >= 61)
            {
                timeBonus = 0;
            }

            Debug.Log($"{rank} Rank - {baseCoins + timeBonus} coins earned!");
        }
    }
}

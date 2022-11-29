// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcome To Address Book Program");


//creating object person1 of AddressBook Class()
AddressBookProblem person1 = new AddressBookProblem();
while (true)
{
    Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-View the AddressBook \n 3-Edit the Address Book \n 4-Delete the person \n 5-Multi Person to AddressBook \n 6-SortingListcity \n 7-SortingListState  \n 8-Exit from the Addressbook");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            person1.AddPerson();
            Console.WriteLine("Enter any key to exit");
            break;
        case 2:
            person1.Display();
            Console.WriteLine("Enter any key to exit");
            break;
        case 3:
            person1.Edit();
            Console.WriteLine("Enter any key to exit");
            break;
        case 4:
            person1.Delete();
            Console.WriteLine("Enter any key to exit");
            break;
        case 5:
            person1.MultiPersons();
            Console.WriteLine("Enter any key to exit");
            break;
        case 6:
            person1.SortingListcity();
            break;
        case 7:
            person1.SortingListState();
            break;
        
        case 8:
            return;
                            
        default:
            Console.WriteLine("Please enter a valid input");
            break;
    }
    Console.ReadLine();
}
        
        
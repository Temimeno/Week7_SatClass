enum Menu {
    RegisterNewStudent = 1,
    RegisterNewTeacher = 2,
    GetListPersons = 3
}

class Program {

    static PersonList personList;
    static void Main(string[] args) {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen() {
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintListMenu() {
        Console.WriteLine("Welcome to registration new user scgool application");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Registration new Student");
        Console.WriteLine("2. Registration new Teacher");
        Console.WriteLine("3. Get List Person");
        Console.WriteLine("****************************************************");
    }

    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresenMenu(menu);
    }

    static void PresenMenu(Menu menu) {
        switch (menu) {
            case Menu.RegisterNewStudent:
            ShowInputRegisterationNewStudentScreen();
            break;
            case Menu.RegisterNewTeacher:
            ShowInputRegisterationNewTeacherScreen();
            break;
            case Menu.GetListPersons:
            showPersons();
            break;
        default:
            break;
        }
    }

    static void ShowInputRegisterationNewStudentScreen() {
        Console.Clear();

        PrintHeaderRegisterationStudent();

        int totalStudent = totalNewStudent();
        InputNewStudentFromKeyboard(totalStudent);

    }
    
    static void ShowInputRegisterationNewTeacherScreen() {
        Console.Clear();

        PrintHeaderRegisterationTeacher();

        int totalTeacher = totalNewTeacher();
        InputNewTeacherFromKeyboard(totalTeacher);

    }

    static void showPersons() {
        Console.Clear();

        Program.personList.FetchPersonList();
    }

    static void PrintHeaderRegisterationStudent() {
        Console.WriteLine("Register New Student");
        Console.WriteLine("**********************");
    }

    static void PrintHeaderRegisterationTeacher() {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("**********************");
    }

    static int totalNewStudent() {
        Console.Write("Input total new Student: ");

        return int.Parse(Console.ReadLine());
    }

    static int totalNewTeacher() {
        Console.Write("Input total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }

    static void InputNewStudentFromKeyboard(int totalNewStudent) {
        for(int i = 0; i< totalNewStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterationStudent();

            Student student = new Student(InputName(), InputAddress(), InputCitizenID(), InputStudentID());

            Program.personList.AddNewPerson(student);
        }

        BackToMenu();
    }

    static void InputNewTeacherFromKeyboard(int totalNewTeacher) {
        for(int i = 0; i< totalNewTeacher; i++) {
            Console.Clear();
            PrintHeaderRegisterationTeacher();

            Teacher teacher = new Teacher(InputName(), InputAddress(), InputCitizenID(), InputEmployeeID());

            Program.personList.AddNewPerson(teacher);
        }

        BackToMenu();
    }

    static void PreparePersonListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }

    static void BackToMenu() {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static string InputName() {
        Console.Write("Name : ");

        return Console.ReadLine();
    }

    static string InputStudentID() {
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }

    static string InputEmployeeID() {
        Console.Write("TeacherID : ");

        return Console.ReadLine();
    }

    static string InputAddress() {
        Console.Write("Address : ");

        return Console.ReadLine();
    }

    static string InputCitizenID() {
        Console.Write("CitizenID : ");

        return Console.ReadLine();
    }
}
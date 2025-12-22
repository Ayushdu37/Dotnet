// using System;

// class Student
// {
//     private string name;
//     private int age;
//     private int marks;
//     private double studentId;
//     private string password;
//     private int registration_number;
//     private int admission_year;
//     public int Admission_year{get; init;} // Init-Only Property

//     public string Name
//     {
//         get{return name;}
//         set
//         {
//             if(!string.IsNullOrEmpty(value))
//             {
//                 name = value;
//             }
//         }
//     }

//     public int Age
//     {
//         get{return age;}
//         set
//         {
//             if(value > 0)
//             {
//                 age = value;
//             }
//         }
//     }

//     public int Marks
//     {
//         get{return marks;}
//         set
//         {
//             if(value > 0 && value < 100)
//             {
//                 marks = value;
//             }
//         }
//     }

//     public string Result // Read-Only Property
//     {
//         get{return marks >= 40 ? "Pass" : "Fail";}
//     }

//     public double StudentId // Auto-Implemented Property
//     {
//         get;
//         set;
//     }

//     public string Password // Write-Only Property (do NOT print the value... it will give error because there is no get accessor)
//     {
//         set
//         {
//             if(value.Length >= 6)
//             {
//                 password = value;
//             }
//         }
//     }

//     public int Reg // Property with Private Set
//     {
//         get;
//         private set;
//     }

//     public Student(int reg)
//     {
//         Reg = reg;
//     }

//     public int Percentage => (Marks * 100) / 100; // Expression-Bodied Property


// }


// // class Rectangle
// // {
// //     public double Length { get; set; }
// //     public double Width { get; set; }
// //     public double Area => Length * Width; // Expression-Bodied Property (Shorter way of writing Read-Only Property)
// // }
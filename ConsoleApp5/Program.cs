var tom = new Person { name = "Tom", age = 13 };
tom.msg = "Hello Tom";
tom.company.title = "CompanyTom";
tom.Print(); 

var john = new Person("John", 43);
john.msg = "Hello John";
john.company.title = "CompanyJohn";
john.Print();

var sam = new Person { name = "Sam", company = { title = "CompanySam"} };
sam.age = 44;
sam.msg = "Hello Sam";
sam.Print();

var jack = new Person { company = { title = "CompanyJack" } };
jack.name = "Jack";
jack.age = 55;
jack.msg = "Hello Jack";
jack.Print();


var ivan = new PersonDeconst("Ivan", 32);
(string nameOut, int ageOut) = ivan;
(string nameOut2, _) = ivan;
(_, int ageOut2) = ivan;
Console.WriteLine($"nameOut: {nameOut}, age: {ageOut}");
Console.WriteLine($"nameOut2: {nameOut2}");
Console.WriteLine($"ageOut2: {ageOut2}");

var brad = new PersonDeconst("Brad", 45);
string bradNameOut;
int bradAgeOut;
brad.Deconstruct(out bradNameOut, out bradAgeOut);
Console.WriteLine($"bradNameOut: {bradNameOut}, bradAgeOut: {bradAgeOut}");


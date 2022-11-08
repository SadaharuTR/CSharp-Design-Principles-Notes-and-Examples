using Interface_Segregation_Principle_IdealCode;

SamsungPrinter printer = new();
printer.Fax();

//printer. dediğimiz an zaten interface içinde olmayan metotlar gelmeyecektir.
//kod hatasız çalışacaktır.


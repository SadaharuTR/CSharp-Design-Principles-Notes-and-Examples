using Dependency_Inversion_Principle_IdealCode;

MailService mailService = new();

mailService.SendMail(new Gmail(), "...", "...");
mailService.SendMail(new Hotmail(), "...", "...");
mailService.SendMail(new Yandex(), "...", "...");

//IMailServer'dan çalışıyoruz artık. Davranışı biz belirlediğimiz için davranışları sergileyecek alt sınıflarda bize bağımlı olacak.

using Liskov_Substituition_Principle_IdealCode;

Cloud cloud = new AWS();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate(); //Amazon cloud yapılanması Translate'i desteklediği sürece Translate fonksiyonuna sahip olacaktır.

cloud = new Google();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate(); //Google cloud yapılanması Translate'i desteklediği sürece Translate fonksiyonuna sahip olacaktır.

cloud = new Azure();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate(); //Azure cloud yapılanması Translate'i desteklediği sürece Translate fonksiyonuna sahip olacaktır.

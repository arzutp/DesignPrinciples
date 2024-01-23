#region NotIdealCode
//using LiskovSubstitutionPrinciple.NotIdealCode;
//Cloud cloud = new AWS();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Google();
//cloud.Translate();
//cloud.MachineLearning();

//cloud = new Azure();
//cloud.Translate(); //Azure da translate boş olduğu için hata gelecek
//cloud.MachineLearning();
#endregion

#region Ideal Code
using LiskovSubstitutionPrinciple.IdealCode;
Cloud cloud = new AWS();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();

cloud = new Google();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();

cloud = new Azure();
cloud.MachineLearning();
(cloud as ITranslatable)?.Translate();
#endregion
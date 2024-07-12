
string root = @"C:\Temp";
string subDir = @"C:\Temp\Sub";

if (!Directory.Exists(root))
{
    Directory.CreateDirectory(root);
}

if (!Directory.Exists(subDir))
{
    Directory.CreateDirectory(subDir);
}

//if (Directory.Exists(subDir))
//{
//    Directory.Delete(subDir);
//}

//if (Directory.Exists(root))
//{
//    Directory.Delete(root);
//}

//string sourceDirName = @"C:\Temp";
//string destDirName = @"C:\NewTemp";
//try
//{
//    Directory.Move(sourceDirName, destDirName);
//}
//catch (IOException exp)
//{
//    Console.WriteLine(exp.Message);
//}


//string filePath = @"C:\Temp\example.txt";
//string content = "Ez egy példa szöveg.";

//if (!File.Exists(filePath))
//{
//    File.WriteAllText(filePath, content);
//}


//DateTime dt = File.GetLastAccessTime(filePath);
//Console.WriteLine(dt);
//DateTime dt2 = File.GetLastWriteTime(filePath);
//Console.WriteLine(dt2);

string path = @"C:\Temp";

// Listázzuk az összes fájlt a mappában
string[] files = Directory.GetFiles(path);
Console.WriteLine("Fájlok:");
foreach (string file in files)
{
    Console.WriteLine(file);
}

// Listázzuk az összes almappát a mappában
string[] directories = Directory.GetDirectories(path);
Console.WriteLine("\nMappák:");
foreach (string directory in directories)
{
    Console.WriteLine(directory);
}
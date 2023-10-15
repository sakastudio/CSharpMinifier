//特定のディレクトリ以下の.csファイルを、再帰的にすべて取得する

using CSharpMinifier;

var files = Directory.GetFiles(@"G:\RiderProjects\moorestech", "*.cs", SearchOption.AllDirectories);


foreach (var file in files)
{
    //ファイル名にAssemblyInfo.csを含むファイルを除外する
    var fileName = Path.GetFileName(file);
    if (fileName.Contains("AssemblyInfo.cs") || fileName.Contains("AssemblyAttributes.cs"))
    {
        continue;
    }

    var result = CSMiniProgram.GetMinimize(file);

    Console.WriteLine(fileName);
    File.WriteAllText(@"G:\moorestech\AutoCoder\compiler\compiler\" + fileName, result);
}


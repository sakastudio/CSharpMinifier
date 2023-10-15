//特定のディレクトリ以下の.csファイルを、再帰的にすべて取得する

using CSharpMinifier;

var files = Directory.GetFiles(@"G:\RiderProjects\moorestech", "*.cs", SearchOption.AllDirectories);


foreach (var file in files)
{
    var result = CSMiniProgram.GetMinimize(file);

    var fileName = Path.GetFileName(file);
    Console.WriteLine(fileName);
    File.WriteAllText(@"G:\moorestech\AutoCoder\compiler\compiler\" + fileName, result);
}


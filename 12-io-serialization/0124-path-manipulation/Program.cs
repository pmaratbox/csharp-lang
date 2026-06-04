var joined = string.Join("/", "/tmp", "file.txt");
var basename = Path.GetFileName(joined);
var extension = Path.GetExtension(joined);

Console.WriteLine($"{joined} {basename} {extension}");

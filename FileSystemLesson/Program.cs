
class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Объем: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }
    }
}


class Disk
{
    public string Name { get; set; }

    public long TotalSpace { get; set; }

    public long FreeSpace { get; set; }

    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }

}

public class Folder
{
    public Folder() { }
    
    public Folder(string name)
    {
        Name = name;
    }

    string Name { get; set; }

    List<string> Files { get; set; } = new List<string>();

    void AddFile(string name)
    {
        if (!Files.Contains(name))
            Files.Add(name);
    }
}
public class Shakl
{
    public virtual void Chiz()
    {
        Console.WriteLine("Umumiy shakl chizilyapti...");
    }
}

public class Doira : Shakl
{
    public override void Chiz()
    {
        Console.WriteLine("Doira chizildi (O)");
    }
}

public class Tortburchak : Shakl
{
    public override void Chiz()
    {
        Console.WriteLine("To'rtburchak chizildi [ ]");
    }
}

public class Uchburchak : Shakl
{
    public override void Chiz()
    {
        Console.WriteLine("Uchburchak chizildi ▲");
    }
}
